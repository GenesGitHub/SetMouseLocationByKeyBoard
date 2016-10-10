using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetMouseLocationByKeyboard
{
    class OverLayDisplay : IDisposable
    {
        Dictionary<int, Form> _forms = new Dictionary<int, Form>();

        public OverLayDisplay()
        {
            List<Screen> screens = Screen.AllScreens.ToList();

            int i = 0;
            foreach (Screen s in screens)
            {
                if (i > 9) { break; }

                AddForm(s, i);

                i++;
            }
        }

        private void AddForm(Screen screen, int i)
        {
            try
            {
                Form f = new Form();

                f.ControlBox = false;
                f.MaximizeBox = false;
                f.MinimizeBox = false;
                f.ShowIcon = false;

                f.StartPosition = FormStartPosition.Manual;
                f.Location = screen.WorkingArea.Location;
                f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f.Height = screen.WorkingArea.Height;// Screen.FromControl(this).Bounds.Height;
                f.Width = screen.WorkingArea.Width;// Screen.FromControl(this).Bounds.Width;

                var image = new Bitmap(f.Width, f.Height, PixelFormat.Format32bppArgb);

                //create a graphics object from the image  
                using (Graphics gfx = Graphics.FromImage(image))
                {
                    //create a color matrix object  
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity  
                    matrix.Matrix33 = 0.5f;

                    //create image attributes  
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    float v1 = f.Width * (1.0F / 3.0F);
                    float v2 = f.Width * (2.0F / 3.0F);

                    float h1 = f.Height * (1.0F / 3.0F);
                    float h2 = f.Height * (2.0F / 3.0F);


                    StringFormat strFormat = new StringFormat();
                    strFormat.Alignment = StringAlignment.Center;
                    strFormat.LineAlignment = StringAlignment.Center;

                    gfx.DrawString((i + 1).ToString(), new Font("Tahoma", 75), Brushes.Red, new RectangleF(v1, h1, v1, h1), strFormat);

                    //now draw the image  
                    gfx.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }

                f.BackColor = Color.White;
                f.TransparencyKey = Color.White;
                f.BackgroundImage = image;
                f.TopMost = true;

                _forms.Add(i, f);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AddForm: " + ex.Message);
            }
        }

        public void Show()
        {
            try
            {
                foreach (Form f in _forms.Values)
                {
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Show: " + ex.Message);
            }
        }

        public void Dispose()
        {
            try
            {
                foreach (Form f in _forms.Values)
                {
                    f.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dispose: " + ex.Message);
            }
        }
    }
}

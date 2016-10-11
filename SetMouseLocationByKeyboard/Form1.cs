using System;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor.WinApi;
using MouseKeyboardActivityMonitor;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SetMouseLocationByKeyboard
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, UIntPtr dwExtraInfo);
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;

        private readonly KeyboardHookListener m_KeyboardHookManager;
        private Keys m_LastKeyPressed = Keys.A;
        private DateTime m_LastKeyPressedTimeStamp = DateTime.Now;
        private Form m_F = null;
        private OverLayDisplay m_Display = null;
        private Color m_Color = Color.Red;

        public Form1()
        {
            InitializeComponent();
            m_KeyboardHookManager = new KeyboardHookListener(new GlobalHooker());
            m_KeyboardHookManager.Enabled = true;
            m_KeyboardHookManager.KeyUp += HookManager_KeyUp;
            m_KeyboardHookManager.KeyDown += HookManager_KeyDown;

            colorDialog1.Color = Color.Red;
            button1.ForeColor = colorDialog1.Color;

            comboBox1.SelectedIndex = 0;
        }


        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (m_Display != null)
            {
                if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode.ToString().Trim() == "Return")
                {
                    e.Handled = true;
                }
            }
            else if (m_F != null)
            {
                if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Return)
                {
                    e.Handled = true;
                }
            }
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode.ToString());
            if (m_Display != null)
            {
                if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Return)
                {
                    e.Handled = true;
                }
                else
                {
                    m_Display.Dispose();
                    m_Display = null;
                }
            }
            else if (m_F != null)
            {
                if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                {
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Return)
                {
                    e.Handled = true;
                }
                else
                {
                    m_F.Dispose();

                    m_F = null;
                }
            }

            Process(e.KeyCode);
        }

        private void Process(Keys key)
        {
            if (m_Display != null)
            {
                Screen s = null;

                if (key == Keys.D1 || key == Keys.NumPad1) { if (Screen.AllScreens.Length >= 0) { s = Screen.AllScreens[0]; } }
                if (key == Keys.D2 || key == Keys.NumPad2) { if (Screen.AllScreens.Length >= 1) { s = Screen.AllScreens[1]; } }
                if (key == Keys.D3 || key == Keys.NumPad3) { if (Screen.AllScreens.Length >= 2) { s = Screen.AllScreens[2]; } }
                if (key == Keys.D4 || key == Keys.NumPad4) { if (Screen.AllScreens.Length >= 3) { s = Screen.AllScreens[3]; } }
                if (key == Keys.D5 || key == Keys.NumPad5) { if (Screen.AllScreens.Length >= 4) { s = Screen.AllScreens[4]; } }
                if (key == Keys.D6 || key == Keys.NumPad6) { if (Screen.AllScreens.Length >= 5) { s = Screen.AllScreens[5]; } }
                if (key == Keys.D7 || key == Keys.NumPad7) { if (Screen.AllScreens.Length >= 6) { s = Screen.AllScreens[6]; } }
                if (key == Keys.D8 || key == Keys.NumPad8) { if (Screen.AllScreens.Length >= 7) { s = Screen.AllScreens[7]; } }
                if (key == Keys.D9 || key == Keys.NumPad9) { if (Screen.AllScreens.Length >= 8) { s = Screen.AllScreens[8]; } }

                CreateSplash(s.WorkingArea.Location.X, s.WorkingArea.Location.Y, s.WorkingArea.Width, s.WorkingArea.Height);

                m_Display.Dispose();

                m_Display = null;
            }
            else if (m_F != null)
            {
                //Do not use Form width/height below.  Need to use BackgroundImage.Width/Height instead.
                //
                float v1 = m_F.BackgroundImage.Width * (1.0F / 3.0F);
                float v2 = m_F.BackgroundImage.Width * (2.0F / 3.0F);

                float h1 = m_F.BackgroundImage.Height * (1.0F / 3.0F);
                float h2 = m_F.BackgroundImage.Height * (2.0F / 3.0F);


                if (key == Keys.D7 || key == Keys.NumPad7)
                {
                    int x = (int)(v1 / 2.0F);
                    int y = (int)(h1 / 2.0F);
                    SetCursorPos(m_F.Location.X + x, m_F.Location.Y + y);
                    CreateSplash(m_F.Location.X, m_F.Location.Y, (int)v1, (int)h1);
                }
                else if (key == Keys.D8 || key == Keys.NumPad8)
                {
                    int x = (int)(v1 + v1 / 2.0F);
                    int y = (int)(h1 / 2.0F);
                    SetCursorPos(m_F.Location.X + x, m_F.Location.Y + y);
                    CreateSplash(m_F.Location.X + (int)v1, m_F.Location.Y, (int)v1, (int)h1);
                }
                else if (key == Keys.D9 || key == Keys.NumPad9)
                {
                    int x = (int)(v2 + v1 / 2.0F);
                    int y = (int)(h1 / 2.0F);
                    SetCursorPos(m_F.Location.X + x, m_F.Location.Y + y);
                    CreateSplash(m_F.Location.X + (int)v2, m_F.Location.Y, (int)v1, (int)h1);
                }
                else if (key == Keys.D4 || key == Keys.NumPad4)
                {
                    int x = (int)(v1 / 2.0F);
                    int y = (int)(h1 + h1 / 2.0F);
                    SetCursorPos(m_F.Location.X + x, m_F.Location.Y + y);
                    CreateSplash(m_F.Location.X, m_F.Location.Y + (int)h1, (int)v1, (int)h1);
                }
                else if (key == Keys.D5 || key == Keys.NumPad5)
                {
                    int x = (int)(v1 + v1 / 2.0F);
                    int y = (int)(h1 + h1 / 2.0F);
                    SetCursorPos(m_F.Location.X + x, m_F.Location.Y + y);
                    CreateSplash(m_F.Location.X + (int)v1, (int)m_F.Location.Y + (int)h1, (int)v1, (int)h1);
                }
                else if (key == Keys.D6 || key == Keys.NumPad6)
                {
                    int x = (int)(v2 + v1 / 2.0F);
                    int y = (int)(h1 + h1 / 2.0F);
                    SetCursorPos(m_F.Location.X + x, m_F.Location.Y + y);
                    CreateSplash(m_F.Location.X + (int)v2, m_F.Location.Y + (int)h1, (int)v1, (int)h1);
                }
                else if (key == Keys.D1 || key == Keys.NumPad1)
                {
                    int x = (int)(v1 / 2.0F);
                    int y = (int)(h2 + h1 / 2.0F);
                    SetCursorPos(m_F.Location.X + x, m_F.Location.Y + y);
                    CreateSplash(m_F.Location.X, m_F.Location.Y + (int)h2, (int)v1, (int)h1);
                }
                else if (key == Keys.D2 || key == Keys.NumPad2)
                {
                    int x = (int)(v1 + v1 / 2.0F);
                    int y = (int)(h2 + h1 / 2.0F);
                    SetCursorPos(m_F.Location.X + x, m_F.Location.Y + y);
                    CreateSplash(m_F.Location.X + (int)v1, m_F.Location.Y + (int)h2, (int)v1, (int)h1);
                }
                else if (key == Keys.D3 || key == Keys.NumPad3)
                {
                    int x = (int)(v2 + v1 / 2.0F);
                    int y = (int)(h2 + h1 / 2.0F);
                    SetCursorPos(m_F.Location.X + x, m_F.Location.Y + y);
                    CreateSplash(m_F.Location.X + (int)v2, m_F.Location.Y + (int)h2, (int)v1, (int)h1);
                }
                else if (key == Keys.Return)
                {
                    m_F.Close();
                    m_F.Dispose();

                    m_F = null;

                    sendMouseDown();
                }
            }

            if (key == Keys.LControlKey && m_LastKeyPressed == Keys.LControlKey)
            {
                m_LastKeyPressed = key;

                if (DateTime.Compare(m_LastKeyPressedTimeStamp.AddSeconds(1), DateTime.Now) < 0)
                {
                    m_LastKeyPressedTimeStamp = DateTime.Now;
                }
                else
                {
                    if (Screen.AllScreens.Length > 1)
                    {
                        m_Display = new OverLayDisplay();

                        m_Display.Show();
                    }
                    else
                    {
                        CreateSplash(0, 0, Screen.FromControl(this).Bounds.Width, Screen.FromControl(this).Bounds.Height);
                    }
                }
            }
            else
            {
                m_LastKeyPressed = key;
                m_LastKeyPressedTimeStamp = DateTime.Now;
            }
        }

        private void CreateSplash(int x, int y, int width, int height)
        {
            try
            {
                if (width <= 10 || height <= 10)
                {
                    return;
                }

                if (m_F != null)
                {
                    m_F.Dispose();
                }
                m_F = new Form();

                m_F.ControlBox = false;
                m_F.MaximizeBox = false;
                m_F.MinimizeBox = false;
                m_F.ShowIcon = false;

                m_F.StartPosition = FormStartPosition.Manual;
                m_F.Location = new Point(x, y);
                m_F.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                m_F.Height = height;// Screen.FromControl(this).Bounds.Height;
                m_F.Width = width;// Screen.FromControl(this).Bounds.Width;

                var image = new Bitmap(width, height, PixelFormat.Format32bppArgb);

                //create a graphics object from the image  
                using (Graphics gfx = Graphics.FromImage(image))
                {
                    Pen p = new Pen(m_Color);
                    Pen p_border = new Pen(m_Color);

                    int thickness = 1;
                    if (comboBox1.SelectedItem.ToString() != null && Int32.TryParse(comboBox1.SelectedItem.ToString(), out thickness))
                    {

                    }
                    p_border.Width = thickness;
                    p.Width = thickness;


                    float v1 = width * (1.0F / 3.0F);
                    float v2 = width * (2.0F / 3.0F);

                    float h1 = height * (1.0F / 3.0F);
                    float h2 = height * (2.0F / 3.0F);


                    //draws left outside vertical line
                    gfx.DrawLine(p_border, 0, 0, 0, m_F.Height);

                    //draws right outside vertical line
                    gfx.DrawLine(p_border, m_F.Width - 1, 0, m_F.Width - 1, m_F.Height);

                    //draws top outside horizontal line
                    gfx.DrawLine(p_border, 0, 0, m_F.Width, 0);

                    //draws bottom outside horizontal line
                    gfx.DrawLine(p_border, 0, m_F.Height - 1, m_F.Width, m_F.Height - 1);



                    //draws left inside vertical line
                    gfx.DrawLine(p, v1, 0, v1, m_F.Height);

                    //draws right inside vertical line
                    gfx.DrawLine(p, v2, 0, v2, m_F.Height);

                    //draws top inside horizontal line
                    gfx.DrawLine(p, 0, h1, m_F.Width, h1);

                    //draws bottom inside horizontal line
                    gfx.DrawLine(p, 0, h2, m_F.Width, h2);

                    StringFormat strFormat = new StringFormat();
                    strFormat.Alignment = StringAlignment.Center;
                    strFormat.LineAlignment = StringAlignment.Center;

                    SolidBrush brush = new SolidBrush(m_Color);

                    gfx.DrawString("7", new Font("Tahoma", 10), brush, new RectangleF(0, 0, v1, h1), strFormat);
                    gfx.DrawString("8", new Font("Tahoma", 10), brush, new RectangleF(v1, 0, v1, h1), strFormat);
                    gfx.DrawString("9", new Font("Tahoma", 10), brush, new RectangleF(v2, 0, v1, h1), strFormat);
                    gfx.DrawString("4", new Font("Tahoma", 10), brush, new RectangleF(0, h1, v1, h1), strFormat);
                    gfx.DrawString("5", new Font("Tahoma", 10), brush, new RectangleF(v1, h1, v1, h1), strFormat);
                    gfx.DrawString("6", new Font("Tahoma", 10), brush, new RectangleF(v2, h1, v1, h1), strFormat);
                    gfx.DrawString("1", new Font("Tahoma", 10), brush, new RectangleF(0, h2, v1, h1), strFormat);
                    gfx.DrawString("2", new Font("Tahoma", 10), brush, new RectangleF(v1, h2, v1, h1), strFormat);
                    gfx.DrawString("3", new Font("Tahoma", 10), brush, new RectangleF(v2, h2, v1, h1), strFormat);
                }

                m_F.BackColor = Color.White;
                m_F.TransparencyKey = Color.White;
                m_F.BackgroundImage = image;
                m_F.BackgroundImageLayout = ImageLayout.None;
                m_F.TopMost = true;
                m_F.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CreateSplash: " + ex.Message);
            }
        }

        private void sendMouseDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)System.Windows.Forms.Cursor.Position.X, (uint)System.Windows.Forms.Cursor.Position.X, 0, (System.UIntPtr)0);
            mouse_event(MOUSEEVENTF_LEFTUP, (uint)System.Windows.Forms.Cursor.Position.X, (uint)System.Windows.Forms.Cursor.Position.X, 0, (System.UIntPtr)0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Show the color dialog.
                DialogResult result = colorDialog1.ShowDialog();
                // See if user pressed ok.
                if (result == DialogResult.OK)
                {
                    // Set form background to the selected color.
                    button1.ForeColor = colorDialog1.Color;
                    m_Color = colorDialog1.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Futur_s
{
    public partial class Form1 : Form
    {
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnclosechildform.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
       /* [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);*/

        private Color SelectThemeColor()
        { int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index) { index=random.Next(ThemeColor.ColorList.Count); }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnsender)
        {
            if(btnsender!=null)
            {
                DisableButton();
                if (currentButton != (Button)btnsender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    p_titlebar.BackColor = color;
                    p_logo.BackColor = ThemeColor.ChangeColorbrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor=ThemeColor.ChangeColorbrightness(color, -0.3);
                    btnclosechildform.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in p_menu.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                { previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if (activeForm != null) { activeForm.Close(); }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.p_desktoppan.Controls.Add(childForm);
            this.p_desktoppan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lb_home.Text = childForm.Text;
        }
        private void btn_produits_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProducts(), sender);
        }

        private void btn_others_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOthers(), sender);
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCustomers(), sender);
        }

        private void btn_reporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReporting(), sender);
        }

        private void btn_noti_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNotifications(), sender);
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
        }

        private void p_desktoppan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclosechildform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }
        private void Reset()
        {
            DisableButton();
            lb_home.Text = "HOME";
            p_titlebar.BackColor = Color.FromArgb(0,150,136);
            p_logo.BackColor = Color.FromArgb(39,39,58);
            currentButton = null;
            btnclosechildform.Visible = false;
        }

        private void p_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
           /* ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);*/
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            
                this.WindowState = FormWindowState.Minimized;
           
        }
    }
}

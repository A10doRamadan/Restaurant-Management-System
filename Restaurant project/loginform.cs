using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Restaurant_project
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            ApplyModernStyle();
        }

        private void ApplyModernStyle()
        {
            this.BackColor = Color.FromArgb(245, 245, 245); 

            groupBox1.BackColor = Color.White;
            groupBox1.FlatStyle = FlatStyle.Flat;
            MakeRounded(groupBox1, 20); 

            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.BackColor = Color.FromArgb(192, 128, 0); 
            btnLogin.ForeColor = Color.White;
            btnLogin.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;
            MakeRounded(btnLogin, 15);

            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = Color.FromArgb(212, 140, 0);
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Color.FromArgb(192, 128, 0);
            radioCashier.Font = new Font("Segoe UI", 11);
            radioManager.Font = new Font("Segoe UI", 11);
        }

        private void MakeRounded(Control cntrl, int radius)
        {
            Graphics g = cntrl.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(cntrl.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(cntrl.Width - radius, cntrl.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, cntrl.Height - radius, radius, radius, 90, 90);
            cntrl.Region = new Region(gp);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (groupBox1 != null)
            {
                groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
                groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2 + 50; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioCashier.Checked)
            {
                kashier cas = new kashier();
                cas.Show();
                this.Hide();
            }
            else if (radioManager.Checked)
            {
                Manager mang = new Manager();
                mang.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a user type first", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btn_login.Enabled = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(txt_user.Text, txt_pass.Text);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            if (txt_user.Text != "" && txt_pass.Text != "")
            {
                btn_login.Enabled = true;
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (txt_user.Text != "" && txt_pass.Text != "")
            {
                btn_login.Enabled = true;
            }
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_user.Text != "" && txt_pass.Text != "")
                {
                    btn_login_Click(sender, e);
                }
            }
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_user.Text != "" && txt_pass.Text != "")
                {
                    btn_login_Click(sender, e);
                }
            }
        }
    }
}

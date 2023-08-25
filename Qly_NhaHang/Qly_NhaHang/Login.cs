﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Qly_NhaHang
{
    public partial class Login : Form
    {
        public Login()
        {
          InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLogin_Enter(object sender, KeyEventArgs e)
        {
           
        }

        private void checkBoxShowHide_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            
        }

        private void checkBoxShowHide_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void chkShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.CheckState == CheckState.Unchecked)
            {
                txbPassword.PasswordChar = '*';
            }
            else
            {
                txbPassword.PasswordChar = '\0';
            }
        }

        private void checkBoxShowHide_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.IsBalloon = true;
            t.ToolTipIcon = ToolTipIcon.Info;
            t.ShowAlways = true;
            if (checkBoxShowHide.CheckState == CheckState.Checked)
            {
                t.SetToolTip(checkBoxShowHide, "Ẩn mật khẩu");
            }
            else
            {
                t.SetToolTip(checkBoxShowHide, "Hiện mật khẩu");
            }
        }
    }
}

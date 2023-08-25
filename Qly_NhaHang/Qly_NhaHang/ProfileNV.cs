using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Qly_NhaHang
{
    public partial class ProfileNV : DevExpress.XtraEditors.XtraForm
    {
      
        public ProfileNV()
        {

            InitializeComponent();
          

        }

        private void ProfileNV_Load(object sender, EventArgs e)
        {
            dtpkBirthDay.Enabled = false; // Để làm cho DateTimePicker không tương tác
            dtpkBirthDay.KeyDown += dtpkBirthDay_KeyDown ; // Ngăn người dùng mở dropdown calendar
        }
        private void dtpkBirthDay_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
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

        private void checkBoxShowHide_MouseHover(object sender, EventArgs e)
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

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*"; // Lọc chỉ hiển thị các tệp ảnh
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                PictureBox1.Image = Image.FromFile(selectedImagePath);
            }
        }
    }
}   
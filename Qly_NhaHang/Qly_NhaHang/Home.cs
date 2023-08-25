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
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        bool sidebarExpand;
        bool homeCollapsed;
        
        public Home()
        {
            InitializeComponent();
        }

        #region method
        // keo ngang thanh sidebar
        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar .MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
            }
        }

        // keo doc nut home
        private void HomeTime_Tick(object sender, EventArgs e)
        {
            if (homeCollapsed)
            {
                HomeContainer.Height += 10;
                if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    HomeTime.Stop();
                }
            }
            else
            {
                HomeContainer.Height -= 10;
                if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    HomeTime.Stop();
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            DateTime now = DateTime.Now;
            labelDay.Text = now.ToString("dddd");
            labelDate.Text = now.ToString("dd/MM/yyyy");
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (IsHandleCreated)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    lblTime.Text = DateTime.Now.ToString("T");
                }));
            }
        }

        #endregion

        #region event
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeTime.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            ListTable f = new ListTable();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        #endregion

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileNV f = new ProfileNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Quanly f = new Quanly();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
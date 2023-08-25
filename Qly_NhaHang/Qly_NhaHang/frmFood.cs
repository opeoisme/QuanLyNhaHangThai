using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmFood : DevExpress.XtraEditors.XtraForm
    {
        public frmFood()
        {
            InitializeComponent();
            //read only gridControl
            {
                GridView gridView = gctFood.MainView as GridView;
                gridView.OptionsBehavior.ReadOnly = true;
            }

        }
        QLNHThaiEntities db = new QLNHThaiEntities();

        public void LoadFormFood()
        {
            List<Food> foods = new List<Food>();
            foods = db.Foods.ToList();
            gctFood.DataSource = foods;
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
          
        }
        
        private void btnLoadFood_Click(object sender, EventArgs e)
        {
            LoadFormFood();
        }
    }
}
using System;
using System.Data;
using System.Windows.Forms;

namespace ShreeWellnessCenter.usrFrm
{
    public partial class usr_frmHome : UserControl
    {
        db DB = new db();
        public usr_frmHome()
        {
            InitializeComponent();

            //datagrid_Items.Refresh();
            ////string query = "select * from product";
            //DataSet dataSet = DB.GetData(query);
            //if (dataSet.Tables[0].Rows.Count > 0)
            //{
            //    datagrid_Items.DataSource = dataSet.Tables[0];
            //}
            //txtProductName.Text = "";
        }

        private void guna2TextBox4_Click(object sender, EventArgs e)
        {
            if (datagridBookings.Visible == false)
            { datagridBookings.Visible = true; }
            else
            { datagridBookings.Visible = true; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            if (datagridBookings.Visible == true)
            { datagridBookings.Visible = false; }
            else { datagridBookings.Visible = false; }
        }

        private void usr_frmHome_Load(object sender, EventArgs e)
        {
            datagridBookings.Refresh();
            string query = "select bookingNo, name, mobile, address, purpose, hall, timing, date1, date2,payStatus from booking";
            DataSet dataSet = DB.GetData(query);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                datagridBookings.DataSource = dataSet.Tables[0];
            }
            txtProductName.Text = "";
            //---------Banner Data ---------
            setNewBannerData();

        }
        private void setNewBannerData()
        {
            db DB = new db();
            //Getting Daya
            string query = "select * from banner";
            //DB.SetData(query);
            DataSet dataSet = DB.GetData(query);
            if (dataSet.Tables[0].Rows.Count >= 0)
            {
                dataGridBanner.DataSource = dataSet.Tables[0];

                lblH1.Text = dataGridBanner.Rows[0].Cells[0].Value.ToString();
                lblh2.Text = dataGridBanner.Rows[0].Cells[1].Value.ToString();
                lblTitle.Text = dataGridBanner.Rows[0].Cells[2].Value.ToString();
                lblAddress.Text = dataGridBanner.Rows[0].Cells[3].Value.ToString();
                lblMob1.Text = dataGridBanner.Rows[0].Cells[4].Value.ToString();
                lblMob2.Text = dataGridBanner.Rows[0].Cells[5].Value.ToString();
                lblEmail.Text = dataGridBanner.Rows[0].Cells[6].Value.ToString();
                lblGST.Text = dataGridBanner.Rows[0].Cells[7].Value.ToString();
            }

        }

        private void usr_frmHome_Leave(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            datagridBookings.Refresh();
            if (datagridBookings.Visible == true)
            { datagridBookings.Visible = false; }
            else
            { datagridBookings.Visible = false; }
            setNewBannerData();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            datagridBookings.Refresh();
            string input = txtProductName.Text;
            string uppercasetxt = input.ToUpper();
            string query = "select bookingNo, name, mobile, address, purpose, hall, timing, date1, date2,payStatus  from  booking where date1 like '" + uppercasetxt + "%'";
            DataSet ds = DB.GetData(query);
            datagridBookings.DataSource = ds.Tables[0];
            datagridBookings.Refresh();
        }

        private void datagrid_Items_Click(object sender, EventArgs e)
        {

            //datagrid_Items.Refresh();
            //string query = "select * from product";
            //DataSet dataSet = DB.GetData(query);
            //if (dataSet.Tables[0].Rows.Count > 0)
            //{
            //    datagrid_Items.DataSource = dataSet.Tables[0];
            //}
            //txtProductName.Text = "";
        }
    }
}

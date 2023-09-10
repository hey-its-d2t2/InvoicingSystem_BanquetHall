using ShreeWellnessCenter.ctrlFrm;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ShreeWellnessCenter.usrFrm
{
    public partial class usr_frmControlAdm : UserControl
    {
        db DB = new db();
        public usr_frmControlAdm()
        {
            InitializeComponent();
        }

       public void getMyData()
        {
     
            dataGridUserDetails.Refresh();
            string query = "select user_id, name, password from user_details";
            DataSet dataSet = DB.GetData(query);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                dataGridUserDetails.DataSource = dataSet.Tables[0]; 
            }
            dataGridUserDetails.Refresh();

            string query1 = "select name, mobile, address from customer";
            DataSet dataSet1 = DB.GetData(query1);
            if (dataSet1.Tables[0].Rows.Count>0)
            {
                dtatGridCusDetailCtrAdm.DataSource = dataSet1.Tables[0];
            }
            dtatGridCusDetailCtrAdm.Refresh();

            string query2 = "select bookingNo, name, purpose, hall, timing,date1, date2, paystatus from booking";
            DataSet dataSet2 = DB.GetData(query2);
            if (dataSet2.Tables[0].Rows.Count>0)
            {
                dataGridBookingsAll.DataSource = dataSet2.Tables[0];
            }

            //-------------------------

            int AdmCount = dataGridUserDetails.Rows.Count;
            lbladmNo.Text = AdmCount.ToString();

      
            //----------------------
            int CustCount = dtatGridCusDetailCtrAdm.Rows.Count;
            lblTotalCust.Text = CustCount.ToString();

            int totalBookingCount = dataGridBookingsAll.Rows.Count;
            lblTotalBooking.Text = totalBookingCount.ToString();

            //--- This month booking
            string query3 = "SELECT name, date1 purpose, hall, timing FROM booking WHERE TO_DATE(date1, 'dd-MM-yyyy') >= TRUNC(SYSDATE, 'MM') AND TO_DATE(date1, 'dd-MM-yyyy') < ADD_MONTHS(TRUNC(SYSDATE, 'MM'), 1)";
            DataSet dataSet3 = DB.GetData(query3);

            if (dataSet3.Tables[0].Rows.Count > 0)
            {
                dataGridThisMonth.DataSource = dataSet3.Tables[0];
            }
            int c = 0;
            if (dataGridThisMonth.Rows.Count > 1)
            {
                for (int i = 0; i < dataGridThisMonth.Rows.Count-1; i++)
                {
                    c++;
                }
            }
            //int countThisMon = dataGridThisMonth.Rows.Count;
            //lblThisMon.Text = countThisMon.ToString();
            lblThisMon.Text = c.ToString();
            //--------XX-----------


            //-----------------

            //--------------
            //----------code for serial number at runtimer--------------
            if (dtatGridCusDetailCtrAdm.Rows.Count > 1)
            {
                for (int i = 0; i < dtatGridCusDetailCtrAdm.Rows.Count; i++)
                {
                    dtatGridCusDetailCtrAdm.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }

            if (dataGridUserDetails.Rows.Count >= 0)
            {
                for (int i = 0; i < dataGridUserDetails.Rows.Count; i++)
                {
                    dataGridUserDetails.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }

            //-----XXXXXXXXXX----code for serial number at runtimer-----XXXXXXX---------
            setNewBannerData();
            dtatGridCusDetailCtrAdm.Refresh();
            dataGridUserDetails.Refresh();
            //dataGridProdCtrAdm.Refresh();

        }

     

        private void usr_frmControlAdm_Load(object sender, EventArgs e)
        {
            getMyData();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridUserDetails.Refresh();
            string input = guna2TextBox1.Text;
            string query = "select * from user_details where name  like '" + input + "%' or name like '"+input+"%'";
            DataSet ds = DB.GetData(query);
            dataGridUserDetails.DataSource = ds.Tables[0];
            dataGridUserDetails.Refresh();
        }

        private void btnUpdatSalesMan_Click(object sender, EventArgs e)
        {
            ctrlFrmupdateSalesman cf = new ctrlFrmupdateSalesman();
            cf.ShowDialog();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            ctrlFrmupdateSalesman cf = new ctrlFrmupdateSalesman();
            cf.ShowDialog();
        }

        private void btnDeleteSalesMan_Click(object sender, EventArgs e)
        {
            ctrlFrmDeleteUsrSale cd = new ctrlFrmDeleteUsrSale();
            cd.ShowDialog();  
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            ctrlFrmDeleteUsrSale cd = new ctrlFrmDeleteUsrSale();
            cd.ShowDialog();
        }

        private void btnAddNewCust_Click(object sender, EventArgs e)
        {
         ctrlFrmAddNewCust cad  = new ctrlFrmAddNewCust();
            cad.ShowDialog();
            
        }

        private void btnAddNewUsr_Click(object sender, EventArgs e)
        {
            ctrlFrmAddNewUsrSal cf = new ctrlFrmAddNewUsrSal();
            cf.ShowDialog();

        }

     

        private void btnRefUPrd_Click(object sender, EventArgs e)
        {
            getMyData();
        }

        private void dataGridUserDetails_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            getMyData();
        }

        private void btnRefUPrd_MouseHover(object sender, EventArgs e)
        {
            getMyData();
        }

        private void btnDelCustAdm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ok दबाने पर सभी Customers का विवरण Delete हो जाएगा !...", "सूचना", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(dr == DialogResult.OK)
            {
                //query for deleating all customers data
                string query = "DELETE  FROM customer";
                DataSet ds = DB.GetData(query);
                getMyData();
            }
            else
            {
                MessageBox.Show(" Customers का विवरण Delete नहीं किया गया !...", "सूचना", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            dtatGridCusDetailCtrAdm.Refresh();
            //string input = txtSearchCust.Text;
            //string uppercasetxt = input.ToUpper();
            string query = "select name,mobile,address from  customer where name like '" + txtSearchCust.Text.ToUpper() + "%'";
            DataSet ds = DB.GetData(query);
            dtatGridCusDetailCtrAdm.DataSource = ds.Tables[0];
            dtatGridCusDetailCtrAdm.Refresh();
            //getMyData();
        }

        private void guna2TabControl1_Click(object sender, EventArgs e)
        {
            getMyData();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            getMyData();
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {
            getMyData();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            getMyData();
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            getMyData();
        }

      

        private void guna2GradientButton8_MouseHover(object sender, EventArgs e)
        {
            getMyData();
        }

        

        


        //------------------- Banner -----------------------
        private void txth1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if (txth1.Text != "")
                {
                    txth2.Select();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Heading 1 आवश्यक है !", "सुचना", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        txth1.Select();
                    }

                }

            }
            else if(e.KeyCode == Keys.Escape)
            {
                txth1.SelectAll();
            }
            
        }

        private void txth2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if (txth2.Text != "")
                {
                    txtTitle.Select();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Heading 2 खाली छोड़ें !", "सुचना", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        txtTitle.Select();
                    }
                    else
                    {
                        txth2.Select();
                    }
                }

            }
            else if (e.KeyCode == Keys.Escape)
            {
                txth2.SelectAll();
            }
            else if( e.KeyCode == Keys.Up)
            {
                txth1.Select();
            }
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if (txtTitle.Text != "")
                {
                    txtAddress.Select();
                }
                else
                {
                    txtAddress.Select();
                }

            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtTitle.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txth2.Select();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if (txtAddress.Text != "")
                {
                    txtMob1.Select();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Address आवश्यक है !", "सुचना", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        txtAddress.Select();
                    }
                    else
                    {
                        txtAddress.Select();
                    }
                }

            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtAddress.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtTitle.Select();
            }
        }

        private void txtMob1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if (txtMob1.Text != "")
                {
                    txtMob2.Select();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Mobile Number 1 आवश्यक है !", "सुचना", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        txtMob1.Select();
                    }
                    else
                    {
                        txtMob1.Select();
                    }
                }

            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtMob1.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtAddress.Select();
            }
        }

        private void txtMob2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if (txtMob2.Text == "")
                {
                    txtEmail.Select();
                }
                else
                {
                    txtEmail.Select();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtMob2.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtMob1.Select();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if (txtEmail.Text == "")
                {
                    txtGST.Select();
                }
                else
                {
                    txtGST.Select();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtEmail.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtMob2.Select();
            }
        }

        private void txtGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if (txtGST.Text == "")
                {
                    btnUpdateBanner.Select();
                }
                else
                {
                    btnUpdateBanner.Select();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtGST.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtEmail.Select();
            }
        }
        private void ClearUpBanner()
        {
            txth1.Clear();
            txth2.Clear();
            txtTitle.Clear();
            txtAddress.Clear();
            txtMob1.Clear();
            txtMob2.Clear();
            txtEmail.Clear();
            txtGST.Clear();
        }
        private void setNewBannerData()
        {
            db DB = new db();
            //Getting Daya
            string query = "select * from banner";
            //DB.SetData(query);
            DataSet dataSet = DB.GetData(query);
            if (dataSet.Tables[0].Rows.Count >=0)
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
        private void btnUpdateBanner_Click(object sender, EventArgs e)
        {
            db DB = new db();

            if(txth1.Text != "" && txtAddress.Text != "" && txtMob1.Text !="")
            {
                //updating banner
                try
                { //---- Deleating previious data
                    string query1 = "drop table banner";
                    DB.SetData(query1);

                    //-- creating Table 

                    string query2 = "create table banner(h1 varchar2(20), h2 VARCHAR2(10),title VARCHAR2(50),address VARCHAR2(50),mob1 VARCHAR2(14),mob2 VARCHAR2(14),email VARCHAR2(50),gst VARCHAR2(20))";
                    DB.SetData(query2);

                    //-- Inserrting new data
                    string query3 = "INSERT INTO banner (h1, h2, title, address, mob1, mob2, email, gst) VALUES ('" + txth1.Text.ToString() + "', '"+txth2.Text.ToString()+"', '"+txtTitle.Text.ToString()+"', '"+txtAddress.Text.ToString()+"', '"+txtMob1.Text.ToString()+"', '"+txtMob2.Text.ToString()+"','"+txtEmail.Text.ToString()+"','"+txtGST.Text.ToString()+"')";
                    DB.SetData(query3);

                    DialogResult result = MessageBox.Show("अपडेट Sucessfull !", "सुचना", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        ClearUpBanner();
                        //Setting new Data
                        setNewBannerData();
                    }
                    else
                    {
                        ClearUpBanner();
                        //Setting new Data
                        setNewBannerData();
                    }
                }
                catch 
                {
                    DialogResult result = MessageBox.Show("Banner अपडेट विफल !", "सुचना", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        txtMob1.Select();
                    }
                    else
                    {
                        ClearUpBanner();
                    }
                }

            }
            else
            {
                DialogResult res = MessageBox.Show("Heading 1"+Environment.NewLine+"Address"+Environment.NewLine+"Mobile Number 1"+Environment.NewLine+"आवश्यक है !","सुचना",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    txth1.Select();
                }
                else
                {
                    ClearUpBanner();
                }
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            setNewBannerData();
        }

        private void guna2GradientButton6_MouseHover(object sender, EventArgs e)
        {
            setNewBannerData();
        }

        private void btnClrBnTxt_Click(object sender, EventArgs e)
        {
            ClearUpBanner();
        }

        private void btnSeeBookingToDate_Click(object sender, EventArgs e)
        {
            string Date1 = date1.Value.ToString("dd-MM-yyyy");
            string Date2 = date2.Value.ToString("dd-MM-yyyy");
            try
            {
                string query = "SELECT bookingNo, name, purpose, hall, timing,date1, date2, paystatus FROM booking WHERE TO_DATE(date1, 'dd-MM-yyyy') BETWEEN TO_DATE('" + Date1 + "', 'dd-MM-yyyy') AND TO_DATE('" + Date2 + "', 'dd-MM-yyyy')";
                DataSet dataSet = DB.GetData(query);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    dataGridBookingsAll.DataSource = dataSet.Tables[0];
                }
            }
            catch
            {
                DialogResult dr =MessageBox.Show("कोई Booking नहीं मिला !","सूचना",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if(dr== DialogResult.OK)
                {
                    getMyData();
                }
                else
                {
                    getMyData();
                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            getMyData();
        }

        private void guna2GradientButton2_MouseHover(object sender, EventArgs e)
        {
            getMyData();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ok दबाने पर सभी Booking का विवरण Delete हो जाएगा !...", "सूचना", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                //query for deleating all booking data
                string query = "DELETE  FROM booking";
                DataSet ds = DB.GetData(query);
                getMyData();
            }
            else
            {
                MessageBox.Show(" Booking का विवरण Delete नहीं किया गया !...", "सूचना", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

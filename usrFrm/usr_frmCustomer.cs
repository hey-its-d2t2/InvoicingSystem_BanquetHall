using System;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ShreeWellnessCenter.usrFrm
{
    public partial class usr_frmCustomer : UserControl
    {
        db DB = new db();

        public usr_frmCustomer()
        {
            InitializeComponent();
            string query = "select * from customer";
            DataSet dataSet = DB.GetData(query);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                dataGridCustDet.DataSource = dataGridUpdate.DataSource = dataSet.Tables[0];
            }
            dataGridCustDet.Refresh();
            dataGridUpdate.Refresh();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dataGridCustDet.Refresh(); getMyData();
            clearAllFields();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dataGridUpdate.Refresh(); getMyData();
            clearallUp();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            datagridPrint.Refresh(); getMyData();
        }
        private void tabPage3_Leave(object sender, EventArgs e)
        {
            datagridPrint.Refresh(); getMyData();
        }
        private void tabPage2_Leave(object sender, EventArgs e)
        {
            dataGridUpdate.Refresh(); getMyData();
            clearallUp();
        }
        private void tabPage1_Leave(object sender, EventArgs e)
        {
            dataGridCustDet.Refresh(); getMyData();
            clearAllFields();
        }
        private void label12_MouseHover(object sender, EventArgs e)
        {
            lblPIM.ForeColor = Color.Red;
            lblPMsgHin.Visible = true;
            lblPMsgEng.Visible = true;
        }

        private void lblPIM_MouseLeave(object sender, EventArgs e)
        {
            lblPIM.ForeColor = Color.FromArgb(51, 51, 51);
            lblPMsgHin.Visible = false;
            lblPMsgEng.Visible = false;
        }

        private void lblPIM_Click(object sender, EventArgs e)
        {
            lblPIM.ForeColor = Color.Red;
            lblPMsgHin.Visible = true;
            lblPMsgEng.Visible = true;
        }
        private void myQueryInsert()
        {


            string txtPname = txtCustName.Text.ToString();
            string upperCustName = txtPname.ToUpper();

            string mob = txtCustMobile.Text.ToString();
            string upperMob = mob.ToUpper();

            string add = txtCustAdd.Text.ToString();
            string upperAdd = add.ToUpper();



            string query = "INSERT INTO CUSTOMER(NAME, MOBILE, ADDRESS, c_id) " +
               "VALUES ('" + upperCustName + "','" + upperMob + "','" + upperAdd + "',c_id_seq.NEXTVAL)";

            DB.SetData(query, txtPname + Environment.NewLine + "एक ग्राहक जोड़ा गया !...");
            getMyData();
            dataGridCustDet.Refresh();
            clearAllFields();
        }
        private void btnAddCust_Click(object sender, EventArgs e)
        {

           
               
                    if (txtCustName.Text != "")
                    {
                        if (txtCustMobile.Text == "")
                        {
                            string title = "Information";
                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                            DialogResult result = MessageBox.Show("ग्राहक का Mobile No. खाली छोड़ें !...", title, buttons);
                            if (result == DialogResult.OK)
                            {
                                if (txtCustAdd.Text == "")
                                {
                                    string title1 = "Information";
                                    MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                                    DialogResult result1 = MessageBox.Show("ग्राहक का Address खाली छोड़ें !...", title, buttons);
                                    if (result1 == DialogResult.OK)
                                    {
                                        myQueryInsert();
                                        dataGridCustDet.Refresh();
                                    }
                                    else
                                    {
                                        txtCustAdd.Select();
                                    }
                                }
                                else
                                {

                                    myQueryInsert();
                                    dataGridCustDet.Refresh();
                                    clearAllFields();
                                }
                            }
                            else
                            {
                                txtCustMobile.Select();
                            }
                        }
                        else
                        {
                            string mob = txtCustMobile.Text.ToString();
                            string upperMob = mob.ToUpper();

                            if (txtCustAdd.Text == "")
                            {
                                string title1 = "Information";
                                MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                                DialogResult result1 = MessageBox.Show("ग्राहक का Address खाली छोड़ें !...", title1, buttons1);
                                if (result1 == DialogResult.OK)
                                {
                                    myQueryInsert();
                                    dataGridCustDet.Refresh();
                                    clearAllFields() ;
                                }
                                else
                                {
                                    txtCustAdd.Select();
                                }
                            }
                            else
                            {
                                 myQueryInsert() ;
                                dataGridCustDet.Refresh();
                                clearAllFields() ;  
                            }
                        }
                    }
                    else
                    {
                        msg("ग्राहक का नाम लिखें !...");
                        txtCustName.Select();
                    }
        
        
        }

        private void usr_frmCustomer_Load(object sender, EventArgs e)
        {
            getMyData();
        }

        private void usr_frmCustomer_Leave(object sender, EventArgs e)
        {

            dataGridUpdate.Refresh();
            datagridPrint.Refresh();
            dataGridCustDet.Refresh();
            clearallUp();
            clearAllFields();
        }

        private void dataGridCustDet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                lblCid.Text = dataGridUpdate.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtUpCusName.Text = dataGridUpdate.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUpCusMob.Text = dataGridUpdate.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtUpCusAddress.Text = dataGridUpdate.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

     

        private void msg(string msg)
        {
            string title = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(msg, title, buttons);
            if (result == DialogResult.OK)
            {
                clearAllFields();
                clearallUp();
                dataGridUpdate.Refresh();
                datagridPrint.Refresh();
                dataGridCustDet.Refresh();
            }
            else { clearAllFields(); dataGridCustDet.Refresh(); }

        }

        private void clearAllFields()
        {
            txtCustName.Text = "";
            txtCustMobile.Text = "";
            txtCustAdd.Text = "";
        }


        //-------------------- key down --- tab page 1 --------------------
      

        private void txtCustName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtCustName.Text != "")
                {
                    txtCustMobile.Select();
                }
                else
                {
                    msg("ग्राहक का नाम लिखें !...");
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtCustName.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                //dropIDGreen.Select();
            }
        }

        private void txtCustMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtCustMobile.Text == "")
                {
                    string title = "Information";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("ग्राहक का Mobile No. खाली छोड़ें !...", title, buttons);
                    if (result == DialogResult.OK)
                    {
                        txtCustAdd.Select();
                    }
                    else { txtCustMobile.Select(); }

                }
                else
                {
                    txtCustAdd.Select();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtCustMobile.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtCustName.Select();
            }
        }

        private void txtCustAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtCustAdd.Text == "")
                {
                    string title = "Information";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("ग्राहक का Address खाली छोड़ें !...", title, buttons);
                    if (result == DialogResult.OK)
                    {
                        btnAddCust.Select();
                    }
                    else { txtCustAdd.Select(); }

                }
                else
                {
                    btnAddCust.Select();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtCustAdd.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                btnAddCust.Select();
            }
            
        }

        private void guna2TextBox13_TextChanged(object sender, EventArgs e)
        {
            dataGridCustDet.Refresh();
            string input = txtCustName.Text;
            string uppercasetxt = input.ToUpper();
            string query = "select * from  CUSTOMER where NAME like '" + uppercasetxt + "%'";
            DataSet ds = DB.GetData(query);
            dataGridCustDet.DataSource = ds.Tables[0];
            dataGridCustDet.Refresh();
        }

       

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearAllFields();
            dataGridCustDet.Refresh();
        }


        //------------------------ Tab page 2 ----------------------------------

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridUpdate.Refresh();
            string input = txtSearch.Text;
            string uppercasetxt = input.ToUpper();
            string query = "select * from  CUSTOMER where name like '" + uppercasetxt + "%'";
            DataSet ds = DB.GetData(query);
            dataGridUpdate.DataSource = ds.Tables[0];
            dataGridUpdate.Refresh();

        }

        private void clearallUp()
        {
            txtSearch.Text = "";
            txtUpCusName.Text = "";
            txtUpCusMob.Text = "";
            txtUpCusAddress.Text = "";
            lblCid.Text = "0";

        }
        private void btnClearAllUp_Click(object sender, EventArgs e)
        {
            clearallUp();
        }
        //---------------------------- Update Details
        private void myQueryupdate()
        {

            string cid = lblCid.Text.ToString();

            string txtCname = txtUpCusName.Text.ToString();
            string upperUpCustName = txtCname.ToUpper();

            string mob = txtUpCusMob.Text.ToString();
            string upperUpMob = mob.ToUpper();

            string add = txtUpCusAddress.Text.ToString();
            string upperUpAdd = add.ToUpper();
            // Int64 slno = Int64.Parse(txtxUpSLNO.Text.ToString());
            //string query = "UPDATE CUSTOMER SET MOBILE = '" + upperUpMob + "',ADDRESS = '" + upperUpAdd + "' where name = " + upperUpCustName + "";

            string query = "UPDATE Customer SET name = '" + upperUpCustName + "', mobile = '" + upperUpMob + "', address = '" + upperUpAdd + "' WHERE c_id = '"+cid+"'";
            DB.SetData(query, txtCname + Environment.NewLine + "ग्राहक का विवरण Update किया गया !...");
            dataGridUpdate.Refresh();
            getMyData();
            clearallUp();

        }
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtUpCusName.Text != "")
                {

                    if (txtUpCusMob.Text != "")
                    {
                        if (txtUpCusAddress.Text != "")
                        {
                            myQueryupdate();
                            getMyData();
                        }
                        else
                        {
                            //address is blank
                            string title1 = "Information";
                            MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                            DialogResult result1 = MessageBox.Show("ग्राहक का Address खाली छोड़ें !...", title1, buttons1);
                            if (result1 == DialogResult.OK)
                            {
                                myQueryupdate();
                                getMyData();
                            }
                            else
                            {
                                txtUpCusAddress.SelectAll();
                            }
                        }
                    }
                    else
                    {
                        //Mobile is blank
                        string title1 = "Information";
                        MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                        DialogResult result1 = MessageBox.Show("ग्राहक का Mobile no. खाली छोड़ें !...", title1, buttons1);
                        if (result1 == DialogResult.OK)
                        {
                            txtCustAdd.Select();

                        }
                        else
                        {
                            txtUpCusMob.SelectAll();
                        }
                    }



                }
                else
                {
                    msg("Name लिखें !...");
                    txtUpCusName.Select();
                }
            }
            catch
            {
                msg("किसी भी ग्राहक का विवरण Update नहीं किया गया !," + Environment.NewLine + "विवरण भरें और पुनः प्रयाश करें...");
                clearallUp();
                dataGridUpdate.Refresh();

            }


        }
        //---------------------------- Delete Details ------------------------

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUpCusName.Text != "")
                {
                    string nm = txtUpCusName.Text.ToString();
                    string query = "DELETE FROM CUSTOMER WHERE name = '" + nm + "'";

                    DB.SetData(query, txtUpCusName.Text + Environment.NewLine + "एक ग्राहक डिलीट किया गया !...");
                    getMyData();
                    dataGridUpdate.Refresh();
                    this.Refresh();
                    clearallUp();
                }
                else
                {
                    msg("कोई भी ग्राहक डिलीट नहीं किया गया !");
                    clearallUp();
                    dataGridUpdate.Refresh();

                }
            }
            catch
            {
                msg("अमान्य विवरण !...");
                clearallUp();
                dataGridUpdate.Refresh();

            }
        }
        // -------------- txt update search------------------
        private void txtUpCusName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtUpCusName.Text != "")
                {
                    txtUpCusMob.Select();
                }
                else
                {
                    msg("ग्राहक का नाम लिखें !...");
                    txtUpCusName.SelectAll();
                }
            }
            else if (e.KeyCode == Keys.Escape) { txtUpCusName.SelectAll(); }
            else if(e.KeyCode == Keys.Up) { /*comUpIDGreen.SelectAll();*/ }
        }

     

      

        private void txtUpCusMob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtUpCusMob.Text == "")
                {
                    string title = "Information";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("ग्राहक का Mobile No. खाली छोड़ें !...", title, buttons);
                    if (result == DialogResult.OK)
                    {
                        txtUpCusAddress.Select();
                    }
                    else { txtUpCusMob.Select(); }

                }
                else
                {
                    txtUpCusAddress.Select();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtUpCusMob.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtUpCusName.Select();
            }
        }

        private void txtUpCusAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtUpCusAddress.Text == "")
                {
                    string title = "Information";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("ग्राहक का Address खाली छोड़ें !...", title, buttons);
                    if (result == DialogResult.OK)
                    {
                        btnUpdate.Select();
                    }
                    else { txtUpCusAddress.Select(); }

                }
                else
                {
                    btnUpdate.Select();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtUpCusAddress.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtUpCusMob.Select();
            }
           
        }

        private void guna2TabControl1_Leave(object sender, EventArgs e)
        {
            clearallUp();
        }


        private void guna2TabControl1_Click(object sender, EventArgs e)
        {
            dataGridUpdate.Refresh();
            datagridPrint.Refresh();
            dataGridCustDet.Refresh();
            clearallUp();
            clearAllFields();
        }
        private void getMyData()
        {
            string query = "select * from CUSTOMER";
            DataSet dataSet = DB.GetData(query);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                dataGridCustDet.DataSource = dataGridUpdate.DataSource = datagridPrint.DataSource = dataSet.Tables[0];
            }
            if (dataGridCustDet.Rows.Count > 1)
            {
                for (int i = 0; i < dataGridCustDet.Rows.Count; i++)
                {
                    dataGridCustDet.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }
            if (dataGridUpdate.Rows.Count > 1)
            {
                for (int i = 0; i < dataGridUpdate.Rows.Count; i++)
                {
                    dataGridUpdate.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }
            if (datagridPrint.Rows.Count > 1)
            {
                for (int i = 0; i < datagridPrint.Rows.Count; i++)
                {
                    datagridPrint.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }
            dataGridCustDet.Refresh();
            datagridPrint.Refresh();
            dataGridUpdate.Refresh();
            clearAllFields();
            clearallUp();
        }
        private void btnRefUp_Click(object sender, EventArgs e)
        {
            getMyData();
        }

        private void btnRefAdC_Click(object sender, EventArgs e)
        {
            getMyData();
        }

        private void btnRefP_Click(object sender, EventArgs e)
        {
            getMyData();
        }

        private void btnRefP_MouseHover(object sender, EventArgs e)
        {
            getMyData();
        }

        private void btnRefUp_MouseHover(object sender, EventArgs e)
        {
            getMyData();
        }

        private void btnRefAdC_MouseHover(object sender, EventArgs e)
        {
            getMyData();
        }


    }
}

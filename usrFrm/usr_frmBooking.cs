using DGVPrinterHelper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ShreeWellnessCenter.usrFrm
{
    public partial class usr_frmInvoice : UserControl
    {
        db DB = new db();
        public usr_frmInvoice()
        {
            InitializeComponent();

        }
        private void myGetData()
        {
            string query = "select bookingNo, name, mobile, address, purpose, hall, timing, date1, date2, totalGuest,paystatus from booking";
            DataSet dataSet = DB.GetData(query);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                  dataGridView.DataSource = dataGridDelete.DataSource = datGridPrint.DataSource=  dataSet.Tables[0];
            }

            string query1 = "SELECT * FROM booking ORDER BY bookingNo DESC FETCH FIRST 1 ROW ONLY";
            DataSet dataSet1 = DB.GetData(query1);
            if (dataSet1.Tables[0].Rows.Count > 0)
            {
                dataGridBooking.DataSource = dataSet1.Tables[0];
            }
        }

        private void usr_frmInvoice_Load(object sender, EventArgs e)
        {

            myGetData();
        }
      
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearAll();
        }
   


        //-----------------------My Functions -------------------

        private void clearAll()
        {
            txtCName.Clear();
            txtCMobile.Clear();
            txtCAddress.Clear();

            cmbPurp.SelectedIndex = -1;
            cmbHall.SelectedIndex = -1;
            cmbTiming.SelectedIndex = -1;
            cmbDJ.SelectedIndex = -1;
            cmbPhoto.SelectedIndex = -1;
            cmbVideo.SelectedIndex = -1;
            cmbStage.SelectedIndex = -1;
            cmbBand.SelectedIndex = -1;
            //Date1.Value.ToString("yyyy-MM-dd");
            //Date2.Value.ToString("yyyy-MM-dd");

            dropGuest.Value = 0;

            txtPayHall.Clear();
            txtPayPhoto.Clear(); 
            txtPayVideo.Clear();
            txtPayStage.Clear();
            txtPayBand.Clear();
            txtPayDJ.Clear();

            txtPayCash.Clear();
             cmbPayStatus.SelectedIndex = -1;

            txtBankName.Clear();
            txtBrancName.Clear();
            txtChecqueNo.Clear();
            txtChqAmount.Clear();
            txtChqDate.Clear();

            myGetData();
        }
        private void msg(string msg)
        {
            string title = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(msg, title, buttons);
            if (result == DialogResult.OK)
            {

            }
            else
            {

            }

        }

        //--------------------- Key Down -------------------------------------




        private void txtCName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtCName.Text != "")
                {
                    txtCMobile.Select();
                }
                else
                {
                    msg("Customer का नाम लिखें !...");
                    txtCName.SelectAll();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtCName.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                // combIDGreen.Select();
            }
        }

        private void txtCMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtCMobile.Text != "")
                {
                    txtCAddress.Select();
                }
                else
                {
                    string title = "Information";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("ग्राहक का Mobile No. खाली छोड़ें !...", title, buttons);
                    if (result == DialogResult.OK)
                    {
                        txtCAddress.Select();
                    }
                    else
                    { txtCMobile.SelectAll();
                    }

                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtCMobile.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtCName.Select();
            }
        }

        private void txtCAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtCAddress.Text != "")
                {
                    // txtProductName.Select();
                }
                else
                {
                    string title = "Information";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("ग्राहक का  Address खाली छोड़ें !...", title, buttons);
                    if (result == DialogResult.OK)
                    {
                        // txtProductName.Select();
                    }
                    else
                    {
                        txtCAddress.SelectAll();
                    }

                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtCAddress.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtCMobile.Select();
            }
        }

        private void combPaymentrStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (cmbPayStatus.SelectedItem != "")
                {
                    txtBankName.Select();
                }
                else
                {
                    msg("Payment Status बताएं...");
                    cmbPayStatus.SelectAll();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cmbPayStatus.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                //   txtCash.Select();
            }
        }

        private void txtBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtBankName.Text != "")
                {
                    txtBrancName.Select();
                }
                else
                {
                    string title = "Information";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("Bank का नाम खाली छोड़ें !...", title, buttons);
                    if (result == DialogResult.OK)
                    {
                        txtBrancName.Select();
                    }
                    else
                    {
                        txtBankName.SelectAll();
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtBankName.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                cmbPayStatus.Select();
            }
        }

        private void txtBrancName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtBrancName.Text != "")
                {
                    txtChecqueNo.Select();
                }
                else
                {
                    if (txtBankName.Text != "")
                    {
                        string title = "Information";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show("Branch का नाम खाली छोड़ें !...", title, buttons);
                        if (result == DialogResult.OK)
                        {
                            txtChecqueNo.Select();
                        }
                        else
                        {
                            txtBrancName.SelectAll();
                        }
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtBrancName.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtBankName.Select();
            }
        }

        private void txtChecqueNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtChecqueNo.Text != "")
                {
                    txtChqAmount.Select();
                }
                else
                {
                    if (txtBrancName.Text != "" || txtBankName.Text != "")
                    {
                        string title = "Information";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show("Checque No. खाली छोड़ें !...", title, buttons);
                        if (result == DialogResult.OK)
                        {
                            txtChqAmount.Select();
                        }
                        else
                        {
                            txtChecqueNo.SelectAll();
                        }
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtChecqueNo.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtBrancName.Select();
            }
        }

        private void txtChqAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtChqAmount.Text != "")
                {
                    txtChqDate.Select();
                }
                else
                {
                    if (txtBrancName.Text != "" || txtBankName.Text != "" || txtChecqueNo.Text != "")
                    {
                        string title = "Information";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show("Checque amount खाली छोड़ें !...", title, buttons);
                        if (result == DialogResult.OK)
                        {
                            txtChqDate.Select();
                        }
                        else
                        {
                            txtChqAmount.SelectAll();
                        }
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtChqAmount.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtChecqueNo.Select();
            }
        }

        private void txtChqDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
            {
                if (txtChqDate.Text != "")
                {
                    btnPrint.Select();
                }
                else
                {
                    if (txtBrancName.Text != "" || txtBankName.Text != "" || txtChecqueNo.Text != "" || txtChqAmount.Text != "")
                    {
                        string title = "Information";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show("Checque Date खाली छोड़ें !...", title, buttons);
                        if (result == DialogResult.OK)
                        {
                            btnPrint.Select();
                        }
                        else
                        {
                            txtChqDate.SelectAll();
                        }
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtChqDate.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtChqAmount.Select();
            }
        }


        private void setBooking()
        {
            string cname = txtCName.Text.ToString().ToUpper();
            string cmob = txtCMobile.Text.ToString().ToUpper();
            string cadd  = txtCAddress.Text.ToString().ToUpper();

            string purp = this.cmbPurp.GetItemText(this.cmbPurp.SelectedItem);
            string hall = this.cmbHall.GetItemText(this.cmbHall.SelectedItem);
            string timing = this.cmbTiming.GetItemText(this.cmbTiming.SelectedItem);   
            string dj = this.cmbDJ.GetItemText(this.cmbDJ.SelectedItem);
            string photo = this.cmbPhoto.GetItemText(this.cmbPhoto.SelectedItem); 
            string video = this.cmbVideo.GetItemText(this.cmbVideo.SelectedItem);
            string  stage = this.cmbStage.GetItemText(this.cmbStage.SelectedItem);
            string band = this.cmbBand.GetItemText(this.cmbBand.SelectedItem);
            string date1 = Date1.Value.ToString("dd-MM-yyyy");
            string date2 = Date2.Value.ToString("dd-MM-yyyy");

            string tg = dropGuest.Value.ToString();

            string payHall = txtPayHall.Text.ToString();
            string payPhoto = txtPayPhoto.Text.ToString();
            string payvideo = txtPayVideo.Text.ToString();
            string payStage = txtPayStage.Text.ToString();
            string payBand = txtPayBand.Text.ToString() ;
            string payDj = txtPayDJ.Text.ToString();

            string payCash = txtPayCash.Text.ToString();
            string payStatus = this.cmbPayStatus.GetItemText(this.cmbPayStatus.SelectedItem);

            string bank = txtBankName.Text.ToString().ToUpper();
            string branch  = txtBrancName.Text.ToString().ToUpper();
            string chqno = txtChecqueNo.Text.ToString().ToUpper();
            string chqamt = txtChqAmount.Text.ToString().ToUpper();
            string chqdate = txtChqDate.Text.ToString().ToUpper();

            try
            {

                string query = "INSERT INTO booking (name, mobile, address, purpose, hall, timing, dj, photo, video, stage, band, date1, date2, totalGuest, PayHall, PayPhoto, PayVideo, PayStage, PayBand, PayDJ, Cash, PayStatus, BankName, BranchName, Cheq, ChqAmt, ChqDate) VALUES (:name, :mobile, :address, :purpose, :hall, :timing, :dj, :photo, :video, :stage, :band, :date1, :date2, :totalGuest, :payHall, :payPhoto, :payVideo, :payStage, :payBand, :payDJ, :cash, :payStatus, :bankName, :branchName, :cheq, :chqAmt, :chqDate)";

                using (OracleConnection connection = new OracleConnection("Data Source = localhost:1521 / XEPDB1; User ID = kalash; Password = kalash"))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("name", OracleDbType.Varchar2).Value = cname;
                        command.Parameters.Add("mobile", OracleDbType.Varchar2).Value = cmob;
                        command.Parameters.Add("address", OracleDbType.Varchar2).Value = cadd;
                        command.Parameters.Add("purpose", OracleDbType.Varchar2).Value = purp;
                        command.Parameters.Add("hall", OracleDbType.Varchar2).Value = hall;
                        command.Parameters.Add("timing", OracleDbType.Varchar2).Value = timing;
                        command.Parameters.Add("dj", OracleDbType.Varchar2).Value = dj;
                        command.Parameters.Add("photo", OracleDbType.Varchar2).Value = photo;
                        command.Parameters.Add("video", OracleDbType.Varchar2).Value = video;
                        command.Parameters.Add("stage", OracleDbType.Varchar2).Value = stage;
                        command.Parameters.Add("band", OracleDbType.Varchar2).Value = band;
                        command.Parameters.Add("date1", OracleDbType.Varchar2).Value = date1;
                        command.Parameters.Add("date2", OracleDbType.Varchar2).Value = date2;
                        command.Parameters.Add("totalGuest", OracleDbType.Varchar2).Value = tg;
                        command.Parameters.Add("payHall", OracleDbType.Varchar2).Value = payHall;
                        command.Parameters.Add("payPhoto", OracleDbType.Varchar2).Value = payPhoto;
                        command.Parameters.Add("payVideo", OracleDbType.Varchar2).Value = payvideo;
                        command.Parameters.Add("payStage", OracleDbType.Varchar2).Value = payStage;
                        command.Parameters.Add("payBand", OracleDbType.Varchar2).Value = payBand;
                        command.Parameters.Add("payDJ", OracleDbType.Varchar2).Value = payDj;
                        command.Parameters.Add("cash", OracleDbType.Varchar2).Value = payCash;
                        command.Parameters.Add("payStatus", OracleDbType.Varchar2).Value = payStatus;
                        command.Parameters.Add("bankName", OracleDbType.Varchar2).Value = bank;
                        command.Parameters.Add("branchName", OracleDbType.Varchar2).Value = branch;
                        command.Parameters.Add("cheq", OracleDbType.Varchar2).Value = chqno;
                        command.Parameters.Add("chqAmt", OracleDbType.Varchar2).Value = chqamt;
                        command.Parameters.Add("chqDate", OracleDbType.Varchar2).Value = chqdate;

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Save विफल ","सूचना",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if(dr == DialogResult.OK)
                {
                    clearAll();
                    myGetData();
                }
                else
                {
                    clearAll();
                    myGetData();
                }
            }
        }
        private void setCustomer()
        {
            string cname = txtCName.Text.ToString().ToUpper();
            string cmob = txtCMobile.Text.ToString().ToUpper();
            string cadd = txtCAddress.Text.ToString().ToUpper();

            string query = "INSERT INTO Customer (name, mobile, address,c_id) VALUES (:name, :mobile, :address,c_id_seq.NEXTVAL)";
            using (OracleConnection connection = new OracleConnection("Data Source = localhost:1521 / XEPDB1; User ID = kalash; Password = kalash"))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = cname;
                    command.Parameters.Add("mobile", OracleDbType.Varchar2).Value = cmob;
                    command.Parameters.Add("address", OracleDbType.Varchar2).Value = cadd;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCName.Text!="")
            {
                lblnmerr.Visible=false;
                if(cmbPurp.SelectedIndex >=0)
                {
                    if(cmbHall.SelectedIndex>=0)
                    {
                        if(cmbTiming.SelectedIndex>=0)
                        {
                            if(txtPayCash.Text!="")
                            {
                                if(cmbPayStatus.SelectedIndex>=0)
                                {
                                    string date1 = Date1.Value.ToString("dd-MM-yyyy");
                                    string date2 = Date2.Value.ToString("dd-MM-yyyy");
                                    string purp = this.cmbPurp.GetItemText(this.cmbPurp.SelectedItem);
                                    string hall = this.cmbHall.GetItemText(this.cmbHall.SelectedItem);
                                    string timing = this.cmbTiming.GetItemText(this.cmbTiming.SelectedItem);
                                    string cname = txtCName.Text.ToString().ToUpper();

                                    //query for save
                                    setBooking();

                                    DialogResult dr = MessageBox.Show("Date : " + date1 + Environment.NewLine + "To Date : " + date2 + Environment.NewLine + "Prpose : " + purp +Environment.NewLine +"Hall : " + hall + Environment.NewLine + "Timing : " + timing + Environment.NewLine +"Name: "+cname+Environment.NewLine+
                                        "के लिए बूकिंग किया गया !"+Environment.NewLine+"(Booking सेव किया गया)","बूकिंग सेव",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    if(dr ==DialogResult.OK)
                                    {
                                        
                                        myGetData();
                                        setCustomer();
                                        clearAll();
                                    }
                                    else
                                    {
                                        
                                        myGetData();
                                        setCustomer();
                                        clearAll();
                                    }
                                }
                                else
                                {
                                    DialogResult dr = MessageBox.Show("Select Payment Status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    cmbPayStatus.Select();

                                }
                            }
                            else
                            {
                                DialogResult dr = MessageBox.Show("Write Payment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                txtPayCash.Select();
                            }
                        }
                        else
                        {
                            DialogResult dr = MessageBox.Show("Select Timing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            cmbTiming.Select();
                        }
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Select Hall", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        cmbHall.Select();
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Select Purpose","Information",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    cmbPurp.Select();
                }
            }
            else
            {
                lblnmerr.Visible = true;

            }

        }

        private void txtCName_Click(object sender, EventArgs e)
        {
            lblnmerr.Visible=false;
        }

        private void lblPIM_MouseHover(object sender, EventArgs e)
        {
            lblPMsgEng.Visible = true;
            lblPMsgHin.Visible =true;
        }

        private void lblPIM_MouseLeave(object sender, EventArgs e)
        {
            lblPMsgEng.Visible = false;
            lblPMsgHin.Visible = false;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label1.Visible=true; label2.Visible=true;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {

            label1.Visible = false; label2.Visible = false;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label4.Visible=true; label6.Visible=true;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false; label6.Visible = false;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            dataGridView.Refresh();
            string input = txtSrhBk.Text;
            string uppercasetxt = input.ToUpper();
            string query = "select bookingNo, name, mobile, address, purpose, hall, timing, date1, date2, totalGuest,paystatus  from  booking where bookingNo like '" + uppercasetxt + "%'";
            DataSet ds = DB.GetData(query);
            dataGridView.DataSource = ds.Tables[0];
            dataGridView.Refresh();
        }

        private void txtSrhDelBk_TextChanged(object sender, EventArgs e)
        {
            dataGridDelete.Refresh();
            string input = txtSrhDelBk.Text;
            string uppercasetxt = input.ToUpper();
            string query = "select  bookingNo, name, mobile, address, purpose, hall, timing, date1, date2, totalGuest,paystatus from booking where bookingNo like '" + uppercasetxt + "%'";
            DataSet ds = DB.GetData(query);
            dataGridDelete.DataSource = ds.Tables[0];
            dataGridDelete.Refresh();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtSrhBk.Clear();
            myGetData();
        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {
            txtSrhBk.Clear();
            myGetData();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            txtSrhBk.Clear();
            myGetData();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            txtSrhDelBk.Clear();
            myGetData();
        }

        private void tabPage3_Leave(object sender, EventArgs e)
        {
            txtSrhDelBk.Clear();
            myGetData();
        }

        private void btnclr2_Click(object sender, EventArgs e)
        {
            txtSrhDelBk.Clear();
            myGetData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
            myGetData();

            dataGridBooking.CurrentRow.Selected = true;
            //name, mobile, address, purpose, hall, timing, dj, photo, video, stage, band, date1, date2, totalGuest, PayHall, PayPhoto, PayVideo, PayStage, PayBand, PayDJ, Cash, PayStatus, BankName, BranchName, Cheq, ChqAmt, ChqDate
            string name, mobile, address, purpose, hall, timing, dj, photo, video, stage, band, date1, date2, totalGuest, PayHall, PayPhoto, PayVideo, PayStage, PayBand, PayDJ, Cash, PayStatus, BankName, BranchName, Cheq, ChqAmt, ChqDate, bookingNO;
            bookingNO = dataGridBooking.Rows[0].Cells["bookingNO"].Value.ToString();
            name = dataGridBooking.Rows[0].Cells["Name"].Value.ToString();
            mobile = dataGridBooking.Rows[0].Cells["Mobile"].Value.ToString();
            address = dataGridBooking.Rows[0].Cells["Address"].Value.ToString();
            purpose = dataGridBooking.Rows[0].Cells["Purpose"].Value.ToString();
            hall  = dataGridBooking.Rows[0].Cells["Hall"].Value.ToString();
            timing = dataGridBooking.Rows[0].Cells["Timing"].Value.ToString();
            dj = dataGridBooking.Rows[0].Cells["DJ"].Value.ToString();
            photo = dataGridBooking.Rows[0].Cells["Photo"].Value.ToString();
            video = dataGridBooking.Rows[0].Cells["Video"].Value.ToString();
            stage = dataGridBooking.Rows[0].Cells["Stage"].Value.ToString();
            band = dataGridBooking.Rows[0].Cells["Band"].Value.ToString();
            date1 = dataGridBooking.Rows[0].Cells["Date1"].Value.ToString();
            date2 = dataGridBooking.Rows[0].Cells["Date2"].Value.ToString();
            totalGuest = dataGridBooking.Rows[0].Cells["TotalGuest"].Value.ToString();
            PayHall = dataGridBooking.Rows[0].Cells["PayHall"].Value.ToString();
            PayPhoto = dataGridBooking.Rows[0].Cells["PayPhoto"].Value.ToString();
            PayVideo = dataGridBooking.Rows[0].Cells["PayVideo"].Value.ToString();
            PayStage = dataGridBooking.Rows[0].Cells["PayStage"].Value.ToString();
            PayBand = dataGridBooking.Rows[0].Cells["PayBand"].Value.ToString();
            PayDJ = dataGridBooking.Rows[0].Cells["PayDJ"].Value.ToString();
            Cash = dataGridBooking.Rows[0].Cells["Cash"].Value.ToString();
            PayStatus= dataGridBooking.Rows[0].Cells["PayStatus"].Value.ToString();
           BankName = dataGridBooking.Rows[0].Cells["BankName"].Value.ToString();
            BranchName = dataGridBooking.Rows[0].Cells["BranchName"].Value.ToString();
            Cheq = dataGridBooking.Rows[0].Cells["Cheq"].Value.ToString();
            ChqAmt = dataGridBooking.Rows[0].Cells["ChqAmt"].Value.ToString();
            ChqDate = dataGridBooking.Rows[0].Cells["ChqDate"].Value.ToString();


            DGVPrinter printer = new DGVPrinter();
            printer.printDocument.DefaultPageSettings.Landscape = true;

            printer.Title = "Kalash Banquet Hall " + Environment.NewLine + "Sari, Bhagalpur - 812002, Bihar" + Environment.NewLine + "Ph : +91 0000000000 | +91 1111111111";
            printer.SubTitle = String.Format("\n                                                " +
                "----------------------------------------- \n" +
                "                                                             Booking Details \n" +
                "                                                ----------------------------------------- \n" +
                " Bill No. : {0}      | Date : {1}                      |                   Time : {2}" +
                "\n-------------------------------------------------------------------------------------------------\n" +
                "\n  Name  :          {3}" +
                "\n  Mobile No. :   {4}" +
                "\n  Address :        {5}" +
                "\n----------------------------------    Booking Details    ----------------------------------------" +
                "\n  Purpose :            {6}" +
                "\n  Hall :                   {7}" +
                "\n  Timing:               {8}" +
                "\n  DJ :                      {9}" +
                "\n  Photo Graphy :   {10}" +
                "\n  Video Graphy :   {11}" +
                "\n  Stage Deco. :      {12}" +
                "\n  Band Baza :        {13}" +
                "\n  Booking Date :   {14}" +
                "\n  To Booking :       {15}" +
                "\n  Total Guest :       {16}" +
                "\n --------------------------------   Charges Details    ----------------------------------------" +
                "\n  Hall  :                  {17}"+
                "\n  Photography :    {18}"+
                "\n  Videography :     {19}"+
                "\n  Satge Deco. :      {20}"+
                "\n  Band Baza :        {21}"+
                "\n  DJ :                     {22}"+
                "\n --------------------------------    Payment Details    ----------------------------------------"+
                "\n  Paid Cash :         {23}" +
                "\n  Payment Status :   {24}"+
                "\n --------------------------    Banking Payment Details   ------------------------------------" +
                "\n  Bank Name :      {25}"+
                "\n  Branch Name :    {26}"+
                "\n  Checque No. :    {27}"+
                "\n  Checque Amount : {28}"+
                "\n  Checque Date :   {29}"+
                "\n\n\n\n\n\n" +
                "-------------------------------------------------------------------------------------------------\n"+
                "                     This is a computer generated biil no signature required \n"+
                "-------------------------------------------------------------------------------------------------\n",
               bookingNO, DateTime.Now.ToString("dd MMMM yyyy"), DateTime.Now.ToString("hh:mm:ss tt"), name, mobile, address, purpose, hall, timing, dj, photo, video, stage, band, date1, date2, totalGuest, PayHall, PayPhoto, PayVideo, PayStage, PayBand, PayDJ, Cash, PayStatus, BankName, BranchName, Cheq, ChqAmt, ChqDate);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PrintMargins = new System.Drawing.Printing.Margins(60, 60, 30, 15);
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.SubTitleAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.Footer = "Developed by : Deepak Singh, Contact: deepsinghkumar01@gmail.com, Ph : +91 9525357044";
            printer.PrintDataGridView(guna2DataGridView1);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.CurrentRow.Selected = true;
            //name, mobile, address, purpose, hall, timing, dj, photo, video, stage, band, date1, date2, totalGuest, PayHall, PayPhoto, PayVideo, PayStage, PayBand, PayDJ, Cash, PayStatus, BankName, BranchName, Cheq, ChqAmt, ChqDate
            string name, mobile, address, purpose, hall, timing, dj, photo, video, stage, band, date1, date2, totalGuest, PayHall, PayPhoto, PayVideo, PayStage, PayBand, PayDJ, Cash, PayStatus, BankName, BranchName, Cheq, ChqAmt, ChqDate, bookingNO;
            bookingNO = dataGridView.Rows[e.RowIndex].Cells["bookingNO"].Value.ToString();
            name = dataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            mobile = dataGridView.Rows[e.RowIndex].Cells["Mobile"].Value.ToString();
            address = dataGridView.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            purpose = dataGridView.Rows[e.RowIndex].Cells["Purpose"].Value.ToString();
            hall = dataGridView.Rows[e.RowIndex].Cells["Hall"].Value.ToString();
            timing = dataGridView.Rows[e.RowIndex].Cells["Timing"].Value.ToString();
            dj = dataGridView.Rows[e.RowIndex].Cells["DJ"].Value.ToString();
            photo = dataGridView.Rows[e.RowIndex].Cells["Photo"].Value.ToString();
            video = dataGridView.Rows[e.RowIndex].Cells["Video"].Value.ToString();
            stage = dataGridView.Rows[e.RowIndex].Cells["Stage"].Value.ToString();
            band = dataGridView.Rows[e.RowIndex].Cells["Band"].Value.ToString();
            date1 = dataGridView.Rows[e.RowIndex].Cells["Date1"].Value.ToString();
            date2 = dataGridView.Rows[e.RowIndex].Cells["Date2"].Value.ToString();
            totalGuest = dataGridView.Rows[e.RowIndex].Cells["TotalGuest"].Value.ToString();
            PayHall = dataGridView.Rows[e.RowIndex].Cells["PayHall"].Value.ToString();
            PayPhoto = dataGridView.Rows[e.RowIndex].Cells["PayPhoto"].Value.ToString();
            PayVideo = dataGridView.Rows[e.RowIndex].Cells["PayVideo"].Value.ToString();
            PayStage = dataGridView.Rows[e.RowIndex].Cells["PayStage"].Value.ToString();
            PayBand = dataGridView.Rows[e.RowIndex].Cells["PayBand"].Value.ToString();
            PayDJ = dataGridView.Rows[e.RowIndex].Cells["PayDJ"].Value.ToString();
            Cash = dataGridView.Rows[e.RowIndex].Cells["Cash"].Value.ToString();
            PayStatus = dataGridView.Rows[e.RowIndex].Cells["PayStatus"].Value.ToString();
            BankName = dataGridView.Rows[e.RowIndex].Cells["BankName"].Value.ToString();
            BranchName = dataGridView.Rows[e.RowIndex].Cells["BranchName"].Value.ToString();
            Cheq = dataGridView.Rows[e.RowIndex].Cells["Cheq"].Value.ToString();
            ChqAmt = dataGridView.Rows[e.RowIndex].Cells["ChqAmt"].Value.ToString();
            ChqDate = dataGridView.Rows[e.RowIndex].Cells["ChqDate"].Value.ToString();


            DGVPrinter printer = new DGVPrinter();
            printer.printDocument.DefaultPageSettings.Landscape = true;

            printer.Title = "Kalash Banquet Hall " + Environment.NewLine + "Sari, Bhagalpur - 812002, Bihar" + Environment.NewLine + "Ph : +91 0000000000 | +91 1111111111";
            printer.SubTitle = String.Format("\n                                                " +
                "----------------------------------------- \n" +
                "                                                             Booking Details \n" +
                "                                                ----------------------------------------- \n" +
                " Bill No. : {0}      | Date : {1}                      |                   Time : {2}" +
                "\n-------------------------------------------------------------------------------------------------\n" +
                "\n  Name  :          {3}" +
                "\n  Mobile No. :   {4}" +
                "\n  Address :        {5}" +
                "\n----------------------------------    Booking Details    ----------------------------------------" +
                "\n  Purpose :            {6}" +
                "\n  Hall :                   {7}" +
                "\n  Timing:               {8}" +
                "\n  DJ :                      {9}" +
                "\n  Photo Graphy :   {10}" +
                "\n  Video Graphy :   {11}" +
                "\n  Stage Deco. :      {12}" +
                "\n  Band Baza :        {13}" +
                "\n  Booking Date :   {14}" +
                "\n  To Booking :       {15}" +
                "\n  Total Guest :       {16}" +
                "\n --------------------------------   Charges Details    ----------------------------------------" +
                "\n  Hall  :                  {17}" +
                "\n  Photography :    {18}" +
                "\n  Videography :     {19}" +
                "\n  Satge Deco. :      {20}" +
                "\n  Band Baza :        {21}" +
                "\n  DJ :                     {22}" +
                "\n --------------------------------    Payment Details    ----------------------------------------" +
                "\n  Paid Cash :         {23}" +
                "\n  Payment Status :   {24}" +
                "\n --------------------------    Banking Payment Details   ------------------------------------" +
                "\n  Bank Name :      {25}" +
                "\n  Branch Name :    {26}" +
                "\n  Checque No. :    {27}" +
                "\n  Checque Amount : {28}" +
                "\n  Checque Date :   {29}" +
                "\n\n\n\n\n\n" +
                "-------------------------------------------------------------------------------------------------\n" +
                "                     This is a computer generated biil no signature required \n" +
                "-------------------------------------------------------------------------------------------------\n",
               bookingNO, DateTime.Now.ToString("dd MMMM yyyy"), DateTime.Now.ToString("hh:mm:ss tt"), name, mobile, address, purpose, hall, timing, dj, photo, video, stage, band, date1, date2, totalGuest, PayHall, PayPhoto, PayVideo, PayStage, PayBand, PayDJ, Cash, PayStatus, BankName, BranchName, Cheq, ChqAmt, ChqDate);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PrintMargins = new System.Drawing.Printing.Margins(60, 60, 30, 15);
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.SubTitleAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.Footer = "Developed by : Deepak Singh, Contact: deepsinghkumar01@gmail.com, Ph : +91 9525357044";
            printer.PrintDataGridView(guna2DataGridView1);
        }
    }
}

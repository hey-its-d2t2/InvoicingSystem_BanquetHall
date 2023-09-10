using ShreeWellnessCenter.usrFrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ShreeWellnessCenter.ctrlFrm
{
    public partial class ctrlFrmAddNewUsrSal : Form
    {
        public ctrlFrmAddNewUsrSal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ctrlFrmAddNewUsrSal_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlFrmAddNewUsrSal_Load(object sender, EventArgs e)
        {
            txtName.Select();
        }

        private void ctrlFrmAddNewUsrSal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if(txtName.Text!="")
                {
                    lblInvalidUsrName.Visible = false;

                    txtID.Select();
                }
                else
                {
                    lblInvalidUsrName.Visible = true;
                }
            }
            else if(e.KeyCode==Keys.Escape)
            {
                    lblInvalidUsrName.Visible = false;
                txtName.SelectAll();
            }
            else if(e.KeyCode == Keys.Up)
            {
                lblInvalidUsrName.Visible = false;
                txtName.SelectAll();
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            lblInvalidUsrName.Visible = false;
            if(txtName.Text!="")
            {
                txtName.SelectAll();
            }
        }

        private void txtID_Click(object sender, EventArgs e)
        {
            lblErrID.Visible = false;
            if( txtID.Text!="")
            {
                txtID.SelectAll();
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if (txtID.Text != "")
                {
                    lblErrID.Visible = false;
                    txtPass.Select();
                }
                else
                {
                    lblErrID.Visible = true;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lblErrID.Visible = false;
                txtID.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                lblErrID.Visible = false;
                txtName.Select();
            }

        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            lblErrPass.Visible = false;
            if(txtPass.Text !="")
            { txtPass.SelectAll(); }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                if (txtPass.Text != "")
                {
                    lblErrID.Visible = false;
                    btnAddNewUsrSal.Select();
                }
                else
                {
                    lblErrPass.Visible = true;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lblErrPass.Visible = false;
                txtPass.SelectAll();
            }
            else if (e.KeyCode == Keys.Up)
            {
                lblErrPass.Visible = false;
                txtID.Select();
            }
        }
        string rad;


        private void btnAddNewUsrSal_Click(object sender, EventArgs e)
        {
            db DB = new db();
            if (txtName.Text != "")
            {
                if (txtID.Text != "")
                {
                    if(txtPass.Text!="")
                    {
                       
                            string s = "admin";
                            string query = "INSERT INTO USER_DETAILS(user_id, name, password) VALUES ('" + txtID.Text.ToString() + "','" + txtName.Text.ToString() + "','"+txtPass.Text.ToString()+"')";
                            DB.SetData(query);
                            usr_frmControlAdm usr_FrmControlAdm = new usr_frmControlAdm();
                            usr_FrmControlAdm.getMyData();
                            usr_FrmControlAdm.dataGridUserDetails.Refresh();
                            string tn = txtName.Text.ToString();
                             DialogResult = MessageBox.Show(tn + Environment.NewLine + "उपयोगकर्ता Admin के रूप में जोड़ा गया !...", "सुचना", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (DialogResult == DialogResult.OK)
                            {
                                usr_FrmControlAdm.getMyData();
                                usr_FrmControlAdm.dataGridUserDetails.Refresh();
                                this.Close();
                            }
                        
                        
                       

                    }
                    else
                    {
                        lblErrPass.Visible = true;
                        txtPass.Select();
                    }
                }
                else
                {
                    txtID.Select();
                    lblErrID.Visible = true;
                }
            }
            else
            {
                txtName.Select();
                lblInvalidUsrName.Visible = true;
            }
        }
    }
}

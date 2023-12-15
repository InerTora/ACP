using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACP
{
    public partial class frmStorageGroup : Form
    {
        productCreationClass pc = new productCreationClass();
        public frmStorageGroup()
        {
            InitializeComponent();
        }

        private void dgvStorageDmnsn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvStorageDmnsn.Rows[e.RowIndex];

            Id.globalID = row.Cells["Storage ID"].Value.ToString();
            Id.globalString = row.Cells["Description"].Value.ToString();
        }

        public void storageDmnsnGroup()
        {
            DataTable dt = pc.fetchRecord("VIEW", "FETCHSTORAGEDMNSN", "", "", "", "");
            BindingSource source = new BindingSource();
            source.DataSource = dt;
            dgvStorageDmnsn.DataSource = source;

        }

        private void frmStorageGroup_Load(object sender, EventArgs e)
        {
            storageDmnsnGroup();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Id.button == "CREATE")
            {
                string description = txtDesc.Text;
                description = char.ToUpper(description[0]) + description.Substring(1);
                DataTable dt = pc.fetchRecord("VIEW", "FETCHSTORAGEDMNSNBYDESC", txtDesc.Text, "", "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtDesc.Text))
                    {
                        pc.modifyProduct(pc.sdGroupID().ToString(), "", description, "CRUD", "STORAGEDMNSN", "");
                        storageDmnsnGroup();
                        txtDesc.Clear();
                    }
                }
            }
            else if (Id.button == "UPDATE")
            {
                string description = txtDesc.Text;
                DataTable dt = pc.fetchRecord("VIEW", "FETCHSTORAGEDMNSNFORUPDATE", txtDesc.Text, Id.globalID, "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtDesc.Text))
                    {
                        description = char.ToUpper(description[0]) + description.Substring(1);
                        pc.modifyProduct(Id.globalID, "", description, "CRUD", "STORAGEDMNSN", "");
                        storageDmnsnGroup();
                        txtDesc.Clear();
                        btnAdd.Enabled = false;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            Id.globalID = "";
            Id.button = "CREATE";
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvStorageDmnsn.SelectedRows.Count > 0)
            {
                btnCreate.Enabled = true;
                txtDesc.Text = Id.globalString;
                label4.Text = Id.globalID;
                Id.button = "UPDATE";
            }
            else
            {
                MessageBox.Show("Please select a row to edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvStorageDmnsn.SelectedRows.Count > 0)
            {
                pc.modifyProduct(Id.globalID, "", "", "DELETE", "STORAGEDMNSN", "");
                storageDmnsnGroup();
                btnCreate.Enabled = false;
                txtDesc.Clear();
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            storageDmnsnGroup();
            txtDesc.Clear();
            btnAdd.Enabled = false;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}

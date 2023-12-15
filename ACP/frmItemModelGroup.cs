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
    public partial class frmItemModelGroup : Form
    {
        productCreationClass pc = new productCreationClass();
        public frmItemModelGroup()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Id.button == "CREATE")
            {
                string description = txtDesc.Text;
                DataTable dt = pc.fetchRecord("VIEW", "FETCHITEMMODELBYDESC", "", "", "", txtDesc.Text);
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
                        pc.modifyProduct(Id.sdGroupID, pc.itemModelID().ToString(), "", "CRUD", "ITEMMODEL", description);
                        itemModel();
                        txtDesc.Clear();
                    }
                }
            }
            else if (Id.button == "UPDATE")
            {
                string description = txtDesc.Text;
                DataTable dt = pc.fetchRecord("VIEW", "FETCHITEMMODELFORUPDATE", "", "", Id.globalID, txtDesc.Text);
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
                        pc.modifyProduct(Id.globalID, Id.sdGroupID, "", "CRUD", "ITEMMODEL", description);
                        itemModel();
                        txtDesc.Clear();
                        btnAdd.Enabled = false;
                    }
                }
            }
        }

        public void cbStorage()
        {
            DataTable dt = pc.fetchRecord("VIEW", "FETCHSTORAGEDMNSN", "", "", "", "");
            DataRow row = dt.NewRow();
            row["Description"] = "";
            row["Storage ID"] = DBNull.Value;
            dt.Rows.InsertAt(row, 0);
            cbSgroup.DataSource = dt;
            cbSgroup.DisplayMember = "Description";
            cbSgroup.ValueMember = "Storage ID";
        }

        public void itemModel()
        {
            DataTable dt = pc.fetchRecord("VIEW", "FETCHITEMMODEL", "", "", "", "");
            BindingSource source = new BindingSource();
            source.DataSource = dt;
            dgvItemModel.DataSource = source;
        }

        private void frmItemModelGroup_Load(object sender, EventArgs e)
        {
            itemModel();
            cbStorage();
        }

        private void cbSgroup_SelectedValueChanged(object sender, EventArgs e)
        {
            Id.sdGroupID = cbSgroup.GetItemText(cbSgroup.SelectedValue);
        }

        private void cbSgroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Id.sdGroupID = cbSgroup.GetItemText(cbSgroup.SelectedValue);
        }

        private void dgvItemModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvItemModel.Rows[e.RowIndex];

            Id.globalID = row.Cells["Item ID"].Value.ToString();
            Id.globalString2 = row.Cells["Storage Group"].Value.ToString();
            Id.globalString = row.Cells["Item Description"].Value.ToString();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            txtDesc.Text = Id.globalString;
            cbSgroup.Text = Id.globalString2;
            Id.button = "UPDATE";
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

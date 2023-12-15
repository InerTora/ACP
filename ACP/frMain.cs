using System;
using System.Windows.Forms;
using ACP;

namespace ACP
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void frMain_Load(object sender, EventArgs e)
        {
            pictureBox2.Focus();
        }

        private void tvModule_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = tvModule.SelectedNode;

            switch (selectedNode.Name)
            {
                case "ProductMgt":

                    frmProdMgt Addproduct = new frmProdMgt { TopLevel = false };
                    pBody.Controls.Add(Addproduct);
                    Addproduct.BringToFront();
                    Addproduct.Show();
                    
                    break;

                case "catHierarchy":

                    frmCatHierarchy prodierar = new frmCatHierarchy { TopLevel = false };
                    pBody.Controls.Add(prodierar);
                    prodierar.BringToFront();
                    prodierar.Show();
                    break;


                case "supmgt":
                    frmSupplierMgt sup = new frmSupplierMgt { TopLevel = false };
                    pBody.Controls.Add(sup);
                    sup.BringToFront();
                    sup.Show();
                    break;

                case "storage_dimension_group":
                    frmStorageGroup sdg = new frmStorageGroup { TopLevel = false };
                    pBody.Controls.Add(sdg);
                    sdg.BringToFront();
                    sdg.Show();
                    break;

                case "item_model_group":
                    frmItemModelGroup img = new frmItemModelGroup { TopLevel = false };
                    pBody.Controls.Add(img);
                    img.BringToFront();
                    img.Show();
                    break;

                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

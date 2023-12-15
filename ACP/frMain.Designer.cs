namespace ACP
{
    partial class frMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Product Management");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Supplier Management");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Process", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Category Hierarchy");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Storage Dimension Group");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Item Model Group");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tracking Dimension Group");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Reservation Hierarchy");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Product", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Setup", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Reports");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Warehouse & Inventory", 6, 6, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Setup");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Reports");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Retail", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Setup");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Reports");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Human Resource", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Setup");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Reports");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Accounting", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Setup");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Reports");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Administration", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pSidebar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tvModule = new System.Windows.Forms.TreeView();
            this.imageModule = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pBody = new System.Windows.Forms.Panel();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.pHeader.Controls.Add(this.btnClose);
            this.pHeader.Controls.Add(this.label1);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(977, 30);
            this.pHeader.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(950, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MALL OF ACE CENTERPOINT";
            // 
            // pSidebar
            // 
            this.pSidebar.BackColor = System.Drawing.Color.White;
            this.pSidebar.Controls.Add(this.label2);
            this.pSidebar.Controls.Add(this.tvModule);
            this.pSidebar.Controls.Add(this.label3);
            this.pSidebar.Controls.Add(this.pictureBox2);
            this.pSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSidebar.Location = new System.Drawing.Point(0, 30);
            this.pSidebar.Name = "pSidebar";
            this.pSidebar.Size = new System.Drawing.Size(244, 568);
            this.pSidebar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Iner E. Tora";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tvModule
            // 
            this.tvModule.BackColor = System.Drawing.Color.White;
            this.tvModule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvModule.ImageIndex = 0;
            this.tvModule.ImageList = this.imageModule;
            this.tvModule.Location = new System.Drawing.Point(3, 119);
            this.tvModule.Name = "tvModule";
            treeNode1.Name = "ProductMgt";
            treeNode1.Text = "Product Management";
            treeNode2.Name = "supmgt";
            treeNode2.Text = "Supplier Management";
            treeNode3.Name = "cWareProcesss";
            treeNode3.Text = "Process";
            treeNode4.Name = "catHierarchy";
            treeNode4.Text = "Category Hierarchy";
            treeNode5.Name = "storage_dimension_group";
            treeNode5.Text = "Storage Dimension Group";
            treeNode6.Name = "item_model_group";
            treeNode6.Text = "Item Model Group";
            treeNode7.Name = "tracking_group";
            treeNode7.Text = "Tracking Dimension Group";
            treeNode8.Name = "reserv_hierarchy";
            treeNode8.Text = "Reservation Hierarchy";
            treeNode9.Name = "product";
            treeNode9.Text = "Product";
            treeNode10.Name = "cWareSetup";
            treeNode10.Text = "Setup";
            treeNode11.Name = "cWareReports";
            treeNode11.Text = "Reports";
            treeNode12.ImageIndex = 6;
            treeNode12.Name = "pWI";
            treeNode12.SelectedImageIndex = 6;
            treeNode12.Text = "Warehouse & Inventory";
            treeNode13.Name = "cRetailProcess";
            treeNode13.Text = "Process";
            treeNode14.Name = "cRetailSetup";
            treeNode14.Text = "Setup";
            treeNode15.Name = "cRetailReports";
            treeNode15.Text = "Reports";
            treeNode16.ImageIndex = 7;
            treeNode16.Name = "pRetail";
            treeNode16.SelectedImageIndex = 7;
            treeNode16.Text = "Retail";
            treeNode17.Name = "cHRProcess";
            treeNode17.Text = "Process";
            treeNode18.Name = "cHRSetup";
            treeNode18.Text = "Setup";
            treeNode19.Name = "cHRReports";
            treeNode19.Text = "Reports";
            treeNode20.ImageIndex = 8;
            treeNode20.Name = "pHR";
            treeNode20.SelectedImageIndex = 8;
            treeNode20.Text = "Human Resource";
            treeNode21.Name = "cAccountingProcess";
            treeNode21.Text = "Process";
            treeNode22.Name = "cAccountingSetup";
            treeNode22.Text = "Setup";
            treeNode23.Name = "cAccountingReports";
            treeNode23.Text = "Reports";
            treeNode24.ImageIndex = 0;
            treeNode24.Name = "pAccounting";
            treeNode24.Text = "Accounting";
            treeNode25.Name = "cAdminProcess";
            treeNode25.Text = "Process";
            treeNode26.Name = "cAdminSetup";
            treeNode26.Text = "Setup";
            treeNode27.Name = "cAdminReports";
            treeNode27.Text = "Reports";
            treeNode28.ImageIndex = 4;
            treeNode28.Name = "pAdmin";
            treeNode28.SelectedImageIndex = 4;
            treeNode28.Text = "Administration";
            this.tvModule.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode16,
            treeNode20,
            treeNode24,
            treeNode28});
            this.tvModule.SelectedImageIndex = 0;
            this.tvModule.Size = new System.Drawing.Size(238, 485);
            this.tvModule.TabIndex = 6;
            this.tvModule.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvModule_AfterSelect);
            // 
            // imageModule
            // 
            this.imageModule.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageModule.ImageStream")));
            this.imageModule.TransparentColor = System.Drawing.Color.Transparent;
            this.imageModule.Images.SetKeyName(0, "accounting.png");
            this.imageModule.Images.SetKeyName(1, "basket.png");
            this.imageModule.Images.SetKeyName(2, "budget.png");
            this.imageModule.Images.SetKeyName(3, "contract.png");
            this.imageModule.Images.SetKeyName(4, "engineer.png");
            this.imageModule.Images.SetKeyName(5, "inventory.png");
            this.imageModule.Images.SetKeyName(6, "received.png");
            this.imageModule.Images.SetKeyName(7, "report.png");
            this.imageModule.Images.SetKeyName(8, "resource (1).png");
            this.imageModule.Images.SetKeyName(9, "settings.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Administrator";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pBody
            // 
            this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBody.Location = new System.Drawing.Point(244, 30);
            this.pBody.Name = "pBody";
            this.pBody.Size = new System.Drawing.Size(733, 568);
            this.pBody.TabIndex = 3;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 598);
            this.ControlBox = false;
            this.Controls.Add(this.pBody);
            this.Controls.Add(this.pSidebar);
            this.Controls.Add(this.pHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frMain_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pSidebar.ResumeLayout(false);
            this.pSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvModule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageModule;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pBody;
    }
}
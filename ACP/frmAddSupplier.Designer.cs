namespace ACP
{
    partial class frmAddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSupplier));
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuppDesc = new System.Windows.Forms.TextBox();
            this.lbNew = new System.Windows.Forms.Label();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddress = new System.Windows.Forms.TabPage();
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.addressID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Record Type:";
            // 
            // txtSupCode
            // 
            this.txtSupCode.BackColor = System.Drawing.Color.White;
            this.txtSupCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupCode.Location = new System.Drawing.Point(231, 56);
            this.txtSupCode.Name = "txtSupCode";
            this.txtSupCode.Size = new System.Drawing.Size(139, 25);
            this.txtSupCode.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Supplier Code:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 5);
            this.panel1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSuppDesc);
            this.groupBox1.Controls.Add(this.lbNew);
            this.groupBox1.Controls.Add(this.txtAgent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSupCode);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 235);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Information";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Non-Trade",
            "Trade"});
            this.comboBox1.Location = new System.Drawing.Point(385, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 25);
            this.comboBox1.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Group:";
            // 
            // txtSuppDesc
            // 
            this.txtSuppDesc.BackColor = System.Drawing.Color.White;
            this.txtSuppDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppDesc.Location = new System.Drawing.Point(17, 108);
            this.txtSuppDesc.Name = "txtSuppDesc";
            this.txtSuppDesc.Size = new System.Drawing.Size(479, 25);
            this.txtSuppDesc.TabIndex = 64;
            // 
            // lbNew
            // 
            this.lbNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNew.Image = ((System.Drawing.Image)(resources.GetObject("lbNew.Image")));
            this.lbNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNew.Location = new System.Drawing.Point(171, 56);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(54, 23);
            this.lbNew.TabIndex = 62;
            this.lbNew.Text = "New";
            this.lbNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbNew.Click += new System.EventHandler(this.lbNew_Click);
            // 
            // txtAgent
            // 
            this.txtAgent.BackColor = System.Drawing.Color.White;
            this.txtAgent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgent.Location = new System.Drawing.Point(17, 164);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(479, 25);
            this.txtAgent.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Agent:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(757, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Create";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(17, 54);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(148, 25);
            this.cbType.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabAddress);
            this.tabControl1.Controls.Add(this.tabContact);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 267);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 208);
            this.tabControl1.TabIndex = 22;
            // 
            // tabAddress
            // 
            this.tabAddress.Controls.Add(this.dgvAddress);
            this.tabAddress.Controls.Add(this.panel3);
            this.tabAddress.Controls.Add(this.panel2);
            this.tabAddress.ImageIndex = 0;
            this.tabAddress.Location = new System.Drawing.Point(4, 23);
            this.tabAddress.Name = "tabAddress";
            this.tabAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddress.Size = new System.Drawing.Size(861, 181);
            this.tabAddress.TabIndex = 0;
            this.tabAddress.Text = "Address Information";
            this.tabAddress.UseVisualStyleBackColor = true;
            // 
            // dgvAddress
            // 
            this.dgvAddress.AllowUserToAddRows = false;
            this.dgvAddress.AllowUserToDeleteRows = false;
            this.dgvAddress.AllowUserToResizeColumns = false;
            this.dgvAddress.AllowUserToResizeRows = false;
            this.dgvAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddress.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressID,
            this.desc,
            this.address,
            this.city,
            this.province,
            this.transDate});
            this.dgvAddress.Location = new System.Drawing.Point(6, 53);
            this.dgvAddress.MultiSelect = false;
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            this.dgvAddress.RowHeadersVisible = false;
            this.dgvAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddress.Size = new System.Drawing.Size(849, 122);
            this.dgvAddress.TabIndex = 22;
            // 
            // addressID
            // 
            this.addressID.HeaderText = "Address ID";
            this.addressID.Name = "addressID";
            this.addressID.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.HeaderText = "Description";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // province
            // 
            this.province.HeaderText = "Province";
            this.province.Name = "province";
            this.province.ReadOnly = true;
            // 
            // transDate
            // 
            this.transDate.HeaderText = "Date Created";
            this.transDate.Name = "transDate";
            this.transDate.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 3);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLink);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 41);
            this.panel2.TabIndex = 0;
            // 
            // btnLink
            // 
            this.btnLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLink.Image = ((System.Drawing.Image)(resources.GetObject("btnLink.Image")));
            this.btnLink.Location = new System.Drawing.Point(79, 3);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(70, 35);
            this.btnLink.TabIndex = 33;
            this.btnLink.Text = "Add";
            this.btnLink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(155, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 35);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(3, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(70, 35);
            this.btnadd.TabIndex = 30;
            this.btnadd.Text = "New";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.dataGridView1);
            this.tabContact.Controls.Add(this.panel5);
            this.tabContact.Controls.Add(this.panel4);
            this.tabContact.ImageIndex = 1;
            this.tabContact.Location = new System.Drawing.Point(4, 23);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(861, 181);
            this.tabContact.TabIndex = 1;
            this.tabContact.Text = "Contact Information";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(849, 127);
            this.dataGridView1.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(855, 3);
            this.panel5.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnConAdd);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(855, 41);
            this.panel4.TabIndex = 1;
            // 
            // btnConAdd
            // 
            this.btnConAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConAdd.FlatAppearance.BorderSize = 0;
            this.btnConAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnConAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnConAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnConAdd.Image")));
            this.btnConAdd.Location = new System.Drawing.Point(79, 3);
            this.btnConAdd.Name = "btnConAdd";
            this.btnConAdd.Size = new System.Drawing.Size(70, 35);
            this.btnConAdd.TabIndex = 33;
            this.btnConAdd.Text = "Add";
            this.btnConAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConAdd.UseVisualStyleBackColor = true;
            this.btnConAdd.Click += new System.EventHandler(this.btnConAdd_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(231, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 35);
            this.button4.TabIndex = 32;
            this.button4.Text = "Delete";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(155, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 35);
            this.button5.TabIndex = 31;
            this.button5.Text = "Edit";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 35);
            this.button6.TabIndex = 30;
            this.button6.Text = "New";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "placeholder.png");
            this.imageList1.Images.SetKeyName(1, "contact.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(757, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 67;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 479);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Supplier Information";
            this.Load += new System.EventHandler(this.frmAddSupplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabAddress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddress;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Label lbNew;
        public System.Windows.Forms.ComboBox cbType;
        public System.Windows.Forms.TextBox txtAgent;
        public System.Windows.Forms.TextBox txtSupCode;
        public System.Windows.Forms.TextBox txtSuppDesc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnConAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.DataGridView dgvAddress;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressID;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDate;
        private System.Windows.Forms.Button button1;
    }
}
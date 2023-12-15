﻿namespace ACP
{
    partial class frmItemModelGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemModelGroup));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sidebar = new System.Windows.Forms.Panel();
            this.dgvItemModel = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cbSgroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemModel)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(338, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 463);
            this.panel2.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(338, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 66);
            this.panel1.TabIndex = 58;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(183, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 60);
            this.btnRefresh.TabIndex = 41;
            this.btnRefresh.Text = "\r\nRefresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.Location = new System.Drawing.Point(117, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(60, 60);
            this.btDelete.TabIndex = 35;
            this.btDelete.Text = "\r\nDelete";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 60);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "\r\nAdd";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.FlatAppearance.BorderSize = 0;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.Location = new System.Drawing.Point(61, 3);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(50, 60);
            this.btEdit.TabIndex = 36;
            this.btEdit.Text = "\r\nEdit";
            this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.dgvItemModel);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(338, 529);
            this.sidebar.TabIndex = 60;
            // 
            // dgvItemModel
            // 
            this.dgvItemModel.AllowUserToAddRows = false;
            this.dgvItemModel.AllowUserToDeleteRows = false;
            this.dgvItemModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemModel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvItemModel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItemModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemModel.Location = new System.Drawing.Point(0, 0);
            this.dgvItemModel.MultiSelect = false;
            this.dgvItemModel.Name = "dgvItemModel";
            this.dgvItemModel.ReadOnly = true;
            this.dgvItemModel.RowHeadersVisible = false;
            this.dgvItemModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemModel.Size = new System.Drawing.Size(338, 529);
            this.dgvItemModel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 2);
            this.panel3.TabIndex = 59;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder (4).png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(295, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbSgroup
            // 
            this.cbSgroup.FormattingEnabled = true;
            this.cbSgroup.Location = new System.Drawing.Point(129, 39);
            this.cbSgroup.Name = "cbSgroup";
            this.cbSgroup.Size = new System.Drawing.Size(322, 28);
            this.cbSgroup.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Storage Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(108, 79);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(343, 27);
            this.txtDesc.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbSgroup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(361, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 168);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Enabled = false;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCreate.Location = new System.Drawing.Point(376, 112);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 36);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmItemModelGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemModelGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItemModelGroup";
            this.panel1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemModel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.DataGridView dgvItemModel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSgroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
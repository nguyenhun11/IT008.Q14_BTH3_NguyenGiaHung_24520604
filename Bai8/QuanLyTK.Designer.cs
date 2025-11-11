namespace Bai8
{
    partial class QuanLyTK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.textBoxSoTien = new System.Windows.Forms.TextBox();
            this.textBoxDC = new System.Windows.Forms.TextBox();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.textBoxSTK = new System.Windows.Forms.TextBox();
            this.labelSoTien = new System.Windows.Forms.Label();
            this.labelDC = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.labelSTK = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.PaleVioletRed;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.LavenderBlush;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(882, 60);
            this.title.TabIndex = 0;
            this.title.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.buttonExit);
            this.panelEdit.Controls.Add(this.buttonDelete);
            this.panelEdit.Controls.Add(this.buttonModify);
            this.panelEdit.Controls.Add(this.textBoxSoTien);
            this.panelEdit.Controls.Add(this.textBoxDC);
            this.panelEdit.Controls.Add(this.textBoxTenKH);
            this.panelEdit.Controls.Add(this.textBoxSTK);
            this.panelEdit.Controls.Add(this.labelSoTien);
            this.panelEdit.Controls.Add(this.labelDC);
            this.panelEdit.Controls.Add(this.labelTenKH);
            this.panelEdit.Controls.Add(this.labelSTK);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEdit.Location = new System.Drawing.Point(0, 60);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(882, 237);
            this.panelEdit.TabIndex = 12;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.BackColor = System.Drawing.Color.Pink;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(681, 183);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 40);
            this.buttonExit.TabIndex = 22;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.Pink;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(561, 183);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 40);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModify.BackColor = System.Drawing.Color.Pink;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Location = new System.Drawing.Point(371, 183);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(10);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(170, 40);
            this.buttonModify.TabIndex = 20;
            this.buttonModify.Text = "Thêm / Cập nhật";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // textBoxSoTien
            // 
            this.textBoxSoTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSoTien.BackColor = System.Drawing.Color.White;
            this.textBoxSoTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoTien.Location = new System.Drawing.Point(294, 136);
            this.textBoxSoTien.Name = "textBoxSoTien";
            this.textBoxSoTien.Size = new System.Drawing.Size(487, 34);
            this.textBoxSoTien.TabIndex = 19;
            // 
            // textBoxDC
            // 
            this.textBoxDC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDC.BackColor = System.Drawing.Color.White;
            this.textBoxDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDC.Location = new System.Drawing.Point(294, 98);
            this.textBoxDC.Name = "textBoxDC";
            this.textBoxDC.Size = new System.Drawing.Size(487, 34);
            this.textBoxDC.TabIndex = 18;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTenKH.BackColor = System.Drawing.Color.White;
            this.textBoxTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenKH.Location = new System.Drawing.Point(294, 60);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(487, 34);
            this.textBoxTenKH.TabIndex = 17;
            // 
            // textBoxSTK
            // 
            this.textBoxSTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSTK.BackColor = System.Drawing.Color.White;
            this.textBoxSTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSTK.Location = new System.Drawing.Point(294, 22);
            this.textBoxSTK.Name = "textBoxSTK";
            this.textBoxSTK.Size = new System.Drawing.Size(487, 34);
            this.textBoxSTK.TabIndex = 16;
            // 
            // labelSoTien
            // 
            this.labelSoTien.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSoTien.Location = new System.Drawing.Point(73, 139);
            this.labelSoTien.Margin = new System.Windows.Forms.Padding(5);
            this.labelSoTien.Name = "labelSoTien";
            this.labelSoTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSoTien.Size = new System.Drawing.Size(213, 28);
            this.labelSoTien.TabIndex = 15;
            this.labelSoTien.Text = "Số tiền trong tài khoản";
            this.labelSoTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDC
            // 
            this.labelDC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDC.Location = new System.Drawing.Point(110, 101);
            this.labelDC.Margin = new System.Windows.Forms.Padding(5);
            this.labelDC.Name = "labelDC";
            this.labelDC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDC.Size = new System.Drawing.Size(176, 28);
            this.labelDC.TabIndex = 14;
            this.labelDC.Text = "Địa chỉ khách hàng";
            this.labelDC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTenKH
            // 
            this.labelTenKH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTenKH.Location = new System.Drawing.Point(140, 62);
            this.labelTenKH.Margin = new System.Windows.Forms.Padding(5);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTenKH.Size = new System.Drawing.Size(146, 28);
            this.labelTenKH.TabIndex = 13;
            this.labelTenKH.Text = "Tên khách hàng";
            this.labelTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSTK
            // 
            this.labelSTK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSTK.Location = new System.Drawing.Point(165, 25);
            this.labelSTK.Margin = new System.Windows.Forms.Padding(5);
            this.labelSTK.Name = "labelSTK";
            this.labelSTK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSTK.Size = new System.Drawing.Size(121, 28);
            this.labelSTK.TabIndex = 12;
            this.labelSTK.Text = "Số tài khoản";
            this.labelSTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaTK,
            this.TenKH,
            this.DC,
            this.SoTien});
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(9, 303);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(861, 290);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.FillWeight = 60F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 60;
            // 
            // MaTK
            // 
            this.MaTK.FillWeight = 104.9465F;
            this.MaTK.HeaderText = "Mã tài khoản";
            this.MaTK.MinimumWidth = 6;
            this.MaTK.Name = "MaTK";
            this.MaTK.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.FillWeight = 104.9465F;
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // DC
            // 
            this.DC.FillWeight = 104.9465F;
            this.DC.HeaderText = "Địa chỉ";
            this.DC.MinimumWidth = 6;
            this.DC.Name = "DC";
            this.DC.ReadOnly = true;
            // 
            // SoTien
            // 
            this.SoTien.FillWeight = 104.9465F;
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            // 
            // labelTongTien
            // 
            this.labelTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Location = new System.Drawing.Point(651, 609);
            this.labelTongTien.Margin = new System.Windows.Forms.Padding(5);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTongTien.Size = new System.Drawing.Size(95, 28);
            this.labelTongTien.TabIndex = 12;
            this.labelTongTien.Text = "Tổng tiền";
            this.labelTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTongTien.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTien.ForeColor = System.Drawing.Color.Crimson;
            this.textBoxTongTien.Location = new System.Drawing.Point(754, 607);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.ReadOnly = true;
            this.textBoxTongTien.Size = new System.Drawing.Size(116, 34);
            this.textBoxTongTien.TabIndex = 19;
            this.textBoxTongTien.Text = "100";
            this.textBoxTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // QuanLyTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBoxTongTien);
            this.Controls.Add(this.labelTongTien);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "QuanLyTK";
            this.Text = "Quản lý tài khoản";
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.TextBox textBoxSoTien;
        private System.Windows.Forms.TextBox textBoxDC;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.TextBox textBoxSTK;
        private System.Windows.Forms.Label labelSoTien;
        private System.Windows.Forms.Label labelDC;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label labelSTK;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.TextBox textBoxTongTien;
    }
}


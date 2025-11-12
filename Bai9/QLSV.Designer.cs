namespace Bai9
{
    partial class QLSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title = new System.Windows.Forms.Label();
            this.groupBoxInfor = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUnchoose = new System.Windows.Forms.Button();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.listBoxChoose = new System.Windows.Forms.ListBox();
            this.listBoxAble = new System.Windows.Forms.ListBox();
            this.comboBoxMajor = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMSSV = new System.Windows.Forms.TextBox();
            this.labelChoose = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelMajor = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMSSV = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.LightSkyBlue;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.AliceBlue;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(912, 60);
            this.title.TabIndex = 0;
            this.title.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxInfor
            // 
            this.groupBoxInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfor.Controls.Add(this.radioButtonFemale);
            this.groupBoxInfor.Controls.Add(this.radioButtonMale);
            this.groupBoxInfor.Controls.Add(this.buttonDelete);
            this.groupBoxInfor.Controls.Add(this.buttonSave);
            this.groupBoxInfor.Controls.Add(this.buttonUnchoose);
            this.groupBoxInfor.Controls.Add(this.buttonChoose);
            this.groupBoxInfor.Controls.Add(this.listBoxChoose);
            this.groupBoxInfor.Controls.Add(this.listBoxAble);
            this.groupBoxInfor.Controls.Add(this.comboBoxMajor);
            this.groupBoxInfor.Controls.Add(this.textBoxName);
            this.groupBoxInfor.Controls.Add(this.textBoxMSSV);
            this.groupBoxInfor.Controls.Add(this.labelChoose);
            this.groupBoxInfor.Controls.Add(this.labelGender);
            this.groupBoxInfor.Controls.Add(this.labelMajor);
            this.groupBoxInfor.Controls.Add(this.labelName);
            this.groupBoxInfor.Controls.Add(this.labelMSSV);
            this.groupBoxInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInfor.Location = new System.Drawing.Point(39, 70);
            this.groupBoxInfor.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.groupBoxInfor.MinimumSize = new System.Drawing.Size(840, 400);
            this.groupBoxInfor.Name = "groupBoxInfor";
            this.groupBoxInfor.Size = new System.Drawing.Size(840, 400);
            this.groupBoxInfor.TabIndex = 1;
            this.groupBoxInfor.TabStop = false;
            this.groupBoxInfor.Text = "Thông tin sinh viên";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Window;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(583, 340);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 40);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Xóa chọn";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(381, 340);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(182, 40);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Lưu thông tin";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUnchoose
            // 
            this.buttonUnchoose.BackColor = System.Drawing.Color.LightCoral;
            this.buttonUnchoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnchoose.Location = new System.Drawing.Point(381, 272);
            this.buttonUnchoose.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.buttonUnchoose.Name = "buttonUnchoose";
            this.buttonUnchoose.Size = new System.Drawing.Size(40, 40);
            this.buttonUnchoose.TabIndex = 13;
            this.buttonUnchoose.Text = "<";
            this.buttonUnchoose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUnchoose.UseVisualStyleBackColor = false;
            this.buttonUnchoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonChoose
            // 
            this.buttonChoose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoose.Location = new System.Drawing.Point(381, 226);
            this.buttonChoose.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(40, 40);
            this.buttonChoose.TabIndex = 12;
            this.buttonChoose.Text = ">";
            this.buttonChoose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonChoose.UseVisualStyleBackColor = false;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // listBoxChoose
            // 
            this.listBoxChoose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxChoose.FormattingEnabled = true;
            this.listBoxChoose.ItemHeight = 28;
            this.listBoxChoose.Items.AddRange(new object[] {
            "nhập môn lập trình",
            "Cớ sở dữ liệu",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.listBoxChoose.Location = new System.Drawing.Point(474, 213);
            this.listBoxChoose.Name = "listBoxChoose";
            this.listBoxChoose.Size = new System.Drawing.Size(223, 114);
            this.listBoxChoose.TabIndex = 11;
            // 
            // listBoxAble
            // 
            this.listBoxAble.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxAble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxAble.FormattingEnabled = true;
            this.listBoxAble.ItemHeight = 28;
            this.listBoxAble.Items.AddRange(new object[] {
            "nhập môn lập trình",
            "Cớ sở dữ liệu",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.listBoxAble.Location = new System.Drawing.Point(105, 213);
            this.listBoxAble.Name = "listBoxAble";
            this.listBoxAble.Size = new System.Drawing.Size(223, 114);
            this.listBoxAble.TabIndex = 10;
            // 
            // comboBoxMajor
            // 
            this.comboBoxMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMajor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxMajor.FormattingEnabled = true;
            this.comboBoxMajor.Items.AddRange(new object[] {
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Kỹ thuật máy tính",
            "Hệ thống thông tin",
            "Mạng máy tính và truyền thông",
            "Khoa học và kỹ thuật thông tin"});
            this.comboBoxMajor.Location = new System.Drawing.Point(256, 103);
            this.comboBoxMajor.Name = "comboBoxMajor";
            this.comboBoxMajor.Size = new System.Drawing.Size(441, 36);
            this.comboBoxMajor.TabIndex = 7;
            this.comboBoxMajor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(256, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(441, 34);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxMSSV
            // 
            this.textBoxMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMSSV.Location = new System.Drawing.Point(256, 32);
            this.textBoxMSSV.Name = "textBoxMSSV";
            this.textBoxMSSV.Size = new System.Drawing.Size(441, 34);
            this.textBoxMSSV.TabIndex = 5;
            // 
            // labelChoose
            // 
            this.labelChoose.Location = new System.Drawing.Point(100, 177);
            this.labelChoose.Margin = new System.Windows.Forms.Padding(3);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(256, 30);
            this.labelChoose.TabIndex = 4;
            this.labelChoose.Text = "Chọn các môn học tham gia";
            this.labelChoose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGender
            // 
            this.labelGender.Location = new System.Drawing.Point(100, 141);
            this.labelGender.Margin = new System.Windows.Forms.Padding(3);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(150, 30);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Giới tính";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMajor
            // 
            this.labelMajor.Location = new System.Drawing.Point(100, 105);
            this.labelMajor.Margin = new System.Windows.Forms.Padding(3);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(150, 30);
            this.labelMajor.TabIndex = 2;
            this.labelMajor.Text = "Chuyên ngành";
            this.labelMajor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(100, 69);
            this.labelName.Margin = new System.Windows.Forms.Padding(3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(150, 30);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Họ tên";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMSSV
            // 
            this.labelMSSV.Location = new System.Drawing.Point(100, 33);
            this.labelMSSV.Margin = new System.Windows.Forms.Padding(3);
            this.labelMSSV.Name = "labelMSSV";
            this.labelMSSV.Size = new System.Drawing.Size(150, 30);
            this.labelMSSV.TabIndex = 0;
            this.labelMSSV.Text = "Mã số sinh viên";
            this.labelMSSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.FullName,
            this.Major,
            this.Gender,
            this.Count});
            this.dataGridView.Location = new System.Drawing.Point(39, 483);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(840, 179);
            this.dataGridView.TabIndex = 2;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Major
            // 
            this.Major.FillWeight = 150F;
            this.Major.HeaderText = "Chuyên ngành";
            this.Major.MinimumWidth = 6;
            this.Major.Name = "Major";
            this.Major.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Số môn";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(256, 139);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(75, 32);
            this.radioButtonMale.TabIndex = 16;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Nam\r\n";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(346, 140);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(60, 32);
            this.radioButtonFemale.TabIndex = 17;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Nữ";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(912, 674);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxInfor);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(930, 660);
            this.Name = "QLSV";
            this.Text = "Nhập liệu sinh viên";
            this.groupBoxInfor.ResumeLayout(false);
            this.groupBoxInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBoxInfor;
        private System.Windows.Forms.Label labelMajor;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMSSV;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMSSV;
        private System.Windows.Forms.ComboBox comboBoxMajor;
        private System.Windows.Forms.ListBox listBoxAble;
        private System.Windows.Forms.ListBox listBoxChoose;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonUnchoose;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
    }
}


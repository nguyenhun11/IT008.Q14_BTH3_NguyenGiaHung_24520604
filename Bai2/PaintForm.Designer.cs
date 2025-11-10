namespace Bai2
{
    partial class PaintForm
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
            this.title = new System.Windows.Forms.Label();
            this.buttonInvalidate = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonDeleteContent = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.title.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(730, 60);
            this.title.TabIndex = 0;
            this.title.Text = "Paint";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInvalidate
            // 
            this.buttonInvalidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInvalidate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonInvalidate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInvalidate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvalidate.Location = new System.Drawing.Point(571, 559);
            this.buttonInvalidate.Name = "buttonInvalidate";
            this.buttonInvalidate.Size = new System.Drawing.Size(147, 55);
            this.buttonInvalidate.TabIndex = 1;
            this.buttonInvalidate.Text = "Invalidate";
            this.buttonInvalidate.UseVisualStyleBackColor = false;
            this.buttonInvalidate.Click += new System.EventHandler(this.Invalidate_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(571, 498);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(147, 55);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.BackColor = System.Drawing.Color.MintCream;
            this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(11, 437);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatus.Size = new System.Drawing.Size(554, 175);
            this.textBoxStatus.TabIndex = 3;
            // 
            // buttonDeleteContent
            // 
            this.buttonDeleteContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteContent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDeleteContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteContent.Location = new System.Drawing.Point(571, 437);
            this.buttonDeleteContent.Name = "buttonDeleteContent";
            this.buttonDeleteContent.Size = new System.Drawing.Size(147, 55);
            this.buttonDeleteContent.TabIndex = 4;
            this.buttonDeleteContent.Text = "Xóa lịch sử";
            this.buttonDeleteContent.UseVisualStyleBackColor = false;
            this.buttonDeleteContent.Click += new System.EventHandler(this.buttonDeleteContent_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.Honeydew;
            this.panelContent.Location = new System.Drawing.Point(11, 63);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(707, 368);
            this.panelContent.TabIndex = 5;
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(730, 626);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.buttonDeleteContent);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonInvalidate);
            this.Controls.Add(this.title);
            this.Name = "PaintForm";
            this.Text = "Paint";
            this.Activated += new System.EventHandler(this.PaintForm_Activated);
            this.Deactivate += new System.EventHandler(this.PaintForm_Deactivate);
            this.Load += new System.EventHandler(this.PaintForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintForm_Paint);
            this.Resize += new System.EventHandler(this.PaintForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button buttonInvalidate;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonDeleteContent;
        private System.Windows.Forms.Panel panelContent;
    }
}


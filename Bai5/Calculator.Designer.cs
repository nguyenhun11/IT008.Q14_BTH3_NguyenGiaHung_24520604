namespace Bai5
{
    partial class Calculator
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.labelAns = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(599, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Simple calculator";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.UseWaitCursor = true;
            // 
            // labelNum1
            // 
            this.labelNum1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNum1.AutoSize = true;
            this.labelNum1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum1.Location = new System.Drawing.Point(123, 97);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(100, 28);
            this.labelNum1.TabIndex = 1;
            this.labelNum1.Text = "Number 1";
            this.labelNum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelNum1.UseWaitCursor = true;
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum1.Location = new System.Drawing.Point(229, 94);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(237, 34);
            this.textBoxNum1.TabIndex = 2;
            this.textBoxNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum1.UseWaitCursor = true;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum2.Location = new System.Drawing.Point(229, 134);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(237, 34);
            this.textBoxNum2.TabIndex = 4;
            this.textBoxNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum2.UseWaitCursor = true;
            // 
            // labelNum2
            // 
            this.labelNum2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNum2.AutoSize = true;
            this.labelNum2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum2.Location = new System.Drawing.Point(123, 137);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(100, 28);
            this.labelNum2.TabIndex = 3;
            this.labelNum2.Text = "Number 2";
            this.labelNum2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelNum2.UseWaitCursor = true;
            // 
            // textBoxAns
            // 
            this.textBoxAns.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAns.Location = new System.Drawing.Point(204, 294);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.ReadOnly = true;
            this.textBoxAns.Size = new System.Drawing.Size(262, 34);
            this.textBoxAns.TabIndex = 6;
            this.textBoxAns.TabStop = false;
            this.textBoxAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAns.UseWaitCursor = true;
            // 
            // labelAns
            // 
            this.labelAns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAns.AutoSize = true;
            this.labelAns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAns.Location = new System.Drawing.Point(123, 296);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(75, 28);
            this.labelAns.TabIndex = 5;
            this.labelAns.Text = "Answer";
            this.labelAns.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAns.UseWaitCursor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(128, 201);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 60);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.UseWaitCursor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(214, 201);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(80, 60);
            this.buttonMinus.TabIndex = 8;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.UseWaitCursor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonTimes
            // 
            this.buttonTimes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonTimes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimes.Location = new System.Drawing.Point(300, 201);
            this.buttonTimes.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(80, 60);
            this.buttonTimes.TabIndex = 9;
            this.buttonTimes.Text = "x";
            this.buttonTimes.UseVisualStyleBackColor = false;
            this.buttonTimes.UseWaitCursor = true;
            this.buttonTimes.Click += new System.EventHandler(this.buttonTimes_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(386, 201);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(80, 60);
            this.buttonDivide.TabIndex = 10;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.UseWaitCursor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(599, 368);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonTimes);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonDivide;
    }
}


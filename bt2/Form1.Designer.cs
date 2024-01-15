namespace bt2
{
    partial class Form1
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.txtNetVe = new System.Windows.Forms.Label();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.inpPenWidth = new System.Windows.Forms.NumericUpDown();
            this.btnColor = new System.Windows.Forms.Button();
            this.cdPenColor = new System.Windows.Forms.ColorDialog();
            this.btnChoseColor = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblChoseColor = new System.Windows.Forms.Label();
            this.cdFillColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(1, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(803, 503);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // txtNetVe
            // 
            this.txtNetVe.AutoSize = true;
            this.txtNetVe.Location = new System.Drawing.Point(835, 22);
            this.txtNetVe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNetVe.Name = "txtNetVe";
            this.txtNetVe.Size = new System.Drawing.Size(49, 17);
            this.txtNetVe.TabIndex = 1;
            this.txtNetVe.Text = "Nét vẽ";
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Location = new System.Drawing.Point(835, 60);
            this.lblPenColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(35, 17);
            this.lblPenColor.TabIndex = 2;
            this.lblPenColor.Text = "Màu";
            // 
            // inpPenWidth
            // 
            this.inpPenWidth.Location = new System.Drawing.Point(913, 20);
            this.inpPenWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inpPenWidth.Name = "inpPenWidth";
            this.inpPenWidth.Size = new System.Drawing.Size(116, 22);
            this.inpPenWidth.TabIndex = 4;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColor.Location = new System.Drawing.Point(913, 54);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(116, 28);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Chọn Màu";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnChoseColor
            // 
            this.btnChoseColor.Location = new System.Drawing.Point(913, 262);
            this.btnChoseColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoseColor.Name = "btnChoseColor";
            this.btnChoseColor.Size = new System.Drawing.Size(116, 28);
            this.btnChoseColor.TabIndex = 6;
            this.btnChoseColor.Text = "Chọn màu tô";
            this.btnChoseColor.UseVisualStyleBackColor = true;
            this.btnChoseColor.Click += new System.EventHandler(this.btnChoseColor_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(913, 110);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Tô màu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblChoseColor
            // 
            this.lblChoseColor.AutoSize = true;
            this.lblChoseColor.Location = new System.Drawing.Point(833, 262);
            this.lblChoseColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoseColor.Name = "lblChoseColor";
            this.lblChoseColor.Size = new System.Drawing.Size(51, 17);
            this.lblChoseColor.TabIndex = 8;
            this.lblChoseColor.Text = "Màu tô";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.lblChoseColor);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnChoseColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.inpPenWidth);
            this.Controls.Add(this.lblPenColor);
            this.Controls.Add(this.txtNetVe);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label txtNetVe;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.NumericUpDown inpPenWidth;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog cdPenColor;
        private System.Windows.Forms.Button btnChoseColor;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblChoseColor;
        private System.Windows.Forms.ColorDialog cdFillColor;
    }
}


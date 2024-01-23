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
            this.lblChoseColor = new System.Windows.Forms.Label();
            this.cdFillColor = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPatternColor = new System.Windows.Forms.RadioButton();
            this.rbFillColor = new System.Windows.Forms.RadioButton();
            this.rbNoColor = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbRectangle = new System.Windows.Forms.RadioButton();
            this.rdbCircle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(1, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtNetVe.Location = new System.Drawing.Point(22, 47);
            this.txtNetVe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNetVe.Name = "txtNetVe";
            this.txtNetVe.Size = new System.Drawing.Size(68, 25);
            this.txtNetVe.TabIndex = 1;
            this.txtNetVe.Text = "Nét vẽ";
            this.txtNetVe.Click += new System.EventHandler(this.txtNetVe_Click);
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Location = new System.Drawing.Point(22, 97);
            this.lblPenColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(51, 25);
            this.lblPenColor.TabIndex = 2;
            this.lblPenColor.Text = "Màu";
            // 
            // inpPenWidth
            // 
            this.inpPenWidth.Location = new System.Drawing.Point(102, 47);
            this.inpPenWidth.Margin = new System.Windows.Forms.Padding(4);
            this.inpPenWidth.Name = "inpPenWidth";
            this.inpPenWidth.Size = new System.Drawing.Size(116, 30);
            this.inpPenWidth.TabIndex = 4;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColor.Location = new System.Drawing.Point(102, 94);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(116, 31);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Chọn Màu";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnChoseColor
            // 
            this.btnChoseColor.BackColor = System.Drawing.SystemColors.Window;
            this.btnChoseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoseColor.Location = new System.Drawing.Point(105, 127);
            this.btnChoseColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoseColor.Name = "btnChoseColor";
            this.btnChoseColor.Size = new System.Drawing.Size(116, 35);
            this.btnChoseColor.TabIndex = 6;
            this.btnChoseColor.Text = "Chọn màu tô";
            this.btnChoseColor.UseVisualStyleBackColor = false;
            this.btnChoseColor.Click += new System.EventHandler(this.btnChoseColor_Click);
            // 
            // lblChoseColor
            // 
            this.lblChoseColor.AutoSize = true;
            this.lblChoseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoseColor.Location = new System.Drawing.Point(23, 134);
            this.lblChoseColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoseColor.Name = "lblChoseColor";
            this.lblChoseColor.Size = new System.Drawing.Size(60, 20);
            this.lblChoseColor.TabIndex = 8;
            this.lblChoseColor.Text = "Màu tô";
            this.lblChoseColor.Click += new System.EventHandler(this.lblChoseColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNetVe);
            this.groupBox1.Controls.Add(this.btnColor);
            this.groupBox1.Controls.Add(this.lblPenColor);
            this.groupBox1.Controls.Add(this.inpPenWidth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(811, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bút";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPatternColor);
            this.groupBox2.Controls.Add(this.rbFillColor);
            this.groupBox2.Controls.Add(this.rbNoColor);
            this.groupBox2.Controls.Add(this.lblChoseColor);
            this.groupBox2.Controls.Add(this.btnChoseColor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(811, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 173);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nét vẽ";
            // 
            // rbPatternColor
            // 
            this.rbPatternColor.AutoSize = true;
            this.rbPatternColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbPatternColor.Location = new System.Drawing.Point(27, 99);
            this.rbPatternColor.Name = "rbPatternColor";
            this.rbPatternColor.Size = new System.Drawing.Size(138, 24);
            this.rbPatternColor.TabIndex = 11;
            this.rbPatternColor.TabStop = true;
            this.rbPatternColor.Text = "Điền màu mẫu";
            this.rbPatternColor.UseVisualStyleBackColor = true;
            // 
            // rbFillColor
            // 
            this.rbFillColor.AutoSize = true;
            this.rbFillColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbFillColor.Location = new System.Drawing.Point(27, 64);
            this.rbFillColor.Name = "rbFillColor";
            this.rbFillColor.Size = new System.Drawing.Size(101, 24);
            this.rbFillColor.TabIndex = 10;
            this.rbFillColor.TabStop = true;
            this.rbFillColor.Text = "Điền màu";
            this.rbFillColor.UseVisualStyleBackColor = true;
            // 
            // rbNoColor
            // 
            this.rbNoColor.AutoSize = true;
            this.rbNoColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbNoColor.Location = new System.Drawing.Point(27, 29);
            this.rbNoColor.Name = "rbNoColor";
            this.rbNoColor.Size = new System.Drawing.Size(113, 24);
            this.rbNoColor.TabIndex = 9;
            this.rbNoColor.TabStop = true;
            this.rbNoColor.Text = "Không điền";
            this.rbNoColor.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(811, 514);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(228, 31);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Làm mới màn hình";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbCircle);
            this.groupBox3.Controls.Add(this.rdbRectangle);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(811, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 111);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hình";
            // 
            // rdbRectangle
            // 
            this.rdbRectangle.AutoSize = true;
            this.rdbRectangle.Location = new System.Drawing.Point(22, 29);
            this.rdbRectangle.Name = "rdbRectangle";
            this.rdbRectangle.Size = new System.Drawing.Size(153, 29);
            this.rdbRectangle.TabIndex = 2;
            this.rdbRectangle.TabStop = true;
            this.rdbRectangle.Text = "Hình chữ nhật";
            this.rdbRectangle.UseVisualStyleBackColor = true;
            // 
            // rdbCircle
            // 
            this.rdbCircle.AutoSize = true;
            this.rdbCircle.Location = new System.Drawing.Point(22, 64);
            this.rdbCircle.Name = "rdbCircle";
            this.rdbCircle.Size = new System.Drawing.Size(111, 29);
            this.rdbCircle.TabIndex = 3;
            this.rdbCircle.TabStop = true;
            this.rdbCircle.Text = "Hình tròn";
            this.rdbCircle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label txtNetVe;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.NumericUpDown inpPenWidth;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog cdPenColor;
        private System.Windows.Forms.Button btnChoseColor;
        private System.Windows.Forms.Label lblChoseColor;
        private System.Windows.Forms.ColorDialog cdFillColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPatternColor;
        private System.Windows.Forms.RadioButton rbFillColor;
        private System.Windows.Forms.RadioButton rbNoColor;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbCircle;
        private System.Windows.Forms.RadioButton rdbRectangle;
    }
}


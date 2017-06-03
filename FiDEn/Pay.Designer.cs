namespace FiDEn
{
  partial class Pay
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
      if(disposing && (components != null))
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
      this.label10 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.tbMailConfrim = new System.Windows.Forms.TextBox();
      this.tbMail = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.tbCVV = new System.Windows.Forms.TextBox();
      this.tbDate2 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.tbDate1 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnValidate = new System.Windows.Forms.Button();
      this.tbArea4 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbArea3 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbArea2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tbArea1 = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label9 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(13, 163);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(338, 16);
      this.label10.TabIndex = 41;
      this.label10.Text = "注意：信箱將作為兩步驟驗證資料，請小心填寫。";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(12, 107);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(53, 16);
      this.label8.TabIndex = 39;
      this.label8.Text = "信箱：";
      // 
      // tbMailConfrim
      // 
      this.tbMailConfrim.Location = new System.Drawing.Point(89, 132);
      this.tbMailConfrim.Name = "tbMailConfrim";
      this.tbMailConfrim.Size = new System.Drawing.Size(289, 23);
      this.tbMailConfrim.TabIndex = 38;
      // 
      // tbMail
      // 
      this.tbMail.Location = new System.Drawing.Point(89, 104);
      this.tbMail.Name = "tbMail";
      this.tbMail.Size = new System.Drawing.Size(289, 23);
      this.tbMail.TabIndex = 37;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(108, 6);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(258, 16);
      this.label7.TabIndex = 36;
      this.label7.Text = "一次性購買。(付費一次即可永久使用)";
      // 
      // tbCVV
      // 
      this.tbCVV.Location = new System.Drawing.Point(335, 66);
      this.tbCVV.Name = "tbCVV";
      this.tbCVV.PasswordChar = '*';
      this.tbCVV.Size = new System.Drawing.Size(51, 23);
      this.tbCVV.TabIndex = 35;
      this.tbCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // tbDate2
      // 
      this.tbDate2.Location = new System.Drawing.Point(202, 66);
      this.tbDate2.Name = "tbDate2";
      this.tbDate2.Size = new System.Drawing.Size(43, 23);
      this.tbDate2.TabIndex = 34;
      this.tbDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(173, 69);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(23, 16);
      this.label6.TabIndex = 33;
      this.label6.Text = "／";
      // 
      // tbDate1
      // 
      this.tbDate1.Location = new System.Drawing.Point(125, 66);
      this.tbDate1.Name = "tbDate1";
      this.tbDate1.Size = new System.Drawing.Size(42, 23);
      this.tbDate1.TabIndex = 32;
      this.tbDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(282, 69);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(47, 16);
      this.label5.TabIndex = 31;
      this.label5.Text = "CVV：";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(31, 69);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(88, 16);
      this.label4.TabIndex = 30;
      this.label4.Text = "有效月/年：";
      // 
      // btnValidate
      // 
      this.btnValidate.Location = new System.Drawing.Point(384, 104);
      this.btnValidate.Name = "btnValidate";
      this.btnValidate.Size = new System.Drawing.Size(91, 51);
      this.btnValidate.TabIndex = 39;
      this.btnValidate.Text = "確認付費";
      this.btnValidate.UseVisualStyleBackColor = true;
      this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
      // 
      // tbArea4
      // 
      this.tbArea4.Location = new System.Drawing.Point(384, 26);
      this.tbArea4.Name = "tbArea4";
      this.tbArea4.Size = new System.Drawing.Size(56, 23);
      this.tbArea4.TabIndex = 28;
      this.tbArea4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbArea4.TextChanged += new System.EventHandler(this.tbArea4_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(355, 29);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(23, 16);
      this.label3.TabIndex = 27;
      this.label3.Text = "─";
      // 
      // tbArea3
      // 
      this.tbArea3.Location = new System.Drawing.Point(293, 26);
      this.tbArea3.Name = "tbArea3";
      this.tbArea3.Size = new System.Drawing.Size(56, 23);
      this.tbArea3.TabIndex = 26;
      this.tbArea3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbArea3.TextChanged += new System.EventHandler(this.tbArea3_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(264, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(23, 16);
      this.label2.TabIndex = 25;
      this.label2.Text = "─";
      // 
      // tbArea2
      // 
      this.tbArea2.Location = new System.Drawing.Point(202, 26);
      this.tbArea2.Name = "tbArea2";
      this.tbArea2.Size = new System.Drawing.Size(56, 23);
      this.tbArea2.TabIndex = 24;
      this.tbArea2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbArea2.TextChanged += new System.EventHandler(this.tbArea2_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(173, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(23, 16);
      this.label1.TabIndex = 23;
      this.label1.Text = "─";
      // 
      // tbArea1
      // 
      this.tbArea1.Location = new System.Drawing.Point(111, 25);
      this.tbArea1.Name = "tbArea1";
      this.tbArea1.Size = new System.Drawing.Size(56, 23);
      this.tbArea1.TabIndex = 22;
      this.tbArea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbArea1.TextChanged += new System.EventHandler(this.tbArea1_TextChanged);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(88, 50);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 21;
      this.pictureBox1.TabStop = false;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(12, 135);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(83, 16);
      this.label9.TabIndex = 40;
      this.label9.Text = "信箱確認：";
      // 
      // Pay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(493, 189);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.tbMailConfrim);
      this.Controls.Add(this.tbMail);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.tbCVV);
      this.Controls.Add(this.tbDate2);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.tbDate1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnValidate);
      this.Controls.Add(this.tbArea4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tbArea3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbArea2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbArea1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label9);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Pay";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FiDEn 凡殿加密 ─ 線上付費";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox tbMailConfrim;
    private System.Windows.Forms.TextBox tbMail;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox tbCVV;
    private System.Windows.Forms.TextBox tbDate2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbDate1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnValidate;
    private System.Windows.Forms.TextBox tbArea4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbArea3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbArea2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbArea1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label9;
  }
}
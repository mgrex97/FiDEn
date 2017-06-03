namespace FiDEn
{
  partial class Main
  {
    /// <summary>
    /// 設計工具所需的變數。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清除任何使用中的資源。
    /// </summary>
    /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
    protected override void Dispose(bool disposing)
    {
      if(disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 設計工具產生的程式碼

    /// <summary>
    /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
    /// 這個方法的內容。
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.btnRegSystemService = new System.Windows.Forms.Button();
      this.btnRemoveMonitor = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.tbDecrypt = new System.Windows.Forms.TextBox();
      this.btnDecrypt = new System.Windows.Forms.Button();
      this.btnDecryptBrowse = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.cbLevel = new System.Windows.Forms.ComboBox();
      this.tbEncrypt = new System.Windows.Forms.TextBox();
      this.btnEncrypt = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.btnEncryptBrowse = new System.Windows.Forms.Button();
      this.gbStatus = new System.Windows.Forms.GroupBox();
      this.btnClearValidate = new System.Windows.Forms.Button();
      this.btnValidate = new System.Windows.Forms.Button();
      this.lbStatus = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label6 = new System.Windows.Forms.Label();
      this.btnAbout = new System.Windows.Forms.Button();
      this.btnAddMonitor = new System.Windows.Forms.Button();
      this.tbNmEncrypt = new System.Windows.Forms.TextBox();
      this.btnNmEncrypt = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.bntNmEncryptBrowse = new System.Windows.Forms.Button();
      this.tbMain = new System.Windows.Forms.TabControl();
      this.tbNormal = new System.Windows.Forms.TabPage();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label8 = new System.Windows.Forms.Label();
      this.tbNmDecrypt = new System.Windows.Forms.TextBox();
      this.btnNmDecrypt = new System.Windows.Forms.Button();
      this.bntNmDecryptBrowse = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label7 = new System.Windows.Forms.Label();
      this.tbAdvanced = new System.Windows.Forms.TabPage();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.lbAutoMonitoring = new System.Windows.Forms.ListBox();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.gbStatus.SuspendLayout();
      this.tbMain.SuspendLayout();
      this.tbNormal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tbAdvanced.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnRegSystemService
      // 
      this.btnRegSystemService.ForeColor = System.Drawing.Color.DarkCyan;
      this.btnRegSystemService.Location = new System.Drawing.Point(679, 34);
      this.btnRegSystemService.Name = "btnRegSystemService";
      this.btnRegSystemService.Size = new System.Drawing.Size(182, 42);
      this.btnRegSystemService.TabIndex = 4;
      this.btnRegSystemService.Text = "註冊程式為系統服務";
      this.btnRegSystemService.UseVisualStyleBackColor = true;
      // 
      // btnRemoveMonitor
      // 
      this.btnRemoveMonitor.ForeColor = System.Drawing.Color.DodgerBlue;
      this.btnRemoveMonitor.Location = new System.Drawing.Point(583, 14);
      this.btnRemoveMonitor.Name = "btnRemoveMonitor";
      this.btnRemoveMonitor.Size = new System.Drawing.Size(75, 23);
      this.btnRemoveMonitor.TabIndex = 3;
      this.btnRemoveMonitor.Text = "移除";
      this.btnRemoveMonitor.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      this.groupBox3.BackColor = System.Drawing.Color.LightGreen;
      this.groupBox3.Controls.Add(this.tbDecrypt);
      this.groupBox3.Controls.Add(this.btnDecrypt);
      this.groupBox3.Controls.Add(this.btnDecryptBrowse);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Location = new System.Drawing.Point(6, 120);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(888, 63);
      this.groupBox3.TabIndex = 10;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "解密";
      // 
      // tbDecrypt
      // 
      this.tbDecrypt.Location = new System.Drawing.Point(77, 25);
      this.tbDecrypt.Name = "tbDecrypt";
      this.tbDecrypt.Size = new System.Drawing.Size(604, 23);
      this.tbDecrypt.TabIndex = 6;
      // 
      // btnDecrypt
      // 
      this.btnDecrypt.Font = new System.Drawing.Font("Tahoma", 15F);
      this.btnDecrypt.ForeColor = System.Drawing.Color.Green;
      this.btnDecrypt.Location = new System.Drawing.Point(758, 19);
      this.btnDecrypt.Name = "btnDecrypt";
      this.btnDecrypt.Size = new System.Drawing.Size(124, 38);
      this.btnDecrypt.TabIndex = 9;
      this.btnDecrypt.Text = "解密";
      this.btnDecrypt.UseVisualStyleBackColor = true;
      // 
      // btnDecryptBrowse
      // 
      this.btnDecryptBrowse.Location = new System.Drawing.Point(687, 23);
      this.btnDecryptBrowse.Name = "btnDecryptBrowse";
      this.btnDecryptBrowse.Size = new System.Drawing.Size(65, 27);
      this.btnDecryptBrowse.TabIndex = 5;
      this.btnDecryptBrowse.Text = "瀏覽";
      this.btnDecryptBrowse.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 28);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 16);
      this.label3.TabIndex = 7;
      this.label3.Text = "路徑：";
      // 
      // groupBox4
      // 
      this.groupBox4.BackColor = System.Drawing.Color.MistyRose;
      this.groupBox4.Controls.Add(this.cbLevel);
      this.groupBox4.Controls.Add(this.tbEncrypt);
      this.groupBox4.Controls.Add(this.btnEncrypt);
      this.groupBox4.Controls.Add(this.label4);
      this.groupBox4.Controls.Add(this.btnEncryptBrowse);
      this.groupBox4.Location = new System.Drawing.Point(6, 17);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(885, 97);
      this.groupBox4.TabIndex = 9;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "加密";
      // 
      // cbLevel
      // 
      this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbLevel.FormattingEnabled = true;
      this.cbLevel.Location = new System.Drawing.Point(323, 59);
      this.cbLevel.Name = "cbLevel";
      this.cbLevel.Size = new System.Drawing.Size(121, 24);
      this.cbLevel.TabIndex = 4;
      // 
      // tbEncrypt
      // 
      this.tbEncrypt.Location = new System.Drawing.Point(74, 22);
      this.tbEncrypt.Name = "tbEncrypt";
      this.tbEncrypt.Size = new System.Drawing.Size(734, 23);
      this.tbEncrypt.TabIndex = 1;
      // 
      // btnEncrypt
      // 
      this.btnEncrypt.Font = new System.Drawing.Font("Tahoma", 15F);
      this.btnEncrypt.ForeColor = System.Drawing.Color.Red;
      this.btnEncrypt.Location = new System.Drawing.Point(447, 51);
      this.btnEncrypt.Name = "btnEncrypt";
      this.btnEncrypt.Size = new System.Drawing.Size(124, 40);
      this.btnEncrypt.TabIndex = 3;
      this.btnEncrypt.Text = "加密";
      this.btnEncrypt.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 25);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 16);
      this.label4.TabIndex = 2;
      this.label4.Text = "路徑：";
      // 
      // btnEncryptBrowse
      // 
      this.btnEncryptBrowse.Location = new System.Drawing.Point(814, 20);
      this.btnEncryptBrowse.Name = "btnEncryptBrowse";
      this.btnEncryptBrowse.Size = new System.Drawing.Size(65, 27);
      this.btnEncryptBrowse.TabIndex = 0;
      this.btnEncryptBrowse.Text = "瀏覽";
      this.btnEncryptBrowse.UseVisualStyleBackColor = true;
      // 
      // gbStatus
      // 
      this.gbStatus.Controls.Add(this.btnClearValidate);
      this.gbStatus.Controls.Add(this.btnValidate);
      this.gbStatus.Controls.Add(this.lbStatus);
      this.gbStatus.Location = new System.Drawing.Point(12, 12);
      this.gbStatus.Name = "gbStatus";
      this.gbStatus.Size = new System.Drawing.Size(791, 57);
      this.gbStatus.TabIndex = 11;
      this.gbStatus.TabStop = false;
      this.gbStatus.Text = "狀態";
      // 
      // btnClearValidate
      // 
      this.btnClearValidate.ForeColor = System.Drawing.Color.DimGray;
      this.btnClearValidate.Location = new System.Drawing.Point(708, 19);
      this.btnClearValidate.Name = "btnClearValidate";
      this.btnClearValidate.Size = new System.Drawing.Size(77, 27);
      this.btnClearValidate.TabIndex = 8;
      this.btnClearValidate.Text = "清除驗證";
      this.btnClearValidate.UseVisualStyleBackColor = true;
      // 
      // btnValidate
      // 
      this.btnValidate.ForeColor = System.Drawing.Color.Red;
      this.btnValidate.Location = new System.Drawing.Point(638, 19);
      this.btnValidate.Name = "btnValidate";
      this.btnValidate.Size = new System.Drawing.Size(65, 27);
      this.btnValidate.TabIndex = 7;
      this.btnValidate.Text = "驗證";
      this.btnValidate.UseVisualStyleBackColor = true;
      // 
      // lbStatus
      // 
      this.lbStatus.AutoSize = true;
      this.lbStatus.Font = new System.Drawing.Font("Tahoma", 12F);
      this.lbStatus.Location = new System.Drawing.Point(6, 19);
      this.lbStatus.Name = "lbStatus";
      this.lbStatus.Size = new System.Drawing.Size(64, 24);
      this.lbStatus.TabIndex = 0;
      this.lbStatus.Text = "label2";
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      // 
      // label6
      // 
      this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
      this.label6.Location = new System.Drawing.Point(664, 18);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(211, 119);
      this.label6.TabIndex = 5;
      this.label6.Text = "\r\n\r\n\r\n\r\n註冊為系統程式後，可常駐在後台實行自動加密，重開機也會自行啟動。";
      // 
      // btnAbout
      // 
      this.btnAbout.ForeColor = System.Drawing.Color.Black;
      this.btnAbout.Location = new System.Drawing.Point(809, 31);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(109, 27);
      this.btnAbout.TabIndex = 12;
      this.btnAbout.Text = "關於凡殿...";
      this.btnAbout.UseVisualStyleBackColor = true;
      // 
      // btnAddMonitor
      // 
      this.btnAddMonitor.ForeColor = System.Drawing.Color.MediumOrchid;
      this.btnAddMonitor.Location = new System.Drawing.Point(502, 14);
      this.btnAddMonitor.Name = "btnAddMonitor";
      this.btnAddMonitor.Size = new System.Drawing.Size(75, 23);
      this.btnAddMonitor.TabIndex = 2;
      this.btnAddMonitor.Text = "新增";
      this.btnAddMonitor.UseVisualStyleBackColor = true;
      // 
      // tbNmEncrypt
      // 
      this.tbNmEncrypt.Location = new System.Drawing.Point(115, 22);
      this.tbNmEncrypt.Name = "tbNmEncrypt";
      this.tbNmEncrypt.Size = new System.Drawing.Size(691, 23);
      this.tbNmEncrypt.TabIndex = 1;
      // 
      // btnNmEncrypt
      // 
      this.btnNmEncrypt.Font = new System.Drawing.Font("Tahoma", 10F);
      this.btnNmEncrypt.ForeColor = System.Drawing.Color.Red;
      this.btnNmEncrypt.Location = new System.Drawing.Point(353, 51);
      this.btnNmEncrypt.Name = "btnNmEncrypt";
      this.btnNmEncrypt.Size = new System.Drawing.Size(145, 31);
      this.btnNmEncrypt.TabIndex = 3;
      this.btnNmEncrypt.Text = "加密";
      this.btnNmEncrypt.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(105, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "步驟1→路徑：";
      // 
      // bntNmEncryptBrowse
      // 
      this.bntNmEncryptBrowse.Location = new System.Drawing.Point(812, 20);
      this.bntNmEncryptBrowse.Name = "bntNmEncryptBrowse";
      this.bntNmEncryptBrowse.Size = new System.Drawing.Size(65, 27);
      this.bntNmEncryptBrowse.TabIndex = 0;
      this.bntNmEncryptBrowse.Text = "瀏覽";
      this.bntNmEncryptBrowse.UseVisualStyleBackColor = true;
      // 
      // tbMain
      // 
      this.tbMain.Controls.Add(this.tbNormal);
      this.tbMain.Controls.Add(this.tbAdvanced);
      this.tbMain.Location = new System.Drawing.Point(15, 75);
      this.tbMain.Name = "tbMain";
      this.tbMain.SelectedIndex = 0;
      this.tbMain.Size = new System.Drawing.Size(905, 374);
      this.tbMain.TabIndex = 10;
      // 
      // tbNormal
      // 
      this.tbNormal.BackColor = System.Drawing.SystemColors.Control;
      this.tbNormal.Controls.Add(this.pictureBox1);
      this.tbNormal.Controls.Add(this.groupBox2);
      this.tbNormal.Controls.Add(this.groupBox1);
      this.tbNormal.Location = new System.Drawing.Point(4, 25);
      this.tbNormal.Name = "tbNormal";
      this.tbNormal.Padding = new System.Windows.Forms.Padding(3);
      this.tbNormal.Size = new System.Drawing.Size(897, 345);
      this.tbNormal.TabIndex = 0;
      this.tbNormal.Text = "一般模式";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(6, 199);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(885, 140);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 9;
      this.pictureBox1.TabStop = false;
      // 
      // groupBox2
      // 
      this.groupBox2.BackColor = System.Drawing.Color.LightGreen;
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.tbNmDecrypt);
      this.groupBox2.Controls.Add(this.btnNmDecrypt);
      this.groupBox2.Controls.Add(this.bntNmDecryptBrowse);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Location = new System.Drawing.Point(3, 102);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(885, 92);
      this.groupBox2.TabIndex = 8;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "解密";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(287, 64);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(60, 16);
      this.label8.TabIndex = 10;
      this.label8.Text = "步驟2→";
      // 
      // tbNmDecrypt
      // 
      this.tbNmDecrypt.Location = new System.Drawing.Point(115, 25);
      this.tbNmDecrypt.Name = "tbNmDecrypt";
      this.tbNmDecrypt.Size = new System.Drawing.Size(691, 23);
      this.tbNmDecrypt.TabIndex = 6;
      // 
      // btnNmDecrypt
      // 
      this.btnNmDecrypt.Font = new System.Drawing.Font("Tahoma", 10F);
      this.btnNmDecrypt.ForeColor = System.Drawing.Color.Green;
      this.btnNmDecrypt.Location = new System.Drawing.Point(353, 54);
      this.btnNmDecrypt.Name = "btnNmDecrypt";
      this.btnNmDecrypt.Size = new System.Drawing.Size(145, 32);
      this.btnNmDecrypt.TabIndex = 9;
      this.btnNmDecrypt.Text = "解密";
      this.btnNmDecrypt.UseVisualStyleBackColor = true;
      // 
      // bntNmDecryptBrowse
      // 
      this.bntNmDecryptBrowse.Location = new System.Drawing.Point(812, 23);
      this.bntNmDecryptBrowse.Name = "bntNmDecryptBrowse";
      this.bntNmDecryptBrowse.Size = new System.Drawing.Size(65, 27);
      this.bntNmDecryptBrowse.TabIndex = 5;
      this.bntNmDecryptBrowse.Text = "瀏覽";
      this.bntNmDecryptBrowse.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 26);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(105, 16);
      this.label2.TabIndex = 7;
      this.label2.Text = "步驟1→路徑：";
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.tbNmEncrypt);
      this.groupBox1.Controls.Add(this.btnNmEncrypt);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.bntNmEncryptBrowse);
      this.groupBox1.Location = new System.Drawing.Point(3, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(885, 92);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "加密";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(287, 60);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(60, 16);
      this.label7.TabIndex = 4;
      this.label7.Text = "步驟2→";
      // 
      // tbAdvanced
      // 
      this.tbAdvanced.BackColor = System.Drawing.SystemColors.Control;
      this.tbAdvanced.Controls.Add(this.groupBox5);
      this.tbAdvanced.Controls.Add(this.groupBox3);
      this.tbAdvanced.Controls.Add(this.groupBox4);
      this.tbAdvanced.Location = new System.Drawing.Point(4, 25);
      this.tbAdvanced.Name = "tbAdvanced";
      this.tbAdvanced.Padding = new System.Windows.Forms.Padding(3);
      this.tbAdvanced.Size = new System.Drawing.Size(897, 345);
      this.tbAdvanced.TabIndex = 1;
      this.tbAdvanced.Text = "專家模式";
      // 
      // groupBox5
      // 
      this.groupBox5.BackColor = System.Drawing.Color.PowderBlue;
      this.groupBox5.Controls.Add(this.btnRegSystemService);
      this.groupBox5.Controls.Add(this.label6);
      this.groupBox5.Controls.Add(this.btnRemoveMonitor);
      this.groupBox5.Controls.Add(this.btnAddMonitor);
      this.groupBox5.Controls.Add(this.label5);
      this.groupBox5.Controls.Add(this.lbAutoMonitoring);
      this.groupBox5.Location = new System.Drawing.Point(7, 190);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(887, 149);
      this.groupBox5.TabIndex = 11;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "進階";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 19);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(233, 16);
      this.label5.TabIndex = 1;
      this.label5.Text = "監視下列資料夾並自動加密其檔案";
      // 
      // lbAutoMonitoring
      // 
      this.lbAutoMonitoring.FormattingEnabled = true;
      this.lbAutoMonitoring.ItemHeight = 16;
      this.lbAutoMonitoring.Location = new System.Drawing.Point(6, 38);
      this.lbAutoMonitoring.Name = "lbAutoMonitoring";
      this.lbAutoMonitoring.Size = new System.Drawing.Size(652, 100);
      this.lbAutoMonitoring.TabIndex = 0;
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.Text = "notifyIcon1";
      this.notifyIcon1.Visible = true;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 460);
      this.Controls.Add(this.gbStatus);
      this.Controls.Add(this.btnAbout);
      this.Controls.Add(this.tbMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FiDEn 檔案加密軟體";
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.gbStatus.ResumeLayout(false);
      this.gbStatus.PerformLayout();
      this.tbMain.ResumeLayout(false);
      this.tbNormal.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tbAdvanced.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnRegSystemService;
    private System.Windows.Forms.Button btnRemoveMonitor;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox tbDecrypt;
    private System.Windows.Forms.Button btnDecrypt;
    private System.Windows.Forms.Button btnDecryptBrowse;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.ComboBox cbLevel;
    private System.Windows.Forms.TextBox tbEncrypt;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnEncryptBrowse;
    private System.Windows.Forms.GroupBox gbStatus;
    private System.Windows.Forms.Button btnClearValidate;
    private System.Windows.Forms.Button btnValidate;
    private System.Windows.Forms.Label lbStatus;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.Button btnAddMonitor;
    private System.Windows.Forms.TextBox tbNmEncrypt;
    private System.Windows.Forms.Button btnNmEncrypt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button bntNmEncryptBrowse;
    private System.Windows.Forms.TabControl tbMain;
    private System.Windows.Forms.TabPage tbNormal;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox tbNmDecrypt;
    private System.Windows.Forms.Button btnNmDecrypt;
    private System.Windows.Forms.Button bntNmDecryptBrowse;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TabPage tbAdvanced;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ListBox lbAutoMonitoring;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
  }
}


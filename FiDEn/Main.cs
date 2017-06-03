using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiDEn
{
  public partial class Main : Form
  {
    bool validated = false;
    TwoStepsValidation TwoStepsValidation;
    DateTime expired;
    About About;
    public Main()
    {
      InitializeComponent();

      lbStatus.Text = "信箱：" + Program.Email + "，尚未驗證！";
      btnClearValidate.Enabled = false;
      btnValidate.Enabled = true;
      TwoStepsValidation = new TwoStepsValidation();
      About = new About();
      validated = false;

    }



    private void btnValidate_Click(object sender,EventArgs e)
    {

      bool validate = false;

      TwoStepsValidation.Initialize(ref validate);
      if(validate == true)
      {
        validated = true;
        expired = DateTime.Now;
        expired = expired.AddMinutes(10);//10分鐘後失效
        btnClearValidate.Enabled = true;
        btnValidate.Enabled = false;
        lbStatus.Text = "信箱：" + Program.Email + "，已驗證！";
        timer1.Enabled = true;
      }
      else
      {
        MessageBox.Show("驗證失敗！","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
      }
    }

    private void btnClearValidate_Click(object sender,EventArgs e)
    {
      timer1.Enabled = false;
      lbStatus.Text = "信箱：" + Program.Email + "，尚未驗證！";
      btnClearValidate.Enabled = false;
      btnValidate.Enabled = true;

      validated = false;
    }

    private void timer1_Tick(object sender,EventArgs e)
    {
      DateTime now = DateTime.Now;
      if(expired.Ticks <= now.Ticks)
      {//過期
        lbStatus.Text = "信箱：" + Program.Email + "，驗證資料過期！";
        btnClearValidate.Enabled = false;
        btnValidate.Enabled = true;
        btnValidate.Enabled = false;
        validated = false;
      }
      else
      {//更新驗證狀態
        int span = Convert.ToInt32((new TimeSpan(Math.Abs(expired.Ticks - now.Ticks))).TotalSeconds);
        lbStatus.Text = "信箱：" + Program.Email + "，已驗證！(剩餘" + span + "秒)";
      }
    }

    private void btnAbout_Click(object sender,EventArgs e)
    {
      About.ShowDialog();

    }
    #region 一般模式

    private void bntNmEncryptBrowse_Click(object sender,EventArgs e)
    {

    }

    private void btnNmEncrypt_Click(object sender,EventArgs e)
    {

    }

    private void bntNmDecryptBrowse_Click(object sender,EventArgs e)
    {

    }

    private void btnNmDecrypt_Click(object sender,EventArgs e)
    {
      if(validated == false)
      {
        MessageBox.Show("沒有驗證身分無法解密哦！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
        return;
      }
    }
    #endregion

    #region 專家模式

    private void btnEncryptBrowse_Click(object sender,EventArgs e)
    {

    }

    private void btnEncrypt_Click(object sender,EventArgs e)
    {

    }

    private void btnDecryptBrowse_Click(object sender,EventArgs e)
    {

    }

    private void btnDecrypt_Click(object sender,EventArgs e)
    {

    }

    private void btnAddMonitor_Click(object sender,EventArgs e)
    {
      if(folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
      {
        if(lbAutoMonitoring.Items.Contains(folderBrowserDialog1.SelectedPath)==false)
        {
          lbAutoMonitoring.Items.Add(folderBrowserDialog1.SelectedPath);
        }
        else
        {
          MessageBox.Show("資料夾已存在，取消新增！","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        
      }
    }

    private void btnRemoveMonitor_Click(object sender,EventArgs e)
    {
      if(lbAutoMonitoring.SelectedIndex < 0) { MessageBox.Show("沒有選擇項目！","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error); return; }
      if(MessageBox.Show("確定要刪除？","確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) { return; }

      lbAutoMonitoring.Items.Remove(lbAutoMonitoring.SelectedItem);
    }

    private void btnRegSystemService_Click(object sender,EventArgs e)
    {

    }
    #endregion


  }
}

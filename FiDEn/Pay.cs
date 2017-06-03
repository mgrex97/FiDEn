using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FiDEn
{
  public partial class Pay : Form
  {
    public Pay()
    {
      InitializeComponent();
    }
    public void Initialize()
    {
      tbArea1.Clear();
      tbArea2.Clear();
      tbArea3.Clear();
      tbArea4.Clear();
      tbDate1.Clear();
      tbDate2.Clear();
      tbCVV.Clear();
      tbMail.Clear();
      tbMailConfrim.Clear();
      ShowDialog();
    }

    private void tbArea1_TextChanged(object sender,EventArgs e)
    {
      if(tbArea1.Text.Length >= 4) { tbArea2.Focus(); }
    }

    private void tbArea2_TextChanged(object sender,EventArgs e)
    {
      if(tbArea2.Text.Length >= 4) { tbArea3.Focus(); }
      else if(tbArea2.Text.Length == 0) { tbArea1.Focus(); }
    }

    private void tbArea3_TextChanged(object sender,EventArgs e)
    {

      if(tbArea3.Text.Length >= 4) { tbArea4.Focus(); }
      else if(tbArea3.Text.Length == 0) { tbArea2.Focus(); }
    }

    private void tbArea4_TextChanged(object sender,EventArgs e)
    {
      if(tbArea4.Text.Length >= 4) { tbDate1.Focus(); }
      else if(tbArea4.Text.Length == 0) { tbArea3.Focus(); }
    }

    private void btnValidate_Click(object sender,EventArgs e)
    {
      //!信用卡與信箱驗證
      SaveKey();
      MessageBox.Show("付費成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
      Hide();
    }

    void SaveKey()
    {
      //!請先加密
      StreamWriter writer = new StreamWriter(@".\key",false,Encoding.Unicode);
      writer.WriteLine("IsPaid=true");
      writer.WriteLine($"ValidationDate={DateTime.Now:yyyy/MM/dd}");
      writer.WriteLine($"Email={tbMail.Text}");



      writer.Close();//請記得放
    }
  }
}

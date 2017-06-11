using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace FiDEn
{
  static class Program
  {
    #region 全域設定
    public static bool isPaid;
    public static DateTime validateDate;
    public static string Email;
    public const int MaximumFileSize = 25 * 1024 * 1024;
    #endregion
    /// <summary>
    /// 應用程式的主要進入點。
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      Pay pay = new Pay();
      while(Validate() == false)
      {
        if(MessageBox.Show("軟體尚未授權！請付費後使用！是否現在付費？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
        {
          MessageBox.Show("軟體尚未付費，不能使用！","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
          Environment.Exit(0);
        }
        pay.Initialize();
      }

      Application.Run(new Main());






      bool Validate()
      {
        //檢查驗證檔案是否存在
        if(File.Exists(@".\key") == false)
        {
          return false;
        }
        //驗證區域
        //!需經過解密

        isPaid = false;
        StreamReader reader = new StreamReader(@".\key",Encoding.Unicode);
        string line = null;
        while((line = reader.ReadLine()) != null)
        {
          line = line.Replace(" ","");
          switch(line.Split('=')[0].ToLower())
          {
            case "ispaid": isPaid = bool.Parse(line.Split('=')[1]); break;
            case "validationdate": validateDate = Convert.ToDateTime(line.Split('=')[1]); break;
            case "email": Email = line.Split('=')[1]; break;
            default:
              break;
          }
        }
        reader.Close();



        return isPaid;
      }
    }
  }
}

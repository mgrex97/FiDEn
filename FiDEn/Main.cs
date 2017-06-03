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
    public Main()
    {
      InitializeComponent();






    }
    public void Initialize()
    {
      lbStatus.Text = "信箱：" + Program.Email + "，尚未驗證！";
      btnClearValidate.Enabled = false;
      btnValidate.Enabled = true;
      TwoStepsValidation = new TwoStepsValidation();
      validated = false;
      ShowDialog();
    }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma
{
  public partial class LoginForm : Form
  {
    public LoginForm()
    {
      InitializeComponent();
    }

    public string get_username()
    {
      return username_textBox.Text;
    }
    public string get_password()
    {
      return pass_textBox.Text;
    }

    private void login_button_Click(object sender, EventArgs e)
    {
      if (username_textBox.Text.Length == 0)
      {
        MessageBox.Show("Поле \"Имя пользователя\" не может быть пустым!");
      }
      else if (pass_textBox.Text.Length == 0)
      {
        MessageBox.Show("Поле \"Пароль\" не может быть пустым!");
      }
      else
      {
        DialogResult = DialogResult.OK;
      }  

    }
  }
}

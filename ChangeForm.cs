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
  public partial class ChangeForm : Form
  {
    public ChangeForm()
    {
      InitializeComponent();
    }

    public ChangeForm(string resource, string login, string pass) : this()
    {
      resource_textBox.Text = resource;
      login_textBox.Text = login;
      pass_textBox.Text = pass;
    }

    public string get_resource()
    {
      return resource_textBox.Text;
    }
    public string get_login()
    {
      return login_textBox.Text;
    }
    public string get_pass()
    {
      return pass_textBox.Text;
    }
    private void confirm_button_Click(object sender, EventArgs e)
    {
      if (resource_textBox.Text.Length == 0)
      {
        MessageBox.Show("Поле \"Наименование ресурса\" не может быть пустым!");
      }
      else if (login_textBox.Text.Length == 0)
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
    private string generate_pass()
    {
      string pass = "";
      Random random = new Random();
      string characters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
      int pass_length = 12;
      for (int i = 0; i < pass_length; i++)
      {
        pass += characters[random.Next(characters.Length)];
      }
      return pass;
    }
    private void generate_button_Click(object sender, EventArgs e)
    {
      pass_textBox.Text = generate_pass();
    }

  }
}

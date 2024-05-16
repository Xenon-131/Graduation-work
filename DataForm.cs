using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace diploma
{
  public partial class DataForm : Form
  {
    public DataForm()
    {
      InitializeComponent();

      connectionString = $"Data Source=DESKTOP-9BMCT7E\\SQLEXPRESS,1433;Initial Catalog=PasswordStorage;Integrated Security=SSPI";
      connection = new SqlConnection(connectionString);
      displayData();
    }

    private string login;

    private string connectionString;
    private SqlConnection connection;

    private int user_id;
    private string master_password;

    

    private void displayData()
    {
      try
      {
        connection.Open();

        string sql = $"SELECT * FROM get_passwords({user_id})";
        SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connectionString);
        DataSet passDataSet = new DataSet();
        dataAdapter.Fill(passDataSet);
        passDataGridView.DataSource = passDataSet.Tables[0];

        passDataGridView.Columns["password_id"].Visible = false;
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Generic Exception Handler: {ex}");
      }
      finally
      {
        connection.Close();
      }
    }

    private void login_button_Click(object sender, EventArgs e)
    {
      LoginForm loginForm = new LoginForm();
      loginForm.ShowDialog(this);
      if (loginForm.DialogResult == DialogResult.OK)
      {
        string login = loginForm.get_username();
        string password = loginForm.get_password();

        try
        {
          connection.Open();


          SqlCommand command = new SqlCommand($"SELECT user_id FROM Users WHERE user_name='{login}'", connection);
          using (SqlDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              user_id = (int)reader[0];
            }
          }

        }
        catch (Exception ex)
        {
          MessageBox.Show($"Generic Exception Handler: {ex}");
        }
        finally
        {
          connection.Close();
        }

        //master_password


        loginForm.Close();
      }

      displayData();

    }

    private void logout_button_Click(object sender, EventArgs e)
    {
      login = null;
      user_id = -1;
      //master_password = null;
      ArrayList empty = new ArrayList();
      passDataGridView.DataSource = empty;

      //passDataGridView.Rows.Clear();


    }

    private void execute_command(string sql)
    {
      try
      {
        connection.Open();

        SqlCommand command;
        command = new SqlCommand(sql, connection);
        command.ExecuteNonQuery();

        command.Dispose();
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Generic Exception Handler: {ex}");
      }
      finally
      {
        connection.Close();
      }
    }

    private void add_button_Click(object sender, EventArgs e)
    {
      string resource, login, pass;

      ChangeForm addForm = new ChangeForm();
      addForm.ShowDialog(this);
      if (addForm.DialogResult == DialogResult.OK)
      {
        resource = addForm.get_resource();
        login = addForm.get_login();
        pass = addForm.get_pass();
        addForm.Close();
      }
      else
      {
        MessageBox.Show("Error");
        return;
      }

      execute_command($"execute add_password '{user_id}', '{resource}', '{login}', '{pass}';");

      displayData();


    }

    private bool one_row_selected(DataGridView dataGridView)
    {
      int selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
      if (selectedRowCount == 0)
      {
        MessageBox.Show("Ни одна строка не выбрана.");
        return false;
      }
      else if (selectedRowCount > 1)
      {
        MessageBox.Show("Выделено слишком много строк. Пожалуйста, выберите одну строку.");
        return false;
      }
      else
      {
        return true;
      }
    }

    private void change_button_Click(object sender, EventArgs e)
    {
      if (one_row_selected(passDataGridView))
      {
        int row_index = passDataGridView.SelectedRows[0].Index;
        int pass_id = (int)passDataGridView.Rows[row_index].Cells[0].Value;
        string old_resource = passDataGridView.Rows[row_index].Cells[1].Value.ToString();
        string old_login = passDataGridView.Rows[row_index].Cells[2].Value.ToString();
        string old_pass = passDataGridView.Rows[row_index].Cells[3].Value.ToString();

        ChangeForm changeForm = new ChangeForm(old_resource, old_login, old_pass);
        changeForm.ShowDialog(this);
        if (changeForm.DialogResult == DialogResult.OK)
        {
          string new_resource = changeForm.get_resource();
          string new_login = changeForm.get_login();
          string new_pass = changeForm.get_pass();
          changeForm.Close();

          execute_command($"execute update_password '{pass_id}', '{new_resource}', '{new_login}', '{new_pass}';");

          displayData();
        }
        else if (changeForm.DialogResult == DialogResult.Cancel)
        {
          MessageBox.Show("Изменения отменены");
        }
        else
        {
          MessageBox.Show("Ошибка");
        }
      }
    }

    private void delete_button_Click(object sender, EventArgs e)
    {
      if (one_row_selected(passDataGridView))
      {
        int row_index = passDataGridView.SelectedRows[0].Index;
        int pass_id = (int)passDataGridView.Rows[row_index].Cells[0].Value;

        execute_command($"EXEC delete_password @id={pass_id};");

        displayData();
      }
    }

    private void copy_button_Click(object sender, EventArgs e)
    {
      if (passDataGridView.SelectedCells.Count == 1)
      {
        int column_index = passDataGridView.SelectedCells[0].ColumnIndex;
        string cell = passDataGridView.SelectedCells[0].Value.ToString();
        Clipboard.SetData(DataFormats.Text, (Object)cell);
        if (column_index == 1)
        {
          MessageBox.Show("Наименование ресурса скопировано в буфер обмена");
        }
        else if (column_index == 2)
        {
          MessageBox.Show("Имя пользователя скопировано в буфер обмена");
        }
        else if (column_index == 3)
        {
          MessageBox.Show("Пароль скопирован в буфер обмена");
        }



      }

    }

    
  }

}







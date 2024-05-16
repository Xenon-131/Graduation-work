namespace diploma
{
  partial class DataForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      passDataGridView = new DataGridView();
      add_button = new Button();
      change_button = new Button();
      delete_button = new Button();
      copy_button = new Button();
      tableLayoutPanel1 = new TableLayoutPanel();
      logout_button = new Button();
      login_button = new Button();
      ((System.ComponentModel.ISupportInitialize)passDataGridView).BeginInit();
      tableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // passDataGridView
      // 
      passDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      tableLayoutPanel1.SetColumnSpan(passDataGridView, 2);
      passDataGridView.Dock = DockStyle.Fill;
      passDataGridView.Location = new Point(3, 193);
      passDataGridView.Name = "passDataGridView";
      passDataGridView.RowHeadersWidth = 62;
      tableLayoutPanel1.SetRowSpan(passDataGridView, 4);
      passDataGridView.RowTemplate.Height = 33;
      passDataGridView.Size = new Size(742, 948);
      passDataGridView.TabIndex = 0;
      // 
      // add_button
      // 
      add_button.Dock = DockStyle.Top;
      add_button.Location = new Point(778, 410);
      add_button.Margin = new Padding(30);
      add_button.Name = "add_button";
      add_button.Size = new Size(315, 34);
      add_button.TabIndex = 1;
      add_button.Text = "Добавить";
      add_button.UseVisualStyleBackColor = true;
      add_button.Click += add_button_Click;
      // 
      // change_button
      // 
      change_button.Dock = DockStyle.Top;
      change_button.Location = new Point(778, 600);
      change_button.Margin = new Padding(30);
      change_button.Name = "change_button";
      change_button.Size = new Size(315, 34);
      change_button.TabIndex = 2;
      change_button.Text = "Изменить";
      change_button.UseVisualStyleBackColor = true;
      change_button.Click += change_button_Click;
      // 
      // delete_button
      // 
      delete_button.Dock = DockStyle.Top;
      delete_button.Location = new Point(778, 790);
      delete_button.Margin = new Padding(30);
      delete_button.Name = "delete_button";
      delete_button.Size = new Size(315, 34);
      delete_button.TabIndex = 3;
      delete_button.Text = "Удалить";
      delete_button.UseVisualStyleBackColor = true;
      delete_button.Click += delete_button_Click;
      // 
      // copy_button
      // 
      copy_button.Dock = DockStyle.Top;
      copy_button.Location = new Point(778, 220);
      copy_button.Margin = new Padding(30);
      copy_button.Name = "copy_button";
      copy_button.Size = new Size(315, 34);
      copy_button.TabIndex = 4;
      copy_button.Text = "Скопировать";
      copy_button.UseVisualStyleBackColor = true;
      copy_button.Click += copy_button_Click;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 3;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
      tableLayoutPanel1.Controls.Add(logout_button, 1, 0);
      tableLayoutPanel1.Controls.Add(copy_button, 2, 1);
      tableLayoutPanel1.Controls.Add(passDataGridView, 0, 1);
      tableLayoutPanel1.Controls.Add(add_button, 2, 2);
      tableLayoutPanel1.Controls.Add(change_button, 2, 3);
      tableLayoutPanel1.Controls.Add(delete_button, 2, 4);
      tableLayoutPanel1.Controls.Add(login_button, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 5;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.Size = new Size(1123, 1144);
      tableLayoutPanel1.TabIndex = 5;
      // 
      // logout_button
      // 
      logout_button.Dock = DockStyle.Top;
      logout_button.Location = new Point(404, 30);
      logout_button.Margin = new Padding(30);
      logout_button.Name = "logout_button";
      logout_button.Size = new Size(314, 34);
      logout_button.TabIndex = 6;
      logout_button.Text = "Выйти";
      logout_button.UseVisualStyleBackColor = true;
      logout_button.Click += logout_button_Click;
      // 
      // login_button
      // 
      login_button.Dock = DockStyle.Top;
      login_button.Location = new Point(30, 30);
      login_button.Margin = new Padding(30);
      login_button.Name = "login_button";
      login_button.Size = new Size(314, 34);
      login_button.TabIndex = 5;
      login_button.Text = "Войти в учетную запись";
      login_button.UseVisualStyleBackColor = true;
      login_button.Click += login_button_Click;
      // 
      // DataForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1123, 1144);
      Controls.Add(tableLayoutPanel1);
      Name = "DataForm";
      Text = "DataForm";
      ((System.ComponentModel.ISupportInitialize)passDataGridView).EndInit();
      tableLayoutPanel1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private DataGridView passDataGridView;
    private Button add_button;
    private Button change_button;
    private Button delete_button;
    private Button copy_button;
    private TableLayoutPanel tableLayoutPanel1;
    private Button logout_button;
    private Button login_button;
  }
}
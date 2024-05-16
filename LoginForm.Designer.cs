namespace diploma
{
  partial class LoginForm
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
      if (disposing && (components != null))
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
      login_label = new Label();
      pass_label = new Label();
      login_button = new Button();
      username_textBox = new TextBox();
      pass_textBox = new TextBox();
      SuspendLayout();
      // 
      // login_label
      // 
      login_label.AutoSize = true;
      login_label.Location = new Point(58, 131);
      login_label.Name = "login_label";
      login_label.Size = new Size(163, 25);
      login_label.TabIndex = 0;
      login_label.Text = "Имя пользователя";
      // 
      // pass_label
      // 
      pass_label.AutoSize = true;
      pass_label.Location = new Point(58, 228);
      pass_label.Name = "pass_label";
      pass_label.Size = new Size(74, 25);
      pass_label.TabIndex = 1;
      pass_label.Text = "Пароль";
      // 
      // login_button
      // 
      login_button.Location = new Point(220, 384);
      login_button.Name = "login_button";
      login_button.Size = new Size(112, 34);
      login_button.TabIndex = 2;
      login_button.Text = "Войти";
      login_button.UseVisualStyleBackColor = true;
      login_button.Click += login_button_Click;
      // 
      // username_textBox
      // 
      username_textBox.Location = new Point(338, 125);
      username_textBox.Name = "username_textBox";
      username_textBox.Size = new Size(150, 31);
      username_textBox.TabIndex = 3;
      // 
      // pass_textBox
      // 
      pass_textBox.Location = new Point(338, 222);
      pass_textBox.Name = "pass_textBox";
      pass_textBox.Size = new Size(150, 31);
      pass_textBox.TabIndex = 4;
      // 
      // LoginForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(541, 530);
      Controls.Add(pass_textBox);
      Controls.Add(username_textBox);
      Controls.Add(login_button);
      Controls.Add(pass_label);
      Controls.Add(login_label);
      Name = "LoginForm";
      Text = "LoginForm";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label login_label;
    private Label pass_label;
    private Button login_button;
    private TextBox username_textBox;
    private TextBox pass_textBox;
  }
}
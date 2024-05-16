namespace diploma
{
  partial class ChangeForm
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
      resource_label = new Label();
      login_label = new Label();
      pass_label = new Label();
      resource_textBox = new TextBox();
      login_textBox = new TextBox();
      pass_textBox = new TextBox();
      confirm_button = new Button();
      generate_button = new Button();
      SuspendLayout();
      // 
      // resource_label
      // 
      resource_label.AutoSize = true;
      resource_label.Location = new Point(182, 116);
      resource_label.Name = "resource_label";
      resource_label.Size = new Size(205, 25);
      resource_label.TabIndex = 0;
      resource_label.Text = "Наименование ресурса";
      // 
      // login_label
      // 
      login_label.AutoSize = true;
      login_label.Location = new Point(182, 192);
      login_label.Name = "login_label";
      login_label.Size = new Size(163, 25);
      login_label.TabIndex = 1;
      login_label.Text = "Имя пользователя";
      // 
      // pass_label
      // 
      pass_label.AutoSize = true;
      pass_label.Location = new Point(182, 277);
      pass_label.Name = "pass_label";
      pass_label.Size = new Size(74, 25);
      pass_label.TabIndex = 2;
      pass_label.Text = "Пароль";
      // 
      // resource_textBox
      // 
      resource_textBox.Location = new Point(531, 113);
      resource_textBox.Name = "resource_textBox";
      resource_textBox.Size = new Size(150, 31);
      resource_textBox.TabIndex = 3;
      // 
      // login_textBox
      // 
      login_textBox.Location = new Point(531, 189);
      login_textBox.Name = "login_textBox";
      login_textBox.Size = new Size(150, 31);
      login_textBox.TabIndex = 4;
      // 
      // pass_textBox
      // 
      pass_textBox.Location = new Point(531, 271);
      pass_textBox.Name = "pass_textBox";
      pass_textBox.Size = new Size(150, 31);
      pass_textBox.TabIndex = 5;
      // 
      // confirm_button
      // 
      confirm_button.Location = new Point(326, 479);
      confirm_button.Name = "confirm_button";
      confirm_button.Size = new Size(157, 34);
      confirm_button.TabIndex = 6;
      confirm_button.Text = "Подтвердить";
      confirm_button.UseVisualStyleBackColor = true;
      confirm_button.Click += confirm_button_Click;
      // 
      // generate_button
      // 
      generate_button.Location = new Point(531, 355);
      generate_button.Name = "generate_button";
      generate_button.Size = new Size(150, 64);
      generate_button.TabIndex = 7;
      generate_button.Text = "Сгенерировать пароль";
      generate_button.UseVisualStyleBackColor = true;
      generate_button.Click += generate_button_Click;
      // 
      // AddForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 613);
      Controls.Add(generate_button);
      Controls.Add(confirm_button);
      Controls.Add(pass_textBox);
      Controls.Add(login_textBox);
      Controls.Add(resource_textBox);
      Controls.Add(pass_label);
      Controls.Add(login_label);
      Controls.Add(resource_label);
      Name = "AddForm";
      Text = "AddForm";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label resource_label;
    private Label login_label;
    private Label pass_label;
    private TextBox resource_textBox;
    private TextBox login_textBox;
    private TextBox pass_textBox;
    private Button confirm_button;
    private Button generate_button;
  }
}
namespace cmp307_prototype
{
  partial class Form1
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
      button1 = new Button();
      label1 = new Label();
      devNameTxt = new TextBox();
      modelTxt = new TextBox();
      manuTxt = new TextBox();
      ipTxt = new TextBox();
      typeTxt = new TextBox();
      noteTxt = new TextBox();
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      label5 = new Label();
      label6 = new Label();
      label7 = new Label();
      label9 = new Label();
      purchaseDate = new DateTimePicker();
      label8 = new Label();
      SuspendLayout();
      // 
      // button1
      // 
      button1.BackColor = Color.Gray;
      button1.Cursor = Cursors.Hand;
      button1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button1.Location = new Point(350, 387);
      button1.Name = "button1";
      button1.Size = new Size(115, 45);
      button1.TabIndex = 0;
      button1.Text = "Add Asset";
      button1.UseVisualStyleBackColor = false;
      button1.Click += button1_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label1.ForeColor = SystemColors.ActiveCaptionText;
      label1.Location = new Point(320, 10);
      label1.Name = "label1";
      label1.Size = new Size(176, 37);
      label1.TabIndex = 1;
      label1.Text = "Add New Asset";
      // 
      // devNameTxt
      // 
      devNameTxt.Font = new Font("Poppins Medium", 12F);
      devNameTxt.Location = new Point(64, 103);
      devNameTxt.Name = "devNameTxt";
      devNameTxt.Size = new Size(286, 31);
      devNameTxt.TabIndex = 2;
      // 
      // modelTxt
      // 
      modelTxt.Font = new Font("Poppins Medium", 12F);
      modelTxt.Location = new Point(64, 172);
      modelTxt.Name = "modelTxt";
      modelTxt.Size = new Size(286, 31);
      modelTxt.TabIndex = 3;
      // 
      // manuTxt
      // 
      manuTxt.Font = new Font("Poppins Medium", 12F);
      manuTxt.Location = new Point(64, 237);
      manuTxt.Name = "manuTxt";
      manuTxt.Size = new Size(286, 31);
      manuTxt.TabIndex = 4;
      // 
      // ipTxt
      // 
      ipTxt.Font = new Font("Poppins Medium", 12F);
      ipTxt.Location = new Point(444, 123);
      ipTxt.Name = "ipTxt";
      ipTxt.Size = new Size(286, 31);
      ipTxt.TabIndex = 5;
      // 
      // typeTxt
      // 
      typeTxt.Font = new Font("Poppins Medium", 12F);
      typeTxt.Location = new Point(64, 298);
      typeTxt.Name = "typeTxt";
      typeTxt.Size = new Size(286, 31);
      typeTxt.TabIndex = 7;
      // 
      // noteTxt
      // 
      noteTxt.Font = new Font("Poppins Medium", 12F);
      noteTxt.Location = new Point(444, 259);
      noteTxt.Multiline = true;
      noteTxt.Name = "noteTxt";
      noteTxt.Size = new Size(286, 70);
      noteTxt.TabIndex = 9;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.BackColor = Color.Transparent;
      label2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label2.ForeColor = SystemColors.ActiveCaptionText;
      label2.Location = new Point(64, 72);
      label2.Name = "label2";
      label2.Size = new Size(134, 28);
      label2.TabIndex = 10;
      label2.Text = "Device Name *";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.BackColor = Color.Transparent;
      label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label3.ForeColor = SystemColors.ActiveCaptionText;
      label3.Location = new Point(64, 141);
      label3.Name = "label3";
      label3.Size = new Size(75, 28);
      label3.TabIndex = 11;
      label3.Text = "Model *";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.BackColor = Color.Transparent;
      label4.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label4.ForeColor = SystemColors.ActiveCaptionText;
      label4.Location = new Point(64, 206);
      label4.Name = "label4";
      label4.Size = new Size(140, 28);
      label4.TabIndex = 12;
      label4.Text = "Manufacturer *";
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.BackColor = Color.Transparent;
      label5.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label5.ForeColor = SystemColors.ActiveCaptionText;
      label5.Location = new Point(64, 267);
      label5.Name = "label5";
      label5.Size = new Size(64, 28);
      label5.TabIndex = 13;
      label5.Text = "Type *";
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.BackColor = Color.Transparent;
      label6.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label6.ForeColor = SystemColors.ActiveCaptionText;
      label6.Location = new Point(444, 92);
      label6.Name = "label6";
      label6.Size = new Size(111, 28);
      label6.TabIndex = 14;
      label6.Text = "IP Address *";
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.BackColor = Color.Transparent;
      label7.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label7.ForeColor = SystemColors.ActiveCaptionText;
      label7.Location = new Point(444, 165);
      label7.Name = "label7";
      label7.Size = new Size(133, 28);
      label7.TabIndex = 15;
      label7.Text = "Purchase Date";
      // 
      // label9
      // 
      label9.AutoSize = true;
      label9.BackColor = Color.Transparent;
      label9.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label9.ForeColor = SystemColors.ActiveCaptionText;
      label9.Location = new Point(446, 233);
      label9.Name = "label9";
      label9.Size = new Size(140, 28);
      label9.TabIndex = 17;
      label9.Text = "Additional Note";
      // 
      // purchaseDate
      // 
      purchaseDate.CustomFormat = " ";
      purchaseDate.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
      purchaseDate.Format = DateTimePickerFormat.Short;
      purchaseDate.Location = new Point(444, 195);
      purchaseDate.Name = "purchaseDate";
      purchaseDate.Size = new Size(286, 27);
      purchaseDate.TabIndex = 18;
      purchaseDate.Value = new DateTime(2024, 11, 5, 0, 0, 0, 0);
      purchaseDate.ValueChanged += purchaseDate_ValueChanged;
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label8.ForeColor = SystemColors.ActiveCaptionText;
      label8.Location = new Point(64, 409);
      label8.Name = "label8";
      label8.Size = new Size(135, 23);
      label8.TabIndex = 19;
      label8.Text = "* Required Fields";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(label8);
      Controls.Add(purchaseDate);
      Controls.Add(noteTxt);
      Controls.Add(typeTxt);
      Controls.Add(ipTxt);
      Controls.Add(manuTxt);
      Controls.Add(modelTxt);
      Controls.Add(devNameTxt);
      Controls.Add(label9);
      Controls.Add(label7);
      Controls.Add(label6);
      Controls.Add(label5);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(button1);
      ForeColor = SystemColors.ButtonFace;
      Name = "Form1";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Form1";
      Load += Form1_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private TextBox modelTxt;
    private TextBox manuTxt;
    private TextBox ipTxt;
    private TextBox typeTxt;
    private TextBox noteTxt;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label9;
    private DateTimePicker purchaseDate;
    public TextBox devNameTxt;
    private Label label8;
  }
}

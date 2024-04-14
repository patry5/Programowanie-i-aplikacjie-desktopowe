namespace WinFormsApp2
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
            groupBox1 = new GroupBox();
            positionBox = new ComboBox();
            Position = new Label();
            labelLastName = new Label();
            InputLastName = new TextBox();
            labelName = new Label();
            InputName = new TextBox();
            groupBox2 = new GroupBox();
            PasswordButton = new Button();
            SpecialCharsCh = new CheckBox();
            UpperLowerCh = new CheckBox();
            DigitsCh = new CheckBox();
            labelPassCount = new Label();
            charsCounterTb = new TextBox();
            ConfirmButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(positionBox);
            groupBox1.Controls.Add(Position);
            groupBox1.Controls.Add(labelLastName);
            groupBox1.Controls.Add(InputLastName);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(InputName);
            groupBox1.Font = new Font("Segoe UI", 11.75F);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pracownika";
            // 
            // positionBox
            // 
            positionBox.FormattingEnabled = true;
            positionBox.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            positionBox.Location = new Point(136, 197);
            positionBox.Name = "positionBox";
            positionBox.Size = new Size(121, 29);
            positionBox.TabIndex = 6;
            // 
            // Position
            // 
            Position.AutoSize = true;
            Position.Location = new Point(6, 197);
            Position.Name = "Position";
            Position.Size = new Size(89, 21);
            Position.TabIndex = 5;
            Position.Text = "Stanowisko";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(6, 126);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(77, 21);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Nazwisko";
            // 
            // InputLastName
            // 
            InputLastName.Location = new Point(98, 123);
            InputLastName.Name = "InputLastName";
            InputLastName.Size = new Size(174, 28);
            InputLastName.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(16, 55);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 21);
            labelName.TabIndex = 2;
            labelName.Text = "Imię";
            // 
            // InputName
            // 
            InputName.Location = new Point(98, 55);
            InputName.Name = "InputName";
            InputName.Size = new Size(174, 28);
            InputName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PasswordButton);
            groupBox2.Controls.Add(SpecialCharsCh);
            groupBox2.Controls.Add(UpperLowerCh);
            groupBox2.Controls.Add(DigitsCh);
            groupBox2.Controls.Add(labelPassCount);
            groupBox2.Controls.Add(charsCounterTb);
            groupBox2.Location = new Point(428, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 267);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie hasła";
            // 
            // PasswordButton
            // 
            PasswordButton.BackColor = Color.SteelBlue;
            PasswordButton.Location = new Point(123, 203);
            PasswordButton.Name = "PasswordButton";
            PasswordButton.Size = new Size(111, 30);
            PasswordButton.TabIndex = 8;
            PasswordButton.Text = "Generuj hasło";
            PasswordButton.UseVisualStyleBackColor = false;
            PasswordButton.Click += PasswordButton_Click;
            // 
            // SpecialCharsCh
            // 
            SpecialCharsCh.AutoSize = true;
            SpecialCharsCh.Location = new Point(6, 173);
            SpecialCharsCh.Name = "SpecialCharsCh";
            SpecialCharsCh.Size = new Size(107, 19);
            SpecialCharsCh.TabIndex = 7;
            SpecialCharsCh.Text = "Znaki specialne";
            SpecialCharsCh.UseVisualStyleBackColor = true;
            // 
            // UpperLowerCh
            // 
            UpperLowerCh.AutoSize = true;
            UpperLowerCh.Checked = true;
            UpperLowerCh.CheckState = CheckState.Checked;
            UpperLowerCh.Location = new Point(6, 123);
            UpperLowerCh.Name = "UpperLowerCh";
            UpperLowerCh.Size = new Size(115, 19);
            UpperLowerCh.TabIndex = 6;
            UpperLowerCh.Text = "Małe i duze litery";
            UpperLowerCh.UseVisualStyleBackColor = true;
            // 
            // DigitsCh
            // 
            DigitsCh.AutoSize = true;
            DigitsCh.Location = new Point(5, 148);
            DigitsCh.Name = "DigitsCh";
            DigitsCh.Size = new Size(54, 19);
            DigitsCh.TabIndex = 5;
            DigitsCh.Text = "Cyfry";
            DigitsCh.UseVisualStyleBackColor = true;
            // 
            // labelPassCount
            // 
            labelPassCount.AutoSize = true;
            labelPassCount.Location = new Point(0, 47);
            labelPassCount.Name = "labelPassCount";
            labelPassCount.Size = new Size(67, 15);
            labelPassCount.TabIndex = 4;
            labelPassCount.Text = "Ile znaków?";
            // 
            // charsCounterTb
            // 
            charsCounterTb.Location = new Point(85, 39);
            charsCounterTb.Name = "charsCounterTb";
            charsCounterTb.Size = new Size(174, 23);
            charsCounterTb.TabIndex = 3;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.SteelBlue;
            ConfirmButton.Location = new Point(264, 330);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(277, 34);
            ConfirmButton.TabIndex = 9;
            ConfirmButton.Text = "Zatwierdź";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(ConfirmButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Dodaj pracownika 0000000000";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox InputName;
        private GroupBox groupBox2;
        private Label labelName;
        private Label labelLastName;
        private TextBox InputLastName;
        private Label labelPassCount;
        private TextBox charsCounterTb;
        private ComboBox positionBox;
        private Label Position;
        private CheckBox SpecialCharsCh;
        private CheckBox UpperLowerCh;
        private CheckBox DigitsCh;
        private Button PasswordButton;
        private Button ConfirmButton;
    }
}

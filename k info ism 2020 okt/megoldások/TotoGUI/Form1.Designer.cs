namespace TotoGUI
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
            label1 = new Label();
            resultTextBox = new TextBox();
            lengthCheckBox = new CheckBox();
            incorrectCheckBox = new CheckBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 0;
            label1.Text = "Kérem a forduló eredményeit [1, 2, X]:";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(22, 58);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(286, 23);
            resultTextBox.TabIndex = 1;
            resultTextBox.Text = "12X12X12X12X12";
            resultTextBox.TextChanged += resultTextBox_TextChanged;
            // 
            // lengthCheckBox
            // 
            lengthCheckBox.AutoSize = true;
            lengthCheckBox.Enabled = false;
            lengthCheckBox.Location = new Point(24, 121);
            lengthCheckBox.Name = "lengthCheckBox";
            lengthCheckBox.Size = new Size(230, 19);
            lengthCheckBox.TabIndex = 2;
            lengthCheckBox.Text = "Nem megfelelo a karakterek száma(14)";
            lengthCheckBox.UseVisualStyleBackColor = true;
            // 
            // incorrectCheckBox
            // 
            incorrectCheckBox.AutoSize = true;
            incorrectCheckBox.Enabled = false;
            incorrectCheckBox.Location = new Point(25, 162);
            incorrectCheckBox.Name = "incorrectCheckBox";
            incorrectCheckBox.Size = new Size(240, 19);
            incorrectCheckBox.TabIndex = 3;
            incorrectCheckBox.Text = "Helytelen karakter az eredményekben (0)";
            incorrectCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(24, 221);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(181, 43);
            saveButton.TabIndex = 4;
            saveButton.Text = "Eredmények mentése";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 311);
            Controls.Add(saveButton);
            Controls.Add(incorrectCheckBox);
            Controls.Add(lengthCheckBox);
            Controls.Add(resultTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Totó eredmény ellenőrző";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox resultTextBox;
        private CheckBox lengthCheckBox;
        private CheckBox incorrectCheckBox;
        private Button saveButton;
    }
}

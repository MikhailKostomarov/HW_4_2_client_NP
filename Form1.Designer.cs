namespace HW_4_2_client_NP
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
            listBoxUserList = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            listBoxMessages = new ListBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // listBoxUserList
            // 
            listBoxUserList.FormattingEnabled = true;
            listBoxUserList.ItemHeight = 15;
            listBoxUserList.Location = new Point(12, 12);
            listBoxUserList.Name = "listBoxUserList";
            listBoxUserList.Size = new Size(164, 304);
            listBoxUserList.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 372);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 53);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(602, 372);
            button1.Name = "button1";
            button1.Size = new Size(75, 53);
            button1.TabIndex = 2;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxMessages
            // 
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.ItemHeight = 15;
            listBoxMessages.Location = new Point(182, 12);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(495, 334);
            listBoxMessages.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 372);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 450);
            Controls.Add(comboBox1);
            Controls.Add(listBoxMessages);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBoxUserList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxUserList;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBoxMessages;
        private ComboBox comboBox1;
    }
}

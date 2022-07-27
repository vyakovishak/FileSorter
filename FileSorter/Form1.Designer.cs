namespace FileSorter
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserProfileList = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.fromPath = new System.Windows.Forms.Label();
            this.toPath = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserProfileList
            // 
            this.UserProfileList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserProfileList.FormattingEnabled = true;
            this.UserProfileList.Location = new System.Drawing.Point(100, 34);
            this.UserProfileList.Name = "UserProfileList";
            this.UserProfileList.Size = new System.Drawing.Size(121, 23);
            this.UserProfileList.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "PDF ",
            "Word Document ",
            "PowerPoint ",
            "Execl",
            "Images",
            "Video",
            "Icons",
            "Code"});
            this.checkedListBox1.Location = new System.Drawing.Point(498, 34);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(249, 148);
            this.checkedListBox1.TabIndex = 2;
            // 
            // fromPath
            // 
            this.fromPath.AutoSize = true;
            this.fromPath.Location = new System.Drawing.Point(53, 85);
            this.fromPath.Name = "fromPath";
            this.fromPath.Size = new System.Drawing.Size(38, 15);
            this.fromPath.TabIndex = 3;
            this.fromPath.Text = "From:";
            // 
            // toPath
            // 
            this.toPath.AutoSize = true;
            this.toPath.Location = new System.Drawing.Point(69, 114);
            this.toPath.Name = "toPath";
            this.toPath.Size = new System.Drawing.Size(22, 15);
            this.toPath.TabIndex = 4;
            this.toPath.Text = "To:";
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.Location = new System.Drawing.Point(19, 143);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(72, 15);
            this.update.TabIndex = 5;
            this.update.Text = "Update Path";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.toPath);
            this.Controls.Add(this.fromPath);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.UserProfileList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox UserProfileList;
        private CheckedListBox checkedListBox1;
        private Label fromPath;
        private Label toPath;
        private Label update;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}
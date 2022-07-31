namespace FileSorter
{
    partial class ProfileSettings
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
            this.lableProfile = new System.Windows.Forms.Label();
            this.comboBoxProfile = new System.Windows.Forms.ComboBox();
            this.labelPathTo = new System.Windows.Forms.Label();
            this.textBoxPathTo = new System.Windows.Forms.TextBox();
            this.labelPathFrom = new System.Windows.Forms.Label();
            this.textBoxPathFrom = new System.Windows.Forms.TextBox();
            this.dialogFolderPath = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonPathFrom = new System.Windows.Forms.Button();
            this.buttonPathTo = new System.Windows.Forms.Button();
            this.buttonTestGetUserData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lableProfile
            // 
            this.lableProfile.AutoSize = true;
            this.lableProfile.Location = new System.Drawing.Point(43, 78);
            this.lableProfile.Name = "lableProfile";
            this.lableProfile.Size = new System.Drawing.Size(44, 15);
            this.lableProfile.TabIndex = 0;
            this.lableProfile.Text = "Profile:";
            // 
            // comboBoxProfile
            // 
            this.comboBoxProfile.FormattingEnabled = true;
            this.comboBoxProfile.Location = new System.Drawing.Point(93, 70);
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.comboBoxProfile.Size = new System.Drawing.Size(128, 23);
            this.comboBoxProfile.TabIndex = 2;
            // 
            // labelPathTo
            // 
            this.labelPathTo.AutoSize = true;
            this.labelPathTo.Location = new System.Drawing.Point(38, 173);
            this.labelPathTo.Name = "labelPathTo";
            this.labelPathTo.Size = new System.Drawing.Size(49, 15);
            this.labelPathTo.TabIndex = 3;
            this.labelPathTo.Text = "Path To:";
            // 
            // textBoxPathTo
            // 
            this.textBoxPathTo.Location = new System.Drawing.Point(93, 165);
            this.textBoxPathTo.Name = "textBoxPathTo";
            this.textBoxPathTo.ReadOnly = true;
            this.textBoxPathTo.Size = new System.Drawing.Size(128, 23);
            this.textBoxPathTo.TabIndex = 4;
            this.textBoxPathTo.WordWrap = false;
            // 
            // labelPathFrom
            // 
            this.labelPathFrom.AutoSize = true;
            this.labelPathFrom.Location = new System.Drawing.Point(22, 122);
            this.labelPathFrom.Name = "labelPathFrom";
            this.labelPathFrom.Size = new System.Drawing.Size(65, 15);
            this.labelPathFrom.TabIndex = 5;
            this.labelPathFrom.Text = "Path From:";
            // 
            // textBoxPathFrom
            // 
            this.textBoxPathFrom.Location = new System.Drawing.Point(93, 116);
            this.textBoxPathFrom.Name = "textBoxPathFrom";
            this.textBoxPathFrom.ReadOnly = true;
            this.textBoxPathFrom.Size = new System.Drawing.Size(128, 23);
            this.textBoxPathFrom.TabIndex = 6;
            this.textBoxPathFrom.WordWrap = false;
            // 
            // buttonPathFrom
            // 
            this.buttonPathFrom.Location = new System.Drawing.Point(227, 116);
            this.buttonPathFrom.Name = "buttonPathFrom";
            this.buttonPathFrom.Size = new System.Drawing.Size(27, 23);
            this.buttonPathFrom.TabIndex = 7;
            this.buttonPathFrom.Text = "...";
            this.buttonPathFrom.UseVisualStyleBackColor = true;
            this.buttonPathFrom.Click += new System.EventHandler(this.buttonPathFrom_Click);
            // 
            // buttonPathTo
            // 
            this.buttonPathTo.Location = new System.Drawing.Point(227, 165);
            this.buttonPathTo.Name = "buttonPathTo";
            this.buttonPathTo.Size = new System.Drawing.Size(27, 23);
            this.buttonPathTo.TabIndex = 8;
            this.buttonPathTo.Text = "...";
            this.buttonPathTo.UseVisualStyleBackColor = true;
            this.buttonPathTo.Click += new System.EventHandler(this.buttonPathTo_Click);
            // 
            // buttonTestGetUserData
            // 
            this.buttonTestGetUserData.Location = new System.Drawing.Point(64, 229);
            this.buttonTestGetUserData.Name = "buttonTestGetUserData";
            this.buttonTestGetUserData.Size = new System.Drawing.Size(75, 23);
            this.buttonTestGetUserData.TabIndex = 9;
            this.buttonTestGetUserData.Text = "button1";
            this.buttonTestGetUserData.UseVisualStyleBackColor = true;
            this.buttonTestGetUserData.Click += new System.EventHandler(this.buttonTestGetUserData_Click);
            // 
            // ProfileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTestGetUserData);
            this.Controls.Add(this.buttonPathTo);
            this.Controls.Add(this.buttonPathFrom);
            this.Controls.Add(this.textBoxPathFrom);
            this.Controls.Add(this.labelPathFrom);
            this.Controls.Add(this.textBoxPathTo);
            this.Controls.Add(this.labelPathTo);
            this.Controls.Add(this.comboBoxProfile);
            this.Controls.Add(this.lableProfile);
            this.Name = "ProfileSettings";
            this.Text = "ProfileSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lableProfile;
        private ComboBox comboBoxProfile;
        private Label labelPathTo;
        private TextBox textBoxPathTo;
        private Label labelPathFrom;
        private TextBox textBoxPathFrom;
        private FolderBrowserDialog dialogFolderPath;
        private Button buttonPathFrom;
        private Button buttonPathTo;
        private Button buttonTestGetUserData;
    }
}
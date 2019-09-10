namespace RSPS_Manager
{
    partial class Form1
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
            this.serverListBox = new System.Windows.Forms.ListBox();
            this.installedListBox = new System.Windows.Forms.ListBox();
            this.installButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverListBox
            // 
            this.serverListBox.FormattingEnabled = true;
            this.serverListBox.ItemHeight = 25;
            this.serverListBox.Location = new System.Drawing.Point(1210, 12);
            this.serverListBox.Name = "serverListBox";
            this.serverListBox.Size = new System.Drawing.Size(458, 904);
            this.serverListBox.TabIndex = 1;
            // 
            // installedListBox
            // 
            this.installedListBox.FormattingEnabled = true;
            this.installedListBox.ItemHeight = 25;
            this.installedListBox.Location = new System.Drawing.Point(22, 12);
            this.installedListBox.Name = "installedListBox";
            this.installedListBox.Size = new System.Drawing.Size(458, 904);
            this.installedListBox.TabIndex = 2;
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(733, 12);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(209, 67);
            this.installButton.TabIndex = 3;
            this.installButton.Text = "<-";
            this.installButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(733, 105);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(209, 67);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(733, 835);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(209, 67);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh List";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 940);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.installedListBox);
            this.Controls.Add(this.serverListBox);
            this.Name = "Form1";
            this.Text = "RSPS Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox serverListBox;
        private System.Windows.Forms.ListBox installedListBox;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button refreshButton;
    }
}


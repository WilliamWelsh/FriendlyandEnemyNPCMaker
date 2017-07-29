namespace FriendlyandEnemyNPCMaker
{
    partial class FriendlyandEnemyNPCMaker
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
            this.OpenQCDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenQCButton = new System.Windows.Forms.Button();
            this.QCTextbox = new System.Windows.Forms.TextBox();
            this.SaveQCDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveQCButton = new System.Windows.Forms.Button();
            this.NPCLuaSampleButton = new System.Windows.Forms.Button();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // OpenQCDialog
            // 
            this.OpenQCDialog.FileName = "OpenQCDialog";
            this.OpenQCDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // OpenQCButton
            // 
            this.OpenQCButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenQCButton.BackColor = System.Drawing.Color.Black;
            this.OpenQCButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.OpenQCButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.OpenQCButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.OpenQCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenQCButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.OpenQCButton.Location = new System.Drawing.Point(12, 258);
            this.OpenQCButton.Name = "OpenQCButton";
            this.OpenQCButton.Size = new System.Drawing.Size(194, 23);
            this.OpenQCButton.TabIndex = 1;
            this.OpenQCButton.Text = "Open QC";
            this.OpenQCButton.UseVisualStyleBackColor = false;
            this.OpenQCButton.Click += new System.EventHandler(this.OpenQCButton_Click);
            // 
            // QCTextbox
            // 
            this.QCTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QCTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.QCTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.QCTextbox.Location = new System.Drawing.Point(12, 12);
            this.QCTextbox.Multiline = true;
            this.QCTextbox.Name = "QCTextbox";
            this.QCTextbox.ReadOnly = true;
            this.QCTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QCTextbox.Size = new System.Drawing.Size(402, 237);
            this.QCTextbox.TabIndex = 3;
            // 
            // SaveQCDialog
            // 
            this.SaveQCDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveQCDialog_FileOk);
            // 
            // SaveQCButton
            // 
            this.SaveQCButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveQCButton.BackColor = System.Drawing.Color.Black;
            this.SaveQCButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.SaveQCButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.SaveQCButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.SaveQCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveQCButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SaveQCButton.Location = new System.Drawing.Point(220, 258);
            this.SaveQCButton.Name = "SaveQCButton";
            this.SaveQCButton.Size = new System.Drawing.Size(194, 23);
            this.SaveQCButton.TabIndex = 4;
            this.SaveQCButton.Text = "Save QC";
            this.SaveQCButton.UseVisualStyleBackColor = false;
            this.SaveQCButton.Click += new System.EventHandler(this.SaveQCButton_Click);
            // 
            // NPCLuaSampleButton
            // 
            this.NPCLuaSampleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NPCLuaSampleButton.BackColor = System.Drawing.Color.Black;
            this.NPCLuaSampleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.NPCLuaSampleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.NPCLuaSampleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.NPCLuaSampleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NPCLuaSampleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.NPCLuaSampleButton.Location = new System.Drawing.Point(305, 289);
            this.NPCLuaSampleButton.Name = "NPCLuaSampleButton";
            this.NPCLuaSampleButton.Size = new System.Drawing.Size(109, 23);
            this.NPCLuaSampleButton.TabIndex = 5;
            this.NPCLuaSampleButton.Text = "NPC Lua Sample";
            this.NPCLuaSampleButton.UseVisualStyleBackColor = false;
            this.NPCLuaSampleButton.Click += new System.EventHandler(this.NPCLuaSampleButton_Click);
            // 
            // GitHubLink
            // 
            this.GitHubLink.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.LinkVisited = true;
            this.GitHubLink.Location = new System.Drawing.Point(12, 294);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(40, 13);
            this.GitHubLink.TabIndex = 6;
            this.GitHubLink.TabStop = true;
            this.GitHubLink.Text = "GitHub";
            this.GitHubLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.GitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLink_LinkClicked);
            // 
            // FriendlyandEnemyNPCMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(426, 324);
            this.Controls.Add(this.GitHubLink);
            this.Controls.Add(this.NPCLuaSampleButton);
            this.Controls.Add(this.SaveQCButton);
            this.Controls.Add(this.QCTextbox);
            this.Controls.Add(this.OpenQCButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 363);
            this.MinimumSize = new System.Drawing.Size(442, 363);
            this.Name = "FriendlyandEnemyNPCMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friendly and Enemy NPC Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenQCDialog;
        private System.Windows.Forms.Button OpenQCButton;
        private System.Windows.Forms.TextBox QCTextbox;
        private System.Windows.Forms.SaveFileDialog SaveQCDialog;
        private System.Windows.Forms.Button SaveQCButton;
        private System.Windows.Forms.Button NPCLuaSampleButton;
        private System.Windows.Forms.LinkLabel GitHubLink;
    }
}


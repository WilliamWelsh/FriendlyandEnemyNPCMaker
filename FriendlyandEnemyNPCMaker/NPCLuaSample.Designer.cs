namespace FriendlyandEnemyNPCMaker
{
    partial class NPCLuaSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPCLuaSample));
            this.NPCLuaSampleTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NPCLuaSampleTextbox
            // 
            this.NPCLuaSampleTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.NPCLuaSampleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NPCLuaSampleTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.NPCLuaSampleTextbox.Location = new System.Drawing.Point(12, 12);
            this.NPCLuaSampleTextbox.Multiline = true;
            this.NPCLuaSampleTextbox.Name = "NPCLuaSampleTextbox";
            this.NPCLuaSampleTextbox.Size = new System.Drawing.Size(260, 243);
            this.NPCLuaSampleTextbox.TabIndex = 0;
            this.NPCLuaSampleTextbox.Text = resources.GetString("NPCLuaSampleTextbox.Text");
            // 
            // NPCLuaSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(275, 259);
            this.Controls.Add(this.NPCLuaSampleTextbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(291, 298);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(291, 298);
            this.Name = "NPCLuaSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPC Lua Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NPCLuaSampleTextbox;
    }
}
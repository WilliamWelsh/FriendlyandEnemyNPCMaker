using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FriendlyandEnemyNPCMaker
{
    public partial class FriendlyandEnemyNPCMaker : Form
    {
        public FriendlyandEnemyNPCMaker()
        {
            InitializeComponent();
            SaveQCDialog.Filter = "Source Engine QC Files|*.qc";
            SaveQCDialog.DefaultExt = "qc";
            OpenQCDialog.Filter = "Source Engine QC Files|*.qc";
            OpenQCDialog.FilterIndex = 1;
        }

        string filePath = null;

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {}

        private void OpenQCButton_Click(object sender, EventArgs e)
        {
            if (OpenQCDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = OpenQCDialog.FileName;
                QCTextbox.Text = File.ReadAllText(filePath);
            }
        }

        private void SaveQCButton_Click(object sender, EventArgs e)
        {
            if (QCTextbox.Text.Length > 0)
            {
                // Creating a Friendly NPC
                string goodPath = filePath.Replace(".qc", "_npc_friendly.qc");
                QCTextbox.Text = QCTextbox.Text.Replace(".mdl", "_npc_friendly.mdl");
                QCTextbox.Text = QCTextbox.Text.Replace("$IncludeModel", "// $IncludeModel");
                QCTextbox.AppendText("\r\n$IncludeModel \"humans/male_shared.mdl\"");
                QCTextbox.AppendText("\r\n$IncludeModel \"humans/male_ss.mdl\"");
                QCTextbox.AppendText("\r\n$IncludeModel \"humans/male_gestures.mdl\"");
                QCTextbox.AppendText("\r\n$IncludeModel \"humans/male_postures.mdl\"");
                File.WriteAllText(goodPath, QCTextbox.Text);

                // Creating an Enemy NPC
                QCTextbox.Text = File.ReadAllText(filePath);
                string evilPath = filePath.Replace(".qc", "_npc_enemy.qc");
                QCTextbox.Text = QCTextbox.Text.Replace(".mdl", "_npc_enemy.mdl");
                QCTextbox.Text = QCTextbox.Text.Replace("$IncludeModel", "// $IncludeModel");
                QCTextbox.AppendText("\r\n$IncludeModel \"Police_animations.mdl\"");
                QCTextbox.AppendText("\r\n$IncludeModel \"Police_ss.mdl\"");
                QCTextbox.AppendText("\r\n$IncludeModel \"humans/male_shared.mdl\"");
                File.WriteAllText(evilPath, QCTextbox.Text);

                MessageBox.Show("Two new QCs have successfully been exported and are in the same directory as your QC: " + filePath, "Success");

                QCTextbox.Text = "";

            } else
            {
                MessageBox.Show("You must select a QC file.", "Error");
            }
        }

        private void SaveQCDialog_FileOk(object sender, CancelEventArgs e) {}

        private void NPCLuaSampleButton_Click(object sender, EventArgs e)
        {
            NPCLuaSample luaSample = new NPCLuaSample();
            luaSample.Show();
        }

        private void GitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/WilliamWelsh/FriendlyandEnemyNPCMaker");
        }
    }
}

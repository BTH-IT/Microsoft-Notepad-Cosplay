using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsoft_Notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void Notepad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
                {
                    zoomInToolStripMenuItem_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
                {
                    zoomOutToolStripMenuItem_Click(sender, e);
                }
                else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                {
                    restoreDefaultZoomToolStripMenuItem_Click(sender, e);
                }
            }
        }
        private void richTextBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                {
                    if (int.Parse(label3.Text.Replace("%", "")) >= 500) return;
                    int currentPercentage = int.Parse(label3.Text.Replace("%", ""));
                    int newPercentage = currentPercentage + 10;
                    label3.Text = $"{newPercentage}%";
                }
                else if (e.Delta < 0)
                {
                    if (int.Parse(label3.Text.Replace("%", "")) <= 10) return;
                    int currentPercentage = int.Parse(label3.Text.Replace("%", ""));
                    int newPercentage = currentPercentage - 10;
                    label3.Text = $"{newPercentage}%";
                }
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(label3.Text.Replace("%", "")) >= 500) return;
            richTextBox1.ZoomFactor += 0.1F;

            int currentPercentage = int.Parse(label3.Text.Replace("%", ""));
            int newPercentage = currentPercentage + 10;
            label3.Text = $"{newPercentage}%";
            
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(label3.Text.Replace("%", "")) <= 10) return;
            richTextBox1.ZoomFactor -= 0.1F;
            
            int currentPercentage = int.Parse(label3.Text.Replace("%", ""));
            int newPercentage = currentPercentage - 10;
            label3.Text = $"{newPercentage}%";
        }

        private void restoreDefaultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.0F;
            label3.Text = "100%";
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gunaLinePanel2.Visible == true)
            {
                statusBarToolStripMenuItem.Checked = false;
                gunaLinePanel2.Hide();
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                gunaLinePanel2.Show();
            }
        }
    }
}

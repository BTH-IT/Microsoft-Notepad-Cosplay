using Microsoft.VisualBasic;
using Microsoft_Notepad.EditFeature;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsoft_Notepad
{
    public partial class Notepad : Form
    {
		private static Notepad instance;
		public static Notepad Instance
		{
			get
			{
				if(instance == null)
				{
					instance = new Notepad();
				}
				return instance;
			}
			set
			{
				instance = value;
			}
		}
		private UndoOperations undoOperations;
		private Timer timer;
		private FindForm findForm;
		private ReplaceForm replaceForm;
		public Notepad()
        {
            InitializeComponent();
			instance =this;
			undoOperations = new UndoOperations();	
			timer = new Timer();
			timer.Tick += timer_Tick;	
			timer.Interval = 500;
			richTextBox1.HideSelection = false;
        }
		private void timer_Tick(object sender,EventArgs args)
		{
			timer.Stop();
			undoOperations.Add_Undo(richTextBox1.Text);
		}
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			if(undoOperations.TxtAreaTextChangeRequired)
			{
				timer.Start();
			}
			else
			{
				undoOperations.TxtAreaTextChangeRequired = false;
			}	
		}

		private void Notepad_Load(object sender, EventArgs e)
		{
           
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//
			searchWithBingToolStripMenuItem.Enabled = richTextBox1.SelectedText.Length > 0;
			cutToolStripMenuItem.Enabled = richTextBox1.SelectedText.Length > 0 ? true : false;
			copyToolStripMenuItem.Enabled = richTextBox1.SelectedText.Length > 0 ? true : false;
			pasteToolStripMenuItem.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text);
			deleteToolStripMenuItem.Enabled = richTextBox1.SelectedText.Length > 0 ? true : false;
			undoToolStripMenuItem.Enabled = undoOperations.CanUndo() ? true  : false;
			
			//
			this.findToolStripMenuItem.Enabled = richTextBox1.Text.Length > 0 ? true : false;
			this.findNextToolStripMenuItem.Enabled = richTextBox1.Text.Length > 0 ? true : false;
			this.findPreviousToolStripMenuItem.Enabled = richTextBox1.Text.Length > 0 ? true : false;

			//
			goToToolStripMenuItem.Enabled = wordWrapToolStripMenuItem.CheckState == CheckState.Unchecked;
		}

		private void editToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			editToolStripMenuItem_Click(sender,e);
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
			pasteToolStripMenuItem.Enabled = true;
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
			copyToolStripMenuItem.Enabled = true;
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
			{
				richTextBox1.Paste();
			}

		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();	
		}

		private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, DateTime.Now.ToString());
		}

		private void goToToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (GoToForm form = new GoToForm())
			{
				form.ShowDialog();
			}	
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart,richTextBox1.SelectionLength);
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = undoOperations.UndoClicked();
		}

		private void findToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(findForm == null)
			{
				findForm = new FindForm();	
			}

			if(!Microsoft_Notepad.FindForm.IsShowed)
			{
				findForm.Show();
			}
		}

		private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (findForm == null)
			{
				findForm = new FindForm();
			}
			if (!Microsoft_Notepad.FindForm.IsShowed && findForm.qry.SearchString.Length==0)
			{
				findForm.Show();
			}
			else
			{
				findForm.handleFindEvent(mode:"DOWN");

			}


		}

		private void findPreviousToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (findForm == null)
			{
				findForm = new FindForm();
			}
			if (!Microsoft_Notepad.FindForm.IsShowed && findForm.qry.SearchString.Length == 0)
			{
				findForm.Show();
			}
			else
			{
				findForm.handleFindEvent(mode: "UP");
			}
		}

		private void searchWithBingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "https://www.bing.com/search?q=" + Uri.EscapeDataString(this.richTextBox1.SelectedText);
				System.Diagnostics.Process.Start(query);
			}
			catch
			{

			}
		}

		private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (replaceForm == null)
			{
				replaceForm = new ReplaceForm();
			}

			if (!Microsoft_Notepad.ReplaceForm.IsShowed)
			{
				replaceForm.Show();
			}
		}
	}
}

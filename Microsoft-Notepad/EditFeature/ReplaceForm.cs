using Microsoft_Notepad.EditFeature;
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
	public partial class ReplaceForm : Form ,IDisposable
	{
		public static bool IsShowed = false;
		FindNextSearch qry= new FindNextSearch();
		public ReplaceForm()
		{
			InitializeComponent();
		}
		public void UpdateSearchQuery()
		{
			qry.SearchString = findTxt.Text;
			qry.Direction =  "UP";
			qry.MatchCase = matchCaseCb.Checked;
			qry.Content = Notepad.Instance.richTextBox1.Text;
			qry.Position = Notepad.Instance.richTextBox1.SelectionStart;
			qry.WrapAround = wrapAroundCbx.Checked;
		}
		private void ReplaceForm_Load(object sender, EventArgs e)
		{
			DisableButtons();
			IsShowed = true;	
		}
		public FindNextResult FindNext(FindNextSearch search, string mode = "")
		{
			FindNextResult result = new FindNextResult();
			int position = -1;
			StringComparison s = search.MatchCase ? StringComparison.CurrentCulture :
				StringComparison.CurrentCultureIgnoreCase;
			if (mode.Trim().Length != 0)
			{
				qry.Direction = mode;
			}
			if (search.Direction == "UP")
			{
				position = search.Content.Substring(0, search.Position)
					.LastIndexOf(search.SearchString, s);
				if (position < 0 && search.WrapAround)
				{
					search.Position = search.Content.Length;
					position = search.Content.Substring(0, search.Position)
					.LastIndexOf(search.SearchString, s);
				}
				search.Success = position >= 0 ? true : false;
				result.SearchStatus = search.Success;
			}
			else
			{
				int start = search.Success ? search.Position + search.SearchString.Length :
					search.Position;
				try
				{
					position = start + search.Content
						.Substring(start, search.Content.Length - start)
						.IndexOf(search.SearchString, s);
					if (position - start < 0 && search.WrapAround)
					{
						start = 0;
						position = start + search.Content
						.Substring(start, search.Content.Length - start)
						.IndexOf(search.SearchString, s);

					}
				}
				catch
				{

				}
			
				search.Success = position - start >= 0 ? true : false;
				result.SearchStatus = search.Success;
			}
			result.SelectionStart = result.SearchStatus ? position : -1;
			return result;
		}
		private void DisableButtons()
		{
			this.btnFind.Enabled = false;
			this.btnReplace.Enabled = false;
			this.btnReplaceAll.Enabled = false;	
		}
		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			IsShowed = false;
			this.Hide();
			e.Cancel = true;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (findTxt.Text.Length == 0)
			{
				DisableButtons();
			}
			else
			{
				EnableButtons();
			}
		}

		private void EnableButtons()
		{
			this.btnFind.Enabled = true;
			this.btnReplace.Enabled = true;
			this.btnReplaceAll.Enabled = true;
		}

		public void handleFindEvent(string mode = "DOWN")
		{
			UpdateSearchQuery();
			FindNextResult result = FindNext(qry, mode);
			if (result.SearchStatus)
			{
				Notepad.Instance.richTextBox1.Select(result.SelectionStart,findTxt.Text.Length);
			}
			else
			{
				MessageBox.Show($"Cannot find \"{qry.SearchString}\" ", "NotePad", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void btnFind_Click(object sender, EventArgs e)
		{
			handleFindEvent();	
		
		}

		private void btnReplace_Click(object sender, EventArgs e)
		{
			
			if(Notepad.Instance.richTextBox1.SelectionLength == 0)
			{
				handleFindEvent();
			}
			else
			{
				Notepad.Instance.richTextBox1.SelectedText = replaceTxt.Text;
				UpdateSearchQuery();
			}

		}

		private void btnReplaceAll_Click(object sender, EventArgs e)
		{
			if(this.matchCaseCb.Checked)
			{
				Notepad.Instance.richTextBox1.Text = Notepad.Instance.richTextBox1.Text.Replace(findTxt.Text, replaceTxt.Text);
			}
			else
			{
				Notepad.Instance.richTextBox1.Text = Notepad.Instance.richTextBox1.Text.Replace(findTxt.Text, replaceTxt.Text);
			}
		}

		private void matchCaseCb_CheckedChanged(object sender, EventArgs e)
		{
			UpdateSearchQuery();
		}

		private void wrapAroundCbx_CheckedChanged(object sender, EventArgs e)
		{
			UpdateSearchQuery();
		}
	}
}

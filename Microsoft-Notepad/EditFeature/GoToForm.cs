using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsoft_Notepad.EditFeature
{
	public partial class GoToForm : Form
	{
		public GoToForm()
		{
			InitializeComponent();
		}

		private void GoToForm_Load(object sender, EventArgs e)
		{
			this.inputTxt.Text = Notepad.Instance.richTextBox1.Lines.Length.ToString(); 
		}

		private void inputTxt_Validating(object sender, CancelEventArgs e)
		{
		}

		private void inputTxt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
			{
				MessageBox.Show("Vui lòng nhập số");
				this.inputTxt.Text = Notepad.Instance.richTextBox1.Lines.Length.ToString();
				e.Handled = true;	

			}	
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
		
			this.Close();
		}

		private void gotoBtn_Click(object sender, EventArgs e)
		{
			try
			{
				int line = Convert.ToInt32(inputTxt.Text);
				if (line > Notepad.Instance.richTextBox1.Lines.Length)
				{
					MessageBox.Show("The line number is beyond the total number of lines", "NotePad - Go to line");
				}
				else
				{
					string[] lines = Notepad.Instance.richTextBox1.Lines;
					int len = 0;
					for (int i = 0; i < line - 1; i++)
					{
						len = len + lines[i].Length + 1;
					}
					Notepad.Instance.richTextBox1.Focus();
					Notepad.Instance.richTextBox1.Select(len, 0);
					this.Close();
				}
			}
			catch
			{
				MessageBox.Show("The line number is beyond the total number of lines", "NotePad - Go to line");
			}

		}
	}
}

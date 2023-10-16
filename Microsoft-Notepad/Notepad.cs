using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Microsoft_Notepad
{
	public partial class Notepad : Form
	{
		private string openedFilePath = null;
		private string filename = "Untitled.txt";
		private bool isFileSaved = true;

		public Notepad()
		{
			InitializeComponent();
			this.Text = filename + " - " + this.Text;
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
		

	//
	// HELP
	//
	private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string helpUrl = "https://support.microsoft.com/vi-vn/windows/tr%C6%A1%CC%A3-giu%CC%81p-trong-notepad-4d68c388-2ff2-0e7f-b706-35fb2ab88a8c";

		try
		{
		// Use the default web browser to open the help page
		System.Diagnostics.Process.Start(helpUrl);
		}
		catch (Exception ex)
		{
		// Handle any exceptions, e.g., if the user doesn't have a default browser set.
		MessageBox.Show("Error opening help: " + ex.Message);
		}
	}

	private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string feedbackHubUri = "feedback-hub:";
		try
		{
		System.Diagnostics.Process.Start(feedbackHubUri);
		}
		catch (Exception ex)
		{
		// Handle any exceptions, e.g., if the user doesn't have a default browser set.
		MessageBox.Show("Error opening help: " + ex.Message);
		}
	}

	private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
		// Create an instance of the aboutForm
		using (aboutForm aboutDialog = new aboutForm())
		{
			// Show the aboutForm as a dialog
			aboutDialog.ShowDialog();
		}
		}
		catch (Exception ex)
		{
		// Handle any exceptions, e.g., if the user doesn't have a default browser set.
		MessageBox.Show("Error opening help: " + ex.Message);
		}
	}

	//
	// FILE
	//
	private void openFile()
	{
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			// Set properties for the OpenFileDialog
			openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
			openFileDialog.Title = "Open File";

			// Show the OpenFileDialog and get the result
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Get the selected file name
				openedFilePath = openFileDialog.FileName;
				string selectedFileName = openFileDialog.SafeFileName;
				Text = $@"{selectedFileName} - Notepad";
				try
				{
					string fileContent = File.ReadAllText(openedFilePath);

					// Assuming textBox1 is the name of your TextBox control
					richTextBox1.Text = fileContent;
					saveToolStripMenuItem.Enabled = false;
					saveAsToolStripMenuItem.Enabled = false;
				}
				catch (IOException ex)
				{
				MessageBox.Show("Error reading the file: " + ex.Message);
				}
			}
		}
	}

	private void openToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (saveToolStripMenuItem.Enabled || saveAsToolStripMenuItem.Enabled)
			{
				using (saveConfirm dialog = new saveConfirm())
				{
					dialog.fileName = openedFilePath;
					dialog.ShowDialog();

					if (dialog.save)
					{
						saveToolStripMenuItem_Click(sender, e);
						openFile();
					}
					else if (dialog.notSave)
					{
						openFile();
					}
				}
			}
			else
			{
				openFile();
			}
		}
		catch (Exception ex)
		{
			// Handle any exceptions, e.g., if the user doesn't have a default browser set.
			MessageBox.Show("Error opening help: " + ex.Message);
		}
	}

	private void saveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (!string.IsNullOrEmpty(openedFilePath))
			{
				try
				{
					string textToSave = richTextBox1.Text;
					File.WriteAllText(openedFilePath, textToSave);
					saveToolStripMenuItem.Enabled = false;
					saveAsToolStripMenuItem.Enabled = false;
				}
				catch (IOException ex)
				{
					MessageBox.Show("Error saving the file: " + ex.Message);
				}
			}
			else
			{
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					// Set properties for the SaveFileDialog
					saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
					saveFileDialog.Title = "Save File";

					// Show the SaveFileDialog and get the result
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
					// Get the selected file name
						string selectedFileName = saveFileDialog.FileName;

						try
						{
							// Assuming textBox1 is the name of your TextBox control
							string textToSave = richTextBox1.Text;

							// Save the text to the selected file
							File.WriteAllText(selectedFileName, textToSave);

							Text = $@"{Path.GetFileName(selectedFileName)} - Notepad";
							this.filename = Path.GetFileName(selectedFileName);
						}
						catch (IOException ex)
						{
							MessageBox.Show("Error saving the file: " + ex.Message);
						}

						saveToolStripMenuItem.Enabled = false;
						saveAsToolStripMenuItem.Enabled = false;
					} 
					else
					{
						saveToolStripMenuItem.Enabled = true;
						saveAsToolStripMenuItem.Enabled = true;
					}
				} 
			}
		}
		catch (Exception ex)
		{
		// Handle any exceptions, e.g., if the user doesn't have a default browser set.
		MessageBox.Show("Error opening help: " + ex.Message);
		}
	}

	private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				// Set properties for the SaveFileDialog
				saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
				saveFileDialog.Title = "Save File";

				// Show the SaveFileDialog and get the result
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					// Get the selected file name
					string selectedFileName = saveFileDialog.FileName;

					try
					{
						// Assuming textBox1 is the name of your TextBox control
						string textToSave = richTextBox1.Text;

						// Save the text to the selected file
						File.WriteAllText(selectedFileName, textToSave);

						if (openedFilePath == null)
						{
							Text = $@"{Path.GetFileName(selectedFileName)} - Notepad";
						}
					}
					catch (IOException ex)
					{
						MessageBox.Show("Error saving the file: " + ex.Message);
					}
					saveToolStripMenuItem.Enabled = false;
					saveAsToolStripMenuItem.Enabled = false;
				}
				else
				{
					saveToolStripMenuItem.Enabled = true;
					saveAsToolStripMenuItem.Enabled = true;
				}
			}
		}
		catch (Exception ex)
		{
			// Handle any exceptions, e.g., if the user doesn't have a default browser set.
			MessageBox.Show("Error opening help: " + ex.Message);
		}
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (saveToolStripMenuItem.Enabled || saveAsToolStripMenuItem.Enabled)
		{
			using (saveConfirm dialog = new saveConfirm())
			{
				dialog.fileName = openedFilePath;
				dialog.ShowDialog();

				if (dialog.save)
				{
					saveToolStripMenuItem_Click(sender, e);
				}
				else if (dialog.notSave)
				{
					Close();
				}
			}
		}
	}

	private void richTextBox1_TextChanged(object sender, EventArgs e)
	{
		saveToolStripMenuItem.Enabled = true;
		saveAsToolStripMenuItem.Enabled = true;
	}

	private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (saveToolStripMenuItem.Enabled || saveAsToolStripMenuItem.Enabled)
		{
		using (saveConfirm dialog = new saveConfirm())
		{
			dialog.fileName = openedFilePath;
			dialog.ShowDialog();
			if (dialog.save)
			{
			saveToolStripMenuItem_Click(sender, e);
			}
			else if (dialog.cancel)
			{
			e.Cancel = true;
			}
		}
		}
	}

		private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pageSetupDialog1.ShowDialog();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 12, 20);
		}

		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			printDialog1.ShowDialog();
		}

		private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Notepad notepad = new Notepad();

			notepad.Show();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Text(*.txt)|*.txt";
			openFile.InitialDirectory = "D:";
			openFile.Title = "Open File";
			string content;
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				this.richTextBox1.TextChanged -= richTextBox1_TextChanged_1;
				Stream stream = File.Open(openFile.FileName, FileMode.Open, FileAccess.ReadWrite);
				using (StreamReader streamReader = new StreamReader(stream))
				{
					content = streamReader.ReadToEnd();
				}
				UpdateFileStatus();
				this.richTextBox1.TextChanged += richTextBox1_TextChanged_1;
				UpdateView();
			}

			this.filename = openFile.FileName;

			Stream stream2 = File.Open(openFile.FileName, FileMode.Open, FileAccess.ReadWrite);
			using (StreamReader streamReader = new StreamReader(stream2))
			{
				content = streamReader.ReadToEnd();
			}
			UpdateFileStatus();
		}

		private void UpdateFileStatus()
		{
			string filename = this.filename.Substring(this.filename.LastIndexOf("\\") + 1);
			this.filename = filename;
			this.isFileSaved = true;
			saveToolStripMenuItem.Enabled = false;
			saveAsToolStripMenuItem.Enabled = false;
		}

		private void UpdateView()
		{
			this.Text = !isFileSaved ? "*" + filename + " - Notepad" : filename + " - Notepad";
		}

		private void richTextBox1_TextChanged_1(object sender, EventArgs e)
		{
			isFileSaved = false;
			UpdateView();
			saveToolStripMenuItem.Enabled = true;
			saveAsToolStripMenuItem.Enabled = true;
		}
	}
}

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
	public partial class saveConfirm : Form
	{
		public bool save { get; private set; }
		public bool notSave { get; private set; }
		public bool cancel { get; private set; }
		public string fileName { get; set; }
		public saveConfirm()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			save = true;
			Close();
		}

		private void notSaveButton_Click(object sender, EventArgs e)
		{
			notSave = true;
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			cancel = true;
			Close();
		}

		private void saveConfirm_Load(object sender, EventArgs e)
		{
			if (fileName == null) 
			{
				filePath.Text = "Untitled.txt?";
			}
            else
            {
				filePath.Text = $@"{fileName}?";
            }
		}
	}
}

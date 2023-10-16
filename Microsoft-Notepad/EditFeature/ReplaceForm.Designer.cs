namespace Microsoft_Notepad
{
	partial class ReplaceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceForm));
			this.label1 = new System.Windows.Forms.Label();
			this.findTxt = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.matchCaseCb = new System.Windows.Forms.CheckBox();
			this.wrapAroundCbx = new System.Windows.Forms.CheckBox();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.replaceTxt = new System.Windows.Forms.TextBox();
			this.btnReplace = new System.Windows.Forms.Button();
			this.btnReplaceAll = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Find what:";
			// 
			// findTxt
			// 
			this.findTxt.Location = new System.Drawing.Point(116, 16);
			this.findTxt.Name = "findTxt";
			this.findTxt.Size = new System.Drawing.Size(217, 22);
			this.findTxt.TabIndex = 9;
			this.findTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(349, 9);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(92, 29);
			this.btnFind.TabIndex = 10;
			this.btnFind.Text = "Find Next";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// matchCaseCb
			// 
			this.matchCaseCb.AutoSize = true;
			this.matchCaseCb.Checked = true;
			this.matchCaseCb.CheckState = System.Windows.Forms.CheckState.Checked;
			this.matchCaseCb.Location = new System.Drawing.Point(15, 136);
			this.matchCaseCb.Name = "matchCaseCb";
			this.matchCaseCb.Size = new System.Drawing.Size(100, 20);
			this.matchCaseCb.TabIndex = 11;
			this.matchCaseCb.Text = "Match Case";
			this.matchCaseCb.UseVisualStyleBackColor = true;
			this.matchCaseCb.CheckedChanged += new System.EventHandler(this.matchCaseCb_CheckedChanged);
			// 
			// wrapAroundCbx
			// 
			this.wrapAroundCbx.AutoSize = true;
			this.wrapAroundCbx.Checked = true;
			this.wrapAroundCbx.CheckState = System.Windows.Forms.CheckState.Checked;
			this.wrapAroundCbx.Location = new System.Drawing.Point(15, 162);
			this.wrapAroundCbx.Name = "wrapAroundCbx";
			this.wrapAroundCbx.Size = new System.Drawing.Size(107, 20);
			this.wrapAroundCbx.TabIndex = 12;
			this.wrapAroundCbx.Text = "Wrap around";
			this.wrapAroundCbx.UseVisualStyleBackColor = true;
			this.wrapAroundCbx.CheckedChanged += new System.EventHandler(this.wrapAroundCbx_CheckedChanged);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(349, 114);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(92, 29);
			this.cancelBtn.TabIndex = 14;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "Replace with:";
			// 
			// replaceTxt
			// 
			this.replaceTxt.Location = new System.Drawing.Point(116, 54);
			this.replaceTxt.Name = "replaceTxt";
			this.replaceTxt.Size = new System.Drawing.Size(217, 22);
			this.replaceTxt.TabIndex = 16;
			// 
			// btnReplace
			// 
			this.btnReplace.Location = new System.Drawing.Point(349, 44);
			this.btnReplace.Name = "btnReplace";
			this.btnReplace.Size = new System.Drawing.Size(92, 29);
			this.btnReplace.TabIndex = 17;
			this.btnReplace.Text = "Replace";
			this.btnReplace.UseVisualStyleBackColor = true;
			this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
			// 
			// btnReplaceAll
			// 
			this.btnReplaceAll.Location = new System.Drawing.Point(348, 79);
			this.btnReplaceAll.Name = "btnReplaceAll";
			this.btnReplaceAll.Size = new System.Drawing.Size(92, 29);
			this.btnReplaceAll.TabIndex = 18;
			this.btnReplaceAll.Text = "Replace All";
			this.btnReplaceAll.UseVisualStyleBackColor = true;
			this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
			// 
			// ReplaceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 194);
			this.Controls.Add(this.btnReplaceAll);
			this.Controls.Add(this.btnReplace);
			this.Controls.Add(this.replaceTxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.wrapAroundCbx);
			this.Controls.Add(this.matchCaseCb);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.findTxt);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ReplaceForm";
			this.Text = "ReplaceForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
			this.Load += new System.EventHandler(this.ReplaceForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox findTxt;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.CheckBox matchCaseCb;
		private System.Windows.Forms.CheckBox wrapAroundCbx;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox replaceTxt;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.Button btnReplaceAll;
	}
}
namespace Microsoft_Notepad
{
	partial class FindForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.matchCaseCb = new System.Windows.Forms.CheckBox();
			this.wrapAroundCbx = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.downDirectionRdoBtn = new System.Windows.Forms.RadioButton();
			this.upDirectionRdoBtn = new System.Windows.Forms.RadioButton();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Find what:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(83, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(249, 22);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(348, 6);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(92, 29);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "Find Next";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// matchCaseCb
			// 
			this.matchCaseCb.AutoSize = true;
			this.matchCaseCb.Checked = true;
			this.matchCaseCb.CheckState = System.Windows.Forms.CheckState.Checked;
			this.matchCaseCb.Location = new System.Drawing.Point(14, 95);
			this.matchCaseCb.Name = "matchCaseCb";
			this.matchCaseCb.Size = new System.Drawing.Size(100, 20);
			this.matchCaseCb.TabIndex = 4;
			this.matchCaseCb.Text = "Match Case";
			this.matchCaseCb.UseVisualStyleBackColor = true;
			this.matchCaseCb.CheckedChanged += new System.EventHandler(this.matchCaseCb_CheckedChanged);
			// 
			// wrapAroundCbx
			// 
			this.wrapAroundCbx.AutoSize = true;
			this.wrapAroundCbx.Checked = true;
			this.wrapAroundCbx.CheckState = System.Windows.Forms.CheckState.Checked;
			this.wrapAroundCbx.Location = new System.Drawing.Point(14, 121);
			this.wrapAroundCbx.Name = "wrapAroundCbx";
			this.wrapAroundCbx.Size = new System.Drawing.Size(107, 20);
			this.wrapAroundCbx.TabIndex = 5;
			this.wrapAroundCbx.Text = "Wrap around";
			this.wrapAroundCbx.UseVisualStyleBackColor = true;
			this.wrapAroundCbx.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.downDirectionRdoBtn);
			this.groupBox1.Controls.Add(this.upDirectionRdoBtn);
			this.groupBox1.Location = new System.Drawing.Point(181, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(151, 57);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Direction";
			// 
			// downDirectionRdoBtn
			// 
			this.downDirectionRdoBtn.AutoSize = true;
			this.downDirectionRdoBtn.Checked = true;
			this.downDirectionRdoBtn.Location = new System.Drawing.Point(72, 22);
			this.downDirectionRdoBtn.Name = "downDirectionRdoBtn";
			this.downDirectionRdoBtn.Size = new System.Drawing.Size(62, 20);
			this.downDirectionRdoBtn.TabIndex = 1;
			this.downDirectionRdoBtn.TabStop = true;
			this.downDirectionRdoBtn.Text = "Down";
			this.downDirectionRdoBtn.UseVisualStyleBackColor = true;
			this.downDirectionRdoBtn.CheckedChanged += new System.EventHandler(this.downDirectionRdoBtn_CheckedChanged);
			// 
			// upDirectionRdoBtn
			// 
			this.upDirectionRdoBtn.AutoSize = true;
			this.upDirectionRdoBtn.Location = new System.Drawing.Point(7, 22);
			this.upDirectionRdoBtn.Name = "upDirectionRdoBtn";
			this.upDirectionRdoBtn.Size = new System.Drawing.Size(46, 20);
			this.upDirectionRdoBtn.TabIndex = 0;
			this.upDirectionRdoBtn.Text = "Up";
			this.upDirectionRdoBtn.UseVisualStyleBackColor = true;
			this.upDirectionRdoBtn.CheckedChanged += new System.EventHandler(this.upDirectionRdoBtn_CheckedChanged);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(348, 41);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(92, 29);
			this.cancelBtn.TabIndex = 7;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// FindForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 153);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.wrapAroundCbx);
			this.Controls.Add(this.matchCaseCb);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FindForm";
			this.Text = "Find";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindForm_FormClosed);
			this.Load += new System.EventHandler(this.FindForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.CheckBox matchCaseCb;
		private System.Windows.Forms.CheckBox wrapAroundCbx;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton upDirectionRdoBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.RadioButton downDirectionRdoBtn;
	}
}
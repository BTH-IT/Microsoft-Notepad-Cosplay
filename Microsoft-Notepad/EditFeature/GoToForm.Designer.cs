namespace Microsoft_Notepad.EditFeature
{
	partial class GoToForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.inputTxt = new System.Windows.Forms.TextBox();
			this.gotoBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Line number:";
			// 
			// inputTxt
			// 
			this.inputTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.inputTxt.Location = new System.Drawing.Point(4, 32);
			this.inputTxt.Name = "inputTxt";
			this.inputTxt.Size = new System.Drawing.Size(303, 22);
			this.inputTxt.TabIndex = 1;
			this.inputTxt.Text = "1";
			this.inputTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTxt_KeyPress);
			this.inputTxt.Validating += new System.ComponentModel.CancelEventHandler(this.inputTxt_Validating);
			// 
			// gotoBtn
			// 
			this.gotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.gotoBtn.Location = new System.Drawing.Point(122, 81);
			this.gotoBtn.Name = "gotoBtn";
			this.gotoBtn.Size = new System.Drawing.Size(92, 31);
			this.gotoBtn.TabIndex = 2;
			this.gotoBtn.Text = "Go to";
			this.gotoBtn.UseVisualStyleBackColor = true;
			this.gotoBtn.Click += new System.EventHandler(this.gotoBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.cancelBtn.Location = new System.Drawing.Point(220, 81);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(87, 31);
			this.cancelBtn.TabIndex = 3;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// GoToForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 124);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.gotoBtn);
			this.Controls.Add(this.inputTxt);
			this.Controls.Add(this.label1);
			this.Name = "GoToForm";
			this.ShowIcon = false;
			this.Text = "Go to line";
			this.Load += new System.EventHandler(this.GoToForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputTxt;
		private System.Windows.Forms.Button gotoBtn;
		private System.Windows.Forms.Button cancelBtn;
	}
}
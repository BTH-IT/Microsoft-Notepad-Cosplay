namespace Microsoft_Notepad
{
	partial class saveConfirm
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
			this.label2 = new System.Windows.Forms.Label();
			this.filePath = new System.Windows.Forms.Label();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
			this.notSaveButton = new Guna.UI2.WinForms.Guna2Button();
			this.saveButton = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Notepad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.label2.Location = new System.Drawing.Point(15, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(198, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Do you want to save changes to:";
			// 
			// filePath
			// 
			this.filePath.AutoEllipsis = true;
			this.filePath.Font = new System.Drawing.Font("Segoe UI", 9.5F);
			this.filePath.Location = new System.Drawing.Point(15, 79);
			this.filePath.Name = "filePath";
			this.filePath.Size = new System.Drawing.Size(345, 17);
			this.filePath.TabIndex = 2;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
			this.guna2Panel1.Controls.Add(this.cancelButton);
			this.guna2Panel1.Controls.Add(this.notSaveButton);
			this.guna2Panel1.Controls.Add(this.saveButton);
			this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.guna2Panel1.Location = new System.Drawing.Point(1, 108);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(374, 76);
			this.guna2Panel1.TabIndex = 3;
			// 
			// cancelButton
			// 
			this.cancelButton.BorderColor = System.Drawing.Color.Silver;
			this.cancelButton.BorderRadius = 4;
			this.cancelButton.BorderThickness = 1;
			this.cancelButton.CheckedState.Parent = this.cancelButton;
			this.cancelButton.CustomImages.Parent = this.cancelButton;
			this.cancelButton.FillColor = System.Drawing.Color.White;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cancelButton.ForeColor = System.Drawing.Color.Black;
			this.cancelButton.HoverState.FillColor = System.Drawing.Color.Blue;
			this.cancelButton.HoverState.ForeColor = System.Drawing.Color.White;
			this.cancelButton.HoverState.Parent = this.cancelButton;
			this.cancelButton.Location = new System.Drawing.Point(248, 23);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
			this.cancelButton.Size = new System.Drawing.Size(110, 31);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// notSaveButton
			// 
			this.notSaveButton.BorderColor = System.Drawing.Color.Silver;
			this.notSaveButton.BorderRadius = 4;
			this.notSaveButton.BorderThickness = 1;
			this.notSaveButton.CheckedState.Parent = this.notSaveButton;
			this.notSaveButton.CustomImages.Parent = this.notSaveButton;
			this.notSaveButton.FillColor = System.Drawing.Color.White;
			this.notSaveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.notSaveButton.ForeColor = System.Drawing.Color.Black;
			this.notSaveButton.HoverState.FillColor = System.Drawing.Color.Blue;
			this.notSaveButton.HoverState.ForeColor = System.Drawing.Color.White;
			this.notSaveButton.HoverState.Parent = this.notSaveButton;
			this.notSaveButton.Location = new System.Drawing.Point(132, 23);
			this.notSaveButton.Name = "notSaveButton";
			this.notSaveButton.ShadowDecoration.Parent = this.notSaveButton;
			this.notSaveButton.Size = new System.Drawing.Size(110, 31);
			this.notSaveButton.TabIndex = 1;
			this.notSaveButton.Text = "Don\'t save";
			this.notSaveButton.Click += new System.EventHandler(this.notSaveButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.BorderColor = System.Drawing.Color.Silver;
			this.saveButton.BorderRadius = 4;
			this.saveButton.BorderThickness = 1;
			this.saveButton.CheckedState.Parent = this.saveButton;
			this.saveButton.CustomImages.Parent = this.saveButton;
			this.saveButton.FillColor = System.Drawing.Color.White;
			this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.saveButton.ForeColor = System.Drawing.Color.Black;
			this.saveButton.HoverState.FillColor = System.Drawing.Color.Blue;
			this.saveButton.HoverState.ForeColor = System.Drawing.Color.White;
			this.saveButton.HoverState.Parent = this.saveButton;
			this.saveButton.Location = new System.Drawing.Point(16, 23);
			this.saveButton.Name = "saveButton";
			this.saveButton.ShadowDecoration.Parent = this.saveButton;
			this.saveButton.Size = new System.Drawing.Size(110, 31);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "Save";
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.BorderColor = System.Drawing.Color.Blue;
			this.guna2Panel2.BorderThickness = 1;
			this.guna2Panel2.Controls.Add(this.guna2Panel1);
			this.guna2Panel2.Location = new System.Drawing.Point(1, 1);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			this.guna2Panel2.Size = new System.Drawing.Size(376, 186);
			this.guna2Panel2.TabIndex = 4;
			// 
			// saveConfirm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(378, 188);
			this.Controls.Add(this.filePath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2Panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "saveConfirm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "saveConfirm";
			this.Load += new System.EventHandler(this.saveConfirm_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label filePath;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Button saveButton;
		private Guna.UI2.WinForms.Guna2Button cancelButton;
		private Guna.UI2.WinForms.Guna2Button notSaveButton;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
	}
}
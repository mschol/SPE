namespace SierraPropertiesEditor
{
	partial class gameSelect
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
			this.SelectGameLabel = new System.Windows.Forms.Label();
			this.pBp = new System.Windows.Forms.PictureBox();
			this.pBc3 = new System.Windows.Forms.PictureBox();
			this.pBz = new System.Windows.Forms.PictureBox();
			this.cancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pBp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBc3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBz)).BeginInit();
			this.SuspendLayout();
			// 
			// SelectGameLabel
			// 
			this.SelectGameLabel.Location = new System.Drawing.Point(43, 13);
			this.SelectGameLabel.Name = "SelectGameLabel";
			this.SelectGameLabel.Size = new System.Drawing.Size(250, 13);
			this.SelectGameLabel.TabIndex = 1;
			this.SelectGameLabel.Text = "Select your game";
			this.SelectGameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pBp
			// 
			this.pBp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBp.Location = new System.Drawing.Point(114, 29);
			this.pBp.Name = "pBp";
			this.pBp.Size = new System.Drawing.Size(100, 75);
			this.pBp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBp.TabIndex = 1;
			this.pBp.Click += new System.EventHandler(this.pBp_Click);
			// 
			// pBc3
			// 
			this.pBc3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBc3.Location = new System.Drawing.Point(221, 29);
			this.pBc3.Name = "pBc3";
			this.pBc3.Size = new System.Drawing.Size(100, 75);
			this.pBc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBc3.TabIndex = 2;
			// 
			// pBz
			// 
			this.pBz.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBz.Location = new System.Drawing.Point(7, 29);
			this.pBz.Name = "pBz";
			this.pBz.Size = new System.Drawing.Size(100, 75);
			this.pBz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBz.TabIndex = 3;
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(131, 116);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// gameSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(329, 146);
			this.ControlBox = false;
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.pBz);
			this.Controls.Add(this.pBc3);
			this.Controls.Add(this.pBp);
			this.Controls.Add(this.SelectGameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "gameSelect";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Select Game";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Click += new System.EventHandler(this.pBz_Click);
			((System.ComponentModel.ISupportInitialize)(this.pBp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBc3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBz)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label SelectGameLabel;
		private System.Windows.Forms.PictureBox pBp;
		private System.Windows.Forms.PictureBox pBc3;
		private System.Windows.Forms.PictureBox pBz;
		private System.Windows.Forms.Button cancelButton;
	}
}
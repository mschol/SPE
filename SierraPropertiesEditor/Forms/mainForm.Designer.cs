namespace SierraPropertiesEditor
{
	partial class mainForm
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
			this.MainMenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectGamepathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GameOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectDifficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.veryEasyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.impossibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.editableItems = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.MainMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// MainMenuStrip1
			// 
			this.MainMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.MainMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.MenuToolStripMenuItem,
			this.GameOptionsToolStripMenuItem,
			this.aboutToolStripMenuItem});
			this.MainMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.MainMenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip1.Name = "MainMenuStrip1";
			this.MainMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.MainMenuStrip1.Size = new System.Drawing.Size(800, 24);
			this.MainMenuStrip1.TabIndex = 27;
			// 
			// MenuToolStripMenuItem
			// 
			this.MenuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.selectGamepathToolStripMenuItem,
			this.recentToolStripMenuItem,
			this.toolStripMenuItem1,
			this.toolStripSeparator1,
			this.exitToolStripMenuItem});
			this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
			this.MenuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.MenuToolStripMenuItem.Text = "menu";
			// 
			// selectGamepathToolStripMenuItem
			// 
			this.selectGamepathToolStripMenuItem.Name = "selectGamepathToolStripMenuItem";
			this.selectGamepathToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.selectGamepathToolStripMenuItem.Click += new System.EventHandler(this.selectGamepathToolStripMenuItem_Click);
			// 
			// recentToolStripMenuItem
			// 
			this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
			this.recentToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(64, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// GameOptionsToolStripMenuItem
			// 
			this.GameOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.selectDifficultyToolStripMenuItem});
			this.GameOptionsToolStripMenuItem.Name = "GameOptionsToolStripMenuItem";
			this.GameOptionsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
			this.GameOptionsToolStripMenuItem.Text = "Game Options";
			// 
			// selectDifficultyToolStripMenuItem
			// 
			this.selectDifficultyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.selectDifficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.veryEasyToolStripMenuItem,
			this.easyToolStripMenuItem,
			this.normalToolStripMenuItem,
			this.hardToolStripMenuItem,
			this.impossibleToolStripMenuItem});
			this.selectDifficultyToolStripMenuItem.Name = "selectDifficultyToolStripMenuItem";
			this.selectDifficultyToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
			this.selectDifficultyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			// 
			// veryEasyToolStripMenuItem
			// 
			this.veryEasyToolStripMenuItem.Name = "veryEasyToolStripMenuItem";
			this.veryEasyToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.veryEasyToolStripMenuItem.Click += new System.EventHandler(this.veryEasyToolStripMenuItem_Click);
			// 
			// easyToolStripMenuItem
			// 
			this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
			this.easyToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
			// 
			// normalToolStripMenuItem
			// 
			this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
			this.normalToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
			// 
			// hardToolStripMenuItem
			// 
			this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
			this.hardToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
			// 
			// impossibleToolStripMenuItem
			// 
			this.impossibleToolStripMenuItem.Name = "impossibleToolStripMenuItem";
			this.impossibleToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.impossibleToolStripMenuItem.Click += new System.EventHandler(this.impossibleToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(123, 365);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 26;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(466, 377);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 25;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(612, 377);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// editableItems
			// 
			this.editableItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.editableItems.FormattingEnabled = true;
			this.editableItems.Location = new System.Drawing.Point(12, 60);
			this.editableItems.Name = "editableItems";
			this.editableItems.Size = new System.Drawing.Size(121, 21);
			this.editableItems.TabIndex = 15;
			this.editableItems.SelectedIndexChanged += new System.EventHandler(this.editableItems_SelectedIndexChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(12, 144);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(272, 377);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 463);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.editableItems);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.MainMenuStrip1);
			this.KeyPreview = true;
			this.Name = "mainForm";
			this.Text = "Sierra Properties Editor";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
			this.MainMenuStrip1.ResumeLayout(false);
			this.MainMenuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem selectGamepathToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GameOptionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.ComboBox editableItems;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		internal System.Windows.Forms.ToolStripMenuItem selectDifficultyToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem veryEasyToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem impossibleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
	}
}


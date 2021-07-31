
namespace TaskBin
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.windowsPapierkorbÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windowsPapierkorbEntleerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon.BalloonTipText = "TaskBin text";
			this.notifyIcon.BalloonTipTitle = "TaskBin Title";
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "TaskBin";
			this.notifyIcon.Visible = true;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsPapierkorbÖffnenToolStripMenuItem,
            this.windowsPapierkorbEntleerenToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItemClose});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(238, 76);
			this.contextMenuStrip.TabStop = true;
			// 
			// windowsPapierkorbÖffnenToolStripMenuItem
			// 
			this.windowsPapierkorbÖffnenToolStripMenuItem.Name = "windowsPapierkorbÖffnenToolStripMenuItem";
			this.windowsPapierkorbÖffnenToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.windowsPapierkorbÖffnenToolStripMenuItem.Text = "Windows-Papierkorb öffnen";
			// 
			// windowsPapierkorbEntleerenToolStripMenuItem
			// 
			this.windowsPapierkorbEntleerenToolStripMenuItem.Name = "windowsPapierkorbEntleerenToolStripMenuItem";
			this.windowsPapierkorbEntleerenToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.windowsPapierkorbEntleerenToolStripMenuItem.Text = "Windows-Papierkorb entleeren";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
			// 
			// toolStripMenuItemClose
			// 
			this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
			this.toolStripMenuItemClose.Size = new System.Drawing.Size(237, 22);
			this.toolStripMenuItemClose.Text = "Programm schließen";
			this.toolStripMenuItemClose.Click += new System.EventHandler(this.CloseApp_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 171);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TaskBin";
			this.Shown += new System.EventHandler(this.HideApp_Click);
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem windowsPapierkorbÖffnenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem windowsPapierkorbEntleerenToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
	}
}


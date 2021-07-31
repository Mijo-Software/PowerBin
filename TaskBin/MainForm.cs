using System;
using System.Windows.Forms;

namespace TaskBin
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void HideApp_Click(object sender, EventArgs e)
		{
			notifyIcon.BalloonTipText = "TaskBin wurde in den Infobereich minimiert.";
			notifyIcon.ShowBalloonTip(100);
			Hide();
		}

		private void CloseApp_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}

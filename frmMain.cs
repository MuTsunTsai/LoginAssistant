using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication1 {
	public partial class frmMain:Form {
		public frmMain() {
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e) {
			 RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main");
			 webBrowser1.Navigate(key.GetValue("Start Page").ToString());
		}

		/////////////////////////////////
		// 視窗功能
		/////////////////////////////////

		private FormWindowState winState;
		private void frmMain_Resize(object sender, EventArgs e) {
			if(FormWindowState.Minimized==WindowState) { Hide(); notifyIcon.Visible=true; } else winState=WindowState;
		}
		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
			Show(); WindowState=winState; notifyIcon.Visible=false;
		}
	}
}

namespace WindowsFormsApplication1 {
	partial class frmMain {
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components=null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing) {
			if(disposing&&(components!=null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
		///
		/// </summary>
		private void InitializeComponent() {
			this.components=new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.webBrowser1=new System.Windows.Forms.WebBrowser();
			this.notifyIcon=new System.Windows.Forms.NotifyIcon(this.components);
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock=System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location=new System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize=new System.Drawing.Size(20, 20);
			this.webBrowser1.Name="webBrowser1";
			this.webBrowser1.Size=new System.Drawing.Size(906, 608);
			this.webBrowser1.TabIndex=1;
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon=((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text="LoginAssistant";
			this.notifyIcon.MouseDoubleClick+=new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize=new System.Drawing.Size(906, 608);
			this.Controls.Add(this.webBrowser1);
			this.Icon=((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name="frmMain";
			this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text="LoginAssistant";
			this.Load+=new System.EventHandler(this.frmMain_Load);
			this.Resize+=new System.EventHandler(this.frmMain_Resize);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.NotifyIcon notifyIcon;
	}
}


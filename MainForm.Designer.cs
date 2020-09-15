/*
 * Created by SharpDevelop.
 * User: gBrss
 * Date: 13-09-2020
 * Time: 21:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WakeOnDead
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.btCheck = new System.Windows.Forms.Button();
			this.timeEngine = new System.Windows.Forms.Timer(this.components);
			this.txConnection = new System.Windows.Forms.Label();
			this.imgSignal = new System.Windows.Forms.PictureBox();
			this.txHost = new System.Windows.Forms.TextBox();
			this.txHostLabel = new System.Windows.Forms.Label();
			this.gpbHostTarget = new System.Windows.Forms.GroupBox();
			this.gpbButtons = new System.Windows.Forms.GroupBox();
			this.btConnRestore = new System.Windows.Forms.Button();
			this.btStart = new System.Windows.Forms.Button();
			this.btStop = new System.Windows.Forms.Button();
			this.startTimer = new System.Windows.Forms.Timer(this.components);
			this.aboutBtImg = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imgSignal)).BeginInit();
			this.gpbHostTarget.SuspendLayout();
			this.gpbButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aboutBtImg)).BeginInit();
			this.SuspendLayout();
			// 
			// trayIcon
			// 
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIconMouseDoubleClick);
			// 
			// btCheck
			// 
			this.btCheck.Location = new System.Drawing.Point(6, 60);
			this.btCheck.Name = "btCheck";
			this.btCheck.Size = new System.Drawing.Size(79, 21);
			this.btCheck.TabIndex = 0;
			this.btCheck.Text = "Test";
			this.btCheck.UseVisualStyleBackColor = true;
			this.btCheck.Click += new System.EventHandler(this.BtCheckClick);
			// 
			// timeEngine
			// 
			this.timeEngine.Interval = 3000;
			this.timeEngine.Tick += new System.EventHandler(this.TimeEngineTick);
			// 
			// txConnection
			// 
			this.txConnection.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txConnection.ForeColor = System.Drawing.Color.Red;
			this.txConnection.Location = new System.Drawing.Point(115, 73);
			this.txConnection.Name = "txConnection";
			this.txConnection.Size = new System.Drawing.Size(171, 23);
			this.txConnection.TabIndex = 3;
			this.txConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imgSignal
			// 
			this.imgSignal.ImageLocation = "";
			this.imgSignal.Location = new System.Drawing.Point(175, 15);
			this.imgSignal.Name = "imgSignal";
			this.imgSignal.Size = new System.Drawing.Size(72, 50);
			this.imgSignal.TabIndex = 5;
			this.imgSignal.TabStop = false;
			// 
			// txHost
			// 
			this.txHost.Location = new System.Drawing.Point(6, 37);
			this.txHost.Name = "txHost";
			this.txHost.Size = new System.Drawing.Size(79, 20);
			this.txHost.TabIndex = 7;
			this.txHost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxHostKeyPress);
			this.txHost.Leave += new System.EventHandler(this.TxHostLeave);
			this.txHost.MouseLeave += new System.EventHandler(this.TxHostMouseLeave);
			// 
			// txHostLabel
			// 
			this.txHostLabel.Location = new System.Drawing.Point(6, 16);
			this.txHostLabel.Name = "txHostLabel";
			this.txHostLabel.Size = new System.Drawing.Size(29, 18);
			this.txHostLabel.TabIndex = 8;
			this.txHostLabel.Text = "Host";
			this.txHostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gpbHostTarget
			// 
			this.gpbHostTarget.Controls.Add(this.txHostLabel);
			this.gpbHostTarget.Controls.Add(this.txHost);
			this.gpbHostTarget.Controls.Add(this.btCheck);
			this.gpbHostTarget.Location = new System.Drawing.Point(15, 10);
			this.gpbHostTarget.Name = "gpbHostTarget";
			this.gpbHostTarget.Size = new System.Drawing.Size(91, 87);
			this.gpbHostTarget.TabIndex = 9;
			this.gpbHostTarget.TabStop = false;
			this.gpbHostTarget.Text = "Ping Target";
			// 
			// gpbButtons
			// 
			this.gpbButtons.Controls.Add(this.btConnRestore);
			this.gpbButtons.Controls.Add(this.btStart);
			this.gpbButtons.Controls.Add(this.btStop);
			this.gpbButtons.Location = new System.Drawing.Point(292, 10);
			this.gpbButtons.Name = "gpbButtons";
			this.gpbButtons.Size = new System.Drawing.Size(74, 87);
			this.gpbButtons.TabIndex = 10;
			this.gpbButtons.TabStop = false;
			// 
			// btConnRestore
			// 
			this.btConnRestore.BackColor = System.Drawing.Color.Gold;
			this.btConnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btConnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btConnRestore.ForeColor = System.Drawing.Color.Green;
			this.btConnRestore.Location = new System.Drawing.Point(9, 63);
			this.btConnRestore.Name = "btConnRestore";
			this.btConnRestore.Size = new System.Drawing.Size(56, 23);
			this.btConnRestore.TabIndex = 9;
			this.btConnRestore.Text = "Reset";
			this.btConnRestore.UseVisualStyleBackColor = false;
			this.btConnRestore.Click += new System.EventHandler(this.BtConnRestoreClick);
			// 
			// btStart
			// 
			this.btStart.BackColor = System.Drawing.Color.LimeGreen;
			this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btStart.ForeColor = System.Drawing.Color.White;
			this.btStart.Location = new System.Drawing.Point(9, 5);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(56, 23);
			this.btStart.TabIndex = 8;
			this.btStart.Text = "Start";
			this.btStart.UseVisualStyleBackColor = false;
			this.btStart.Click += new System.EventHandler(this.BtStartClick);
			this.btStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtStartMouseDown);
			this.btStart.MouseEnter += new System.EventHandler(this.BtStartMouseEnter);
			this.btStart.MouseLeave += new System.EventHandler(this.BtStartMouseLeave);
			this.btStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtStartMouseUp);
			// 
			// btStop
			// 
			this.btStop.BackColor = System.Drawing.Color.Red;
			this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btStop.ForeColor = System.Drawing.Color.White;
			this.btStop.Location = new System.Drawing.Point(9, 34);
			this.btStop.Name = "btStop";
			this.btStop.Size = new System.Drawing.Size(56, 23);
			this.btStop.TabIndex = 7;
			this.btStop.Text = "Stop";
			this.btStop.UseVisualStyleBackColor = false;
			this.btStop.Click += new System.EventHandler(this.BtStopClick);
			// 
			// startTimer
			// 
			this.startTimer.Interval = 1;
			this.startTimer.Tick += new System.EventHandler(this.StartTimerTick);
			// 
			// aboutBtImg
			// 
			this.aboutBtImg.Image = ((System.Drawing.Image)(resources.GetObject("aboutBtImg.Image")));
			this.aboutBtImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("aboutBtImg.InitialImage")));
			this.aboutBtImg.Location = new System.Drawing.Point(115, 12);
			this.aboutBtImg.Name = "aboutBtImg";
			this.aboutBtImg.Size = new System.Drawing.Size(16, 18);
			this.aboutBtImg.TabIndex = 11;
			this.aboutBtImg.TabStop = false;
			this.aboutBtImg.Click += new System.EventHandler(this.AboutBtImgClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 109);
			this.Controls.Add(this.aboutBtImg);
			this.Controls.Add(this.gpbButtons);
			this.Controls.Add(this.gpbHostTarget);
			this.Controls.Add(this.imgSignal);
			this.Controls.Add(this.txConnection);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WakeOnDead";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.imgSignal)).EndInit();
			this.gpbHostTarget.ResumeLayout(false);
			this.gpbHostTarget.PerformLayout();
			this.gpbButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.aboutBtImg)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox aboutBtImg;
		private System.Windows.Forms.Timer startTimer;
		private System.Windows.Forms.GroupBox gpbButtons;
		private System.Windows.Forms.GroupBox gpbHostTarget;
		private System.Windows.Forms.Label txHostLabel;
		private System.Windows.Forms.TextBox txHost;
		private System.Windows.Forms.Button btConnRestore;
		private System.Windows.Forms.PictureBox imgSignal;
		private System.Windows.Forms.Label txConnection;
		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.Button btStop;
		private System.Windows.Forms.Timer timeEngine;
		private System.Windows.Forms.Button btCheck;
		private System.Windows.Forms.NotifyIcon trayIcon;
	}
}

/*
 * Created by SharpDevelop.
 * User: gBrss
 * Date: 13-09-2020
 * Time: 21:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Media;
using System.Threading;
using Microsoft.Win32;

namespace WakeOnDead
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		String host = "goo.gl";
		SoundPlayer alertSound = new SoundPlayer("alarm.wav");
		public MainForm()
		{
			InitializeComponent();
			killMonitor();
			trayIcon.Text = "WakeOnDead";
			btStop.Enabled = false;
			txHost.Text = host;
			startTimer.Enabled = true;
			
		}
		void MainFormSizeChanged(object sender, EventArgs e)
		{
			if(this.WindowState == FormWindowState.Minimized && checkConnection())
			{
				Hide();
				trayIcon.Visible = true;
				trayIcon.BalloonTipText = "WakeOnDead Started\nPing Target to the host: "+host;
				trayIcon.ShowBalloonTip(1000);
				checkConnection();
				timeEngine.Enabled = true;
				//TimeEngineTick(sender, e);
				btStop.Enabled = true;
			}
			else if(this.WindowState == FormWindowState.Minimized)
			{	
				trayIcon.Visible = true;
				trayIcon.BalloonTipText = "WakeOnDead Monitor\nnot connected to the host: "+host;
				trayIcon.ShowBalloonTip(1000);
			}
		}
		void killMonitor()
		{
			imgSignal.Load("img/monitor.png");
			txConnection.Text = "STAND BY";
			txConnection.ForeColor = Color.Gray;
			
		}
		void TrayIconMouseDoubleClick(object sender, MouseEventArgs e)
		{
			checkConnectionGui();
			Show();
			this.WindowState = FormWindowState.Normal;  
    		trayIcon.Visible = false;
		}
		
		void BtCheckClick(object sender, EventArgs e) // Check Button Click
		{
			checkConnectionWithButton();
			if(checkConnection())
			{
				btStop.Enabled = true;
			}
		}
		
		void checkConnectionWithButton(){
			if(checkConnection()){
				checkConnectionGui();
				//MessageBox.Show("CONNECTED to "+host,"Success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
			}else{
				checkConnectionGui();
				//MessageBox.Show("NOT CONNECTED","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void checkConnectionGui()
		{
			if(checkConnection())
			{
			   	txConnection.Text = "CONNECTED";
			   	txConnection.ForeColor = Color.LimeGreen;
			   	imgSignal.Load("img/on.png");
			}
			else
			{
				imgSignal.Load("img/off.png");
				txConnection.Text = "NOT CONNECTED";
			   	txConnection.ForeColor = Color.Red;
			}
		}
		bool checkConnection(){
			try
			{
			    Ping myPing = new Ping();
			    byte[] buffer = new byte[32];
			    int timeout = 1500;
			    PingOptions pingOptions = new PingOptions();
			    PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
			    return (reply.Status == IPStatus.Success);
			}
			catch (Exception) 
			{
				return false;
			}
		}
		
		void TimeEngineTick(object sender, EventArgs e)
		{
			long usedMemory = GC.GetTotalMemory(true); //Memory Usage Limiter
			checkConnection();
			if(!checkConnection()){
				trayIcon.BalloonTipText = "Network Not Connected\nHost: "+host;
				trayIcon.ShowBalloonTip(1000);
				alertSound.Play();
				checkConnectionGui();
			}
			checkConnectionGui();
		}
		
		void BtStopClick(object sender, EventArgs e) // Stop Button Click Event
		{	
			if(btStop.Enabled){
				timeEngine.Stop();
				btStop.Enabled = false;
				btStart.Enabled = true;
				txHost.Enabled = true;
				imgSignal.Load("img/off.png");
				btCheck.Enabled = true;
				killMonitor();
				alertSound.Stop();
			}
		}
		
		void BtStartClick(object sender, EventArgs e) // Start Button Click Event
		{
			checkConnectionGui();
			if(checkConnection())
			{
				btStart.Enabled = false;
				this.WindowState = FormWindowState.Minimized;
				txHost.Enabled = false;
				btCheck.Enabled = false;
			}
			else
			{
				MessageBox.Show("Can't run Alarm service if host is unreachable.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			trayIcon.Visible = false;
		}
		
		void BtConnRestoreClick(object sender, EventArgs e) // Reset Connection Button Event
		{
			Process cmd = new Process();
			cmd.StartInfo.FileName = "cmd.exe";
			cmd.StartInfo.RedirectStandardInput = true;
			cmd.StartInfo.RedirectStandardOutput = true;
			cmd.StartInfo.CreateNoWindow = true;
			cmd.StartInfo.UseShellExecute = false;
			cmd.Start();
			cmd.StandardInput.WriteLine("ipconfig /release");
			cmd.StandardInput.WriteLine("ipconfig /renew");
			cmd.StandardInput.Flush();
			cmd.StandardInput.Close();
			cmd.WaitForExit();
			MessageBox.Show("Network restarted","Network Reset",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
		}
		
		void TxHostKeyPress(object sender, KeyPressEventArgs e)
		{
			host = txHost.Text;
		}
		
		void TxHostLeave(object sender, EventArgs e)
		{
			host = txHost.Text;
			checkConnectionGui();
		}
		
		void TxHostMouseLeave(object sender, EventArgs e)
		{
			host = txHost.Text;
		}
		
		void BtStartMouseDown(object sender, MouseEventArgs e)
		{
			btStart.ForeColor = Color.Blue;
		}
		
		void BtStartMouseUp(object sender, MouseEventArgs e)
		{
			btStart.ForeColor = Color.White;
		}
		
		void BtStartMouseEnter(object sender, EventArgs e)
		{
			btStart.ForeColor = Color.Black;
		}
		
		void BtStartMouseLeave(object sender, EventArgs e)
		{
			btStart.ForeColor = Color.White;
			
		}
		
		void StartTimerTick(object sender, EventArgs e)
		{
			BtStartClick(sender, e);
			startTimer.Stop();
		}
		void AboutBtImgClick(object sender, System.EventArgs e)
		{
			About aboutForm = new About();
			aboutForm.ShowDialog();
		}
		
		//Function that allows create an windows startup registry
		/* */
		/*RegistryKey key=Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
		string keyName=@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
		string valueName="WakeOnDead";
		void OptStartupCheckedChanged(object sender, System.EventArgs e)
		{
			
			if (Registry.GetValue(keyName, valueName, null) == null && optStartup.Checked)
			{
				key.SetValue("WakeOnDead", Application.ExecutablePath);
				optStartup.Checked = true;
			}
			else
			{
					key.DeleteValue("WakeOnDead",false);
					optStartup.Checked = false;
				
			}
		}*/
		

	}
}

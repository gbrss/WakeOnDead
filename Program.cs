/*
 * Created by SharpDevelop.
 * User: gBrss
 * Date: 13-09-2020
 * Time: 21:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
using System.Windows.Forms;

namespace WakeOnDead
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		
		private static void Main(string[] args)
		{
			const string appName = "WakeOnDead";  
            bool createdNew;  
  			Mutex mutex = null;
            mutex = new Mutex(true, appName, out createdNew);  
  
            if (!createdNew)  
            {  
            	MessageBox.Show("Can't run another instance","Already running",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;  
            }else{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());}
		}
		
	}
}

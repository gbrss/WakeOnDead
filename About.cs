/*
 * Created by SharpDevelop.
 * User: gBrss
 * Date: 14-09-2020
 * Time: 22:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WakeOnDead
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About : Form
	{
		public About()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TxaboutClick(object sender, System.EventArgs e)
			{
				System.Diagnostics.Process.Start("http://gbrss.ml");
			}
	}
}

/*
 * Created by SharpDevelop.
 * User: yurem
 * Date: 24/11/2024
 * Time: 03:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetess
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int xd, xd2, xd3, xd4, xd5, xd6, total;
			xd = int.Parse(textBox3.Text);
			xd2 = int.Parse(textBox4.Text);
			xd3 = int.Parse(textBox5.Text);
			xd4 = int.Parse(textBox6.Text);
			xd5 = int.Parse(textBox7.Text);
			xd6 = int.Parse(textBox8.Text);
			xd = xd * 370;
			xd2 = xd2 * 250;
			xd3 = xd3 * 200;
			xd4 = xd4 * 450;
			xd5 = xd5 * 9;
			xd6 = xd6 * 455;
			total = xd + xd2 + xd3 + xd4 + xd5 + xd6;
			label4.Text = total.ToString();
		}
	}
}

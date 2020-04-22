using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Electron_OnlineInstaller
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Log("Form Initialized");
		}

		private void Log(string msg){
			DateTime time = DateTime.Now;
			richTextBox1.Text += $"[{time.Year}.{time.Month}.{time.Day} {time.Hour}:{time.Minute}:{time.Second}.{time.Millisecond}] {msg}\n";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Log("Form Loaded");
		}
	}
}

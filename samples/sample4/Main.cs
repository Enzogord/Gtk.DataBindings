// project created on 12/9/2007 at 6:40 PM
using System;
using Gtk;

namespace sample4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
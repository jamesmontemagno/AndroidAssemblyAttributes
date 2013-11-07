using System;
using Android.App;
using Android.Runtime;

namespace AssemblySettings
{
	[Application(Icon = "@drawable/ic_launcher", Label = "@string/app_name")]
	public class MyApplication : Application
	{
		public static MyApplication App { get; private set; }


		public MyApplication(IntPtr handle, JniHandleOwnership transfer) : base(handle,transfer)
		{
			App = this;
		}
	}
}


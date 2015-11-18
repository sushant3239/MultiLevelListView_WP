using System;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;
using MultiLevelList.Core.ViewModel;

namespace MultiLevelList.Core
{
	public class App : MvxApplication
	{
		public App ()
		{
			Mvx.RegisterSingleton<IMvxAppStart> (new MvxAppStart<MainViewModel> ());
		}
	}
}


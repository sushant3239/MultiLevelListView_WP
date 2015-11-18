
using System;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using MultiLevelList.Core.ViewModel;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace MultiLevelList.iOS
{
	public partial class MainView : MvxViewController
	{
		public MainView () : base ("MainView", null)
		{
		}

		public new MainViewModel ViewModel
		{
			get { return base.ViewModel as MainViewModel; }
			set { base.ViewModel = value; }
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			MyTableView.RegisterNibForCellReuse (UINib.FromName (MyTableViewCell.Key,
				NSBundle.MainBundle),MyTableViewCell.Key);

			var source = new MyTableViewSource (MyTableView);
			var set = this.CreateBindingSet<MainView,MainViewModel> ();
			set.Bind (source).To (vm => vm.Items);
			set.Apply ();

			MyTableView.Source = source;
			MyTableView.ReloadData ();
		}
	}
}


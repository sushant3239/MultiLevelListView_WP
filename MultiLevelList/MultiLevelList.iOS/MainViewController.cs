
using System;

using Foundation;
using UIKit;
using MultiLevelList.Core.ViewModel;

namespace MultiLevelList.iOS
{
	public partial class MainViewController : UIViewController
	{
		public MainViewController () : base ("MainViewController", null)
		{
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
			var vm = new MainViewModel ();
			MyTableView.RegisterNibForCellReuse (UINib.FromName (MyTableViewCell.Key,
				NSBundle.MainBundle),MyTableViewCell.Key);
			
			MyTableView.Source = new MyTableViewSource (MyTableView);
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}


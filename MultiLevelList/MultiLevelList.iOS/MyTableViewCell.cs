
using System;

using Foundation;
using UIKit;
using System.Collections.Generic;
using MultiLevelList.Core.Model;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;


namespace MultiLevelList.iOS
{
	public partial class MyTableViewCell : MvxTableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("MyTableViewCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("MyTableViewCell");

		public MyTableViewCell (IntPtr handle) : base (handle)
		{
		}

		public TreeItem Model {
			get;
			set;
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();
			var set = this.CreateBindingSet<MyTableViewCell,TreeItem> ();
			set.Bind (LabelTitle).To (vm => vm.Title);
			set.Apply ();
		}
	}
}


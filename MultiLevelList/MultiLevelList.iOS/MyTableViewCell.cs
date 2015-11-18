
using System;

using Foundation;
using UIKit;
using System.Collections.Generic;
using MultiLevelList.Core.Model;

namespace MultiLevelList.iOS
{
	public partial class MyTableViewCell : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("MyTableViewCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("MyTableViewCell");

		public MyTableViewCell (IntPtr handle) : base (handle)
		{
		}

		public TreeItem Model 
		{
			get;
			set;
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();
			LabelTitle.Text = Model.Title;
		}
	}
}


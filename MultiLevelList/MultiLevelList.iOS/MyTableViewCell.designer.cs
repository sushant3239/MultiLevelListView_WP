// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MultiLevelList.iOS
{
	[Register ("MyTableViewCell")]
	partial class MyTableViewCell
	{
		[Outlet]
		UIKit.UILabel LabelTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LabelTitle != null) {
				LabelTitle.Dispose ();
				LabelTitle = null;
			}
		}
	}
}

using System;
using UIKit;
using System.Collections.Generic;
using MultiLevelList.Core.Model;
using Foundation;

namespace MultiLevelList.iOS
{
	public abstract class MultiLevelListSourceBase : UITableViewSource
	{
		private List<TreeItem> _items;

		public MultiLevelListSourceBase (List<TreeItem> items)
		{
			_items = items;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (MyTableViewCell.Key, indexPath) as MyTableViewCell;
			var currentItem = _items [indexPath.Row];
			cell.DataContext = currentItem;
			return cell;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return _items.Count;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			var selectedCell = tableView.CellAt (indexPath) as MyTableViewCell;
			var currentTreeItem = selectedCell.Model;
			var selectedItemIndex = _items.IndexOf (currentTreeItem);

			if (currentTreeItem.IsExpanded) {
				DeleteRows (currentTreeItem, tableView, selectedItemIndex);
			} else {
				InsertRows (currentTreeItem, tableView, selectedItemIndex);
			}
		}

		private void InsertRows (TreeItem treeItem, UITableView tableView, int selectedItemIndex)
		{
			if (treeItem.Childrens != null) {
				var itemsToInsert = new List<TreeItem> (treeItem.Childrens);
				var itemsToInsertPath = new List<NSIndexPath> ();

				foreach (var item in itemsToInsert) {
					selectedItemIndex++;
					_items.Insert (selectedItemIndex, item);
					itemsToInsertPath.Add (NSIndexPath.FromRowSection (selectedItemIndex, 0));
				}
				tableView.InsertRows (itemsToInsertPath.ToArray (), UITableViewRowAnimation.Bottom);
				treeItem.IsExpanded = true;
			}
		}

		private void DeleteRows (TreeItem treeItem, UITableView tableView, int selectedItemIndex)
		{
			if (treeItem.Childrens != null) {
				var itemsToRemove = new List<TreeItem> (treeItem.Childrens);
				var itmesToRemovePath = new List<NSIndexPath> ();
				int totalDeleteCount = 0;

				RecursiveDelete (itemsToRemove, itmesToRemovePath, ref totalDeleteCount);
				_items.RemoveRange (selectedItemIndex + 1, totalDeleteCount);
				tableView.DeleteRows (itmesToRemovePath.ToArray (), UITableViewRowAnimation.Fade);
				treeItem.IsExpanded = false;
			}
		}

		private void RecursiveDelete (List<TreeItem> itemsToRemove, 
			List<NSIndexPath> itemsToRemovePath, ref int totalDeleteCount)
		{
			foreach (var item in itemsToRemove) {
				if (item.IsExpanded) {
					RecursiveDelete (item.Childrens, itemsToRemovePath, ref totalDeleteCount);
				}
				var indexOfItemToRemove = _items.IndexOf (item);
				itemsToRemovePath.Add (NSIndexPath.FromRowSection (indexOfItemToRemove, 0));
				item.IsExpanded = false;
				totalDeleteCount++;
			}
		}
	}
}



using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MultiLevelList
{
    public class TreeItem : INotifyPropertyChanged
    {
        private bool _isExpanded = false;

        public string Title { get; set; }
        public List<TreeItem> Childrens { get; set; }
        public bool IsExpanded
        {
            get
            {
                return _isExpanded;
            }
            set
            {
                _isExpanded = value;
                OnPropertyChanged("IsExpanded");
            }
        }
        public int Level { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

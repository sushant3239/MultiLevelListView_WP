
using MultiLevelList.Core.Model;
using System.Collections.Generic;

namespace MultiLevelList.Core.ViewModel
{
    public class MainViewModel
    {
        private List<TreeItem> _items;

        public List<TreeItem> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public MainViewModel()
        {
            Init();
        }

        private void Init()
        {
            Items = new List<TreeItem>
            {
                new TreeItem
                {
                    Title = "item1",
                    Childrens = new List<TreeItem>
                    {
                        new TreeItem
                        {
                            Title = "item1_1",
                            Childrens = new List<TreeItem>
                            {
                                new TreeItem
                                {
                                     Title = "item1_1_1",
                                },
                                new TreeItem
                                {
                                    Title = "item1_1_2",
                                },
                                new TreeItem
                                {
                                    Title = "item1_1_3",
                                },
                                new TreeItem
                                {
                                    Title = "item1_1_4",
                                },
                            }
                        },



                        new TreeItem
                        {
                            Title = "item1_2",
                        },



                        new TreeItem
                        {
                            Title = "item1_3",
                        },






                    },
                },


                new TreeItem
                {
                    Title = "item2",
                    Childrens = new List<TreeItem>
                    {
                        new TreeItem
                        {
                            Title = "item2_1",
                            Childrens = new List<TreeItem>
                            {
                                new TreeItem
                                {
                                     Title = "item2_1_1",
                                },
                                new TreeItem
                                {
                                    Title = "item2_1_2",
                                },
                                new TreeItem
                                {
                                    Title = "item2_1_3",
                                },
                                new TreeItem
                                {
                                    Title = "item2_1_4",
                                },
                            }
                        },



                        new TreeItem
                        {
                            Title = "item2_2",
                        },



                        new TreeItem
                        {
                            Title = "item2_3",
                        },






                    },
                },

            };
        }

    }
}

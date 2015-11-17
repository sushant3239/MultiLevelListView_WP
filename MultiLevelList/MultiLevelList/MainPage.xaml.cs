using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace MultiLevelList
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<TreeItem> Items { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            Init();
            this.DataContext = this;
            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
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

using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SlideOverKit.MoreSample
{
    class TabModel
    {
        public string Title { get; set; }
    }

    public class RightSideDetailPage : MenuContainerPage
    {
        public static RightSideDetailPage Instance;

        public RightSideDetailPage ()
        {
            ItemsSource = new List<TabModel> () { new TabModel () { Title = "boo"},new TabModel () { Title = "coo" } };
            this.ItemTemplate = new DataTemplate (typeof (TabPage));
            this.SlideMenu = new RightSideMasterPage ();
            Instance = this;
        }
    }
}



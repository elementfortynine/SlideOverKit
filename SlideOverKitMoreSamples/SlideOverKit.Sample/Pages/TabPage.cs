using System;
using Xamarin.Forms;

namespace SlideOverKit.MoreSample
{
    public class TabPage : ContentPage
    {
        public TabPage ()
        {
            Content = new StackLayout {
                VerticalOptions = LayoutOptions.Center,
                Spacing = 10,
                Children = {
                    new Button{
                        Text ="Show Menu",
                        Command = new Command(()=>{
                            RightSideDetailPage.Instance.ShowMenu();
                        })
                    },
                    new Button{
                        Text ="Hide Menu",
                        Command = new Command(()=>{
                           RightSideDetailPage.Instance.HideMenu();
                        })
                    },
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BuildStuff.Mobile
{
    public class App
    {
        public static Page GetMainPage()
        {
            var listView = new ListView
            {
                RowHeight = 60
            };
            listView.ItemsSource = new SpeakerList().ToList();
            listView.ItemTemplate = new DataTemplate( typeof (SpeakerViewCell));

            return new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    Children = { listView }
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BuildStuff.Mobile
{
    class SpeakerViewCell : ViewCell
    {
        public SpeakerViewCell()
        {
            var image = new Image
            {
                HorizontalOptions = LayoutOptions.Start
            };
            image.SetBinding(Image.SourceProperty, new Binding("ImageUri"));
            image.WidthRequest = image.HeightRequest = 60;

            var nameLayout = CreateNameLayout();

            var viewLayout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = { image, nameLayout }
            };
            View = viewLayout;
        }

        static StackLayout CreateNameLayout()
        {

            var nameLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium)
                
            };
            nameLabel.SetBinding(Label.TextProperty, "Name");

            var bioLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            bioLabel.SetBinding(Label.TextProperty, "Bio");

            var nameLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { nameLabel, bioLabel }
            };
            return nameLayout;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ViewCellApp
{
  public   class Page:ContentPage
    {
        public Page()
        {
            Label header = new Label
            {
                Text = "Android",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
            //SearchBar sb = new SearchBar
            //{
            //    Placeholder = "Search",
            //   SearchCommand = new Command(() => { }),
            //  HorizontalOptions = LayoutOptions.Start
            //};

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot
                {

                    new TableSection
                    {
                        new ImageCell
                        {
                          ImageSource ="image1.png",
                               Text = "Android Image",
                            Detail = "This is logo",

                        },
                        new ImageCell
                        {
                          ImageSource ="image2.png",
                               Text = "Android main Image",
                            Detail = "This is logo",

                        },
                        new ImageCell
                        {
                          ImageSource ="image3.png",
                               Text = "Android Based Image",
                            Detail = "This is logo",

                        },

                    }
                }
            };

            this.Padding = new Thickness(10,20, 10, 5);
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    tableView
                }
            };
        }


    }
    
}

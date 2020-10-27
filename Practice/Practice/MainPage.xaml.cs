using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Practice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private List<Image> Images;
        private ObservableCollection<Product> Products;

        public MainPage()
        {
            this.InitializeComponent();

            Images = new List<Image>();
            Images.Add(new Image { ImagePath = "Assets/iphone12.jpg" });
            Images.Add(new Image { ImagePath = "Assets/appleWatch.jpg" });

            Products = new ObservableCollection<Product>();
            Products.Add(new Product { ProductName = "Iphone 12", Description = "abcd", Image = "Assets/iphone12.jpg" });
        }

        private void NewProductButton_Click(object sender, RoutedEventArgs e)
        {
            string image = ((Image)ImageComboBox.SelectedValue).ImagePath;
            Products.Add(new Product
            {
                ProductName = ProductTextBox.Text,
                Description = DescriptionTextBox.Text,
                Image = image
            });

            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}

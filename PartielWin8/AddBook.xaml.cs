using B3.LibraryManager;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PartielWin8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddBook : Page
    {
        public AddBook()
        {
            this.InitializeComponent();
        }

        private void Ajout(object sender, RoutedEventArgs e)
        {
            Book b = new Book(int.Parse(Id.Text), Title.Text, Author.Text, Synopsis.Text, Convert.ToDateTime(Date.Text), int.Parse(Stock.Text));   

            PersistentLibraryManager.Instance.AddBook(b);

            Id.Text = "";
            Title.Text = "";
            Author.Text = "";
            Synopsis.Text = "";
            Date.Text = "";
            Stock.Text = "";
        }

        private void GoMainPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}

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
using B3.LibraryManager;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PartielWin8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static LibraryPage _libraryPage;

        private static AddBook _addBook;

        public MainPage()
        {
            this.InitializeComponent();
        }

        // Accéder à la librairie après un click
        private void GoToLibrairie(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LibraryPage), _libraryPage);
        }

        private void addBook(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddBook), _addBook);
        }
    }
}

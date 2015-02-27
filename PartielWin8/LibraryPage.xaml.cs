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
    public sealed partial class LibraryPage : Page
    {
        public LibraryPage()
        {
            this.InitializeComponent();

            List<Book> book = new List<Book>();

            var items = PersistentLibraryManager.Instance.GetAllBooks();

            foreach (var item in items)
            {
                book.Add(new Book(item.Id, item.Title, item.Author, item.Synopsis, item.ParutionDate, item.NbInStock));
            }

            MyListView.ItemsSource = book;
        }

        private void SelectedItem(object sender, SelectionChangedEventArgs e)
        {
            Book b = MyListView.SelectedItem as Book;

            Case1.Text = b.Title;
            Case2.Text = b.Author;
            Case3.Text = b.Synopsis;
            Case4.Text = b.ParutionDate.ToString();
            if(0 == b.NbInStock)
            {
                borrow.IsEnabled = false;
            }
            else { borrow.IsEnabled = true; }
        }

        private void deleting(object sender, RoutedEventArgs e)
        {
            Book b = MyListView.SelectedItem as Book;

            PersistentLibraryManager.Instance.DeleteBook(b);
            Frame.Navigate(typeof(LibraryPage));
        }

        private void borrowing(object sender, RoutedEventArgs e)
        {
            Book b = MyListView.SelectedItem as Book;

            PersistentLibraryManager.Instance.BorrowBook(b);
            Frame.Navigate(typeof(LibraryPage));
        }

        private void BackButton_Clicked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = new List<Book>();//Все книги
        List<Book> booksView = new List<Book>();//Книги на вывод
        List<string> autors = new List<string>() ;//Список авторов 
        public MainWindow()
        {
            InitializeComponent();
            CreateList();
            PZ();
            dataGrid.ItemsSource = booksView;
        }

        public void PZ()
        {
            booksView = books.Where(b => b.Date <= new DateTime(1994,1,1) &&
                                         b.PageCount >= 200).ToList();//Фильтрация

            autors = (from b in books // передаем каждый элемент из books в переменную b
                           select b.Autor).ToList(); // создаём калекцию авторов

            autors = autors.Distinct().ToList();//Удаление дублей

            list.ItemsSource = autors;//Вывод
        }
        public void CreateList()
        {
            books.Add(new Book("Автор 1", 200, new DateTime(1900, 1, 1)));
            books.Add(new Book("Автор 1", 30, new DateTime(1999, 1, 1)));
            books.Add(new Book("Автор 2", 50, new DateTime(2000, 1, 1)));
            books.Add(new Book("Автор 2", 250, new DateTime(2023, 1, 1)));
            books.Add(new Book("Автор 3", 50, new DateTime(1991, 1, 1)));
            books.Add(new Book("Автор 3", 150, new DateTime(1992, 1, 1)));
        }
    }
}

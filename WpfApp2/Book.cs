using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Book
    {
        public Book(string autor, int page, DateTime date)
        {
            this.Autor = autor;
            this.PageCount = page;
            this.Date = date;   
        }
        public string Autor { get; set; }
        public int PageCount { get; set; }
        public DateTime Date { get; set; }
    }
}

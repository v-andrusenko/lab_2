using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_3
{
    public class Book
    {
        Title title = null;
        Author author = null;
        Content content = null;
        void InitializeBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }
        public Book(string title)
        {
            InitializeBook();
            this.title.title = title;
        }
        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public string Content
        {
            set
            {
                this.content.content = value;
            }
        }
        public string Author
        {
            set
            {
                this.author.author = value;
            }
        }
    }
}

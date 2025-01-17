﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int NumberOfPages { get; set; }

        public int Price { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int OriginalLanguageId { get; set; }
        public Language OriginalLanguage { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public IEnumerable<BookCopy> Copies { get; set; }
    }
}

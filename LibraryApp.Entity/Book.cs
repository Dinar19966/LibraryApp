using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Autor { get; set; }   
        public virtual IEnumerable<BookGenre> BookGenres { get; set; }  
        
     
    }
}

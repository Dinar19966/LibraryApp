using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entity
{
    public class IssueLog
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public User User { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime? DateOfReturn { get; set;  }
        
    }
}

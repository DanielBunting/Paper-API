using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper.Models
{
    public class Workbook
    {
        public string Title { get; set; }

        public List<Page> Pages { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_WinForm
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string DisplayName => Name;
        public string DisplayFull => $"{Id} - {Name} - {Author}";
    }
}



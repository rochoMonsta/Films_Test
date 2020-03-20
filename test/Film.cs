using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Film
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public double Mark { get; set; }
        public string Comment { get; set; }
        public Film() { }
        public Film(string Name, string Link, double Mark, string Comment)
        {
            this.Name = Name;
            this.Link = Link;
            this.Mark = Mark;
            this.Comment = Comment;
        }
        public override string ToString()
        {
            return $"{Name} - {Link} - {Mark}";
        }
    }
}

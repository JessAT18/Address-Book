using System;
using System.Collections.Generic;
using System.Text;

namespace appAddress.Models
{
    public enum TypeContact
    {
        telephone,
        email,
        facebook,
        twitter,
        instagram,
        dblink
    }
    public class Book
    {
        public int bookID { get; set; }
        public string name { get; set; }
        public TypeContact type { get; set; }
        public string contact { get; set; }
    }
}
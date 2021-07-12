using AdaptUniversity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptUniversity
{
    public interface IPerson
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniqueID { get; set; }
    }
}

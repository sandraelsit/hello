using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore3Test.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}

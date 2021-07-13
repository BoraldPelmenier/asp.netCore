using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducation.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime Created { get; set; }
    }
}

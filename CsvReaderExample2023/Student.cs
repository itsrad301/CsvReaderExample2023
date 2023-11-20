using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Console
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string FirstName { get; set; }

        public string SecondName { get; set; }
    }
}

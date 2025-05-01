using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, RegularExpression(@"^\d{13}$")]
        public string CNP { get; set; }

        [Required, RegularExpression(@"^\d{4}$")]
        public string MatricolNumber { get; set; }

        [Required]
        public string Sex { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        [Required, StringLength(100)]
        public string Department { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}

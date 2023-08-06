using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace campany.Models
{
    public class Employee
    {

        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public string password { get; set; }
        [ForeignKey("off")]
        [Display(Name="office_name")]
        public int? off_ID { get; set; }

        public office? off { get; set; }
        public List<Emp_projects> proj { get; set; }
    }
}

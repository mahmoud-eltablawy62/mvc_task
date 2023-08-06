using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace campany.Models
{
    [PrimaryKey("Emp_id" , "proj_id")]
    public class Emp_projects
    {
        public int W_hours { get; set; }
        [ForeignKey("employees")]

        public int Emp_id { get; set; }
        [ForeignKey("project")]
        public int proj_id { get; set; }    

        public  Employee employees  { get; set; }
        public project project { get; set; }

    }
}

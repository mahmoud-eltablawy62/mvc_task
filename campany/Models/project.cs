namespace campany.Models
{
    public class project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Emp_projects> emps; 

    }
}

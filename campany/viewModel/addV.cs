using System.ComponentModel.DataAnnotations;

namespace campany.viewModel
{
    public class addV
    {
        public int id { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "name must be between 3 to 25 char ")]
        public string name { get; set; }
        [Range(20, 35, ErrorMessage = "age must be between 20 to 35 ")]
        public int age { get; set; }
        public int salary { get; set; }
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[0 - 9])(?=.*[a - z])(?=.*[A - Z])(?=.*[*.!@$% ^&(){} []:;<>,.?/~_+-=|\\]).{8,32}$", ErrorMessage = "At least one digit " +
            "At least one lowercase character " +
            "At least one uppercase character " +
            "At least one special character " +
            "At least 8 characters in length, but no more than "
            )]
        public string  password { get; set; }
        [DataType(DataType.Password)]
        [Compare("password" , ErrorMessage ="Not Match")]   
        public string confirm_password { get; set; }    
    }
}

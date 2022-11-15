using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMVC.Models.Domain
{
    public class Manager
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public long Salary { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Department { get; set; }

    }
}
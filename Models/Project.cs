using System.ComponentModel.DataAnnotations;

namespace BHPractiseEmlak.Models
{
    public class Project
    {
        [Key]
        public int projectId { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? ImagePath { get; set; }

        public string? Type { get; set; }

    }
}

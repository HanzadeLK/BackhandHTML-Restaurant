using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace BHPractiseEmlak.Models
{
    public class Team
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImagePathTeam{ get; set; }
        public string? JobTitle { get; set; }
        public string? Curriculum { get; set; }
    }
}
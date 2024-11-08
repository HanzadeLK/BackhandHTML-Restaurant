using BHPractiseEmlak.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace BHPractiseEmlak.Data
{
    public class TeamDataAccess
    {
        public static List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>()
        {
            new Team() { Id = 1, Name = "John Doe", JobTitle = "CEO & Founder", ImagePathTeam = "https://www.w3schools.com/w3images/team2.jpg", Curriculum = "Phasellus eget enim eu lectus faucibus vestibulum. Suspendisse sodales pellentesque elementum." },
            new Team() { Id = 2, Name = "Jane Doe", JobTitle = "Architect", ImagePathTeam = "https://www.w3schools.com/w3images/team1.jpg", Curriculum = "Phasellus eget enim eu lectus faucibus vestibulum. Suspendisse sodales pellentesque elementum." },
            new Team() { Id = 3, Name = "Mike Ross", JobTitle = "Architect", ImagePathTeam = "https://www.w3schools.com/w3images/team3.jpg", Curriculum = "Phasellus eget enim eu lectus faucibus vestibulum. Suspendisse sodales pellentesque elementum." },
            new Team() { Id = 4, Name = "Dan Start", JobTitle = "Architect", ImagePathTeam = "https://www.w3schools.com/w3images/team4.jpg", Curriculum = "Phasellus eget enim eu lectus faucibus vestibulum. Suspendisse sodales pellentesque elementum." }
        };

            return teams;
        }
    }

}
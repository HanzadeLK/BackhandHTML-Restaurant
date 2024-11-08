using BHPractiseEmlak.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BHPractiseEmlak.Data
{
    public class DataAccess
    {
        public static List<Models.Project> GetProjects()
        {     

            List<Models.Project> projects = new List<Models.Project>()
            {
            new Models.Project() { projectId = 1, ImagePath= "https://www.w3schools.com/w3images/house3.jpg", Name ="Barn House", Type=" House"},
            new Models.Project() { projectId = 2, ImagePath= "https://www.w3schools.com/w3images/house5.jpg", Name ="Brick House", Type=" House"},
            new Models.Project() { projectId = 3, ImagePath= "https://www.w3schools.com/w3images/house2.jpg", Name ="Summer House", Type=" House"},
            new Models.Project() { projectId = 4, ImagePath= "https://www.w3schools.com/w3images/house4.jpg", Name ="Barn House", Type=" House"},
            new Models.Project() { projectId = 1, ImagePath= "https://www.w3schools.com/w3images/house3.jpg", Name ="Barn House", Type=" House"},
            new Models.Project() { projectId = 2, ImagePath= "https://www.w3schools.com/w3images/house5.jpg", Name ="Brick House", Type=" House"},
            new Models.Project() { projectId = 3, ImagePath= "https://www.w3schools.com/w3images/house2.jpg", Name ="Summer House", Type=" House"},
            new Models.Project() { projectId = 4, ImagePath= "https://www.w3schools.com/w3images/house4.jpg", Name ="Barn House", Type=" House"}
            };
            
        return projects;
        
        }

    }

}

        


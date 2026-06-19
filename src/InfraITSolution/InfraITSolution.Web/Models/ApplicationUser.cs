using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InfraITSolution.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public int DepartmentId { get; set; }
    }
}

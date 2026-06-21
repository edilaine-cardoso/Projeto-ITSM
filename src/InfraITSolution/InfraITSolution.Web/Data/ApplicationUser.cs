using Microsoft.AspNetCore.Identity;

namespace InfraITSolution.Web.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
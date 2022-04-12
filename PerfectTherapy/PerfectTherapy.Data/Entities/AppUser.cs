using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectTherapy.Data.Entities
{
    public class AppUser: IdentityUser
    {
        public AppUser()
        {
            this.Messages = new HashSet<ChatMessage>();
        }
        [PersonalData]
        public string? FullName { get; set; }

        //The ASP.NET Core Identity UI includes a "Download Personal Data" page
        [PersonalData]
        public Address? DeliveryAddress { get; set; }

        public bool IsSubscribed { get; set; }

        public Membership? Membership { get; set; }

        //take it from root folder
        public string? ProfilePictureId { get; set; }

        public string? Resume { get; set; }

        public bool IsActive { get; set; }

        //signalR chat
        public virtual ICollection<ChatMessage>? Messages { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }

    }
}

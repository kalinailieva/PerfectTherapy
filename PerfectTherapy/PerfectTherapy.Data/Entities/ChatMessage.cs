using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectTherapy.Data.Entities
{
    public class ChatMessage
    {
        [Key]
        public string Id = Guid.NewGuid().ToString();

        [Required]
        public string Username { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public virtual AppUser Sender { get; set; }
    }
}

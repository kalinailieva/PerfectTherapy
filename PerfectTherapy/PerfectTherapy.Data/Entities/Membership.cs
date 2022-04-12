
namespace PerfectTherapy.Data.Entities
{
    public class Membership
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Discount{ get; set; }

        public bool IsActive { get; set; }

    }
}

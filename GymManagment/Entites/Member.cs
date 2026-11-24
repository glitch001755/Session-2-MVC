namespace GymManagment.Entites
{
    public class Member : GymUser
    {
        public string? Photo { get; set; }

        //Relationship
        public ICollection<Membership> MemberSubscriptions { get; set; } = default!;
    }
}

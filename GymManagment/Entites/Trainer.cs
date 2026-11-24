using GymManagment.Entites.Enums;

namespace GymManagment.Entites
{
    public class Trainer : GymUser
    {
        public DateTime HireDate { get; set; }
        public Specialties Specialties { get; set; }

        //Relationship
        public ICollection<Session> Sessions { get; set; } = default!;
    }
}

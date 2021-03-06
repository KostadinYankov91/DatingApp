using API.Extensions;

namespace API.Entites
{
	public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Parse(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
        
        public DateTime LastAcvite { get; set; } = DateTime.Parse(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }
        // public int GetAge()
        // {
        //     return DateOfBirth.CalculateAge();
        // }
	}
}
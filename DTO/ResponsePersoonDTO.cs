namespace Opdracht2_Adam.Controllers
{
    public partial class PetController
    {
        public class ResponsePersoonDTO
        {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string Geboortedatum { get; set; }
            public int PetId { get; set; } // 0 geen - 1 huisdier - 2 huisdier - ...
            public int HasHouse { get; set; } // 0 nee - 1 Ja
        }
    }
}

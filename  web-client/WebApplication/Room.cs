namespace Infrastructure.Entities
{
    public class Room : IEntities
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public byte[] Photo { get; set; }
        public string RoomNumber { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBeds { get; set; }
        public int Roominess { get; set; }


        public int ID
        {
            get;
            set;
        }

    }
}

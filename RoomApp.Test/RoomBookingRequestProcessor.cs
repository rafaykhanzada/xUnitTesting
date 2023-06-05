namespace RoomApp
{
    internal class RoomBookingRequestProcessor
    {
        public RoomBookingRequestProcessor()
        {
        }

        internal RoomBookingResult BookRoom(RoomBookingRequest request)
        {
            return new RoomBookingResult()
            {
                Name = "Rafay Khan",
                Email = "rafay@finosys.com",
                Date =new DateTime(2022,02,02)
            };
        }
    }
}
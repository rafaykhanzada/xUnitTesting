using RoomApp;

namespace RoomBooking.Processor
{
    public class RoomBookingRequestProcessor
    {
        public RoomBookingRequestProcessor()
        {
        }

        public RoomBookingResult BookRoom(RoomBookingRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            return new RoomBookingResult()
            {
                Name = "Rafay Khan",
                Email = "rafay@finosys.com",
                Date = new DateTime(2022, 02, 02)
            };
        }
    }
}
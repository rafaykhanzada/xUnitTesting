using RoomBooking.Processor;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RoomApp
{
    public class RoomBookingRequestTest
    {
        private readonly RoomBookingRequestProcessor _process;

        public RoomBookingRequestTest()
        {
            _process = new RoomBookingRequestProcessor();
        }

        #region Method
        [Fact]
       public void Should_Return_Room_Booking_Response_With_Request_Values()
        {
            //Arrange
            var request = new RoomBookingRequest
            {
                Name = "Rafay Khan",
                Email = "rafay@finosys.com",
                Date = new DateTime(2022, 02, 02)
            };
            //Act
            RoomBookingResult result = _process.BookRoom(request);
            //Assert
            //Assert.NotNull(result);
            //result.ShouldNotBeNull();
            //Assert.Equal(request.Name, result.Name);
            //Assert.Equal(request.Email, result.Email);
            //Assert.Equal(request.Date, result.Date);

            result.ShouldNotBeNull();
            result.Name.ShouldBe(request.Name);
            result.Email.ShouldBe(request.Email);
            result.Date.ShouldBe(request.Date);
        }
        [Fact]
        public void Should_Throw_Exception_For_Null_Request()
        {
            var exception = Should.Throw<ArgumentNullException>(() => _process.BookRoom(null));
            exception.ParamName.ShouldBe("request");
        }
        #endregion
    }
}

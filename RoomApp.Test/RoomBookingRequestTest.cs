using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RoomApp
{
    public class RoomBookingRequestTest
    {

        // Method
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
            var process = new RoomBookingRequestProcessor();
            //Act
            RoomBookingResult result = process.BookRoom(request);
            //Assert
            Assert.NotNull(result);
            result.ShouldNotBeNull();
            Assert.Equal(request.Name, result.Name);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);

            result.ShouldNotBeNull();
            result.Name.ShouldBe(request.Name);
            result.Email.ShouldBe(request.Email);
            result.Date.ShouldBe(request.Date);
        }
    }
}

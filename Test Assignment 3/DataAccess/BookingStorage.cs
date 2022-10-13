using Test_Assignment_3.Context;
using Test_Assignment_3.Models;

namespace Test_Assignment_3.DataAccess
{
    public interface IBookingStorage
    {
        public Task<bool> CreateBooking(Booking booking);
    }

    public class BookingStorage : IBookingStorage
    {
        private readonly DBApplicationContext _dbContext;

        public BookingStorage(DBApplicationContext dBApplicationContext)
        {
            _dbContext = dBApplicationContext;
        }

        public async Task<bool> CreateBooking(Booking booking)
        {
            try
            {
                await _dbContext.Bookings.AddAsync(booking);
                await _dbContext.SaveChangesAsync();    
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

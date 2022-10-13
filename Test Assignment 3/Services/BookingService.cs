using Test_Assignment_3.Context;
using Test_Assignment_3.DataAccess;
using Test_Assignment_3.Dto;

namespace Test_Assignment_3.Services
{
    public interface IBookingService
    {
        public Task<bool> CreateBooking(CreateBookingDto createBookingDto);
    }

    public class BookingService : IBookingService
    {
        private readonly IBookingStorage _bookingStorage;
        private readonly IEmployeeStorage _employeeStorage;
        private readonly ICustomerStorage _customerStorage;

        public BookingService(
            IBookingStorage bookingStorage,
            IEmployeeStorage employeeStorage,
            ICustomerStorage customerStorage
            )
        {
            _bookingStorage = bookingStorage;
            _employeeStorage = employeeStorage;
            _customerStorage = customerStorage;
        }

        /// <summary>
        /// Creates a booking
        /// </summary>
        /// <param name="createBookingDto"></param>
        /// <returns></returns>
        public async Task<bool> CreateBooking(CreateBookingDto createBookingDto)
        {
            try
            {
                return await _bookingStorage.CreateBooking(
                    new Models.Booking
                    {
                        Customer = await _customerStorage.GetCustomerById(createBookingDto.CustomerId),
                        Employee = await _employeeStorage.GetEmployeeById(createBookingDto.EmployeeId),
                        Date = DateTime.UtcNow,
                        Start = DateTime.UtcNow
                    });
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

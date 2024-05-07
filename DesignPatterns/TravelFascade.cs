using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class TravelFacade
    {
        private HotelBooker hotelBooker;
        private FlightBooker flightBooker;

        public TravelFacade()
        {
            hotelBooker = new HotelBooker();
            flightBooker = new FlightBooker();
        }

        public void GetFlightsAndHotels(DateTime from, DateTime to)
        {
            List<Flight> flights = flightBooker.GetFlightsFor(from, to);
            List<Hotel> hotels = hotelBooker.GetHotelsFor(from, to);

            // Display both the lists i.e. flights and hotels
            Console.WriteLine("Flights:");
            foreach (Flight flight in flights)
            {
                Console.WriteLine(flight);
            }

            Console.WriteLine("Hotels:");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine(hotel);
            }
        }
    }

    public class HotelBooker
    {
        public List<Hotel> GetHotelsFor(DateTime from, DateTime to)
        {
            // Returns hotels available in the particular date range
            return new List<Hotel>(); // Dummy implementation, replace with actual logic
        }
    }

    public class FlightBooker
    {
        public List<Flight> GetFlightsFor(DateTime from, DateTime to)
        {
            // Returns flights available in the particular date range
            return new List<Flight>(); // Dummy implementation, replace with actual logic
        }
    }
    public class Hotel
    {
        // Hotel class implementation
    }

    public class Flight
    {
        // Flight class implementation
    }
}

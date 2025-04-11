using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class FeaturesCinema
    {
        private string _movieTitle;
        private readonly double _ticketPrice;
        private int _numberOfViewers;

        public string MovieTitle
        {
            get { return _movieTitle; }
            set { _movieTitle = value; }
        }

        public double TicketPrice
        {
            get { return _ticketPrice; }
        }

        public int NumberOfViewers
        {
            get { return _numberOfViewers; }
            set { _numberOfViewers = value; }
        }

        public string _Hall { get; }

        public FeaturesCinema(string movieTitle, double ticketPrice, int numberOfViewers, string Hall)
        {
            _movieTitle = movieTitle;
            _ticketPrice = ticketPrice;
            _numberOfViewers = numberOfViewers;
            _Hall = Hall;
        }

        public string Information
        {
            get
            {
                return $"$3\nНазвание фильма: {MovieTitle}, Стоимость билетка: {TicketPrice} Руб, Кол-во зрителей: {NumberOfViewers}, Зал: {_Hall}";
            }
        }
    }
}

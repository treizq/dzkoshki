using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class MethodCinema
    { 
        private string _movieTitle;
        private readonly double _ticketPrice;
        private int _numberOfViewers;
        private readonly string _Hall;

        public MethodCinema(string movieTitle, double ticketPrice, int numberOfViewers, string Hall)
        {
            _movieTitle = movieTitle;
            _ticketPrice = ticketPrice;
            _numberOfViewers = numberOfViewers;
            _Hall = Hall;
        }

        public string GetMovieTitle()
        {
            return _movieTitle;
        }

        public void SetMovieTitle(string movieTitle)
        {
            _movieTitle = movieTitle;
        }

        public double GetTicketPrice()
        {
            return _ticketPrice;
        }

        public int GetNumberOfViewers()
        {
            return _numberOfViewers;
        }

        public void SetNumberOfViewers(int numberOfViewers)
        {
            _numberOfViewers = numberOfViewers;
        }

        public string Hall()
        {
            return _Hall;
        }

        public string GetInformation()
        {
            return $"Название фильма: {_movieTitle}, Стоимость билетка: {_ticketPrice} Руб, Кол-во зрителей: {_numberOfViewers}, Зал: {_Hall}";
        }
    }
}

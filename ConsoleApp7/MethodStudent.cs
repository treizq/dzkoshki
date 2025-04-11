using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class MethodСтудент
    {
        
        private string _fio;
        private readonly string _numbergroup;
        private readonly string _enrollmentbooknumber;
        private readonly string _snils;

        public MethodСтудент(string fio, string numbergroup, string enrollmentbooknumber, string snils)
        {
            _fio = fio;
            _numbergroup = numbergroup;
            _enrollmentbooknumber = enrollmentbooknumber;
            _snils = snils;
        }

        public string GetFio()
        {
            return _fio;
        }

        public void SetFio(string fio)
        {
            _fio = fio;
        }

        public string GetGroupNumber()
        {
            return _numbergroup;
        }

        public string GetEnrollmentBookNumber()
        {
            return _enrollmentbooknumber;
        }

        public string GetSnils()
        {
            return _snils;
        }

        public string GetInfo()
        {
            return $"ФИО: {_fio}, Номер группы: {_numbergroup}, Номер зачетной книжки: {_enrollmentbooknumber}, СНИЛС: {_snils}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class FeaturesStudent
    {

        private string _fio;
        private readonly string _numbergroup;
        private readonly string _enrollmentbooknumber;

        public string FIO
        {
            get { return _fio; }
            set { _fio = value; }
        }

        public string NumberGroup
        {
            get { return _numbergroup; }
        }

        public string _EnrollmentBookNumber
        {
            get { return _enrollmentbooknumber; }
        }

        public string Snils { get; }


        public FeaturesStudent(string fio, string numbergroup, string enrollmentbooknumber, string snils)
        {
            _fio = fio;
            _numbergroup = numbergroup;
            _enrollmentbooknumber = enrollmentbooknumber;
            Snils = snils;
        }

        public string Info
        {
            get
            {
                return $"#1\nФИО: {FIO}, Номер группы: {NumberGroup}, Номер зачетной книжки: {_enrollmentbooknumber}, СНИЛС: {Snils}";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class House
    {
        // Field
        string number;
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value.GetType() != typeof(int))
                {
                    return;
                }
                number = value;
            }
        }

        // Property
        public int NumberOfFloors { get; set; }
        public int NumberOfRooms { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string Dicstrict { get; set; }

    }
    internal class TestHouse // Used inside this assembly only
    {
        public House House { get; set; }

        private void TestMethod()
        {
            House.NumberOfFloors = 5;
        }
    }
}

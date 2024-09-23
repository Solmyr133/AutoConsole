using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConsole
{
    internal class Car
    {
        public int Id { get; private set; }
        public string brand { get; private set; }
        public string type { get; private set; }
        public string license { get; private set; }
        public DateTime date { get; private set; }

        public Car(int id, string brand, string type, string license, DateTime date)
        {
            this.Id = id;
            this.brand = brand;
            this.type = type;
            this.license = license;
            this.date = date;
        }
    }
}

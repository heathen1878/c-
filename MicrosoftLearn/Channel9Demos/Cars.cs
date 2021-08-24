using System;
using System.Collections.Generic;
using System.Text;

namespace Channel9Demos
{
    public class Cars
    {
        public string Make { get; set; }

        public string Model { get; set; }
        public string Colour { get; set; }

        public DateTime Date { get; set; }


        public Cars(string MakeOfCar, string ModelOfCar, string ColourOfCar, DateTime YearCarBought)
        {
            this.Make = MakeOfCar;
            this.Model = ModelOfCar;
            this.Colour = ColourOfCar;
            this.Date = YearCarBought;

        }

        public void AddCar()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

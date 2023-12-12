using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep
{
    internal class Car
    {
        int mileage;
        readonly int cost;

        public string LicencePlateNumber {  get; set; }
        public int BaseCost {  get; set; }

        public int Mileage 
        {
            get { return mileage; }
            set { mileage = value; }
        }

        public int Cost
        {
            get { return BaseCost * ( (1- Mileage)/50000 ); }
        }

       // public Car() { }


        public override string ToString()
        {
            return $"{LicencePlateNumber}";
        }

    }
}

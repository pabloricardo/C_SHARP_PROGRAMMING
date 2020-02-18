using System;

namespace EnumerationAndComposition.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHora { get; set; }
        public int Hours { get; set; }

        HourContract() { }

        public HourContract(DateTime date, double valuePerHora, int hours)
        {
            Date = date;
            ValuePerHora = valuePerHora;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHora * Hours;
        }
    }
}

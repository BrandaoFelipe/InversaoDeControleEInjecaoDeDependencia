using System.Globalization;

namespace Interface.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice() { }

        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; } // why use this 'get' here?
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

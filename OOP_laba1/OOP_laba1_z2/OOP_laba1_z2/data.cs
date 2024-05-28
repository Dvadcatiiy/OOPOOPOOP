using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba1_z2
{
    interface IDateTimePrinter
    {
        string GetFormattedDateTime();
    }

    class BaseDateTimePrinter : IDateTimePrinter
    {
        public virtual string GetFormattedDateTime()
        {
            return DateTime.Now.ToString();
        }
    }
    class EuropeanDateTimePrinter : BaseDateTimePrinter
    {
        public override string GetFormattedDateTime()
        {
            CultureInfo euCulture = new CultureInfo("es-ES");
            return DateTime.Now.ToString(euCulture);
        }
    }
    class AmericanDateTimePrinter : BaseDateTimePrinter
    {
        public override string GetFormattedDateTime()
        {
            CultureInfo usCulture = new CultureInfo("en-US");
            return DateTime.Now.ToString(usCulture);
        }
    }
    abstract class DateTimeDecorator : IDateTimePrinter
    {
        protected IDateTimePrinter dateTimePrinter;

        public DateTimeDecorator(IDateTimePrinter printer)
        {
            dateTimePrinter = printer;
        }

        public virtual string GetFormattedDateTime()
        {
            return dateTimePrinter.GetFormattedDateTime();
        }
    }
    class SymbolDecorator : DateTimeDecorator
    {
        private string symbol;

        public SymbolDecorator(IDateTimePrinter printer, string symbol) : base(printer)
        {
            this.symbol = symbol;
        }

        public override string GetFormattedDateTime()
        {
            string baseDateTime = dateTimePrinter.GetFormattedDateTime();
            StringBuilder sb = new StringBuilder(baseDateTime);
            sb.Append(symbol);
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_n_5
{
    public class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
        public class Sale
        {
            public decimal Amount { get; set; }

            public Sale(decimal amount)
            {
                Amount = amount;
            }

            public virtual decimal CalculateTotal()
            {
                return Amount;
            }
        }

        public class RetailSale : Sale
        {
            public RetailSale(decimal amount) : base(amount)
            {
            }

            public override decimal CalculateTotal()
            {
                return Amount;
            }
        }

        public class WholesaleSale : Sale
        {
            public WholesaleSale(decimal amount) : base(amount)
            {
            }

            public override decimal CalculateTotal()
            {
                return Amount * 0.90m;
            }
        }       
    }

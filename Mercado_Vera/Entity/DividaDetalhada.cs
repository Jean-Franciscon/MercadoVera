using Mercado_Vera.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Vera.Entity
{
    class DividaDetalhada
    {
        public int Id { get; set; }
        public int IdVenda { get; set; }
        public int Status { get; set; }
        public decimal ValorPago { get; set; }

        public DividaDetalhada()
        {
        }

        public DividaDetalhada(string id)
        {
            Id = int.Parse(id);
        }

        public DividaDetalhada(string id, string valorPago) : this(id)
        {
            ValorPago = decimal.Parse(valorPago);
        }
    }
}

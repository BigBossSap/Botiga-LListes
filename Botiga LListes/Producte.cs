using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botiga_LListes
{
    internal class Producte
    {


        public string nom { get; set; }
        public double preu_sense_iva { get; set; }
        public double iva { get; set; }



        public Producte()
        {


        }
        public Producte(string producte, double preu, double iva)
        {
            nom = producte;
            preu_sense_iva = preu;
            this.iva = iva;
        }

        public double Preu()
        {
            double preuTotal;

            preuTotal = preu_sense_iva + (preu_sense_iva * iva / 100);


            return preuTotal;


        }

        public string toString()
        {
            string text = $"Producte: {nom}, preu sense IVA: {preu_sense_iva}, preu amb IVA: {Preu()}, IVA aplicat: {iva}";


            return text;
        }




    }
}

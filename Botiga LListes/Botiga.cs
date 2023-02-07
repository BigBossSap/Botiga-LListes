using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Botiga_LListes
{
    internal class Botiga


    {

        string nom_botiga { get; set; }

        private List<Producte> prestatge = new List<Producte>();

        private int nombre_productes;

        private int nombre_productes_actual;

        public Botiga (int n)
        {

            nombre_productes = n;



        }

        public bool AfegirProducte(Producte Producte)
        {
            bool afegit = false;
            bool trobat = false;
            int posBuscar = 0;


            while ((prestatge[posBuscar] != null) || (trobat == false) && (nombre_productes_actual<nombre_productes))
            {
                if (prestatge[posBuscar] == null)
                {
                    trobat = true;
                }

                else
                    posBuscar++;


            }

            if (trobat)
            {
                prestatge[posBuscar] = Producte;
                afegit = true;
                nombre_productes_actual++;
                
            }


            return afegit;





        }

        public Producte BuscarProducte(Producte p)
        {
            Producte producte = null;
            producte = prestatge.Find(a => a.nom.Equals(p.nom));
            return (producte);
        }


    }
}

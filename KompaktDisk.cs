using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    public class KompaktDisk
    {
        string naziv, izvodjac;
        DateTime datum;
        ArrayList lista = new ArrayList();

        public string Naziv
        {
            get { return naziv; }
        }

        public string Izvodjac
        {
            get { return izvodjac; }
        }

        public DateTime Datum
        {
            get { return datum; }
        }

        public ArrayList ListaPesama
        {
            get { return lista; }
        }

        public KompaktDisk(string naziv, string izvodjac, DateTime datum)
        {
            this.naziv = naziv;
            this.izvodjac = izvodjac;
            this.datum = datum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Naziv albuma : "+naziv);
            sb.Append(Environment.NewLine);
            sb.Append("Naziv izvodjaca : " + izvodjac);
            sb.Append(Environment.NewLine);
            sb.Append("Datum izdavanja : " + datum);
            sb.Append(Environment.NewLine);
            sb.AppendLine("Pesme:");
            for (int i = 0; i < lista.Count; i++)
            {
                sb.AppendLine((i+1)+". "+lista[i]);
            }

            return sb.ToString();
        }

        public void DodajPesmu(string pesma)
        {
            lista.Add(pesma);
        }

    }
}

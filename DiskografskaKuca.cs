using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    public static class DiskografskaKuca
    {
        static List<KompaktDisk> listaDiskova = new List<KompaktDisk>();

        public static void DodajKompaktDisk(KompaktDisk disk)
        {
            listaDiskova.Add(disk);
        }


        public static List<KompaktDisk> KompaktDiskoviPoVremenu(DateTime donjaGranica, DateTime gornjaGranica)
        {
            List<KompaktDisk> list = new List<KompaktDisk>();

            for (int i = 0; i < listaDiskova.Count; i++)
            {
                if (listaDiskova[i].Datum >= donjaGranica && listaDiskova[i].Datum <= gornjaGranica)
                {
                    list.Add(listaDiskova[i]);
                }
            }

            return list;
        }

        public static List<KompaktDisk> KompaktDiskoviIzvodjaca(string izvodjac)
        {
            List<KompaktDisk> list = new List<KompaktDisk>();

            foreach (KompaktDisk disk in listaDiskova)
            {
                if (disk.Izvodjac.Equals(izvodjac))
                    list.Add(disk);
            }
            

            return list;
        }

        public static List<KompaktDisk> KompaktDiskoviPoBrojuPesam(int broj)
        {
            List<KompaktDisk> list = new List<KompaktDisk>();

            for (int i = 0; i < listaDiskova.Count; i++)
            {
                if (listaDiskova[i].ListaPesama.Count >= broj)
                {
                    list.Add(listaDiskova[i]);
                }
            }

            return list;
        }

    }
}

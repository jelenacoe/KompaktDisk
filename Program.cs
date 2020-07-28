using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            KompaktDisk kd1 = new KompaktDisk("21", "Adele", new DateTime(2011, 10, 5));
            kd1.DodajPesmu("Rolling in the Deep");
            kd1.DodajPesmu("Turning Tables");
            kd1.DodajPesmu("Set Fire to the Rain");
            kd1.DodajPesmu("Take It All");
            kd1.DodajPesmu("One and Only");

            Console.WriteLine(kd1.ToString());

            KompaktDisk kd2 = new KompaktDisk("25", "Adele", new DateTime(2015, 11, 20));
            kd2.DodajPesmu("I Miss You");
            kd2.DodajPesmu("Hello");
            kd2.DodajPesmu("Remedy");

            Console.WriteLine(kd2.ToString());

            KompaktDisk kd3 = new KompaktDisk("Our Version of Events", "Emeli Sande", new DateTime(2012, 2, 13));
            kd3.DodajPesmu("Heaven");
            kd3.DodajPesmu("My Kind of Love");
            kd3.DodajPesmu("Where I Sleep");
            kd3.DodajPesmu("Mountains");
            kd3.DodajPesmu("Clown");

            Console.WriteLine(kd3.ToString());

            DiskografskaKuca.DodajKompaktDisk(kd1);
            DiskografskaKuca.DodajKompaktDisk(kd2);
            DiskografskaKuca.DodajKompaktDisk(kd3);

            List<KompaktDisk> retList = new List<KompaktDisk>();

            Console.WriteLine("SVI DISKOVI IZVODJACA Adele\n");
            retList = DiskografskaKuca.KompaktDiskoviIzvodjaca("Adele");
            foreach (KompaktDisk disk in retList)
                Console.WriteLine(disk);

            Console.WriteLine("KOMPAKT DISKOVI KOJI IMAJU VISE OD 4 PESME\n");
            retList = DiskografskaKuca.KompaktDiskoviPoBrojuPesam(4);
            foreach (KompaktDisk disk in retList)
                Console.WriteLine(disk);

            Console.WriteLine("KOMPAKTDISKOVI IZDATI U PERIODU OD 01.10.2000. DO 01.10.2012.\n");
            retList = DiskografskaKuca.KompaktDiskoviPoVremenu(new DateTime(2000,10,1), new DateTime(2012,10,1));
            foreach (KompaktDisk disk in retList)
                Console.WriteLine(disk);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusStore.Entities;

namespace VirusStore.Engine
{
    public class VirusStoreEngine
    {
        public VirusStock VirusStocker { get; set; }

        public void Inicializador()
        {
            VirusStocker = new VirusStock();
            ChargeCategories();
            
        }
        public  void ChargeCategories()
        {          
               VirusStocker.Categories = new List<Category>()
               {
                        new Category{ Name = "Troyano", ID = 1 },
                        new Category{ Name = "Adware", ID = 2 },
                        new Category{ Name = "Gusano", ID = 3 },
                        new Category{ Name = "Spyware", ID = 4 },
                        new Category{ Name = "Ransomware", ID = 5 }
               };
            Random rnd = new Random();
            foreach (var item in VirusStocker.Categories)
            {
                int cantRandom = rnd.Next(5, 20);
                item.Viruses = GenerateVirus(cantRandom);
            }
        }
        private List<Virus> GenerateVirus(int cantidad)
        {
            string[] vname = { "ALBA", "UNIX", "KARSPERSKY", "DEATHMATCH", "DOSS", "ORANGE", "REAPER" };
            string[] vtype = { "TY", "BL", "HOAX", "BUG", "JOKE", "DNS", "BAT", "FAT" };

            var VirusList = from n1 in vname
                               from n2 in vtype                             
                               select new Virus { NameVirus = $"{n1} {n2}" }; //Armado de nombre aleatorio 

            return VirusList.OrderBy((virus) => virus.UniqueId).Take(cantidad).ToList();
        }
    }    
}

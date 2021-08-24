using System;
using System.Collections.Generic;
using System.Xml;
using static System.Console;


namespace VirusStore.Entities
{
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<Virus> Viruses { get; set; }
       

    }
}

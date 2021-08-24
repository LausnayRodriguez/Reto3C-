using System;
using System.Collections.Generic;
using System.Xml;

namespace VirusStore.Entities
{
    public class Virus
    {
        public string UniqueId { get; set; }
        public Virus() => UniqueId = Guid.NewGuid().ToString(); //Unique id se genera automaticamente
        public int IDVirus { get; set; }
        public string NameVirus { get; set; }
        
    }
}

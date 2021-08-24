using System;
using System.Collections.Generic;
using System.Xml;

namespace VirusStore.Entities
{
    public class VirusStock
    {
        public string UniqueId { get; set; }

        public List<Category> Categories { get; set; }

        public List<Virus> Viruses { get; set; }

        public VirusStock()=>UniqueId = Guid.NewGuid().ToString();
    }
}

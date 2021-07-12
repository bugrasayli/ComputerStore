using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Computer.Core.Entities
{
    public class Computer
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ModelName { get; set; }
        public int RamID { get; set; }
        public int GraphicCardID { get; set; }

        public Ram Ram { get; set; }
        public GraphicCard GraphicCard { get; set; }
    }

}

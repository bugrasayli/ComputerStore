using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Computer.Core.Entities
{
    public class Ram
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Core.DTO.ComputerDTO.Response
{
    public class GetComputerResponse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ModelName { get; set; }
        public GraphicDTO.Response.GetGraphicCardResponse GraphicCard { get; set; }
        public RamDTO.Response.GetRamResponse Ram { get; set; }
    }
}


namespace Computer.Core.DTO.ComputerDTO.Request
{
    public class UpdateComputerRequest
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public string ModelName { get; set; }
        public int GraphicCardID { get; set; }
        public int RamID { get; set; }
    }
}

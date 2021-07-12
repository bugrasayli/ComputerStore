using System.Collections;
using System.Collections.Generic;

namespace Computer.Application.Mapper
{
    public interface IComputerMapper
    {
        public Core.DTO.ComputerDTO.Response.GetComputerResponse MapComputer(Core.Entities.Computer computer);
        public Core.DTO.ComputerDTO.Response.GetComputersResponse MapComputers(IEnumerable<Core.Entities.Computer> computer);
        public Core.Entities.Computer MapComputer(Core.DTO.ComputerDTO.Request.PostcomputerRequest computer);
        
    }
}

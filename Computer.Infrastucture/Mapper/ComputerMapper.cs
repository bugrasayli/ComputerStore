using Computer.Application.Mapper;
using Computer.Core.DTO.ComputerDTO.Request;
using Computer.Core.DTO.ComputerDTO.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Infrastucture.Mapper
{
    public class ComputerMapper : IComputerMapper
    {
        private readonly IGraphicCardMapper _gMapper;
        private readonly IRamMapper _rMapper;
        public ComputerMapper(IGraphicCardMapper gMapper,IRamMapper rMapper)
        {
            _gMapper = gMapper;
            _rMapper= rMapper;
        }
        public GetComputerResponse MapComputer(Core.Entities.Computer computer)
        {
            GetComputerResponse comp = new GetComputerResponse()
            {
                ID = computer.ID,
                Name = computer.Name,
                ModelName = computer.ModelName,
                GraphicCard = _gMapper.MapGraphicCard( computer.GraphicCard),
                Ram = _rMapper.MapRam( computer.Ram)
            };
            return null; 
        }
        public Core.Entities.Computer MapComputer(PostcomputerRequest computer)
        {
            Core.Entities.Computer comp = new Core.Entities.Computer();
            comp.Name = computer.Name;
            comp.ModelName = computer.ModelName;
            comp.RamID = computer.RamID;
            comp.GraphicCardID = computer.GraphicCardID;
            return comp;
        }
        public GetComputersResponse MapComputers(IEnumerable<Core.Entities.Computer> computers)
        {
            GetComputersResponse comps = new GetComputersResponse();
            foreach (var item in computers)
            {
                comps.Computers.Add( new GetComputerResponse() {
                    ID= item.ID,
                    Name = item.Name,
                    ModelName = item.ModelName,
                    GraphicCard = _gMapper.MapGraphicCard(item.GraphicCard),
                    Ram = _rMapper.MapRam(item.Ram)
                });
            }
            return comps;
        }

    }
}

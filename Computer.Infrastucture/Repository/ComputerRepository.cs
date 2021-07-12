using Computer.Application.Mapper;
using Computer.Application.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Computer.Infrastucture.Repository
{
    public class ComputerRepository : IComputer
    {
        private readonly IComputerMapper _map;
        private readonly ComputerContext _ctx;
        public ComputerRepository(IComputerMapper map, ComputerContext ctx)
        {
            _ctx = ctx;
            _map = map;
        }
        public Task<Core.Entities.Computer> Create(Core.DTO.ComputerDTO.Request.PostcomputerRequest computer)
        {
            Core.Entities.Computer comp = _map.MapComputer(computer);
            return null;
        }

        public Task<Core.Entities.Computer> Delete(int ID)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Core.Entities.Computer>> Get()
        {
            Core.DTO.ComputerDTO.Response.GetComputersResponse a = _map.MapComputers(_ctx.Computers);
            throw new System.NotImplementedException();
        }

        public Task<Core.Entities.Computer> Get(int ID)
        {
            throw new System.NotImplementedException();
        }

        public Task<Core.Entities.Computer> Update(Core.Entities.Computer computer)
        {
            throw new System.NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Application.Repository
{
    public interface IComputer 
    {
        public  Task<IEnumerable<Core.Entities.Computer>> Get();
        public Task<Core.Entities.Computer> Get(int ID);
        public Task<Core.Entities.Computer> Update(Core.Entities.Computer computer);
        public Task<Core.Entities.Computer> Delete(int ID);
        public Task<Core.Entities.Computer> Create(Core.DTO.ComputerDTO.Request.PostcomputerRequest computer);
    }
}

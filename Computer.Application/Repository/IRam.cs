using Computer.Core.DTO.RamDTO.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Application.Repository
{
    public interface IRam
    {
        public IEnumerable<Core.DTO.RamDTO.Response.GetRamResponse> Get();
        public Core.DTO.RamDTO.Response.GetRamResponse Get(int ID);
        public bool Update(UpdateRamRequest ram);
        public bool Delete(int ID);
        public bool Create(PostRamRequest ram);
    }
}

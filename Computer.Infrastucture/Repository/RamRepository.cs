using Computer.Application.Mapper;
using Computer.Application.Repository;
using Computer.Core.DTO.RamDTO.Request;
using Computer.Core.DTO.RamDTO.Response;
using Computer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer.Infrastucture.Repository
{
    public class RamRepository : IRam
    {
        private readonly ComputerContext _ctx;
        private readonly IRamMapper _map;
        private readonly IRepository _repo;
        public RamRepository(ComputerContext ctx, IRamMapper map, IRepository repo)
        {
            _ctx = ctx;
            _map = map;
            _repo = repo;

        }

        public bool Create(PostRamRequest ram)
        {
            Ram a = _map.MapRam(ram);
            _ctx.Add(a);
            bool isStored = _repo.SaveChange();
            return isStored;
        }

        public bool Delete(int ID)
        {
            Ram a = _ctx.Rams.Where(x => x.ID == ID).FirstOrDefault();
            bool isStored = false;
            if (a == null)
                return false;
            else
            {
                _ctx.Rams.Remove(a);
                isStored = _repo.SaveChange();
            }
            return isStored;
        }

        public IEnumerable<GetRamResponse> Get()
        {
            var a = _map.MapRams(_ctx.Rams.ToList());
            return a;
        }

        public GetRamResponse Get(int ID)
        {
            var a = _map.MapRam(_ctx.Rams.Where(x=> x.ID == ID).FirstOrDefault());
            return a;
        }

        public bool Update(UpdateRamRequest ram)
        {
            throw new NotImplementedException();
        }
    }
}

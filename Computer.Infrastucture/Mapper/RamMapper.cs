using Computer.Application.Mapper;
using Computer.Core.DTO.RamDTO.Request;
using Computer.Core.DTO.RamDTO.Response;
using Computer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Infrastucture.Mapper
{
    public class RamMapper : IRamMapper
    {
        public GetRamResponse MapRam(Ram ram)
        {
            GetRamResponse _ram = new GetRamResponse()
            {
                ID = ram.ID,
                Name = ram.Name,
            };
            return _ram;
        }

        public List<GetRamResponse> MapRams(IEnumerable<Ram> rams)
        {
            List<GetRamResponse> _rams = new List<GetRamResponse>();
            foreach (var item in rams)
            {
                _rams.Add(new GetRamResponse
                {
                    ID = item.ID,
                    Name = item.Name
                });
            }
            return _rams;
        }
        public Ram MapRam(PostRamRequest ram)
        {
            Ram _ram = new Ram()
            {
                Name = ram.Name
            };
            return _ram;
        }
    }
}

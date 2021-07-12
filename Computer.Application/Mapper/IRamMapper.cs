using Computer.Core.DTO.RamDTO.Request;
using Computer.Core.DTO.RamDTO.Response;
using Computer.Core.Entities;
using System.Collections.Generic;

namespace Computer.Application.Mapper
{
    public interface IRamMapper
    {
        public GetRamResponse MapRam(Ram ram);
        public List<GetRamResponse> MapRams(IEnumerable<Ram> rams);
        public Ram MapRam(PostRamRequest ram);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Application.Repository
{
    public interface IGraphicCard
    {
        public Task<IEnumerable<Core.Entities.GraphicCard>> Get();
        public Task<Core.Entities.GraphicCard> Get(int ID);
        public Task<Core.Entities.GraphicCard> Update(Core.Entities.Ram ram);
        public Task<Core.Entities.GraphicCard> Delete(int ID);
        public Task<Core.Entities.GraphicCard> Create(Core.Entities.Ram ram);
    }
}

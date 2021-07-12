using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Computer.Application.Mapper
{
    public interface IGraphicCardMapper
    {
        public Core.DTO.GraphicDTO.Response.GetGraphicCardResponse MapGraphicCard(Core.Entities.GraphicCard graph);
        public Core.DTO.GraphicDTO.Response.GetGraphicCardsResponse MapGraphicCards(IEnumerable<Core.Entities.GraphicCard> graphs);
        public Core.Entities.GraphicCard MapGraphicCard(Core.DTO.GraphicDTO.Request.PostGraphicCardRequest graph);
    }
}

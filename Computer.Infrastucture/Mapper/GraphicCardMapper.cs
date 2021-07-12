using Computer.Application.Mapper;
using Computer.Core.DTO.GraphicDTO.Request;
using Computer.Core.DTO.GraphicDTO.Response;
using Computer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Infrastucture.Mapper
{
    public class GraphicCardMapper : IGraphicCardMapper
    {
        public GraphicCard MapGraphicCard(PostGraphicCardRequest graph)
        {
            GraphicCard graphicCard = new GraphicCard()
            {
                Name = graph.Name
            };
            return graphicCard;
        }

        public GetGraphicCardResponse MapGraphicCard(GraphicCard graph)
        {
            GetGraphicCardResponse graphicCard = new GetGraphicCardResponse()
            {
                ID = graph.ID,
                Name = graph.Name,
            };
            return graphicCard;
        }

        public GetGraphicCardsResponse MapGraphicCards(IEnumerable<GraphicCard> graphs)
        {
            GetGraphicCardsResponse graphics = new GetGraphicCardsResponse();
            foreach (var item in graphs)
            {
                graphics.GraphicCards.Add(new GetGraphicCardResponse
                {
                    ID = item.ID,
                    Name = item.Name
                });
            }
            return graphics;
        }
    }
}

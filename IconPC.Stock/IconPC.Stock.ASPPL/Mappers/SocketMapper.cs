using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntitySocket = IconPC.Stock.Entities.Socket;
using ModelSocket = IconPC.Stock.ASPPL.Models.Socket;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class SocketMapper : IMapper<EntitySocket, ModelSocket>
    {
        public EntitySocket Map(ModelSocket socketModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelSocket, EntitySocket>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelSocket, EntitySocket>(socketModel);
            return model;
        }
        public ModelSocket Map(EntitySocket socketModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntitySocket, ModelSocket>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntitySocket, ModelSocket>(socketModel);
            return model;
        }

        public IEnumerable<ModelSocket> Map(IEnumerable<EntitySocket> socketModel)
        {
            List<ModelSocket> models = new List<ModelSocket>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntitySocket, ModelSocket>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            foreach (var socket in socketModel)
            {
                var model = mapper.Map<EntitySocket, ModelSocket>(socket);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntitySocket> Map(IEnumerable<ModelSocket> socketModel)
        {
            if (socketModel != null)
            {
                List<EntitySocket> models = new List<EntitySocket>();
                foreach (var socket in socketModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelSocket, EntitySocket>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelSocket, EntitySocket>(socket);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

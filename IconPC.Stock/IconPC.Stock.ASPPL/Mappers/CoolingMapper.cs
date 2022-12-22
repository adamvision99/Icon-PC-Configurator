using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntityCooling = IconPC.Stock.Entities.Cooling;
using ModelCooling = IconPC.Stock.ASPPL.Models.Cooling;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class CoolingMapper : IMapper<EntityCooling, ModelCooling>
    {
        public EntityCooling Map(ModelCooling coolingModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelCooling, EntityCooling>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.HeatAmount, x => x.MapFrom(y => y.HeatAmount))
            .ForMember(x => x.Comment, x => x.MapFrom(y => y.Comment))
            .ForMember(x => x.Color, x => x.MapFrom(y => y.Color))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelCooling, EntityCooling>(coolingModel);
            return model;
        }
        public ModelCooling Map(EntityCooling coolingModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityCooling, ModelCooling>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Comment, x => x.MapFrom(y => y.Comment))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntityCooling, ModelCooling>(coolingModel);
            return model;
        }

        public IEnumerable<ModelCooling> Map(IEnumerable<EntityCooling> coolingModel)
        {
            List<ModelCooling> models = new List<ModelCooling>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityCooling, ModelCooling>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Comment, x => x.MapFrom(y => y.Comment))
            );
            var mapper = config.CreateMapper();
            foreach (var cooling in coolingModel)
            {
                var model = mapper.Map<EntityCooling, ModelCooling>(cooling);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntityCooling> Map(IEnumerable<ModelCooling> coolingModel)
        {
            if (coolingModel != null)
            {
                List<EntityCooling> models = new List<EntityCooling>();
                foreach (var cooling in coolingModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelCooling, EntityCooling>()
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.Comment, x => x.MapFrom(y => y.Comment))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelCooling, EntityCooling>(cooling);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

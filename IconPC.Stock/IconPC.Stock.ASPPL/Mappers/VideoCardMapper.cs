using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntityVideoCard = IconPC.Stock.Entities.VideoCard;
using ModelVideoCard = IconPC.Stock.ASPPL.Models.VideoCard;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class VideoCardMapper : IMapper<EntityVideoCard, ModelVideoCard>
    {
        public EntityVideoCard Map(ModelVideoCard videocardModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelVideoCard, EntityVideoCard>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Desctription, x => x.MapFrom(y => y.Desctription))
            .ForMember(x => x.MemorySize, x => x.MapFrom(y => y.MemorySize))
            .ForMember(x => x.BusWidth, x => x.MapFrom(y => y.BusWidth))
            .ForMember(x => x.MinimumPowerSupply, x => x.MapFrom(y => y.MinimumPowerSupply))
            .ForMember(x => x.Length, x => x.MapFrom(y => y.Length))
            .ForMember(x => x.Connector, x => x.MapFrom(y => y.Connector))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelVideoCard, EntityVideoCard>(videocardModel);
            return model;
        }
        public ModelVideoCard Map(EntityVideoCard videocardModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityVideoCard, ModelVideoCard>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Desctription, x => x.MapFrom(y => y.Desctription))
            .ForMember(x => x.MemorySize, x => x.MapFrom(y => y.MemorySize))
            .ForMember(x => x.BusWidth, x => x.MapFrom(y => y.BusWidth))
            .ForMember(x => x.MinimumPowerSupply, x => x.MapFrom(y => y.MinimumPowerSupply))
            .ForMember(x => x.Length, x => x.MapFrom(y => y.Length))
            .ForMember(x => x.Connector, x => x.MapFrom(y => y.Connector))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntityVideoCard, ModelVideoCard>(videocardModel);
            return model;
        }

        public IEnumerable<ModelVideoCard> Map(IEnumerable<EntityVideoCard> videocardModel)
        {
            List<ModelVideoCard> models = new List<ModelVideoCard>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityVideoCard, ModelVideoCard>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Desctription, x => x.MapFrom(y => y.Desctription))
            .ForMember(x => x.MemorySize, x => x.MapFrom(y => y.MemorySize))
            .ForMember(x => x.BusWidth, x => x.MapFrom(y => y.BusWidth))
            .ForMember(x => x.MinimumPowerSupply, x => x.MapFrom(y => y.MinimumPowerSupply))
            .ForMember(x => x.Length, x => x.MapFrom(y => y.Length))
            .ForMember(x => x.Connector, x => x.MapFrom(y => y.Connector))
            );
            var mapper = config.CreateMapper();
            foreach (var videocard in videocardModel)
            {
                var model = mapper.Map<EntityVideoCard, ModelVideoCard>(videocard);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntityVideoCard> Map(IEnumerable<ModelVideoCard> videocardModel)
        {
            if (videocardModel != null)
            {
                List<EntityVideoCard> models = new List<EntityVideoCard>();
                foreach (var videocard in videocardModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelVideoCard, EntityVideoCard>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Desctription, x => x.MapFrom(y => y.Desctription))
            .ForMember(x => x.MemorySize, x => x.MapFrom(y => y.MemorySize))
            .ForMember(x => x.BusWidth, x => x.MapFrom(y => y.BusWidth))
            .ForMember(x => x.MinimumPowerSupply, x => x.MapFrom(y => y.MinimumPowerSupply))
            .ForMember(x => x.Length, x => x.MapFrom(y => y.Length))
            .ForMember(x => x.Connector, x => x.MapFrom(y => y.Connector))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelVideoCard, EntityVideoCard>(videocard);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

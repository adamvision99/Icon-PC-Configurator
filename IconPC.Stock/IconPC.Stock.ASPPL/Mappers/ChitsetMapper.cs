using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntityChipset = IconPC.Stock.Entities.Chipset;
using ModelChipset = IconPC.Stock.ASPPL.Models.Chipset;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class ChipsetMapper : IMapper<EntityChipset, ModelChipset>
    {
        public EntityChipset Map(ModelChipset chipsetModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelChipset, EntityChipset>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelChipset, EntityChipset>(chipsetModel);
            return model;
        }
        public ModelChipset Map(EntityChipset chipsetModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityChipset, ModelChipset>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntityChipset, ModelChipset>(chipsetModel);
            return model;
        }

        public IEnumerable<ModelChipset> Map(IEnumerable<EntityChipset> chipsetModel)
        {
            List<ModelChipset> models = new List<ModelChipset>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityChipset, ModelChipset>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            foreach (var chipset in chipsetModel)
            {
                var model = mapper.Map<EntityChipset, ModelChipset>(chipset);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntityChipset> Map(IEnumerable<ModelChipset> chipsetModel)
        {
            if (chipsetModel != null)
            {
                List<EntityChipset> models = new List<EntityChipset>();
                foreach (var chipset in chipsetModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelChipset, EntityChipset>()
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelChipset, EntityChipset>(chipset);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

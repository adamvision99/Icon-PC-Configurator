using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntityRAMtype = IconPC.Stock.Entities.RAMtype;
using ModelRAMtype = IconPC.Stock.ASPPL.Models.RAMtype;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class RAMtypeMapper : IMapper<EntityRAMtype, ModelRAMtype>
    {
        public EntityRAMtype Map(ModelRAMtype ramtypeModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelRAMtype, EntityRAMtype>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelRAMtype, EntityRAMtype>(ramtypeModel);
            return model;
        }
        public ModelRAMtype Map(EntityRAMtype ramtypeModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityRAMtype, ModelRAMtype>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntityRAMtype, ModelRAMtype>(ramtypeModel);
            return model;
        }

        public IEnumerable<ModelRAMtype> Map(IEnumerable<EntityRAMtype> ramtypeModel)
        {
            List<ModelRAMtype> models = new List<ModelRAMtype>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityRAMtype, ModelRAMtype>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            foreach (var ramtype in ramtypeModel)
            {
                var model = mapper.Map<EntityRAMtype, ModelRAMtype>(ramtype);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntityRAMtype> Map(IEnumerable<ModelRAMtype> ramtypeModel)
        {
            if (ramtypeModel != null)
            {
                List<EntityRAMtype> models = new List<EntityRAMtype>();
                foreach (var ramtype in ramtypeModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelRAMtype, EntityRAMtype>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelRAMtype, EntityRAMtype>(ramtype);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

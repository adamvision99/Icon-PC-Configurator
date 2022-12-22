using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntityRAM = IconPC.Stock.Entities.RAM;
using ModelRAM = IconPC.Stock.ASPPL.Models.RAM;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class RAMMapper : IMapper<EntityRAM, ModelRAM>
    {
        IMapper<Entities.RAMtype, Models.RAMtype> ramtypeMapper = new RAMtypeMapper();
        public EntityRAM Map(ModelRAM ramModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelRAM, EntityRAM>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => ramtypeMapper.Map(y.Type)))
            .ForMember(x => x.Size, x => x.MapFrom(y => y.Size))
            .ForMember(x => x.NumberOfModules, x => x.MapFrom(y => y.NumberOfModules))
            .ForMember(x => x.MemoryFrequency, x => x.MapFrom(y => y.MemoryFrequency))
            .ForMember(x => x.Latency, x => x.MapFrom(y => y.Latency))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelRAM, EntityRAM>(ramModel);
            return model;
        }
        public ModelRAM Map(EntityRAM ramModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityRAM, ModelRAM>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.Size, x => x.MapFrom(y => y.Size))
            .ForMember(x => x.NumberOfModules, x => x.MapFrom(y => y.NumberOfModules))
            .ForMember(x => x.MemoryFrequency, x => x.MapFrom(y => y.MemoryFrequency))
            .ForMember(x => x.Latency, x => x.MapFrom(y => y.Latency))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntityRAM, ModelRAM>(ramModel);
            return model;
        }

        public IEnumerable<ModelRAM> Map(IEnumerable<EntityRAM> ramModel)
        {
            List<ModelRAM> models = new List<ModelRAM>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityRAM, ModelRAM>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.Size, x => x.MapFrom(y => y.Size))
            .ForMember(x => x.NumberOfModules, x => x.MapFrom(y => y.NumberOfModules))
            .ForMember(x => x.MemoryFrequency, x => x.MapFrom(y => y.MemoryFrequency))
            .ForMember(x => x.Latency, x => x.MapFrom(y => y.Latency))
            );
            var mapper = config.CreateMapper();
            foreach (var ram in ramModel)
            {
                var model = mapper.Map<EntityRAM, ModelRAM>(ram);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntityRAM> Map(IEnumerable<ModelRAM> ramModel)
        {
            if (ramModel != null)
            {
                List<EntityRAM> models = new List<EntityRAM>();
                foreach (var ram in ramModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelRAM, EntityRAM>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.Size, x => x.MapFrom(y => y.Size))
            .ForMember(x => x.NumberOfModules, x => x.MapFrom(y => y.NumberOfModules))
            .ForMember(x => x.MemoryFrequency, x => x.MapFrom(y => y.MemoryFrequency))
            .ForMember(x => x.Latency, x => x.MapFrom(y => y.Latency))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelRAM, EntityRAM>(ram);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

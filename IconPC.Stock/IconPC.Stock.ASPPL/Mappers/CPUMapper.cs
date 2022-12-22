using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntityCPU = IconPC.Stock.Entities.CPU;
using ModelCPU = IconPC.Stock.ASPPL.Models.CPU;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class CPUMapper : IMapper<EntityCPU, ModelCPU>
    {
        IMapper<Entities.Socket, Models.Socket> socketMapper = new SocketMapper();
        public EntityCPU Map(ModelCPU cpuModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelCPU, EntityCPU>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.NumberOfCores, x => x.MapFrom(y => y.NumberOfCores))
            .ForMember(x => x.NumberOfThreads, x => x.MapFrom(y => y.NumberOfThreads))
            .ForMember(x => x.TurboFrequency, x => x.MapFrom(y => y.TurboFrequency))
            .ForMember(x => x.Socket, x => x.MapFrom(y => socketMapper.Map(y.Socket)))
            .ForMember(x => x.TDP, x => x.MapFrom(y => y.TDP))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelCPU, EntityCPU>(cpuModel);
            return model;
        }
        public ModelCPU Map(EntityCPU cpuModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityCPU, ModelCPU>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.NumberOfCores, x => x.MapFrom(y => y.NumberOfCores))
            .ForMember(x => x.NumberOfThreads, x => x.MapFrom(y => y.NumberOfThreads))
            .ForMember(x => x.TurboFrequency, x => x.MapFrom(y => y.TurboFrequency))
            .ForMember(x => x.Socket, x => x.MapFrom(y => socketMapper.Map(y.Socket)))
            .ForMember(x => x.TDP, x => x.MapFrom(y => y.TDP))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntityCPU, ModelCPU>(cpuModel);
            return model;
        }

        public IEnumerable<ModelCPU> Map(IEnumerable<EntityCPU> cpuModel)
        {
            List<ModelCPU> models = new List<ModelCPU>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityCPU, ModelCPU>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.NumberOfCores, x => x.MapFrom(y => y.NumberOfCores))
            .ForMember(x => x.NumberOfThreads, x => x.MapFrom(y => y.NumberOfThreads))
            .ForMember(x => x.TurboFrequency, x => x.MapFrom(y => y.TurboFrequency))
            .ForMember(x => x.Socket, x => x.MapFrom(y => socketMapper.Map(y.Socket)))
            .ForMember(x => x.TDP, x => x.MapFrom(y => y.TDP))
            );
            var mapper = config.CreateMapper();
            foreach (var cpu in cpuModel)
            {
                var model = mapper.Map<EntityCPU, ModelCPU>(cpu);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntityCPU> Map(IEnumerable<ModelCPU> cpuModel)
        {
            if (cpuModel != null)
            {
                List<EntityCPU> models = new List<EntityCPU>();
                foreach (var cpu in cpuModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelCPU, EntityCPU>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.NumberOfCores, x => x.MapFrom(y => y.NumberOfCores))
            .ForMember(x => x.NumberOfThreads, x => x.MapFrom(y => y.NumberOfThreads))
            .ForMember(x => x.TurboFrequency, x => x.MapFrom(y => y.TurboFrequency))
            .ForMember(x => x.Socket, x => x.MapFrom(y => socketMapper.Map(y.Socket)))
            .ForMember(x => x.TDP, x => x.MapFrom(y => y.TDP))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelCPU, EntityCPU>(cpu);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

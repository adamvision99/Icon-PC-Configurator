using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntityMotherboard = IconPC.Stock.Entities.Motherboard;
using ModelMotherboard = IconPC.Stock.ASPPL.Models.Motherboard;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class MotherboardMapper : IMapper<EntityMotherboard, ModelMotherboard>
    {
        IMapper<Entities.Socket, Models.Socket> socketMapper = new SocketMapper();
        IMapper<Entities.Chipset, Models.Chipset> chipsetMapper = new ChipsetMapper();
        IMapper<Entities.RAMtype, Models.RAMtype> ramtypeMapper = new RAMtypeMapper();
        public EntityMotherboard Map(ModelMotherboard motherboardModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelMotherboard, EntityMotherboard>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Socket, x => x.MapFrom(y => socketMapper.Map(y.Socket)))
            .ForMember(x => x.Chipset, x => x.MapFrom(y => chipsetMapper.Map(y.Chipset)))
            .ForMember(x => x.NumberOfDRAM, x => x.MapFrom(y => y.NumberOfDRAM))
            .ForMember(x => x.Interfaces, x => x.MapFrom(y => y.Interfaces))
            .ForMember(x => x.RAMtype, x => x.MapFrom(y => ramtypeMapper.Map(y.RAMtype)))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelMotherboard, EntityMotherboard>(motherboardModel);
            return model;
        }
        public ModelMotherboard Map(EntityMotherboard motherboardModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityMotherboard, ModelMotherboard>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Socket, x => x.MapFrom(y => socketMapper.Map(y.Socket)))
            .ForMember(x => x.Chipset, x => x.MapFrom(y => chipsetMapper.Map(y.Chipset)))
            .ForMember(x => x.NumberOfDRAM, x => x.MapFrom(y => y.NumberOfDRAM))
            .ForMember(x => x.Interfaces, x => x.MapFrom(y => y.Interfaces))
            .ForMember(x => x.RAMtype, x => x.MapFrom(y => ramtypeMapper.Map(y.RAMtype)))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntityMotherboard, ModelMotherboard>(motherboardModel);
            return model;
        }

        public IEnumerable<ModelMotherboard> Map(IEnumerable<EntityMotherboard> motherboardModel)
        {
            List<ModelMotherboard> models = new List<ModelMotherboard>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityMotherboard, ModelMotherboard>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Socket, x => x.MapFrom(y => socketMapper.Map(y.Socket)))
            .ForMember(x => x.Chipset, x => x.MapFrom(y => chipsetMapper.Map(y.Chipset)))
            .ForMember(x => x.NumberOfDRAM, x => x.MapFrom(y => y.NumberOfDRAM))
            .ForMember(x => x.Interfaces, x => x.MapFrom(y => y.Interfaces))
            .ForMember(x => x.RAMtype, x => x.MapFrom(y => ramtypeMapper.Map(y.RAMtype)))
            );
            var mapper = config.CreateMapper();
            foreach (var motherboard in motherboardModel)
            {
                var model = mapper.Map<EntityMotherboard, ModelMotherboard>(motherboard);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntityMotherboard> Map(IEnumerable<ModelMotherboard> motherboardModel)
        {
            if (motherboardModel != null)
            {
                List<EntityMotherboard> models = new List<EntityMotherboard>();
                foreach (var motherboard in motherboardModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelMotherboard, EntityMotherboard>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Socket, x => x.MapFrom(y => socketMapper.Map(y.Socket)))
            .ForMember(x => x.Chipset, x => x.MapFrom(y => chipsetMapper.Map(y.Chipset)))
            .ForMember(x => x.NumberOfDRAM, x => x.MapFrom(y => y.NumberOfDRAM))
            .ForMember(x => x.Interfaces, x => x.MapFrom(y => y.Interfaces))
            .ForMember(x => x.RAMtype, x => x.MapFrom(y => ramtypeMapper.Map(y.RAMtype)))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelMotherboard, EntityMotherboard>(motherboard);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

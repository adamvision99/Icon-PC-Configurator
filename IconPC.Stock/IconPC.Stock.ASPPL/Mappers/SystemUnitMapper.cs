using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntitySystemUnit = IconPC.Stock.Entities.SystemUnit;
using ModelSystemUnit = IconPC.Stock.ASPPL.Models.SystemUnit;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class SystemUnitMapper : IMapper<EntitySystemUnit, ModelSystemUnit>
    {
        IMapper<Entities.CPU, Models.CPU> cpuMapper = new CPUMapper();
        IMapper<Entities.Motherboard, Models.Motherboard> motherboardMapper = new MotherboardMapper();
        IMapper<Entities.RAM, Models.RAM> ramMapper = new RAMMapper();
        IMapper<Entities.VideoCard, Models.VideoCard> videocardMapper = new VideoCardMapper();
        IMapper<Entities.Cooling, Models.Cooling> coolingMapper = new CoolingMapper();
        IMapper<Entities.Drive, Models.Drive> driveMapper = new DriveMapper();
        IMapper<Entities.PowerUnit, Models.PowerUnit> powerunitMapper = new PowerUnitMapper();
        IMapper<Entities.Case, Models.Case> caseMapper = new CaseMapper();
        public EntitySystemUnit Map(ModelSystemUnit systemunitModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelSystemUnit, EntitySystemUnit>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Description, x => x.MapFrom(y => y.Description))
            .ForMember(x => x.Series, x => x.MapFrom(y => y.Series))
            .ForMember(x => x.CPU, x => x.MapFrom(y => cpuMapper.Map(y.CPU)))
            .ForMember(x => x.Motherboard, x => x.MapFrom(y => motherboardMapper.Map(y.Motherboard)))
            .ForMember(x => x.RAM, x => x.MapFrom(y => ramMapper.Map(y.RAM)))
            .ForMember(x => x.VideoCard, x => x.MapFrom(y => videocardMapper.Map(y.VideoCard)))
            .ForMember(x => x.Cooling, x => x.MapFrom(y => coolingMapper.Map(y.Cooling)))
            .ForMember(x => x.Drive, x => x.MapFrom(y => driveMapper.Map(y.Drive)))
            .ForMember(x => x.PowerUnit, x => x.MapFrom(y => powerunitMapper.Map(y.PowerUnit)))
            .ForMember(x => x.Case, x => x.MapFrom(y => caseMapper.Map(y.Case)))
            .ForMember(x => x.Price, x => x.MapFrom(y => y.Price))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelSystemUnit, EntitySystemUnit>(systemunitModel);
            return model;
        }
        public ModelSystemUnit Map(EntitySystemUnit systemunitModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntitySystemUnit, ModelSystemUnit>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Description, x => x.MapFrom(y => y.Description))
            .ForMember(x => x.Series, x => x.MapFrom(y => y.Series))
            .ForMember(x => x.CPU, x => x.MapFrom(y => cpuMapper.Map(y.CPU)))
            .ForMember(x => x.Motherboard, x => x.MapFrom(y => motherboardMapper.Map(y.Motherboard)))
            .ForMember(x => x.RAM, x => x.MapFrom(y => ramMapper.Map(y.RAM)))
            .ForMember(x => x.VideoCard, x => x.MapFrom(y => videocardMapper.Map(y.VideoCard)))
            .ForMember(x => x.Cooling, x => x.MapFrom(y => coolingMapper.Map(y.Cooling)))
            .ForMember(x => x.Drive, x => x.MapFrom(y => driveMapper.Map(y.Drive)))
            .ForMember(x => x.PowerUnit, x => x.MapFrom(y => powerunitMapper.Map(y.PowerUnit)))
            .ForMember(x => x.Case, x => x.MapFrom(y => caseMapper.Map(y.Case)))
            .ForMember(x => x.Price, x => x.MapFrom(y => y.Price))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntitySystemUnit, ModelSystemUnit>(systemunitModel);
            return model;
        }

        public IEnumerable<ModelSystemUnit> Map(IEnumerable<EntitySystemUnit> systemunitModel)
        {
            List<ModelSystemUnit> models = new List<ModelSystemUnit>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntitySystemUnit, ModelSystemUnit>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Description, x => x.MapFrom(y => y.Description))
            .ForMember(x => x.Series, x => x.MapFrom(y => y.Series))
            .ForMember(x => x.CPU, x => x.MapFrom(y => cpuMapper.Map(y.CPU)))
            .ForMember(x => x.Motherboard, x => x.MapFrom(y => motherboardMapper.Map(y.Motherboard)))
            .ForMember(x => x.RAM, x => x.MapFrom(y => ramMapper.Map(y.RAM)))
            .ForMember(x => x.VideoCard, x => x.MapFrom(y => videocardMapper.Map(y.VideoCard)))
            .ForMember(x => x.Cooling, x => x.MapFrom(y => coolingMapper.Map(y.Cooling)))
            .ForMember(x => x.Drive, x => x.MapFrom(y => driveMapper.Map(y.Drive)))
            .ForMember(x => x.PowerUnit, x => x.MapFrom(y => powerunitMapper.Map(y.PowerUnit)))
            .ForMember(x => x.Case, x => x.MapFrom(y => caseMapper.Map(y.Case)))
            .ForMember(x => x.Price, x => x.MapFrom(y => y.Price))
            );
            var mapper = config.CreateMapper();
            foreach (var systemunit in systemunitModel)
            {
                var model = mapper.Map<EntitySystemUnit, ModelSystemUnit>(systemunit);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntitySystemUnit> Map(IEnumerable<ModelSystemUnit> systemunitModel)
        {
            if (systemunitModel != null)
            {
                List<EntitySystemUnit> models = new List<EntitySystemUnit>();
                foreach (var systemunit in systemunitModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelSystemUnit, EntitySystemUnit>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Description, x => x.MapFrom(y => y.Description))
            .ForMember(x => x.Series, x => x.MapFrom(y => y.Series))
            .ForMember(x => x.CPU, x => x.MapFrom(y => cpuMapper.Map(y.CPU)))
            .ForMember(x => x.Motherboard, x => x.MapFrom(y => motherboardMapper.Map(y.Motherboard)))
            .ForMember(x => x.RAM, x => x.MapFrom(y => ramMapper.Map(y.RAM)))
            .ForMember(x => x.VideoCard, x => x.MapFrom(y => videocardMapper.Map(y.VideoCard)))
            .ForMember(x => x.Cooling, x => x.MapFrom(y => coolingMapper.Map(y.Cooling)))
            .ForMember(x => x.Drive, x => x.MapFrom(y => driveMapper.Map(y.Drive)))
            .ForMember(x => x.PowerUnit, x => x.MapFrom(y => powerunitMapper.Map(y.PowerUnit)))
            .ForMember(x => x.Case, x => x.MapFrom(y => caseMapper.Map(y.Case)))
            .ForMember(x => x.Price, x => x.MapFrom(y => y.Price))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelSystemUnit, EntitySystemUnit>(systemunit);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

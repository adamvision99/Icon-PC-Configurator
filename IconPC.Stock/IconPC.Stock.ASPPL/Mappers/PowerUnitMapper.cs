using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntityPowerUnit = IconPC.Stock.Entities.PowerUnit;
using ModelPowerUnit = IconPC.Stock.ASPPL.Models.PowerUnit;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class PowerUnitMapper : IMapper<EntityPowerUnit, ModelPowerUnit>
    {
        public EntityPowerUnit Map(ModelPowerUnit powerunitModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelPowerUnit, EntityPowerUnit>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Watt, x => x.MapFrom(y => y.Watt))
            .ForMember(x => x.Plus80, x => x.MapFrom(y => y.Plus80))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelPowerUnit, EntityPowerUnit>(powerunitModel);
            return model;
        }
        public ModelPowerUnit Map(EntityPowerUnit powerunitModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityPowerUnit, ModelPowerUnit>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Watt, x => x.MapFrom(y => y.Watt))
            .ForMember(x => x.Plus80, x => x.MapFrom(y => y.Plus80))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntityPowerUnit, ModelPowerUnit>(powerunitModel);
            return model;
        }

        public IEnumerable<ModelPowerUnit> Map(IEnumerable<EntityPowerUnit> powerunitModel)
        {
            List<ModelPowerUnit> models = new List<ModelPowerUnit>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityPowerUnit, ModelPowerUnit>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Watt, x => x.MapFrom(y => y.Watt))
            .ForMember(x => x.Plus80, x => x.MapFrom(y => y.Plus80))
            );
            var mapper = config.CreateMapper();
            foreach (var powerunit in powerunitModel)
            {
                var model = mapper.Map<EntityPowerUnit, ModelPowerUnit>(powerunit);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntityPowerUnit> Map(IEnumerable<ModelPowerUnit> powerunitModel)
        {
            if (powerunitModel != null)
            {
                List<EntityPowerUnit> models = new List<EntityPowerUnit>();
                foreach (var powerunit in powerunitModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelPowerUnit, EntityPowerUnit>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Watt, x => x.MapFrom(y => y.Watt))
            .ForMember(x => x.Plus80, x => x.MapFrom(y => y.Plus80))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelPowerUnit, EntityPowerUnit>(powerunit);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

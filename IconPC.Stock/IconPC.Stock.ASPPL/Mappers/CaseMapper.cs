using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntityCase = IconPC.Stock.Entities.Case;
using ModelCase = IconPC.Stock.ASPPL.Models.Case;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class CaseMapper : IMapper<EntityCase, ModelCase>
    {
        public EntityCase Map(ModelCase _caseModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelCase, EntityCase>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.MaximumCoolerHeight, x => x.MapFrom(y => y.MaximumCoolerHeight))
            .ForMember(x => x.MaximumVideoCardLength, x => x.MapFrom(y => y.MaximumVideoCardLength))
            .ForMember(x => x.WaterCoolingMount, x => x.MapFrom(y => y.WaterCoolingMount))
            .ForMember(x => x.Color, x => x.MapFrom(y => y.Color))
            .ForMember(x => x.FansNumber, x => x.MapFrom(y => y.FansNumber))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelCase, EntityCase>(_caseModel);
            return model;
        }
        public ModelCase Map(EntityCase _caseModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityCase, ModelCase>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.MaximumCoolerHeight, x => x.MapFrom(y => y.MaximumCoolerHeight))
            .ForMember(x => x.MaximumVideoCardLength, x => x.MapFrom(y => y.MaximumVideoCardLength))
            .ForMember(x => x.WaterCoolingMount, x => x.MapFrom(y => y.WaterCoolingMount))
            .ForMember(x => x.Color, x => x.MapFrom(y => y.Color))
            .ForMember(x => x.FansNumber, x => x.MapFrom(y => y.FansNumber))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntityCase, ModelCase>(_caseModel);
            return model;
        }

        public IEnumerable<ModelCase> Map(IEnumerable<EntityCase> _caseModel)
        {
            List<ModelCase> models = new List<ModelCase>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityCase, ModelCase>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.MaximumCoolerHeight, x => x.MapFrom(y => y.MaximumCoolerHeight))
            .ForMember(x => x.MaximumVideoCardLength, x => x.MapFrom(y => y.MaximumVideoCardLength))
            .ForMember(x => x.WaterCoolingMount, x => x.MapFrom(y => y.WaterCoolingMount))
            .ForMember(x => x.Color, x => x.MapFrom(y => y.Color))
            .ForMember(x => x.FansNumber, x => x.MapFrom(y => y.FansNumber))
            );
            var mapper = config.CreateMapper();
            foreach (var _case in _caseModel)
            {
                var model = mapper.Map<EntityCase, ModelCase>(_case);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntityCase> Map(IEnumerable<ModelCase> _caseModel)
        {
            if (_caseModel != null)
            {
                List<EntityCase> models = new List<EntityCase>();
                foreach (var _case in _caseModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelCase, EntityCase>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.MaximumCoolerHeight, x => x.MapFrom(y => y.MaximumCoolerHeight))
            .ForMember(x => x.MaximumVideoCardLength, x => x.MapFrom(y => y.MaximumVideoCardLength))
            .ForMember(x => x.WaterCoolingMount, x => x.MapFrom(y => y.WaterCoolingMount))
            .ForMember(x => x.Color, x => x.MapFrom(y => y.Color))
            .ForMember(x => x.FansNumber, x => x.MapFrom(y => y.FansNumber))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelCase, EntityCase>(_case);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

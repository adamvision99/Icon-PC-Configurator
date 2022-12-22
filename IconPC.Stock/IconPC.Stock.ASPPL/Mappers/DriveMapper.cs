using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using EntityDrive = IconPC.Stock.Entities.Drive;
using ModelDrive = IconPC.Stock.ASPPL.Models.Drive;

namespace IconPC.Stock.ASPPL.Mappers
{
    public class DriveMapper : IMapper<EntityDrive, ModelDrive>
    {
        public EntityDrive Map(ModelDrive driveModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelDrive, EntityDrive>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.Capacity, x => x.MapFrom(y => y.Capacity))
            .ForMember(x => x.WriteSpeed, x => x.MapFrom(y => y.WriteSpeed))
            .ForMember(x => x.ReadSpeed, x => x.MapFrom(y => y.ReadSpeed))
            .ForMember(x => x.TBW, x => x.MapFrom(y => y.TBW))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<ModelDrive, EntityDrive>(driveModel);
            return model;
        }
        public ModelDrive Map(EntityDrive driveModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityDrive, ModelDrive>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.Capacity, x => x.MapFrom(y => y.Capacity))
            .ForMember(x => x.WriteSpeed, x => x.MapFrom(y => y.WriteSpeed))
            .ForMember(x => x.ReadSpeed, x => x.MapFrom(y => y.ReadSpeed))
            .ForMember(x => x.TBW, x => x.MapFrom(y => y.TBW))
            );
            var mapper = config.CreateMapper();
            var model = mapper.Map<EntityDrive, ModelDrive>(driveModel);
            return model;
        }

        public IEnumerable<ModelDrive> Map(IEnumerable<EntityDrive> driveModel)
        {
            List<ModelDrive> models = new List<ModelDrive>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntityDrive, ModelDrive>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.Capacity, x => x.MapFrom(y => y.Capacity))
            .ForMember(x => x.WriteSpeed, x => x.MapFrom(y => y.WriteSpeed))
            .ForMember(x => x.ReadSpeed, x => x.MapFrom(y => y.ReadSpeed))
            .ForMember(x => x.TBW, x => x.MapFrom(y => y.TBW))
            );
            var mapper = config.CreateMapper();
            foreach (var drive in driveModel)
            {
                var model = mapper.Map<EntityDrive, ModelDrive>(drive);
                models.Add(model);
            }
            return models;
        }
        public IEnumerable<EntityDrive> Map(IEnumerable<ModelDrive> driveModel)
        {
            if (driveModel != null)
            {
                List<EntityDrive> models = new List<EntityDrive>();
                foreach (var drive in driveModel)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<ModelDrive, EntityDrive>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            .ForMember(x => x.Type, x => x.MapFrom(y => y.Type))
            .ForMember(x => x.Capacity, x => x.MapFrom(y => y.Capacity))
            .ForMember(x => x.WriteSpeed, x => x.MapFrom(y => y.WriteSpeed))
            .ForMember(x => x.ReadSpeed, x => x.MapFrom(y => y.ReadSpeed))
            .ForMember(x => x.TBW, x => x.MapFrom(y => y.TBW))
                );
                    var mapper = config.CreateMapper();
                    var model = mapper.Map<ModelDrive, EntityDrive>(drive);
                    models.Add(model);
                }

                return models;
            }
            else return null;
        }
    }
}

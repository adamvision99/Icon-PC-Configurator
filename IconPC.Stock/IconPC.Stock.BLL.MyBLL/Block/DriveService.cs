using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.BLL.Interfaces;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.BLL.MyBLL
{
    public class DriveService : IDriveService
    {
        private IDriveRepository _driveRepository;
        public DriveService(IDriveRepository driveRepository) =>
            _driveRepository = driveRepository;
        public Drive Add(Drive Drive)
        {
            return _driveRepository.Add(Drive);
        }

        public Drive Edit(int id, Drive Drive)
        {
            return _driveRepository.Edit(id, Drive);
        }

        public Drive Get(int id)
        {
            return _driveRepository.Get(id);
        }

        public IEnumerable<Drive> GetAll()
        {
            return _driveRepository.GetAll();
        }

        public void Remove(int id)
        {
            _driveRepository.Remove(id);
        }
    }
}

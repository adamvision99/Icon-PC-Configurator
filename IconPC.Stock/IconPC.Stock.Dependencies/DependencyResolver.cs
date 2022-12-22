using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.BLL.Interfaces;
using IconPC.Stock.DAL.Interfaces;
using IconPC.Stock.SQLDAL;
using IconPC.Stock.BLL.MyBLL;

namespace IconPC.Stock.Dependencies
{
    public class DependencyResolver
    {
        #region SINGLETONE

        private static DependencyResolver _instance = null;

        public static DependencyResolver Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DependencyResolver();

                return _instance;
            }
        }

        #endregion

        public IChipsetRepository ChipsetRepository => new ChipsetRepository();
        public IRAMRepository RAMRepository => new RAMRepository();
        public ISocketRepository SocketRepository => new SocketRepository();
        public ICaseRepository CaseRepository => new CaseRepository();
        public ICoolingRepository CoolingRepository => new CoolingRepository();
        public ICPURepository CPURepository => new CPURepository();
        public IDriveRepository driveRepository => new DriveRepository();
        public IMotherboardRepository motherboardRepository => new MotherboardRepository();
        public IPowerUnitRepository powerUnitRepository => new PowerUnitRepository();
        public IRAMtypeRepository rAMtypeRepository => new RAMtypeRepository();
        public IVideoCardRepository videoCardRepository => new VideoCardRepository();
        public ISystemUnitRepository systemUnitRepository => new SystemUnitRepository();

        public IChipsetService ChipsetService => new ChipsetService(ChipsetRepository);
        public IRAMtypeService rAMtypeService => new RAMtypeService(rAMtypeRepository);
        public ISocketService socketService => new SocketService(SocketRepository);
        public ICaseService caseService => new CaseService(CaseRepository);
        public ICoolingService coolingService => new CoolingService(CoolingRepository);
        public ICPUService cPUService => new CPUService(CPURepository);
        public IDriveService driveService => new DriveService(driveRepository);
        public IMotherboardService motherboardService => new MotherboardService(motherboardRepository);
        public IPowerUnitService powerUnitService => new PowerUnitService(powerUnitRepository);
        public IRAMService rAMService => new RAMService(RAMRepository);
        public IVideoCardService videoCardService => new VideoCardService(videoCardRepository);
        public ISystemUnitService systemUnitService => new SystemUnitService(systemUnitRepository);
    }
}

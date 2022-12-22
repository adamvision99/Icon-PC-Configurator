using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class DriveRepository : IDriveRepository
    {
        public Drive Add(Drive drive)
        {
            using (var context = new StockDbContext())
            {
                context.Drives.Add(drive);
                context.SaveChanges();

                return drive;
            }
        }

        public Drive Edit(int id, Drive drive)
        {
            using (var context = new StockDbContext())
            {
                var oldDrive = context.Drives.Where(x => x.Id == id).FirstOrDefault();

                oldDrive.Id = id;
                oldDrive.Name = drive.Name;
                oldDrive.Type = drive.Type;
                oldDrive.Capacity = drive.Capacity;
                oldDrive.WriteSpeed = drive.WriteSpeed;
                oldDrive.ReadSpeed = drive.ReadSpeed;
                oldDrive.TBW = drive.TBW;

                context.SaveChanges();

                return oldDrive;
            }
        }

        public Drive Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.Drives.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<Drive> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var drives = context.Drives.ToList();
                return drives;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableDrive = context.Drives
                    .FirstOrDefault(x => x.Id == id);

                context.Drives.Remove(removableDrive);

                context.SaveChanges();
            }
        }
    }
}

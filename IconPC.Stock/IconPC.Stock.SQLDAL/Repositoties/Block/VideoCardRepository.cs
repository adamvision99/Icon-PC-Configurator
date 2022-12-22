using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;
using IconPC.Stock.DAL.Interfaces;

namespace IconPC.Stock.SQLDAL
{
    public class VideoCardRepository : IVideoCardRepository
    {
        public VideoCard Add(VideoCard videocard)
        {
            using (var context = new StockDbContext())
            {
                context.VideoCards.Add(videocard);
                context.SaveChanges();

                return videocard;
            }
        }

        public VideoCard Edit(int id, VideoCard videocard)
        {
            using (var context = new StockDbContext())
            {
                var oldVideoCard = context.VideoCards.Where(x => x.Id == id).FirstOrDefault();

                oldVideoCard.Id = id;
                oldVideoCard.Name = videocard.Name;
                oldVideoCard.Desctription = videocard.Desctription;
                oldVideoCard.MemorySize = videocard.MemorySize;
                oldVideoCard.BusWidth = videocard.BusWidth;
                oldVideoCard.MinimumPowerSupply = videocard.MinimumPowerSupply;
                oldVideoCard.Length = videocard.Length;
                oldVideoCard.Connector = videocard.Connector;

                context.SaveChanges();

                return oldVideoCard;
            }
        }

        public VideoCard Get(int id)
        {
            using (var context = new StockDbContext())
            {
                var book = context.VideoCards.Where(x => x.Id == id).FirstOrDefault();
                return book;
            }
        }

        public IEnumerable<VideoCard> GetAll()
        {
            using (var context = new StockDbContext())
            {
                var videocards = context.VideoCards.ToList();
                return videocards;
            }
        }

        public void Remove(int id)
        {
            using (var context = new StockDbContext())
            {
                var removableVideoCard = context.VideoCards
                    .FirstOrDefault(x => x.Id == id);

                context.VideoCards.Remove(removableVideoCard);

                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconPC.Stock.Entities;

namespace IconPC.Stock.BLL.Interfaces
{
    public interface IVideoCardService
    {
        VideoCard Add(VideoCard VideoCard);
        VideoCard Edit(int id, VideoCard VideoCard);
        void Remove(int id);
        IEnumerable<VideoCard> GetAll();
        VideoCard Get(int id);
    }
}

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
    public class VideoCardService : IVideoCardService
    {
        private IVideoCardRepository _videocardRepository;
        public VideoCardService(IVideoCardRepository videocardRepository) =>
            _videocardRepository = videocardRepository;
        public VideoCard Add(VideoCard VideoCard)
        {
            return _videocardRepository.Add(VideoCard);
        }

        public VideoCard Edit(int id, VideoCard VideoCard)
        {
            return _videocardRepository.Edit(id, VideoCard);
        }

        public VideoCard Get(int id)
        {
            return _videocardRepository.Get(id);
        }

        public IEnumerable<VideoCard> GetAll()
        {
            return _videocardRepository.GetAll();
        }

        public void Remove(int id)
        {
            _videocardRepository.Remove(id);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using AspNetCoreVideo.Entities;
using AspNetCoreVideo.ViewModels;

namespace AspNetCoreVideo.Services
{
    public class MockVideoData : IVideoData
    {
        private List<Video> _videos;

        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video {Id = 1, Genre = Genres.Action, Title = "Shreck"},
                new Video {Id = 2, Genre = Genres.Comedy,Title = "Despicable Me"},
                new Video {Id = 3,Genre = Genres.Horror, Title = "Megamind"}
            };
        }

        public Video Get(int id)
        {
            return _videos.FirstOrDefault(v => v.Id.Equals(id));
        }

        public void Add(Video newVideo)
        {
            newVideo.Id = _videos.Max(v => v.Id) + 1;
            _videos.Add(newVideo);
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }
    }
}

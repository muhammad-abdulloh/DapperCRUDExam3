using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUDExam3.Domain.Models
{
    public class Music : BaseClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int SingerId { get; set; }
        public int Length { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }

        public virtual ICollection<Singer> Singers { get; set; }

        public Music()
        {
            Playlists = new List<Playlist>();

        }
    }
}
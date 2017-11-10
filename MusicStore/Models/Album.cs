using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public String Title { get; set; }

        public Artist Artist { get; set; }
    }
}
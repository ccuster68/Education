using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.ViewModels;

namespace AspNetCoreVideo.Entities
{
    public class Video
    {
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Title { get; set; }
        public Genres Genre { get; set; }
    }
}

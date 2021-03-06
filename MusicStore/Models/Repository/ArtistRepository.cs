﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models.Repository
{
    public class ArtistRepository : Repository<Artist>
    {
        public List<Artist> GetByName(String name)
        {
            return DbSet.Where(a => a.Name.Contains(name)).ToList();
        }

        public override void Update(Artist entity)
        {
            entity.Version++;
            base.Update(entity);
        }

        public List<SoloArtist> GetSoloArtists()
        {
            return DbSet.OfType<SoloArtist>().ToList();
        }
    }
}
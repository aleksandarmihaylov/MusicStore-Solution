using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class MusicStoreDataContextInitializer : DropCreateDatabaseAlways<MusicStoreDataContext>
    {
        protected override void Seed(MusicStoreDataContext context)
        {
            Artist artist = new Artist() { Name = "First Artist" };
            context.Artists.Add(artist);

            context.Artists.Add(new Artist() { Name = "Second Artist" });

            context.SaveChanges();
        }
    }
}
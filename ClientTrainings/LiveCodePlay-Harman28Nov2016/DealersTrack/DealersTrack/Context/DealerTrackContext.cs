using DealersTrack.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DealersTrack.Context
{
    public class DealerTrackContext:DbContext
    {
        public DbSet<State> States { get; set; }

        public DbSet<Dealer> Dealers { get; set; }

        public DbSet<Lendor> Lendors { get; set; }

        public DbSet<Application> Applications { get; set; }


    }
}
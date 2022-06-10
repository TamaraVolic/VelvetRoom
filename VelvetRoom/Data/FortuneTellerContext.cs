using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VelvetRoom.Models;

namespace VelvetRoom.Data
{
    public class FortuneTellerContext : DbContext
    {
        public FortuneTellerContext(DbContextOptions<FortuneTellerContext> options)
            : base(options)
        {
        }

        public DbSet<VelvetRoom.Models.FortuneTellerModel> FortuneTeller { get; set; }
    }
}
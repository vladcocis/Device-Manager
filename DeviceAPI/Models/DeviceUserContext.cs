using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceAPI.Models
{
    public class DeviceUserContext : DbContext
    {
        public DeviceUserContext(DbContextOptions<DeviceUserContext> options): base(options)
        {

        }
        //create new db table DeviceDetails
        public DbSet<DeviceDetail> DeviceDetails { get; set; }

        //create new db table Users
        public DbSet<User> Users { get; set; }
    }
}

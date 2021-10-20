using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceAPI.Models
{
    //fields in Users table
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Location { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Password { get; set; }
    }
}

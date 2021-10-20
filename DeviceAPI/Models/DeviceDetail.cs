using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceAPI.Models
{
    //fields in DeviceDetails table
    public class DeviceDetail
    {
        [Key]
        public int DeviceDetailID { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string DeviceName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Manufacturer { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string DeviceType { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string OS { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string OSVersion { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Processor { get; set; }

        [Column(TypeName = "int")]
        public int? RAM { get; set; }

        [ForeignKey("User")]
        public int? UserID { get; set; }

    }
}

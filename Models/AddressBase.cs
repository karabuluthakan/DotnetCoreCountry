using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCoreCountry.Models
{
    public abstract class AddressBase
    {
        [Key] [Column("id")] public long ID { get; set; }

        [Column("name")] public string Name { get; set; }

        [Column("created_date")] public DateTime CreatedDate { get; set; }
    }
}
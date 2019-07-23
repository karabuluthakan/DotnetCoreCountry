using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCoreCountry.Models
{
    [Table("countries")]
    public class Country : AddressBase
    {
        [Column("region_id", Order = 1)] public long RegionId { get; set; }
        [ForeignKey(nameof(RegionId))] public virtual Region Region { get; set; }
        [Column("alpha_2_code")] public string Alpha2Code { get; set; }
        [Column("alpha_3_code")] public string Alpha3Code { get; set; }
        [Column("un_code")] public int UNCode { get; set; } 
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCoreCountry.Models
{
    [Table("regions")]
    public class Region : AddressBase
    {
        [Column("continental_id",Order = 1)]  public long ContinentalId { get; set; }
        [ForeignKey(nameof(ContinentalId))] public virtual Continental Continental { get; set; }
    }
}
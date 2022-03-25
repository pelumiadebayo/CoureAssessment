using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryDetails.Model
{
    public class CountryDetail
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace capstone.Model
{
    public class offers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public long SimNumber { get; set; }
        public long ServiceNumber { get; set; }
        public long Price { get; set; }
        public string? NetData { get; set; }
        public string? Sms { get; set; }
        public long Validity { get; set; }
        public string? Otherbenifits { get; set; }
    }
}

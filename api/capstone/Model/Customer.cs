using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace capstone.Model
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? DOB { get; set; }
        public long SimNumber { get; set; }
        public long ServiceNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? AdharNumber { get; set; }
        public bool? Simstatus { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public long PinCode { get; set; }
    }

    public class JSonResponse
    {
        public bool IsSuccess { get; set; }
        public string Errorcode { get; set; }
        public string ErrorMessage { get; set; }
        public object Result { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace PetConn.Model.Requests
{
    public class GradUpsert//baca error na get , ista kalas na uspert i search
    {
        //[Required]
        public int DrzavaId { get; set; }
        //[Required(AllowEmptyStrings =false)]    
        public string Naziv { get; set; }
        //[Required]
        //[MinLength(5)]
        public string PostanskiBroj { get; set; }
    }
}

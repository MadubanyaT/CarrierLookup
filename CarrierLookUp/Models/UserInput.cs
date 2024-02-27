using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarrierLookUp.Models
{
    //Validating
    public class UserInput
    {
        public string Carrier = "";
        [Required(ErrorMessage = "Please type a valid cellphone number."), StringLength(10, ErrorMessage ="Must be 10 digits.")]
        public string CNumber { get; set; }
    }
}
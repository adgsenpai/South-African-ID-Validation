using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;

namespace SouthAfricanIDValidation.Pages
{
    public class validateidModel : PageModel
    {
        public string output { get; set; }
        public void OnGet(string idnumber)
        {
           var ex = @"(((\d{2}((0[13578]|1[02])(0[1-9]|[12]\d|3[01])|(0[13456789]|1[012])(0[1-9]|[12]\d|30)|02(0[1-9]|1\d|2[0-8])))|([02468][048]|[13579][26])0229))(( |-)(\d{4})( |-)(\d{3})|(\d{7}))";
           Regex re = new Regex(ex);
            if (re.IsMatch(idnumber))
            {
                output = "ID Number is valid :-)";
            }
            else
            {
                output = "ID Number is invalid";

            }
        }
    }
}

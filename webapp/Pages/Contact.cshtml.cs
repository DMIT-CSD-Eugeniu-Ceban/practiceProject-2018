using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ContactModel : PageModel
    {
        public string Text1{ get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        



        public string ErrorMessage { get; set; }
        public string SucessMessage { get; set; }


        public void OnGet()
        {
        }
    }
}

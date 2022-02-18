using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ContactModel : PageModel
    {
        public string Text1 { get; set; }
        [BindProperty]
        public string Text2 { get; set; }
        [BindProperty]
        public string Text3 { get; set; }
        public int Number1 { get; set; }
        [BindProperty]
        public int Number2 { get; set; }
        [BindProperty]
        public int Number3 { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public DateTime MyDate { get; set; }
        public List<string> SelectListOfSubjects { get; set; }
        [BindProperty]
        public int SelectedSubjectId { get; set; }
        [BindProperty]
        public string MessageBody { get; set; }
        [BindProperty]
        public string CheckBox { get; set; }
        [BindProperty]
        public string Radio { get; set; }
        [BindProperty]
        public string Range { get; set; }
        [BindProperty]
        public string ButtonPressed { get; set; }
        public string SucessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<Exception> errors { get; set; } = new();

        public void OnGet()
        {
            Console.WriteLine($"ContactModel: OnGet");
            PopulateSelectLists();
        }

        public IActionResult OnPost(string text1, string number1)
        {

        }


























    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StratagemsGame.Pages.Game
{
    public class GamePageModel : PageModel
    {
        Stratagems stratagems = new Stratagems();
        [BindProperty]
        public List<CodeCategory> CodeList { get; set; } = new List<CodeCategory>();
        [BindProperty]
        public List<int> CurrentSequence { get; set; }
        public int? CurrentLevel { get; set; } 
        [BindProperty]
        public string? StratName { get; set; }
        [BindProperty]
        public string? CategoryName { get; set; }
        public int Score { get; set; } = 0;
        [BindProperty]
        public string ImagePath { get; set; } = string.Empty;

        public void OnGet()
        {

            GenerateSequence();
        }
        public IActionResult OnGetNext()
        {
            GenerateSequence();
;           string result = "<div class='card-header' hx-target='#card-header' hx-swap='innerHtml'>"+ CategoryName+ "</div><div class='card-body'><h5 class='card-title'>"+StratName+"</h5><span><img class='sicon' src='"+ImagePath+"'/></i></span><table id='table'>";
            foreach(var code in CurrentSequence)
            {
                result += $@"<td class='arrow'><span id='{code}' class='bi bi-{arrowIcons[code]}' style='font-size: 40px;'></span></td>";
            }
            result += "</table><div hidden><input type='text' id=cseq value='"+CurrentSequence+"'></div>";
            return Content(result);
        }

        public async void GenerateSequence()
        {
            CodeList = stratagems.codeList;
            CodeCategory category = CodeList[Random.Shared.Next(CodeList.Count)];
            CodeSequence sequence = category.Sequences[Random.Shared.Next(category.Sequences.Count)];
            CategoryName = category.Name;
            StratName = sequence.Name;
            CurrentSequence = sequence.Keys;
            ImagePath = sequence.ImagePath;
        }

        public Dictionary<int, string> arrowIcons = new Dictionary<int, string>
        {
            {37, "arrow-left"},
            {38, "arrow-right"},
            {39, "arrow-up"},
            {40, "arrow-down"}
        }; 
        public Dictionary<int, string>KeyNames = new Dictionary<int, string>{
            {37,"ArrowLeft"},
            {38, "ArrowRight"},
            {39, "ArrowUp"},
            {40, "ArrowDown"}
        };
    }
}

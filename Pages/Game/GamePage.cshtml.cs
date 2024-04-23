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
        public string? StratName { get; set; }
        public string? CategoryName { get; set; }
        public int Score { get; set; } = 0;

        public void OnGet()
        {

            GenerateSequence();
        }

        public void GenerateSequence()
        {
            CodeList = stratagems.codeList;
            CodeCategory category = CodeList[Random.Shared.Next(CodeList.Count)];
            CodeSequence sequence = category.Sequences[Random.Shared.Next(category.Sequences.Count)];
            CategoryName = category.Name;
            StratName = sequence.Name;
            CurrentSequence = sequence.Keys;
        }

        public Dictionary<int, string> arrowIcons = new Dictionary<int, string>
    {
        {37, "arrow-left"},
        {38, "arrow-right"},
        {39, "arrow-up"},
        {40, "arrow-down"}
    };
    }
}

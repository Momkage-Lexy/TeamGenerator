using System.ComponentModel.DataAnnotations;
namespace TeamGenerator2.Models;

public class Names
{
    [Required(ErrorMessage = "Name is required")]
    public string NameInput { get; set; } = string.Empty;

    [Required(ErrorMessage = "Team size is required")]
    public int TeamSize { get; set; }

    public List<string> NameList 
    { 
        get 
        {
            // Split the input string by newline into a list of names
            return NameInput.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }

    public override string ToString()
    {
        return $"{NameList} {TeamSize}";
    }
}

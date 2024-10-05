using System.ComponentModel.DataAnnotations;
namespace TeamGenerator2.Models;

public class Names
{
    [Required(ErrorMessage = "Name is required")]
    public List<string> Name { get; set;} = new List<string>();

    [Required(ErrorMessage = "Name is required")]
    public int TeamSize { get; set;}


    public override string ToString()
    {
        return $"{Name} {TeamSize}";
    
    }
}

//Shuffle list

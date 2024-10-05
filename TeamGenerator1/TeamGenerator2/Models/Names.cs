using System.ComponentModel.DataAnnotations;
namespace Homework1.Models;

public class Names
{
    [Required(ErrorMessage = "Name is required")]
    public List<string> Name { get; set;}

    [Required(ErrorMessage = "Name is required")]
    public int TeamSize { get; set;}

    public override string ToString()
    {
        return $"{Name} {TeamSize}";
    
    }
}

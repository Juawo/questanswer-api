using System.ComponentModel.DataAnnotations;
namespace QuestAnswerApi.Models;

public class Card
{
    [Key]
    public  long Id { get; set; }
    public  string Answer { get; set; }
    public  string Category { get; set; }
    public  List<string> Tips { get; set; }

    public Card() { }
    public Card(string answer, string category, List<string> tips)
    {
        Answer = answer;
        Category = category;
        Tips = tips;
    }
}
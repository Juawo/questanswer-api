using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestAnswerApi.Models
{
    public class Card
    {
        [Key]
        public required int Id { get; set; }
        public required string Answer { get; set; }
        public required string Category { get; set; }
        public required List<string> Tips { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnToTech.Database.Enities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Label { get; set; }
        public List<Training> Trainings { get; set; } = new List<Training>();
    }
}

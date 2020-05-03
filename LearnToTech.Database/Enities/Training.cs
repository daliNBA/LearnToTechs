using System;
using System.Collections.Generic;
using System.Text;

namespace LearnToTech.Database.Enities
{
    public class Training
    {
        public int TrainingId { get; set; }
        public string Label { get; set; }
        public decimal Price { get; set; }
        public bool IsSubtitled { get; set; }
        public bool IsActive { get; set; }
    }
}

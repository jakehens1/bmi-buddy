using System;

namespace BMI.Buddy.Models
{

    public class Metric
    {
        public double meters { get; set; }
        public double kilos { get; set; }
        public double BMI { get; set; }
        public string BMICategory { get; set; }
        public double healthyBMI { get; set; }
        public double idealWeight { get; set; }
        public double difference {get; set; }

    }
}
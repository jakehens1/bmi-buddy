using System;

namespace BMI.Buddy.Models
{

    public class Imperial
    {
        public int feet { get; set; }
        public double inches { get; set; }
        public double pounds { get; set; }
        public double BMI { get; set; }
        public string BMICategory { get; set; }
        public double healthyBMI { get; set; }
        public double idealWeight { get; set; }
        public double difference {get; set; }


    }
}
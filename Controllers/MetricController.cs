using BMI.Buddy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BMI.Buddy.Controllers
{

    public class MetricController : Controller
    {

        public IActionResult Calculate()
        {
            return View();
        }

        public IActionResult Results(Metric metInputs)
        {
            metInputs.healthyBMI = 21.7;
            metInputs.BMI = Math.Round(metInputs.kilos/(metInputs.meters*metInputs.meters),2);
            metInputs.idealWeight = Math.Round((metInputs.healthyBMI*(metInputs.meters*metInputs.meters)),2);
            metInputs.difference = metInputs.kilos - metInputs.idealWeight;           
            if (metInputs.BMI >= 30)
            {
                metInputs.BMICategory = "OBESE";
            }
            else if (metInputs.BMI >= 25)
            {
                metInputs.BMICategory = "OVERWEIGHT";
            }
            else if (metInputs.BMI >= 18.5)
            {
                metInputs.BMICategory = "NORMAL";
            }
            else
            {
                metInputs.BMICategory = "UNDERWEIGHT";
            }
            return View(metInputs);
        }
    }
}
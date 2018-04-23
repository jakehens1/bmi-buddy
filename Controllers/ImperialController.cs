using BMI.Buddy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BMI.Buddy.Controllers
{

    public class ImperialController : Controller
    {

        public IActionResult Calculate()
        {
            return View();
        }

        public IActionResult Results(Imperial impInputs)
        {
            impInputs.healthyBMI = 21.7;
            impInputs.BMI = Math.Round(703*(impInputs.pounds/(((impInputs.feet*12)+impInputs.inches)*((impInputs.feet*12)+impInputs.inches))),2);
            impInputs.idealWeight = Math.Round((impInputs.healthyBMI*(((impInputs.feet*12)+impInputs.inches)*((impInputs.feet*12)+impInputs.inches)))/703,2);
            impInputs.difference = impInputs.pounds - impInputs.idealWeight;           
            if (impInputs.BMI >= 30)
            {
                impInputs.BMICategory = "OBESE";
            }
            else if (impInputs.BMI >= 25)
            {
                impInputs.BMICategory = "OVERWEIGHT";
            }
            else if (impInputs.BMI >= 18.5)
            {
                impInputs.BMICategory = "NORMAL";
            }
            else
            {
                impInputs.BMICategory = "UNDERWEIGHT";
            }
            return View(impInputs);
        }
    }
}
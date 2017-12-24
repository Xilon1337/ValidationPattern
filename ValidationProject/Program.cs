﻿using System;
using ValidationProject.Interfaces;
using ValidationProject.ValidationSteps;

namespace ValidationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IValidationStep Step = new WorldValidation();
            IValidationStep Step2 = new PolandValidation();

            Console.WriteLine(Step.Validate());
            Console.WriteLine(Step2.Validate());
        }
    }
}
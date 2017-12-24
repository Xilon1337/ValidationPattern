using System;
using System.Collections.Generic;
using System.Linq;
using ValidationProject.Interfaces;
using ValidationProject.ValidationConfigurations;
using ValidationProject.ValidationSteps;

namespace ValidationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimaryValidationConfigurator validation = new PrimaryValidationConfigurator();
            validation.Register();
            Console.WriteLine(validation.Validate());
        }
    }
}

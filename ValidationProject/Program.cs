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


            Console.WriteLine();
            List<bool> lista = new List<bool>() { true, false, false };

            var xa = lista.Any(x => x == true);

            Console.WriteLine(xa);
        }
    }
}

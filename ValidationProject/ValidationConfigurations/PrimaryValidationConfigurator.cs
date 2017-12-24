using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationProject.Abstracts;
using ValidationProject.ValidationSteps;

namespace ValidationProject.ValidationConfigurations
{
    public class PrimaryValidationConfigurator : ValidationConfiguration
    {
        public PrimaryValidationConfigurator()
        {

        }

        public override void Register()
        {
            this.AddStep(new WorldValidation());
            this.AddStep(new PolandValidation());
        }
    }
}

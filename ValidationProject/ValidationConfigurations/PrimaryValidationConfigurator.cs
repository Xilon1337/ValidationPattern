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

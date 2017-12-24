using System;
using System.Collections.Generic;
using System.Linq;
using ValidationProject.Interfaces;

namespace ValidationProject.Abstracts
{
    public abstract class ValidationConfiguration : IValidationConfiguration
    {
        private List<IValidationStep> _steps { get; set; }

        public ValidationConfiguration()
        {
            _steps = new List<IValidationStep>();
        }
        public void AddStep(IValidationStep step)
        {
            _steps.Add(step);
        }

        public abstract void Register();

        public bool Validate()
        {
            var value = _steps.Any(x => x.Validate() == false);

            return !_steps.Any(x => x.Validate() == false);
        }
    }
}

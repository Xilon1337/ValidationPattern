using System;
using ValidationProject.Interfaces;

namespace ValidationProject.Abstracts
{
    abstract class ValidationConfiguration : IValidationConfiguration
    {
        public ValidationConfiguration()
        {

        }
        public void AddStep(IValidationStep step)
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            throw new NotImplementedException();
        }
    }
}

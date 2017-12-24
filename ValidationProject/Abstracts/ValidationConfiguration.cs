using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

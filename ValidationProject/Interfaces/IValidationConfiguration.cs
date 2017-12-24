using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationProject.Interfaces
{
    public interface IValidationConfiguration
    {
        void Register();

        void AddStep(IValidationStep step);
    }
}

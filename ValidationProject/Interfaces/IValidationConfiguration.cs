namespace ValidationProject.Interfaces
{
    public interface IValidationConfiguration
    {
        void Register();

        void AddStep(IValidationStep step);
    }
}

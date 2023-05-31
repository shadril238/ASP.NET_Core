namespace DI_Service_Lifetime.Services
{
    public class SingletonGuidService : ISingletonGuidService
    {
        private readonly Guid Id;
        public SingletonGuidService()
        {
            this.Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}

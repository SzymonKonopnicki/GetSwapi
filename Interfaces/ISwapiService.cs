namespace GetSwapi.Interfaces
{
    public interface ISwapiService
    {
        public IEnumerable<T> GetList<T>(string url) where T : BaseResource;
        public T GetPerson<T>(int id, string url) where T : BaseResource;
    }
}

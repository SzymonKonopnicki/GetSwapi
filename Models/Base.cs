namespace GetSwapi.Models
{
    public class Base<T> : BaseResource where T : BaseResource
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<T> results { get; set; }

    }
}

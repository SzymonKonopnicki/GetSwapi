namespace GetSwapi.Models
{
    public class Base
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Person> results { get; set; }

    }
}

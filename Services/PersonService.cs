namespace GetSwapi.Services
{
    public class PersonService : IPersonService
    {
        private readonly SwapiUrl _url;
        public PersonService(SwapiUrl url) 
        {
            _url = url;
        }
        public List<Person> GetPersons()
        {
            var request = WebRequest.Create(_url.People);

            request.Method = "GET";
            using var webResonse = request.GetResponse();
            using var webStream = webResonse.GetResponseStream();

            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            Base model = JsonConvert.DeserializeObject<Base>(data);

            return model.results.ToList();
        }
        public Person GetPerson(int id)
        {
            var request = WebRequest.Create(_url.People + id);

            request.Method = "GET";
            using var webResonse = request.GetResponse();
            using var webStream = webResonse.GetResponseStream();

            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            Person deserializedPerson = JsonConvert.DeserializeObject<Person>(data);
           
            return deserializedPerson;
        }
    }
}

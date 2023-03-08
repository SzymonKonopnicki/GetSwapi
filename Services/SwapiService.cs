namespace GetSwapi.Services
{
    public class SwapiService : ISwapiService
    {
        public IEnumerable<T> GetList<T>(string url) where T : BaseResource
        {
            var request = System.Net.WebRequest.Create(url);

            WebResponse webResonse;
            Stream webStream;
            StreamReader reader;
            string data;
            WebRequest(request, out webResonse, out webStream, out reader, out data);

            Base<T> model = JsonConvert.DeserializeObject<Base<T>>(data);

            return model.results.ToList();
        }
        public T GetPerson<T>(int id, string url) where T : BaseResource
        {
            var request = System.Net.WebRequest.Create(url + id);

            WebResponse webResonse;
            Stream webStream;
            StreamReader reader;
            string data;
            WebRequest(request, out webResonse, out webStream, out reader, out data);

            var deserialized = JsonConvert.DeserializeObject<T>(data);

            return deserialized;
        }

        private static void WebRequest(WebRequest request, out WebResponse webResonse, out Stream webStream, out StreamReader reader, out string data)
        {
            request.Method = "GET";
            webResonse = request.GetResponse();
            webStream = webResonse.GetResponseStream();
            reader = new StreamReader(webStream);
            data = reader.ReadToEnd();
        }

    }
}

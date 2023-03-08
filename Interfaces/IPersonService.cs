using GetSwapi.Models;

namespace GetSwapi.Interfaces
{
    public interface IPersonService
    {
        public List<Person> GetPersons();
        public Person GetPerson(int id);
    }
}

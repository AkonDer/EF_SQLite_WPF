using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SQLite_WPF
{
    public interface IPerson
    {
        Task<bool> HasData();
        Task EnsurePersonStore();
        Task<List<Person>> GetPersons();
        Task AddPerson(Person person);
        Task RemovePerson(Person person);
        Task UpdatePerson(Person person);
        Task SavePerson(Person person);
    }
}

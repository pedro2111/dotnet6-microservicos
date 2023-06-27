using System;
using ApiRestUdemy.Model;

namespace ApiRestUdemy.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> listPerson = new List<Person>();

            for(int i = 0; i < 8; i++)
            {
                Person person = mockPerson(i);
                listPerson.Add(person);
            }
            return listPerson;
        }

        

        public Person FindById(long id)
        {
            return new Person { Id = 1, Nome = "Pedro", Sobrenome = "Chaves", Endereco = "Riacho fundo 1", Genero = "masc" };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person mockPerson(int i)
        {
            return new Person { Id = i, Nome = "Pedro " + i, Sobrenome = "Chaves " + i, Endereco = "Riacho fundo 1", Genero = "masc" };
        }
    }
}


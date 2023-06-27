using System;
using ApiRestUdemy.Model;

namespace ApiRestUdemy.Services.Implementations
{
	public interface IPersonService
	{
		Person Create(Person person);
		Person FindById(long id);
		Person Update(Person person);
		void Delete(long id);
		List<Person> FindAll();
	}
}


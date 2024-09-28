using Shared.Entities;

namespace Shared.IRepositories;

public interface IUserRepository
{
	User? GetById(int id);

	// later disable GetAll method
	List<User> GetAll();

	//List<User> GetBySearch();

	List<User> GetByIds(IEnumerable<int> ids);

	User Add(User user);

	User Update(User user);

	void DeleteById(int id);

	bool Exists(int id);
}
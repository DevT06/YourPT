using YourPT.Shared.Entities;
using Shared.Interfaces.IRepositories;

namespace YourPT.DataAccess.EFCore.Repositories;

public class UserRepository : IUserRepository
{
	private readonly YourPTDbContext _context;

	public UserRepository(YourPTDbContext context)
	{
		_context = context;
	}


	public User? GetById(int id)
	{
		throw new NotImplementedException();
	}

	public List<User> GetAll()
	{
		throw new NotImplementedException();
	}

	public List<User> GetByIds(IEnumerable<int> ids)
	{
		throw new NotImplementedException();
	}

	public User Add(User user)
	{
		throw new NotImplementedException();
	}

	public User Update(User user)
	{
		throw new NotImplementedException();
	}

	public void DeleteById(int id)
	{
		throw new NotImplementedException();
	}

	public bool Exists(int id)
	{
		throw new NotImplementedException();
	}
}
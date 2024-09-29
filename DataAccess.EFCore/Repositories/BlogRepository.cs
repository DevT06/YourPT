using Shared.Entities;
using Shared.IRepositories;

namespace DataAccess.EFCore.Repositories;

public class BlogRepository : IBlogRepository
{
	private readonly YourPTDbContext _context;

	public BlogRepository(YourPTDbContext context)
	{
		_context = context;
	}


	public Blog? GetById(int id)
	{
		throw new NotImplementedException();
	}

	public List<Blog> GetAll()
	{
		throw new NotImplementedException();
	}

	public List<Blog> GetByIds(IEnumerable<int> ids)
	{
		throw new NotImplementedException();
	}

	public Blog Add(Blog blog)
	{
		throw new NotImplementedException();
	}

	public Blog Update(Blog blog)
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
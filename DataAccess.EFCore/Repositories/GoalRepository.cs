using Shared.Entities;
using Shared.IRepositories;

namespace DataAccess.EFCore.Repositories;

public class GoalRepository : IGoalRepository
{
	private readonly YourPTDbContext _context;

	public GoalRepository(YourPTDbContext context)
	{
		_context = context;
	}


	public Goal? GetById(int id)
	{
		throw new NotImplementedException();
	}

	public List<Goal> GetByIds(IEnumerable<int> ids)
	{
		throw new NotImplementedException();
	}

	public List<Goal> GetAll()
	{
		throw new NotImplementedException();
	}

	public Goal Add(Goal goal)
	{
		throw new NotImplementedException();
	}

	public Goal Update(Goal goal)
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
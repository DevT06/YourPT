using Shared.Entities;
using Shared.IRepositories;

namespace DataAccess.EFCore.Repositories;

public class GoalReflectionRepository : IGoalReflectionRepository
{
	private readonly YourPTDbContext _context;

	public GoalReflectionRepository(YourPTDbContext context)
	{
		_context = context;
	}


	public GoalReflection? GetById(int id)
	{
		throw new NotImplementedException();
	}

	public List<GoalReflection> GetAll()
	{
		throw new NotImplementedException();
	}

	public GoalReflection Add(GoalReflection goalReflection)
	{
		throw new NotImplementedException();
	}

	public GoalReflection Update(GoalReflection goalReflection)
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
using Shared.Entities;
using Shared.IRepositories;

namespace DataAccess.EFCore.Repositories;

public class AssignmentReflectionRepository : IAssignmentReflectionRepository
{
	private readonly YourPTDbContext _context;

	public AssignmentReflectionRepository(YourPTDbContext context)
	{
		_context = context;
	}


	public AssignmentReflection? GetById(int id)
	{
		throw new NotImplementedException();
	}

	public List<AssignmentReflection> GetAll()
	{
		throw new NotImplementedException();
	}

	public AssignmentReflection Add(AssignmentReflection reflection)
	{
		throw new NotImplementedException();
	}

	public AssignmentReflection Update(AssignmentReflection reflection)
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
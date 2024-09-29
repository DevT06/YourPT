using Shared.Entities;
using Shared.IRepositories;

namespace DataAccess.EFCore.Repositories;

public class AssignmentRepository : IAssignmentRepository
{
	private readonly YourPTDbContext _context;

	public AssignmentRepository(YourPTDbContext context)
	{
		_context = context;
	}


	public Assignment? GetById(int id)
	{
		throw new NotImplementedException();
	}

	public List<Assignment> GetByIds(IEnumerable<int> ids)
	{
		throw new NotImplementedException();
	}

	public List<Assignment> GetAll()
	{
		throw new NotImplementedException();
	}

	public Assignment Add(Assignment assignment)
	{
		throw new NotImplementedException();
	}

	public Assignment Update(Assignment assignment)
	{
		throw new NotImplementedException();
	}

	public Assignment DeleteById(int id)
	{
		throw new NotImplementedException();
	}
}
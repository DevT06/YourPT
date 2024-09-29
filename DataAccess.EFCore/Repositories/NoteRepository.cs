using Shared.Entities;
using Shared.IRepositories;

namespace DataAccess.EFCore.Repositories;

public class NoteRepository : INoteRepository
{
	private readonly YourPTDbContext _context;

	public NoteRepository(YourPTDbContext context)
	{
		_context = context;
	}


	public Note? GetById(int id)
	{
		throw new NotImplementedException();
	}

	public List<Note> GetByIds(IEnumerable<int> ids)
	{
		throw new NotImplementedException();
	}

	public List<Note> GetAll()
	{
		throw new NotImplementedException();
	}

	public Note Add(Note note)
	{
		throw new NotImplementedException();
	}

	public Note Update(Note note)
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
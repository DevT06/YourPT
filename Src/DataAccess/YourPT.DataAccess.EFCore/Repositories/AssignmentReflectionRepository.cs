using Microsoft.EntityFrameworkCore;
using YourPT.Shared.Entities;
using Shared.Interfaces.IRepositories;

namespace YourPT.DataAccess.EFCore.Repositories;

public class AssignmentReflectionRepository : IAssignmentReflectionRepository
{
	private readonly YourPTDbContext _context;

	public AssignmentReflectionRepository(YourPTDbContext context)
	{
		_context = context;
	}

	public async Task<AssignmentReflection?> GetByIdAsync(int id)
	{
		return await _context.AssignmentReflections
			//.Include(a => a.Assignment)
			//.FirstOrDefaultAsync(a => a.Id == id)
			.FindAsync(id);
	}

	public async Task<List<AssignmentReflection>> GetAllAsync()
	{
		return await _context.AssignmentReflections
			.ToListAsync();
	}

	public async Task<AssignmentReflection> AddAsync(AssignmentReflection reflection)
	{
		//?
		_context.Assignments.Attach(reflection.Assignment);
		_context.Users.Attach(reflection.User);

		_context.AssignmentReflections.Add(reflection);
		await _context.SaveChangesAsync();
		return reflection;
	}

	public async Task<AssignmentReflection> UpdateAsync(AssignmentReflection reflection)
	{
		// not necessary because cannot be changed? remove later
		// Check if the Assignment entity is already tracked by the context
		if (_context.Assignments.Local.All(a => a.Id != reflection.Assignment.Id))
		{
			_context.Assignments.Attach(reflection.Assignment);
		}

		// Check if the User entity is already tracked by the context
		if (_context.Users.Local.All(u => u.Id != reflection.User.Id))
		{
			_context.Users.Attach(reflection.User);
		}

		_context.AssignmentReflections.Update(reflection);
		await _context.SaveChangesAsync();

		return reflection;
	}

	public async void DeleteByIdAsync(int id)
	{
		var existingReflection = GetByIdAsync(id);

		//replaces exists method
		if (existingReflection == null) return;

		_context.AssignmentReflections.Remove(await existingReflection);
		await _context.SaveChangesAsync();
	}


	#region Non Async Methods DONT USE IN PRODUCTION!

	public AssignmentReflection? GetById(int id)
	{
		return _context.AssignmentReflections
			.Find(id);
	}

	public List<AssignmentReflection> GetAll()
	{
		return _context.AssignmentReflections
			.ToList();
	}

	public AssignmentReflection Add(AssignmentReflection reflection)
	{
		_context.Assignments.Attach(reflection.Assignment);
		_context.Users.Attach(reflection.User);

		_context.AssignmentReflections.Add(reflection);
		_context.SaveChanges();
		return reflection;
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

	#endregion
}
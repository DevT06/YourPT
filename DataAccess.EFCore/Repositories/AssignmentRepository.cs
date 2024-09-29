using Microsoft.EntityFrameworkCore;
using Shared.AbstractEntities;
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


	public async Task<Assignment?> GetByIdAsync(int id)
	{
		return await _context.Assignments
			.FindAsync(id);
	}

	public async Task<List<Assignment>> GetByIdsAsync(IEnumerable<int> ids)
	{
		return await _context.Assignments
			.Where(a => ids.Contains(a.Id))
			.ToListAsync();
	}

	public async Task<List<Assignment>> GetAllAsync()
	{
		return await _context.Assignments
			.ToListAsync();
	}

	public async Task<Assignment> AddAsync(Assignment assignment)
	{
		//?
		if (assignment.Reflection != null)
		{
			_context.AssignmentReflections.Attach(assignment.Reflection);
		}

		_context.Goals.Attach(assignment.Goal);
		_context.Users.Attach(assignment.User);

		_context.Assignments.Add(assignment);
		await _context.SaveChangesAsync();
		return assignment;
	}

	public async Task<Assignment> UpdateAsync(Assignment assignment)
	{
		// not necessary because cannot be changed? remove later
		// Check if the Assignment entity is already tracked by the context
		if (_context.AssignmentReflections.Local.All(a => a.Id != assignment.Reflection.Id))
		{
			_context.AssignmentReflections.Attach(assignment.Reflection);
		}

		// Check if the User entity is already tracked by the context
		if (_context.Users.Local.All(u => u.Id != assignment.User.Id))
		{
			_context.Users.Attach(assignment.User);
		}

		if (_context.Goals.Local.All(u => u.Id != assignment.Goal.Id)) //GoalId works to?
		{
			_context.Goals.Attach(assignment.Goal);
		}

		_context.Assignments.Update(assignment);
		await _context.SaveChangesAsync();

		return assignment;
	}

	public async void DeleteByIdAsync(int id)
	{
		var existingAssignment = GetByIdAsync(id);

		//replaces exists method
		if (existingAssignment == null) return;

		_context.Assignments.Remove(await existingAssignment);
		await _context.SaveChangesAsync();
	}
}
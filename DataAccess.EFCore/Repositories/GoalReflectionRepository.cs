using Microsoft.EntityFrameworkCore;
using Shared.AbstractEntities;
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


	public async Task<GoalReflection?> GetByIdAsync(int id)
	{
		return await _context.GoalReflections
			.FindAsync(id);
	}

	public async Task<List<GoalReflection>> GetAllAsync()
	{
		return await _context.GoalReflections
			.ToListAsync();
	}

	public async Task<GoalReflection> AddAsync(GoalReflection reflection)
	{
		//?
		_context.Goals.Attach(reflection.Goal);
		_context.Users.Attach(reflection.User);

		_context.GoalReflections.Add(reflection);
		await _context.SaveChangesAsync();
		return reflection;
	}

	public async Task<GoalReflection> UpdateAsync(GoalReflection reflection)
	{
		// not necessary because cannot be changed? remove later
		// Check if the Assignment entity is already tracked by the context
		if (_context.Goals.Local.All(a => a.Id != reflection.Goal.Id))
		{
			_context.Goals.Attach(reflection.Goal);
		}

		// Check if the User entity is already tracked by the context
		if (_context.Users.Local.All(u => u.Id != reflection.User.Id))
		{
			_context.Users.Attach(reflection.User);
		}

		_context.GoalReflections.Update(reflection);
		await _context.SaveChangesAsync();

		return reflection;
	}

	public async void DeleteByIdAsync(int id)
	{
		var existingReflection = GetByIdAsync(id);

		//replaces exists method
		if (existingReflection == null) return;

		_context.GoalReflections.Remove(await existingReflection);
		await _context.SaveChangesAsync();
	}
}
using Microsoft.EntityFrameworkCore;
using Shared.Entities;
using Shared.IRepositories;
using System.Reflection.Metadata;

namespace DataAccess.EFCore.Repositories;

public class GoalRepository : IGoalRepository
{
	private readonly YourPTDbContext _context;

	public GoalRepository(YourPTDbContext context)
	{
		_context = context;
	}


	public async Task<Goal?> GetByIdAsync(int id)
	{
		return await _context.Goals
			.FindAsync(id);
	}

	public async Task<List<Goal>> GetByIdsAsync(IEnumerable<int> ids)
	{
		return await _context.Goals
			.Where(b => ids.Contains(b.Id))
			.ToListAsync();
	}

	public async Task<List<Goal>> GetAllAsync()
	{
		return await _context.Goals
			.ToListAsync();
	}

	public async Task<Goal> AddAsync(Goal goal)
	{
		_context.Users.Attach(goal.User);

		if (goal.Assignments.Count > 0)
		{
			_context.Assignments.AttachRange(goal.Assignments);
		}

		_context.GoalReflections.Attach(goal.Reflection);
		_context.Goals.Add(goal);
		await _context.SaveChangesAsync();
		return goal;
	}

	public async Task<Goal> UpdateAsync(Goal goal)
	{
		// not necessary because cannot be changed? remove later
		// Check if the Assignment entity is already tracked by the context
		if (_context.GoalReflections.Local.All(a => a.Id != goal.Reflection.Id))
		{
			_context.GoalReflections.Attach(goal.Reflection);
		}

		// Check if the User entity is already tracked by the context
		if (_context.Users.Local.All(u => u.Id != goal.User.Id))
		{
			_context.Users.Attach(goal.User);
		}

		//if (_context.Assignments.Local.All(u => u.Id != assignment.Goal.Id)) //GoalId works to?
		//{
		//	_context.Goals.Attach(assignment.Goal);
		//}


		//Todo improve efficiency down below at the AttachRange
		_context.Assignments.AttachRange(goal.Assignments);

		_context.Goals.Update(goal);
		await _context.SaveChangesAsync();

		return goal;
	}

	public async void DeleteByIdAsync(int id)
	{
		var existingGoal = GetByIdAsync(id);

		//replaces exists method
		if (existingGoal == null) return;

		//Todo also remove the attached Assignments and the belonging AssignmentReflections

		_context.Goals.Remove(await existingGoal);
		await _context.SaveChangesAsync();
	}
}
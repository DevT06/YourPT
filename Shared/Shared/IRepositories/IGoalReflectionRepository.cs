using Shared.Entities;

namespace Shared.IRepositories;

public interface IGoalReflectionRepository
{
	Task<GoalReflection?> GetByIdAsync(int id);

	Task<List<GoalReflection>> GetAllAsync();

	Task<GoalReflection> AddAsync(GoalReflection reflection);

	Task<GoalReflection> UpdateAsync(GoalReflection reflection);

	void DeleteByIdAsync(int id);
}
using Shared.Entities;

namespace Shared.Interfaces.IRepositories;

public interface IGoalRepository
{
	Task<Goal?> GetByIdAsync(int id);

	// search with owner id

	Task<List<Goal>> GetByIdsAsync(IEnumerable<int>  ids);

	Task<List<Goal>> GetAllAsync();

	Task<Goal> AddAsync(Goal goal);

	Task<Goal> UpdateAsync(Goal goal);

	void DeleteByIdAsync(int id);

	// bool Exists(int id); ?
}
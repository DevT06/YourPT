using YourPT.Shared.Entities;

namespace Shared.Interfaces.IRepositories;

public interface IAssignmentRepository
{
	Task<Assignment?> GetByIdAsync(int id);

	Task<List<Assignment>> GetByIdsAsync(IEnumerable<int> ids);

	Task<List<Assignment>> GetAllAsync();

	// search

	Task<Assignment> AddAsync(Assignment assignment);

	Task<Assignment> UpdateAsync(Assignment assignment);

	void DeleteByIdAsync(int id);
}
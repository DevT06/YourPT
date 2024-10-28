using YourPT.Shared.Entities;

namespace Shared.Interfaces.IRepositories;

public interface IBlogRepository
{
	Task<Blog?> GetByIdAsync(int id);

	Task<List<Blog>> GetAllAsync();

	Task<List<Blog>> GetByIdsAsync(IEnumerable<int> ids);

	//List<Blog> GetBySearch(int? categoryId, string searchTerm);

	Task<Blog> AddAsync(Blog blog);

	Task<Blog> UpdateAsync(Blog blog);

	void DeleteByIdAsync(int id);

}
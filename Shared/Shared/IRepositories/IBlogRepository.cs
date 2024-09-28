using Shared.Entities;

namespace Shared.IRepositories;

public interface IBlogRepository
{
	Blog? GetById(int id);

	List<Blog> GetAll();

	List<Blog> GetByIds(IEnumerable<int> ids);

	//List<Blog> GetBySearch(int? categoryId, string searchTerm);

	Blog Add(Blog blog);

	Blog Update(Blog blog);

	void DeleteById(int id);

	bool Exists(int id);
}
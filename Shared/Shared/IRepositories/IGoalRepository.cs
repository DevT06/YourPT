using Shared.Entities;

namespace Shared.IRepositories;

public interface IGoalRepository
{
	Goal? GetById(int id);

	// search

	List<Goal> GetByIds(IEnumerable<int>  ids);

	List<Goal> GetAll();

	Goal Add(Goal goal);

	Goal Update(Goal goal);

	void DeleteById(int id);

	bool Exists(int id);
}
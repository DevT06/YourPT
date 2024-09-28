using Shared.Entities;

namespace Shared.IRepositories;

public interface IAssignmentRepository
{
	Assignment? GetById(int id);

	List<Assignment> GetByIds(IEnumerable<int> ids);

	List<Assignment> GetAll();

	// search

	Assignment Add(Assignment assignment);

	Assignment Update(Assignment assignment);

	Assignment DeleteById(int id);
}
using Shared.Entities;

namespace Shared.IRepositories;

public interface IAssignmentReflectionRepository
{
	AssignmentReflection? GetById(int id);

	// NOT NEEDED ||
	//            \/
	// List<AssignmentReflection> GetByIds(int[] ids); or use IEnumerable<int> 

	List<AssignmentReflection> GetAll();

	AssignmentReflection Add(AssignmentReflection reflection);

	AssignmentReflection Update(AssignmentReflection reflection);

	void DeleteById(int id);

	bool Exists(int id);
}
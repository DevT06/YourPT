using Shared.Entities;

namespace Shared.Interfaces.IRepositories;

public interface IAssignmentReflectionRepository
{
	Task<AssignmentReflection?> GetByIdAsync(int id);

	Task<List<AssignmentReflection>> GetAllAsync();

	Task<AssignmentReflection> AddAsync(AssignmentReflection reflection);

	Task<AssignmentReflection> UpdateAsync(AssignmentReflection reflection);

	void DeleteByIdAsync(int id);

	#region Non Async Methods
	AssignmentReflection? GetById(int id);

	// NOT NEEDED ||
	//            \/
	// List<AssignmentReflection> GetByIds(int[] ids); or use IEnumerable<int> 

	List<AssignmentReflection> GetAll();

	AssignmentReflection Add(AssignmentReflection reflection);

	AssignmentReflection Update(AssignmentReflection reflection);

	void DeleteById(int id);

	bool Exists(int id);

#endregion
}
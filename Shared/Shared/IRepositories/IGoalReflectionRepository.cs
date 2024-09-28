using Shared.Entities;

namespace Shared.IRepositories;

public interface IGoalReflectionRepository
{
	GoalReflection? GetById(int id);

	List<GoalReflection> GetAll();

	GoalReflection Add(GoalReflection goalReflection);

	GoalReflection Update(GoalReflection goalReflection);

	void DeleteById(int id);

	bool Exists(int id);
}
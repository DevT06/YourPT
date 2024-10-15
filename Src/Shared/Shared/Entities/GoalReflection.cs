using Shared.AbstractEntities;

namespace Shared.Entities;

public class GoalReflection : Reflection
{
	public Goal Goal { get; set; }
	//FK
	public int? GoalId { get; set; }

	//Todo rethink reflections (add in mongo db) and or make Assignment or goal can have multiple
}
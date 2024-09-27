using Shared.AbstractEntities;

namespace Shared.Entities;

public class GoalReflection : Reflection
{
	public Goal Goal { get; set; }
	//FK
	public int? GoalId { get; set; }
}
using YourPT.Shared.AbstractEntities;

namespace YourPT.Shared.Entities;

public class AssignmentReflection : Reflection
{
	public Assignment Assignment { get; set; }
	//FK (all fks were nullable)
	public int AssignmentId {get; set; }

	//Todo rethink reflections (add in mongo db) and or make Assignment or goal can have multiple
}
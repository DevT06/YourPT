using Shared.Entities;

namespace Shared.AbstractEntities;

public abstract class Reflection
{
	// maybe combine both reflection types
	public int Id { get; set; }

	//later add Public / private boolean

	public string Name { get; set; }

	public string Description { get; set; } // longer description than CommissionReflection?

	public DateTime CreatedAt { get; set; }

	public DateTime? UpdatedAt { get; set; }

	public User User { get; set; }
}
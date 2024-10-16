namespace Shared.Entities;

public class Goal
{
	public int Id { get; set; } // later to bigger type of int

	//later add Public / private boolean

	public string Name { get; set; }

	public string Description { get; set; }

	public DateTime CreatedAt { get; set; }

	public DateTime? UpdatedAt { get; set; }

	public bool Complete { get; set; }
	//later add completion in percentages based on completion of assignments

	#region Implement later

	//public int CompletionRate { get; set; }
	//public bool Public { get; set; }

	#endregion

	public List<GoalReflection> Reflections { get; set; } 

	// change later to reflection and combine commissionReflection | maybe later change to multiple


	public List<Assignment> Assignments { get; set; }

	//completion

	public User User { get; set; } //change later to multiple
	//FK
	public int? UserId { get; set; }

	//maybe override Equals and GetHashcode Methods (performance)

	public Goal()
	{
		Assignments = new List<Assignment>();
		Reflections = new List<GoalReflection>();
	}
}
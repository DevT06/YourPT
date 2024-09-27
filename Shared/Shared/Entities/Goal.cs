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

	public GoalReflection Reflection { get; set; } 

	// change later to reflection and combine commissionReflection | maybe later change to multiple

	//Commissions

	public List<Assignment> Assignments { get; set; }

	//completion

	public User User { get; set; } //change later to multiple

	//maybe override Equals and GetHashcode Methods (performance)

	public Goal()
	{
		Assignments = new List<Assignment>();
	}
}
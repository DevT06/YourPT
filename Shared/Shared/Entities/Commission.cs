namespace Shared.Entities;

public class Commission
{
	public int Id { get; set; }

	//later add Public / private boolean

	public string Name { get; set; }

	public string Description { get; set; } //shorter than Goal description

	public DateTime CreatedAt { get; set; }

	public DateTime? UpdatedAt { get; set; }

	public bool Complete { get; set; }

	public Reflection Reflection { get; set; }  // maybe change to multiple

	public Goal Goal { get; set; }

	public User User { get; set; }
}
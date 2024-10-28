namespace YourPT.Shared.Entities;

public class Note
{
	public int Id { get; set; }

	//later add Public / private boolean

	public string  Title { get; set; }

	public string Text { get; set; }

	public DateTime CreatedAt { get; set; }

	public DateTime? UpdatedAt { get; set; }

	public User User { get; set; }
	//FK
	public int? UserId { get; set; }
}
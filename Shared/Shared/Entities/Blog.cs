namespace Shared.Entities;

public class Blog
{
	public int Id { get; set; }

	//later add Public / private boolean

	public string Title { get; set; }

	public string Text { get; set; }

	public DateTime CreatedAt { get; set; }

	public DateTime? UpdatedAt { get; set; }

	//comments?

	public User User { get; set; } // multiple?
}
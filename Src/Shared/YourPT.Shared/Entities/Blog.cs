namespace YourPT.Shared.Entities;

public class Blog
{
	public int Id { get; set; }

	//later add Public / private boolean
	//later category or some sort of hashtag (not only for blog)

	public string Title { get; set; }

	public string Content { get; set; } // was Text

	public DateTime CreatedAt { get; set; }

	public DateTime? UpdatedAt { get; set; }

	//comments?

	public User User { get; set; } // multiple?
	//FK make not nullable nullable?
	public int? UserId { get; set; }
}
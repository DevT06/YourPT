namespace Shared.Entities;

public class User
{
	#region HashSet Variables

	private ISet<Blog> _blogs = new HashSet<Blog>();

	private ISet<Assignment> _assignments = new HashSet<Assignment>();

	private ISet<Goal> _goals = new HashSet<Goal>();

	private ISet<GoalReflection> _goalReflections = new HashSet<GoalReflection>();

	private ISet<AssignmentReflection> _assignmentReflections = new HashSet<AssignmentReflection>();

	private ISet<Note> _notes = new HashSet<Note>();

	#endregion

	public int Id { get; set; }

	public string Username { get; set; }

	public string? DisplayName { get; set; }

	//age?

	public string Email { get; set; }

	public string Password { get; set; }

	#region HashSet Relations

	public ISet<Blog> Blogs
	{
		get => _blogs;
		set => _blogs = value;
	}

	public ISet<Assignment> Assignments
	{
		get => _assignments;
		set => _assignments = value;
	}

	public ISet<Goal> Goals
	{
		get => _goals;
		set => _goals = value;
	}

	public ISet<GoalReflection> GoalReflections
	{
		get => _goalReflections;
		set => _goalReflections = value;
	}

	public ISet<AssignmentReflection> AssignmentReflections
	{
		get => _assignmentReflections;
		set => _assignmentReflections = value;
	}

	public ISet<Note> Notes
	{
		get => _notes; 
		set => _notes = value;
	}
	#endregion
}
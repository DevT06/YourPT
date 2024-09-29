using Microsoft.EntityFrameworkCore;
using Shared.Entities;
using Shared.IRepositories;

namespace DataAccess.EFCore.Repositories;

public class BlogRepository : IBlogRepository
{
	private readonly YourPTDbContext _context;

	public BlogRepository(YourPTDbContext context)
	{
		_context = context;
	}


	public async Task<Blog?> GetByIdAsync(int id)
	{
		return await _context.Blogs
			.FindAsync(id);
	}

	public async Task<List<Blog>> GetAllAsync()
	{
		return await _context.Blogs
			.ToListAsync();
	}

	public async Task<List<Blog>> GetByIdsAsync(IEnumerable<int> ids)
	{
		return await _context.Blogs
			.Where(b => ids.Contains(b.Id))
			.ToListAsync();
	}

	public async Task<Blog> AddAsync(Blog blog)
	{
		_context.Users.Attach(blog.User);

		_context.Blogs.Add(blog);
		await _context.SaveChangesAsync();
		return blog;
	}

	public async Task<Blog> UpdateAsync(Blog blog)
	{
		// not necessary because cannot be changed? remove later
		// Check if the User entity is already tracked by the context
		if (_context.Users.Local.All(u => u.Id != blog.User.Id))
		{
			_context.Users.Attach(blog.User);
		}

		_context.Blogs.Update(blog);
		await _context.SaveChangesAsync();

		return blog;
	}

	public async void DeleteByIdAsync(int id)
	{
		var existingBlog = GetByIdAsync(id);

		//replaces exists method
		if (existingBlog == null) return;

		_context.Blogs.Remove(await existingBlog);
		await _context.SaveChangesAsync();
	}
}
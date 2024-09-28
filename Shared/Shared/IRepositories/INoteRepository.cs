using Shared.Entities;

namespace Shared.IRepositories;

public interface INoteRepository
{
	Note? GetById(int id);

	List<Note> GetByIds(IEnumerable<int> ids);

	List<Note> GetAll();

	Note Add(Note note);

	Note Update(Note note);

	void DeleteById(int id);

	bool Exists(int id);
}
using MovieWeb.Models;

namespace MovieWeb.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        void Update(int id, Actor newActor);
        void Delete(Actor actor);
    }
}

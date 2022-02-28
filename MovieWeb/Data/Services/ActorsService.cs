using Microsoft.EntityFrameworkCore;
using MovieWeb.Models;

namespace MovieWeb.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly ApplicationDbContext context;

        public ActorsService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(Actor actor)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}

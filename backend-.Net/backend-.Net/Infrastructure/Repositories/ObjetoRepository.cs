using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_.Net.Domain.Interfaces;
using backend_.Net.Domain.Models;
using backend_.Net.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace backend_.Net.Infrastructure.Repositories
{
    public class ObjetoRepository : IObjetoRepository
    {
        private readonly AppDbContext _context;

        public ObjetoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Objeto>> GetAll()
        {
            return await _context.Objeto.ToListAsync();
        }

        public async Task<Objeto> GetById(long id)
        {
            return await _context.Objeto.FindAsync(id);
        }

        public async Task Add(Objeto objeto)
        {
            await _context.Objeto.AddAsync(objeto);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Objeto objeto)
        {
            _context.Entry(objeto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var objeto = await _context.Objeto.FindAsync(id);
            if (objeto != null)
            {
                _context.Objeto.Remove(objeto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Objeto>> Search(string nombre, string descripcion, double? precio, DateTime? fechaCreacion)
        {
            var query = _context.Objeto.AsQueryable();

            if (!string.IsNullOrEmpty(nombre))
            {
                query = query.Where(o => o.nombre.Contains(nombre));
            }

            if (!string.IsNullOrEmpty(descripcion))
            {
                query = query.Where(o => o.descripcion.Contains(descripcion));
            }

            if (precio.HasValue)
            {
                query = query.Where(o => o.precio == precio.Value);
            }

            if (fechaCreacion.HasValue)
            {
                query = query.Where(o => o.fecha_creacion.Date == fechaCreacion.Value.Date);
            }

            return await query.ToListAsync();
        }
    }
}

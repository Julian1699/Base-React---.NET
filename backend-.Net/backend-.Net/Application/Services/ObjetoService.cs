using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend_.Net.Application.Interfaces;
using backend_.Net.Domain.Interfaces;
using backend_.Net.Domain.Models;

namespace backend_.Net.Application.Services
{
    public class ObjetoService : IObjetoService
    {
        private readonly IObjetoRepository _objetoRepository;

        public ObjetoService(IObjetoRepository objetoRepository)
        {
            _objetoRepository = objetoRepository;
        }

        public async Task<IEnumerable<Objeto>> GetAll()
        {
            return await _objetoRepository.GetAll();
        }

        public async Task<Objeto> GetById(long id)
        {
            return await _objetoRepository.GetById(id);
        }

        public async Task Add(Objeto objeto)
        {
            await _objetoRepository.Add(objeto);
        }

        public async Task Update(Objeto objeto)
        {
            await _objetoRepository.Update(objeto);
        }

        public async Task Delete(long id)
        {
            await _objetoRepository.Delete(id);
        }

        public async Task<IEnumerable<Objeto>> Search(string nombre, string descripcion, double? precio, DateTime? fechaCreacion)
        {
            return await _objetoRepository.Search(nombre, descripcion, precio, fechaCreacion);
        }
    }
}

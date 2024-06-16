using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend_.Net.Domain.Models;

namespace backend_.Net.Application.Interfaces
{
    public interface IObjetoService
    {
        Task<IEnumerable<Objeto>> GetAll();
        Task<Objeto> GetById(long id);
        Task Add(Objeto objeto);
        Task Update(Objeto objeto);
        Task Delete(long id);
        Task<IEnumerable<Objeto>> Search(string nombre, string descripcion, double? precio, DateTime? fechaCreacion);
    }
}

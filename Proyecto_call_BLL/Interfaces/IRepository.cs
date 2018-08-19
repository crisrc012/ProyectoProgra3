using System.Collections.Generic;
using Uam.Programacion.Proyecto.Models.Interfaces;

namespace Proyecto_call_BLL.Interfaces
{
    /// <summary>
    /// Contrato que deben implementar los repositorios que desean realizar las acciones de select, insert, update y delete.
    /// </summary>
    /// <typeparam name="T">El tipo de objeto del repositorio.</typeparam>
    /// <typeparam name="T1">El tipo de dato del campo identificador del <typeparamref name="T"/>.</typeparam>
    public interface IRepository<T, T1>
        where T : class, IEntity<T1>, new ()
    {
        /// <summary>
        /// Metodo para listar los objetos del repositorio. Permite filtrar por un campo de tipo texto.
        /// </summary>
        /// <param name="filterObject">Objeto con las propiedades que se van a usar para filtrar los resultados.</param>
        /// <returns>Lista de objetos del repositorio.</returns>
        IEnumerable<T> List(T filterObject);

        /// <summary>
        /// Agrega un nuevo objeto en el repositorio.
        /// </summary>
        /// <param name="entity">Objeto del tipo <typeparamref name="T"/> que va a ser agregado.</param>
        void Add(T entity);

        /// <summary>
        /// Borra un objeto del repositorio.
        /// </summary>
        /// <param name="entity">Objeto del tipo <typeparamref name="T"/> que va a ser borrado.</param>
        /// <returns>true si el borrado fue realizado exitosamente, en cualquier otro caso false.</returns>
        bool Delete(T entity);

        /// <summary>
        /// Actualiza un objeto del repositorio.
        /// </summary>
        /// <param name="entity">Objeto del tipo <typeparamref name="T"/> que va a ser actualizado.</param>
        /// <returns>true si el actualizado fue realizado exitosamente, en cualquier otro caso false.</returns>
        bool Update(T entity);
    }
}
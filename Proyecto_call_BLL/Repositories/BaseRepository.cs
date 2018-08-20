using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_call_BLL.Interfaces;
using Proyecto_call_BLL.Utils;
using Proyecto_call_DAL;
using Proyecto_call_DAL.Interfaces;
using Uam.Programacion.Proyecto.Models.Attributes;
using Uam.Programacion.Proyecto.Models.Enums;
using Uam.Programacion.Proyecto.Models.Interfaces;

namespace Proyecto_call_BLL.Repositories
{
    /// <inheritdoc />
    public abstract class BaseRepository<T, T1> : IRepository<T, T1>
        where T : class, IEntity<T1>, new()
        where T1: IConvertible
    {
        private readonly IDbContext _dbContext;
        private readonly T _defaultObject;

        protected BaseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
            _defaultObject = new T();
        }

        /// <inheritdoc />
        public void Add(T entity)
        {
           string procedureName;

            if (_defaultObject.Mappings.ContainsKey(Command.Insert))
                procedureName = _defaultObject.Mappings[Command.Insert];
            else
                return;

            using (var dbContext = _dbContext.Create())
            {
                var parametersToCreate = ReflectionHelper.GetInsertParameters<T>().ToList();
                var parameters = new List<DatabaseParameter>();

                foreach (var parameter in parametersToCreate)
                {
                    var insertParamValue = parameter.GetValue(entity);
                    var insertParamAttribute = parameter.GetCustomAttributes(true).FirstOrDefault(x => x.GetType() == typeof(InsertParameterAttribute)) as InsertParameterAttribute;

                    if (insertParamAttribute == null || insertParamValue == null)
                        continue;

                    var dbParam = DatabaseParameter.CreateInParam(insertParamAttribute.ParamName, insertParamAttribute.Type, insertParamValue);
                    parameters.Add(dbParam);
                }

                var id = (T1) Convert.ChangeType(dbContext.ExecuteScalar(procedureName, parameters), typeof(T1));
                entity.Id = id;
            }
        }

        /// <inheritdoc />
        public bool Delete(T entity)
        {
            string procedureName;

            if (_defaultObject.Mappings.ContainsKey(Command.Delete))
                procedureName = _defaultObject.Mappings[Command.Delete];
            else
                return false;

            using (var dbContext = _dbContext.Create())
            {
                var parametersToCreate = ReflectionHelper.GetDeleteParameters<T>().ToList();
                var parameters = new List<DatabaseParameter>();

                foreach (var parameter in parametersToCreate)
                {
                    var deleteParamValue = parameter.GetValue(entity);
                    var deleteParamAttribute = parameter.GetCustomAttributes(true).FirstOrDefault(x => x.GetType() == typeof(DeleteParameterAttribute)) as DeleteParameterAttribute;

                    if (deleteParamAttribute == null || deleteParamValue == null)
                        continue;

                    var dbParam = DatabaseParameter.CreateInParam(deleteParamAttribute.ParamName, deleteParamAttribute.Type, deleteParamValue);
                    parameters.Add(dbParam);
                }

                dbContext.ExecuteNonQuery(procedureName, parameters);
                return true;
            }
        }

        /// <inheritdoc />
        public IEnumerable<T> List(T filterObject)
        {
            string procedureName;

            if (filterObject == null)
                filterObject = new T();

            if (_defaultObject.Mappings.ContainsKey(Command.Select))
                procedureName = _defaultObject.Mappings[Command.Select];
            else
                return new List<T>();

            using (var dbContext = _dbContext.Create())
            {
                var parametersToCreate = ReflectionHelper.GetSelectParameters<T>().ToList();
                var parameters = new List<DatabaseParameter>();

                foreach (var parameter in parametersToCreate)
                {
                    var selectParamValue = parameter.GetValue(filterObject);
                    var selectParamAttribute = parameter.GetCustomAttributes(true).FirstOrDefault(x => x.GetType() == typeof(SelectParameterAttribute)) as SelectParameterAttribute;

                    if (selectParamAttribute == null || selectParamValue == null)
                        continue;

                    var dbParam = DatabaseParameter.CreateInParam(selectParamAttribute.ParamName, selectParamAttribute.Type, selectParamValue);
                    parameters.Add(dbParam);
                }

                return dbContext.ExecuteDataTable(procedureName, parameters).ToList<T>();
            }
        }

        /// <inheritdoc />
        public bool Update(T entity)
        {
            string procedureName;

            if (_defaultObject.Mappings.ContainsKey(Command.Update))
                procedureName = _defaultObject.Mappings[Command.Update];
            else
                return false;

            using (var dbContext = _dbContext.Create())
            {
                var parametersToCreate = ReflectionHelper.GetUpdateParameters<T>().ToList();
                var parameters = new List<DatabaseParameter>();

                foreach (var parameter in parametersToCreate)
                {
                    var updateParamValue = parameter.GetValue(entity);
                    var updateParamAttribute = parameter.GetCustomAttributes(true).FirstOrDefault(x => x.GetType() == typeof(UpdateParameterAttribute)) as UpdateParameterAttribute;

                    if (updateParamAttribute == null || updateParamValue == null)
                        continue;

                    var dbParam = DatabaseParameter.CreateInParam(updateParamAttribute.ParamName, updateParamAttribute.Type, updateParamValue);
                    parameters.Add(dbParam);
                }

                dbContext.ExecuteNonQuery(procedureName, parameters);
                return true;
            }
        }
    }
}
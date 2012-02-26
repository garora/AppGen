

namespace MySampleApplication {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using NHibernate;
    using NHibernate.Cfg;
    using NHibernate.Criterion;
    using NHibernate.Tool.hbm2ddl;
    
    public class MySampleRepositoryClass : IDisposable {
        protected static Configuration Config;
        protected static ISessionFactory SessionFactory;
        protected static ITransaction Transaction;
        public MySampleRepositoryClass() {
            if (SessionFactory==null) {
			Config = new Configuration();
Config.Configure();
Config.AddAssembly(typeof(MySampleRepositoryClass).Assembly);
SessionFactory = Config.BuildSessionFactory();
            }
Session = SessionFactory.OpenSession();
Transaction = Session.BeginTransaction();

        }
        protected static ISession Session { get; private set; }
        public bool Commit() {
            if (Transaction.IsActive) {
try {Transaction.Commit();return true; }catch (Exception exception){//Error log
return false;}
            }
return false;
        }
        public bool Rollback() {
            if (Transaction.IsActive) {
try {Transaction.Rollback();return true; }catch (Exception exception){//Error log
return false;}
            }
return false;
        }
        public void GenerateSchema() {
new SchemaExport(Config).Execute(true, false, false);
        }
        #region Repository Functions
        /// <summary>
        /// Saves or updates the object to the database, depending on the value of its identifier property.
        /// </summary>
        /// <param name="value">
        /// A transient instance containing a new or updated state.</param>
        public void Save(object value) {
Session.Save(value);
        }
        /// <summary>
        /// Save object to repository
        /// </summary>
        /// <param name="value">
        /// Object for save</param>
        public void SaveorUpdate(object value) {
Session.SaveorUpdate(value);
        }
        /// <summary>
        /// Removes a persistent instance from the database.
        /// </summary>
        /// <param name="value">
        /// The instance to be removed.</param>
        public void Delete(object value) {
Session.Delete(value);
        }
        /// <summary>
        /// Returns a strong typed persistent instance of the given named entity with the given identifier, or null if there is no such persistent instance.
        /// </summary>
        /// <typeparam name="T">The type of the given persistant instance.</typeparam>
        /// <param name="id">An identifier.</param>
        public T Get<T>(object id) {
T returnVal = Session.Get<T>(id);
return returnVal;
        }
        /// <summary>
        /// Returns a list of all instances of type T from the database.
        /// </summary>
        /// <typeparam name="T">The type of the given persistant instance.</typeparam>
        public IList<T> GetAll<T>()
            where T :  class {
IList<T> returnVal = Session.CreateCriteria<T>().List<T>();
 return returnVal;
        }
        /// <summary>
        /// Returns a list of all instances of type T from the database for pagination
        /// </summary>
        /// <typeparam name="T">The type of the given persistant instance.</typeparam>
        /// <param name="pageIndex">Number- page index.</param>
        /// <param name="pageSize">Number -  maximum page size.</param>
        /// <returns>List of type the given persistent instance</returns>
        public IList<T> GetAll<T>(int pageIndex, int pageSize)
            where T :  class {
 var criteria = Session.CreateCriteria(typeof(T));
            if (pageSize > 0) {
criteria.SetMaxResults(pageSize);
            }
  return criteria.List<T>();
        }
        public IList<T> Find<T>(IList<string> strs)
            where T :  class {
 IList<ICriterion> objs = strs.Select(Expression.Sql).Cast<ICriterion>().ToList();
 ICriteria criteria = Session.CreateCriteria(typeof(T));
 foreach (ICriterion rest in objs) 
 criteria.SetFirstResult(0);
    return criteria.List<T>();
        }
        public IList<T> GetListByQuery<T>(IQuery query)
            where T :  class {
 IList<T> list = query.List<T>();
 return list;
        }
        #endregion
        #region IDisposable methods
        public void Dispose() {
            if (Session != null) {
if (Session.IsOpen) Session.Close();
            }
        }
        #endregion
    }
}

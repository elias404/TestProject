using System.Collections.Generic;
using System.Data.Objects;
using System.Linq.Expressions;

namespace ClassLibraryWithEntities
{
    public abstract class BaseTable
    {

        public abstract class MeerkatTable : BaseTable
        {
            protected override System.Data.Objects.ObjectContext createEntitiesFactoryMethod()
            {
                return createEntities();
            }

            protected MeerkatEntities createEntities()
            {
                var connectionString = EntityConnectionContainer<MeerkatEntities>.getEntityConnection();
                return new MeerkatEntities(connectionString);
            }
        }

        protected abstract ObjectContext createEntitiesFactoryMethod();

        protected BaseTable()
        {
           
        }

        protected ObjectSet<TEntityType> getObjectSet<TEntityType>(ObjectContext entities)
            where TEntityType : class
        {
            return entities.CreateObjectSet<TEntityType>();
        }

        protected ObjectSet<TEntityType> getObjectSet<TEntityType>()
            where TEntityType : class
        {
            ObjectContext entities = createEntitiesFactoryMethod();
            return getObjectSet<TEntityType>(entities);
        }

        //#region Nested type: JoinHelper

        //protected class JoinHelper<TOuter, TInner>
        //    where TOuter : class
        //    where TInner : class
        //{
        //    public IQueryable<TResult> Join<TKey, TResult>(Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector)
        //    {
        //        ObjectContext entities = createEntitiesFactory().createEntities();

        //        IQueryable<TInner> inner = entities.CreateObjectSet<TInner>();
        //        IQueryable<TOuter> outer = entities.CreateObjectSet<TOuter>();

        //        return outer.Join(inner, outerKeySelector, innerKeySelector, resultSelector);
        //    }
        //}

        //#endregion
    }
}
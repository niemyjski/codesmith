﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using CodeSmith.Data.Linq;
using CodeSmith.Data.Linq.Dynamic;

namespace PetShop.Core.Data
{
    /// <summary>
    /// The query extension class for Category.
    /// </summary>
    public static partial class CategoryExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static PetShop.Core.Data.Category GetByKey(this IQueryable<PetShop.Core.Data.Category> queryable, string categoryId)
        {
            var entity = queryable as System.Data.Linq.Table<PetShop.Core.Data.Category>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((PetShop.Core.Data.PetShopDataContext)entity.Context, categoryId);

            return queryable.FirstOrDefault(c => c.CategoryId == categoryId);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<PetShop.Core.Data.Category> table, string categoryId)
        {
            return table.Delete(c => c.CategoryId == categoryId);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.CategoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="categoryId">CategoryId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByCategoryId(this IQueryable<PetShop.Core.Data.Category> queryable, string categoryId)
        {
            return queryable.Where(c => c.CategoryId == categoryId);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.CategoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="categoryId">CategoryId to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByCategoryId(this IQueryable<PetShop.Core.Data.Category> queryable, string categoryId, ContainmentOperator containmentOperator)
        {
            if (categoryId == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("categoryId", "Parameter 'categoryId' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.CategoryId.Contains(categoryId));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.CategoryId.StartsWith(categoryId));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.CategoryId.EndsWith(categoryId));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.CategoryId.Contains(categoryId) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(c => c.CategoryId != categoryId);
                default:
                    return queryable.Where(c => c.CategoryId == categoryId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.CategoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="categoryId">CategoryId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByCategoryId(this IQueryable<PetShop.Core.Data.Category> queryable, string categoryId, params string[] additionalValues)
        {
            var categoryIdList = new List<string> { categoryId };

            if (additionalValues != null)
                categoryIdList.AddRange(additionalValues);

            if (categoryIdList.Count == 1)
                return queryable.ByCategoryId(categoryIdList[0]);

            return queryable.ByCategoryId(categoryIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.CategoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByCategoryId(this IQueryable<PetShop.Core.Data.Category> queryable, IEnumerable<string> values)
        {
            return queryable.Where(c => values.Contains(c.CategoryId));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByName(this IQueryable<PetShop.Core.Data.Category> queryable, string name)
        {
            // using object equals to support nulls
            return queryable.Where(c => object.Equals(c.Name, name));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByName(this IQueryable<PetShop.Core.Data.Category> queryable, string name, ContainmentOperator containmentOperator)
        {
            if (name == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("name", "Parameter 'name' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.Name.Contains(name));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.Name.StartsWith(name));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.Name.EndsWith(name));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.Name.Contains(name) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(c => object.Equals(c.Name, name) == false);
                default:
                    return queryable.Where(c => object.Equals(c.Name, name));
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByName(this IQueryable<PetShop.Core.Data.Category> queryable, string name, params string[] additionalValues)
        {
            var nameList = new List<string> { name };

            if (additionalValues != null)
                nameList.AddRange(additionalValues);
            else
                nameList.Add(null);

            if (nameList.Count == 1)
                return queryable.ByName(nameList[0]);

            return queryable.ByName(nameList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByName(this IQueryable<PetShop.Core.Data.Category> queryable, IEnumerable<string> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<PetShop.Core.Data.Category, bool>("Name", values);
            return queryable.Where(expression);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.Descn"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="descn">Descn to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByDescn(this IQueryable<PetShop.Core.Data.Category> queryable, string descn)
        {
            // using object equals to support nulls
            return queryable.Where(c => object.Equals(c.Descn, descn));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.Descn"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="descn">Descn to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByDescn(this IQueryable<PetShop.Core.Data.Category> queryable, string descn, ContainmentOperator containmentOperator)
        {
            if (descn == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("descn", "Parameter 'descn' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.Descn.Contains(descn));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.Descn.StartsWith(descn));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.Descn.EndsWith(descn));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.Descn.Contains(descn) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(c => object.Equals(c.Descn, descn) == false);
                default:
                    return queryable.Where(c => object.Equals(c.Descn, descn));
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.Descn"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="descn">Descn to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByDescn(this IQueryable<PetShop.Core.Data.Category> queryable, string descn, params string[] additionalValues)
        {
            var descnList = new List<string> { descn };

            if (additionalValues != null)
                descnList.AddRange(additionalValues);
            else
                descnList.Add(null);

            if (descnList.Count == 1)
                return queryable.ByDescn(descnList[0]);

            return queryable.ByDescn(descnList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Category.Descn"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Category> ByDescn(this IQueryable<PetShop.Core.Data.Category> queryable, IEnumerable<string> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<PetShop.Core.Data.Category, bool>("Descn", values);
            return queryable.Where(expression);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<PetShop.Core.Data.PetShopDataContext, string, PetShop.Core.Data.Category> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (PetShop.Core.Data.PetShopDataContext db, string categoryId) =>
                        db.Category.FirstOrDefault(c => c.CategoryId == categoryId));

        }
        #endregion
    }
}

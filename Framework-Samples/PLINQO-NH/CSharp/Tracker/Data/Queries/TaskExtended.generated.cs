﻿#pragma warning disable 1591
// <auto-generated>
//     This code was generated from a CodeSmith Generator template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using CodeSmith.Data.Linq;

namespace Tracker.Data
{
    /// <summary>
    /// The query extension class for TaskExtended.
    /// </summary>
    public static partial class TaskExtendedExtensions
    {
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Tracker.Data.Entities.TaskExtended GetByKey(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, System.Int32 taskId)
        {
            return queryable.FirstOrDefault(t => t.TaskId == taskId);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.Browser"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="browser">Browser to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByBrowser(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, System.String browser)
        {
            return queryable.Where(t => t.Browser == browser);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.Browser"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="browser">Browser to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByBrowser(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, ContainmentOperator containmentOperator, System.String browser)
        {
            if (browser == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("browser", "Parameter 'browser' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(t => t.Browser.Contains(browser));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(t => t.Browser.StartsWith(browser));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(t => t.Browser.EndsWith(browser));
                case ContainmentOperator.NotContains:
                    return queryable.Where(t => t.Browser.Contains(browser) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(t => t.Browser != browser);
                default:
                    return queryable.Where(t => t.Browser == browser);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.Browser"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="browser">Browser to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByBrowser(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, System.String browser, params System.String[] additionalValues)
        {
            var browserList = new List<System.String> { browser };

            if (additionalValues != null)
                browserList.AddRange(additionalValues);

            if (browserList.Count == 1)
                return queryable.ByBrowser(browserList[0]);

            return queryable.ByBrowser(browserList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.Browser"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByBrowser(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(t => values.Contains(t.Browser));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.Os"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="os">Os to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByOs(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, System.String os)
        {
            return queryable.Where(t => t.Os == os);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.Os"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="os">Os to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByOs(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, ContainmentOperator containmentOperator, System.String os)
        {
            if (os == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("os", "Parameter 'os' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(t => t.Os.Contains(os));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(t => t.Os.StartsWith(os));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(t => t.Os.EndsWith(os));
                case ContainmentOperator.NotContains:
                    return queryable.Where(t => t.Os.Contains(os) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(t => t.Os != os);
                default:
                    return queryable.Where(t => t.Os == os);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.Os"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="os">Os to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByOs(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, System.String os, params System.String[] additionalValues)
        {
            var osList = new List<System.String> { os };

            if (additionalValues != null)
                osList.AddRange(additionalValues);

            if (osList.Count == 1)
                return queryable.ByOs(osList[0]);

            return queryable.ByOs(osList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.Os"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByOs(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(t => values.Contains(t.Os));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByCreatedDate(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, System.DateTime createdDate)
        {
            return queryable.Where(t => t.CreatedDate == createdDate);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByCreatedDate(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, ComparisonOperator comparisonOperator, System.DateTime createdDate)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(t => t.CreatedDate > createdDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(t => t.CreatedDate >= createdDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(t => t.CreatedDate < createdDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(t => t.CreatedDate <= createdDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(t => t.CreatedDate != createdDate);
                default:
                    return queryable.Where(t => t.CreatedDate == createdDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByCreatedDate(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, System.DateTime createdDate, params System.DateTime[] additionalValues)
        {
            var createdDateList = new List<System.DateTime> { createdDate };

            if (additionalValues != null)
                createdDateList.AddRange(additionalValues);

            if (createdDateList.Count == 1)
                return queryable.ByCreatedDate(createdDateList[0]);

            return queryable.ByCreatedDate(createdDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByCreatedDate(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(t => values.Contains(t.CreatedDate));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByModifiedDate(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, System.DateTime modifiedDate)
        {
            return queryable.Where(t => t.ModifiedDate == modifiedDate);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByModifiedDate(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, ComparisonOperator comparisonOperator, System.DateTime modifiedDate)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(t => t.ModifiedDate > modifiedDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(t => t.ModifiedDate >= modifiedDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(t => t.ModifiedDate < modifiedDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(t => t.ModifiedDate <= modifiedDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(t => t.ModifiedDate != modifiedDate);
                default:
                    return queryable.Where(t => t.ModifiedDate == modifiedDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByModifiedDate(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, System.DateTime modifiedDate, params System.DateTime[] additionalValues)
        {
            var modifiedDateList = new List<System.DateTime> { modifiedDate };

            if (additionalValues != null)
                modifiedDateList.AddRange(additionalValues);

            if (modifiedDateList.Count == 1)
                return queryable.ByModifiedDate(modifiedDateList[0]);

            return queryable.ByModifiedDate(modifiedDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskExtended.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskExtended> ByModifiedDate(this IQueryable<Tracker.Data.Entities.TaskExtended> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(t => values.Contains(t.ModifiedDate));
        }
    }
}
#pragma warning restore 1591

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
using Plinqo.NHibernate;

namespace Tracker.Data
{
    /// <summary>
    /// The query extension class for TaskDetail.
    /// </summary>
    public static partial class TaskDetailExtensions
    {
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Tracker.Data.Entities.TaskDetail GetByKey(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.Int32 id, System.String summary, System.String priority, System.String status, System.String assigned, System.String created)
        {
            return queryable.FirstOrDefault(t => t.Id == id 
					&& t.Summary == summary 
					&& t.Priority == priority 
					&& t.Status == status 
					&& t.Assigned == assigned 
					&& t.Created == created);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ById(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.Int32 id)
        {
            return queryable.Where(t => t.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ById(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, ComparisonOperator comparisonOperator, System.Int32 id)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(t => t.Id > id);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(t => t.Id >= id);
                case ComparisonOperator.LessThan:
                    return queryable.Where(t => t.Id < id);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(t => t.Id <= id);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(t => t.Id != id);
                default:
                    return queryable.Where(t => t.Id == id);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ById(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.Int32 id, params System.Int32[] additionalValues)
        {
            var idList = new List<System.Int32> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ById(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, IEnumerable<System.Int32> values)
        {
            return queryable.Where(t => values.Contains(t.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Summary"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="summary">Summary to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> BySummary(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.String summary)
        {
            return queryable.Where(t => t.Summary == summary);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Summary"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="summary">Summary to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> BySummary(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, ContainmentOperator containmentOperator, System.String summary)
        {
            if (summary == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("summary", "Parameter 'summary' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(t => t.Summary.Contains(summary));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(t => t.Summary.StartsWith(summary));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(t => t.Summary.EndsWith(summary));
                case ContainmentOperator.NotContains:
                    return queryable.Where(t => t.Summary.Contains(summary) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(t => t.Summary != summary);
                default:
                    return queryable.Where(t => t.Summary == summary);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Summary"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="summary">Summary to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> BySummary(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.String summary, params System.String[] additionalValues)
        {
            var summaryList = new List<System.String> { summary };

            if (additionalValues != null)
                summaryList.AddRange(additionalValues);

            if (summaryList.Count == 1)
                return queryable.BySummary(summaryList[0]);

            return queryable.BySummary(summaryList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Summary"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> BySummary(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(t => values.Contains(t.Summary));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Priority"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="priority">Priority to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByPriority(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.String priority)
        {
            return queryable.Where(t => t.Priority == priority);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Priority"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="priority">Priority to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByPriority(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, ContainmentOperator containmentOperator, System.String priority)
        {
            if (priority == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("priority", "Parameter 'priority' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(t => t.Priority.Contains(priority));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(t => t.Priority.StartsWith(priority));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(t => t.Priority.EndsWith(priority));
                case ContainmentOperator.NotContains:
                    return queryable.Where(t => t.Priority.Contains(priority) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(t => t.Priority != priority);
                default:
                    return queryable.Where(t => t.Priority == priority);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Priority"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="priority">Priority to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByPriority(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.String priority, params System.String[] additionalValues)
        {
            var priorityList = new List<System.String> { priority };

            if (additionalValues != null)
                priorityList.AddRange(additionalValues);

            if (priorityList.Count == 1)
                return queryable.ByPriority(priorityList[0]);

            return queryable.ByPriority(priorityList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Priority"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByPriority(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(t => values.Contains(t.Priority));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Status"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="status">Status to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByStatus(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.String status)
        {
            return queryable.Where(t => t.Status == status);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Status"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="status">Status to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByStatus(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, ContainmentOperator containmentOperator, System.String status)
        {
            if (status == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("status", "Parameter 'status' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(t => t.Status.Contains(status));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(t => t.Status.StartsWith(status));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(t => t.Status.EndsWith(status));
                case ContainmentOperator.NotContains:
                    return queryable.Where(t => t.Status.Contains(status) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(t => t.Status != status);
                default:
                    return queryable.Where(t => t.Status == status);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Status"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="status">Status to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByStatus(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.String status, params System.String[] additionalValues)
        {
            var statusList = new List<System.String> { status };

            if (additionalValues != null)
                statusList.AddRange(additionalValues);

            if (statusList.Count == 1)
                return queryable.ByStatus(statusList[0]);

            return queryable.ByStatus(statusList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Status"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByStatus(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(t => values.Contains(t.Status));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Assigned"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="assigned">Assigned to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByAssigned(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.String assigned)
        {
            return queryable.Where(t => t.Assigned == assigned);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Assigned"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="assigned">Assigned to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByAssigned(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, ContainmentOperator containmentOperator, System.String assigned)
        {
            if (assigned == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("assigned", "Parameter 'assigned' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(t => t.Assigned.Contains(assigned));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(t => t.Assigned.StartsWith(assigned));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(t => t.Assigned.EndsWith(assigned));
                case ContainmentOperator.NotContains:
                    return queryable.Where(t => t.Assigned.Contains(assigned) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(t => t.Assigned != assigned);
                default:
                    return queryable.Where(t => t.Assigned == assigned);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Assigned"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="assigned">Assigned to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByAssigned(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.String assigned, params System.String[] additionalValues)
        {
            var assignedList = new List<System.String> { assigned };

            if (additionalValues != null)
                assignedList.AddRange(additionalValues);

            if (assignedList.Count == 1)
                return queryable.ByAssigned(assignedList[0]);

            return queryable.ByAssigned(assignedList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Assigned"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByAssigned(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(t => values.Contains(t.Assigned));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Created"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="created">Created to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByCreated(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.String created)
        {
            return queryable.Where(t => t.Created == created);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Created"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="created">Created to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByCreated(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, ContainmentOperator containmentOperator, System.String created)
        {
            if (created == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("created", "Parameter 'created' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(t => t.Created.Contains(created));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(t => t.Created.StartsWith(created));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(t => t.Created.EndsWith(created));
                case ContainmentOperator.NotContains:
                    return queryable.Where(t => t.Created.Contains(created) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(t => t.Created != created);
                default:
                    return queryable.Where(t => t.Created == created);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Created"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="created">Created to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByCreated(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, System.String created, params System.String[] additionalValues)
        {
            var createdList = new List<System.String> { created };

            if (additionalValues != null)
                createdList.AddRange(additionalValues);

            if (createdList.Count == 1)
                return queryable.ByCreated(createdList[0]);

            return queryable.ByCreated(createdList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.TaskDetail.Created"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.TaskDetail> ByCreated(this IQueryable<Tracker.Data.Entities.TaskDetail> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(t => values.Contains(t.Created));
        }
    }
}
#pragma warning restore 1591


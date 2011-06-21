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
using CodeSmith.Data.Linq.Dynamic;

namespace Sakila.Data
{
    /// <summary>
    /// The query extension class for Payment.
    /// </summary>
    public static partial class PaymentExtensions
    {
        #region Unique Results
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Sakila.Data.Entities.Payment GetByKey(this IQueryable<Sakila.Data.Entities.Payment> queryable
            , System.Int16 paymentId
            )
        {
            return queryable
                .Where(p => p.PaymentId == paymentId)
                .FirstOrDefault();
        }
        
        #endregion
        
        #region By Property
        

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.PaymentId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="paymentId">PaymentId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByPaymentId(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.Int16 paymentId)
        {
            return queryable.Where(p => p.PaymentId == paymentId);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.PaymentId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="paymentId">PaymentId to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByPaymentId(this IQueryable<Sakila.Data.Entities.Payment> queryable, ComparisonOperator comparisonOperator, System.Int16 paymentId)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(p => p.PaymentId > paymentId);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(p => p.PaymentId >= paymentId);
                case ComparisonOperator.LessThan:
                    return queryable.Where(p => p.PaymentId < paymentId);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(p => p.PaymentId <= paymentId);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.PaymentId != paymentId);
                default:
                    return queryable.Where(p => p.PaymentId == paymentId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.PaymentId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="paymentId">PaymentId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByPaymentId(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.Int16 paymentId, params System.Int16[] additionalValues)
        {
            var paymentIdList = new List<System.Int16> { paymentId };

            if (additionalValues != null)
                paymentIdList.AddRange(additionalValues);

            if (paymentIdList.Count == 1)
                return queryable.ByPaymentId(paymentIdList[0]);

            return queryable.ByPaymentId(paymentIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.PaymentId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByPaymentId(this IQueryable<Sakila.Data.Entities.Payment> queryable, IEnumerable<System.Int16> values)
        {
            return queryable.Where(p => values.Contains(p.PaymentId));
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.Amount"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="amount">Amount to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByAmount(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.Decimal amount)
        {
            return queryable.Where(p => p.Amount == amount);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.Amount"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="amount">Amount to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByAmount(this IQueryable<Sakila.Data.Entities.Payment> queryable, ComparisonOperator comparisonOperator, System.Decimal amount)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(p => p.Amount > amount);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(p => p.Amount >= amount);
                case ComparisonOperator.LessThan:
                    return queryable.Where(p => p.Amount < amount);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(p => p.Amount <= amount);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.Amount != amount);
                default:
                    return queryable.Where(p => p.Amount == amount);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.Amount"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="amount">Amount to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByAmount(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.Decimal amount, params System.Decimal[] additionalValues)
        {
            var amountList = new List<System.Decimal> { amount };

            if (additionalValues != null)
                amountList.AddRange(additionalValues);

            if (amountList.Count == 1)
                return queryable.ByAmount(amountList[0]);

            return queryable.ByAmount(amountList);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.Amount"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByAmount(this IQueryable<Sakila.Data.Entities.Payment> queryable, IEnumerable<System.Decimal> values)
        {
            return queryable.Where(p => values.Contains(p.Amount));
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.PaymentDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="paymentDate">PaymentDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByPaymentDate(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.DateTime paymentDate)
        {
            return queryable.Where(p => p.PaymentDate == paymentDate);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.PaymentDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="paymentDate">PaymentDate to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByPaymentDate(this IQueryable<Sakila.Data.Entities.Payment> queryable, ComparisonOperator comparisonOperator, System.DateTime paymentDate)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(p => p.PaymentDate > paymentDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(p => p.PaymentDate >= paymentDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(p => p.PaymentDate < paymentDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(p => p.PaymentDate <= paymentDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.PaymentDate != paymentDate);
                default:
                    return queryable.Where(p => p.PaymentDate == paymentDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.PaymentDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="paymentDate">PaymentDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByPaymentDate(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.DateTime paymentDate, params System.DateTime[] additionalValues)
        {
            var paymentDateList = new List<System.DateTime> { paymentDate };

            if (additionalValues != null)
                paymentDateList.AddRange(additionalValues);

            if (paymentDateList.Count == 1)
                return queryable.ByPaymentDate(paymentDateList[0]);

            return queryable.ByPaymentDate(paymentDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.PaymentDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByPaymentDate(this IQueryable<Sakila.Data.Entities.Payment> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(p => values.Contains(p.PaymentDate));
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.LastUpdate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastUpdate">LastUpdate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByLastUpdate(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.DateTime lastUpdate)
        {
            return queryable.Where(p => p.LastUpdate == lastUpdate);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.LastUpdate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastUpdate">LastUpdate to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByLastUpdate(this IQueryable<Sakila.Data.Entities.Payment> queryable, ComparisonOperator comparisonOperator, System.DateTime lastUpdate)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(p => p.LastUpdate > lastUpdate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(p => p.LastUpdate >= lastUpdate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(p => p.LastUpdate < lastUpdate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(p => p.LastUpdate <= lastUpdate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.LastUpdate != lastUpdate);
                default:
                    return queryable.Where(p => p.LastUpdate == lastUpdate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.LastUpdate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastUpdate">LastUpdate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByLastUpdate(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.DateTime lastUpdate, params System.DateTime[] additionalValues)
        {
            var lastUpdateList = new List<System.DateTime> { lastUpdate };

            if (additionalValues != null)
                lastUpdateList.AddRange(additionalValues);

            if (lastUpdateList.Count == 1)
                return queryable.ByLastUpdate(lastUpdateList[0]);

            return queryable.ByLastUpdate(lastUpdateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment.LastUpdate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByLastUpdate(this IQueryable<Sakila.Data.Entities.Payment> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(p => values.Contains(p.LastUpdate));
        }
    
        #endregion
        
        #region By Association
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Rental's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="rental">Rental to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByRental(this IQueryable<Sakila.Data.Entities.Payment> queryable, Sakila.Data.Entities.Rental rental)
        {
            return queryable.ByRental(ComparisonOperator.Equals, rental);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Rental's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="rental">Rental to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByRental(this IQueryable<Sakila.Data.Entities.Payment> queryable, ComparisonOperator comparisonOperator, Sakila.Data.Entities.Rental rental)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(p => p.Rental == rental);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.Rental != rental);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Rental's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="rentalId">RentalId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByRental(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.Int32 rentalId)
        {
            return queryable.ByRental(ComparisonOperator.Equals, rentalId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Rental's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="rentalId">RentalId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByRental(this IQueryable<Sakila.Data.Entities.Payment> queryable, ComparisonOperator comparisonOperator, System.Int32 rentalId)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(p => p.Rental.RentalId == rentalId);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.Rental.RentalId != rentalId);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Customer's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="customer">Customer to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByCustomer(this IQueryable<Sakila.Data.Entities.Payment> queryable, Sakila.Data.Entities.Customer customer)
        {
            return queryable.ByCustomer(ComparisonOperator.Equals, customer);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Customer's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="customer">Customer to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByCustomer(this IQueryable<Sakila.Data.Entities.Payment> queryable, ComparisonOperator comparisonOperator, Sakila.Data.Entities.Customer customer)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(p => p.Customer == customer);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.Customer != customer);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Customer's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="customerId">CustomerId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByCustomer(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.Int16 customerId)
        {
            return queryable.ByCustomer(ComparisonOperator.Equals, customerId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Customer's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="customerId">CustomerId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByCustomer(this IQueryable<Sakila.Data.Entities.Payment> queryable, ComparisonOperator comparisonOperator, System.Int16 customerId)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(p => p.Customer.CustomerId == customerId);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.Customer.CustomerId != customerId);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Staff's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="staff">Staff to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByStaff(this IQueryable<Sakila.Data.Entities.Payment> queryable, Sakila.Data.Entities.Staff staff)
        {
            return queryable.ByStaff(ComparisonOperator.Equals, staff);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Staff's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="staff">Staff to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByStaff(this IQueryable<Sakila.Data.Entities.Payment> queryable, ComparisonOperator comparisonOperator, Sakila.Data.Entities.Staff staff)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(p => p.Staff == staff);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.Staff != staff);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Staff's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="staffId">StaffId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByStaff(this IQueryable<Sakila.Data.Entities.Payment> queryable, System.Byte staffId)
        {
            return queryable.ByStaff(ComparisonOperator.Equals, staffId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Payment by Staff's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="staffId">StaffId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Payment> ByStaff(this IQueryable<Sakila.Data.Entities.Payment> queryable, ComparisonOperator comparisonOperator, System.Byte staffId)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(p => p.Staff.StaffId == staffId);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.Staff.StaffId != staffId);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        #endregion
    }
}
#pragma warning restore 1591

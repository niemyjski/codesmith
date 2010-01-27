//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'LineItemList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class LineItemList : BusinessListBase< LineItemList, LineItem >
    {    
        #region Contructor(s)
        
        private LineItemList()
        { 
            AllowNew = true;
        }
        
        #endregion

        #region Factory Methods 
        
        public static LineItemList NewList()
        {
            return DataPortal.Create< LineItemList >();
        }

        public static LineItemList GetByOrderIdLineNum(System.Int32 orderId, System.Int32 lineNum)
        {
            return DataPortal.Fetch< LineItemList >(
                new LineItemCriteria{OrderId = orderId, LineNum = lineNum});
        }

        public static LineItemList GetByOrderId(System.Int32 orderId)
        {
            return DataPortal.Fetch< LineItemList >(
                new LineItemCriteria{OrderId = orderId});
        }

        public static LineItemList GetAll()
        {
            return DataPortal.Fetch< LineItemList >(new LineItemCriteria());
        }

        #endregion

        #region Properties
        
        protected override object AddNewCore()
        {
            LineItem item = PetShop.Tests.ParameterizedSQL.LineItem.NewLineItem();
            Add(item);
            return item;
        }
        
        #endregion

        #region Exists Command

        public static bool Exists(LineItemCriteria criteria)
        {
            return LineItem.Exists(criteria);
        }

        #endregion
    }
}
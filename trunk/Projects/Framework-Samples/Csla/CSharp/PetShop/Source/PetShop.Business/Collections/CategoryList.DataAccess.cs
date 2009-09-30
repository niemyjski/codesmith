
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.7.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'CategoryList.cs'.
//
//     Template: EditableRootList.DataAccess.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;

using Csla;
using Csla.Data;

using PetShop.Data;

#endregion

namespace PetShop.Business
{
	public partial class CategoryList
	{
		#region Data Access
		
        [RunLocal]
        protected override void DataPortal_Create()
        {
        }
        
		private void DataPortal_Fetch(CategoryCriteria criteria)
		{
            RaiseListChangedEvents = false;
            
            using(SafeDataReader reader = DataAccessLayer.Instance.CategoryFetch(criteria.StateBag)) 
			{
                while(reader.Read())
				{	
                    this.Add(new PetShop.Business.Category(reader));
				}
			}
            
            RaiseListChangedEvents = true;
		}
        
	        protected override void DataPortal_Update()
	        {
	            Child_Update();
	        }
       
		#endregion
	}
}
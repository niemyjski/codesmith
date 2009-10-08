
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.7.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Cart.cs'.
//
//     Template: EditableChild.DataAccess.cst
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
	public partial class Cart
	{
		#region Data Access
		
		protected override void Child_Create()
		{
			// TODO: load default values
			// omit this override if you have no defaults to set
			//base.Child_Create();
		}
		
		private void Child_Fetch(object criteria)
		{
			CartCriteria theCriteria = criteria as CartCriteria;
            if (theCriteria != null)
            {
				using(SafeDataReader reader = DataAccessLayer.Instance.CartFetch(theCriteria.StateBag)) 
				{
					if(reader.Read())
					{	
						Fetch(reader);
					}
				}
			}
		}
		
		private void Child_Insert()
		{
			using(SafeDataReader reader = DataAccessLayer.Instance.CartInsert(ReadProperty(_itemIdProperty), ReadProperty(_nameProperty), ReadProperty(_typeProperty), ReadProperty(_priceProperty), ReadProperty(_categoryIdProperty), ReadProperty(_productIdProperty), ReadProperty(_isShoppingCartProperty), ReadProperty(_quantityProperty), ReadProperty(_uniqueIDProperty)))
			{
				if(reader.Read())
				{

					LoadProperty(_cartIdProperty, reader.GetInt32("CartId"));
				}
			}
		}
		
		private void Child_Update()
		{
            using(SafeDataReader reader = DataAccessLayer.Instance.CartUpdate(ReadProperty(_cartIdProperty), ReadProperty(_itemIdProperty), ReadProperty(_nameProperty), ReadProperty(_typeProperty), ReadProperty(_priceProperty), ReadProperty(_categoryIdProperty), ReadProperty(_productIdProperty), ReadProperty(_isShoppingCartProperty), ReadProperty(_quantityProperty), ReadProperty(_uniqueIDProperty)))
            {
			}
		}
		
		private void Child_DeleteSelf()
		{
			DataPortal_Delete(new CartCriteria(CartId));
		}
		
        [Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Delete(object criteria)
		{
			CartCriteria theCriteria = criteria as CartCriteria;
            if (theCriteria != null)
            {
				using(SafeDataReader reader = DataAccessLayer.Instance.CartDelete(theCriteria.StateBag)) 
				{
				}
			}
        }
        
		private void Fetch(SafeDataReader reader)
		{
			LoadProperty(_cartIdProperty, reader.GetInt32("CartId"));
			LoadProperty(_itemIdProperty, reader.GetString("ItemId"));
			LoadProperty(_nameProperty, reader.GetString("Name"));
			LoadProperty(_typeProperty, reader.GetString("Type"));
			LoadProperty(_priceProperty, reader.GetDecimal("Price"));
			LoadProperty(_categoryIdProperty, reader.GetString("CategoryId"));
			LoadProperty(_productIdProperty, reader.GetString("ProductId"));
			LoadProperty(_isShoppingCartProperty, reader.GetBoolean("IsShoppingCart"));
			LoadProperty(_quantityProperty, reader.GetInt32("Quantity"));

			LoadProperty(_uniqueIDProperty, reader.GetInt32("UniqueID"));

            MarkAsChild();
            MarkOld();
        }
		
		#endregion
	}
}
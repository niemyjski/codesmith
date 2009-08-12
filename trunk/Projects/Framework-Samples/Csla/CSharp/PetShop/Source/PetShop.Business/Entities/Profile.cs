//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.7.X CodeSmith Templates.
//	   Changes to this template will not be lost.
//
//     Template: SwitchableObject.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;

using Csla;
using Csla.Security;
using Csla.Validation;

#endregion

namespace PetShop.Business
{
	public partial class Profile
	{
		#region Validation Rules

		/// <summary>
        /// All custom rules need to be placed in this method.
        /// </summary>
        /// <returns>Return true to override the generated rules; If false generated rules will be run.</returns>
		protected bool AddBusinessValidationRules()
		{
			// TODO: add validation rules
			//ValidationRules.AddRule(RuleMethod, "");

		    return false;
		}

		#endregion

		#region Authorization Rules

		protected override void AddAuthorizationRules()
		{
            //// More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

            //string[] canWrite = { "AdminUser", "RegularUser" };
            //string[] canRead = { "AdminUser", "RegularUser", "ReadOnlyUser" };
            //string[] admin = { "AdminUser" };

            // AuthorizationRules.AllowCreate(typeof(Profile), admin);
            // AuthorizationRules.AllowDelete(typeof(Profile), admin);
            // AuthorizationRules.AllowEdit(typeof(Profile), canWrite);
            // AuthorizationRules.AllowGet(typeof(Profile), canRead);

            //// UniqueID
            // AuthorizationRules.AllowWrite(_uniqueIDProperty, canWrite);
            // AuthorizationRules.AllowRead(_uniqueIDProperty, canRead);

            //// Username
            // AuthorizationRules.AllowRead(_usernameProperty, canRead);

            //// ApplicationName
            // AuthorizationRules.AllowRead(_applicationNameProperty, canRead);

            //// IsAnonymous
            // AuthorizationRules.AllowRead(_isAnonymousProperty, canRead);

            //// LastActivityDate
            // AuthorizationRules.AllowRead(_lastActivityDateProperty, canRead);

            //// LastUpdatedDate
            // AuthorizationRules.AllowRead(_lastUpdatedDateProperty, canRead);

            //// Cart
            // AuthorizationRules.AllowRead(_cartProperty, canRead);

            //// Accounts
            // AuthorizationRules.AllowRead(_accountsProperty, canRead);

		}

		private static void AddObjectAuthorizationRules()
		{
			// TODO: add authorization rules
			//AuthorizationRules.AllowEdit(typeof(Profile), "Role");
		}

		#endregion

        #region Custom Factory Methods

        public static Profile GetProfile(string username)
        {
            return DataPortal.Fetch<Profile>(
                new ProfileCriteria { Username = username });
        }

        #endregion

        #region Custom Business Methods

        private static readonly PropertyInfo<CartList> _shoppingCart = RegisterProperty<CartList>(p => p.ShoppingCart, Csla.RelationshipTypes.LazyLoad);
        public CartList ShoppingCart
        {
            get
            {
                if (!FieldManager.FieldExists(_shoppingCart))
                    SetProperty(_shoppingCart, CartList.GetCart(UniqueID, true));

                return GetProperty(_shoppingCart);
            }
        }

        private static readonly PropertyInfo<CartList> _wishList = RegisterProperty<CartList>(p => p.WishList, Csla.RelationshipTypes.LazyLoad);
        public CartList WishList
        {
            get
            {
                if (!FieldManager.FieldExists(_wishList))
                    SetProperty(_wishList, CartList.GetCart(UniqueID, false));

                return GetProperty(_wishList);
            }
        }

        #endregion
    }
}
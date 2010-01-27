//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Category.cs'.
//
//     Template path: EditableRoot.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;
using Csla.Validation;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class Category : BusinessBase< Category >
    {
        #region Contructor(s)

        private Category()
        { /* Require use of factory methods */ }

        private Category(System.String categoryId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_categoryIdProperty, categoryId);
            }
        }

        internal Category(SafeDataReader reader)
        {
            Map(reader);
        }
        #endregion

        #region Validation Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            ValidationRules.AddRule(CommonRules.StringRequired, _categoryIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_categoryIdProperty, 10));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_nameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_descnProperty, 255));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.String > _categoryIdProperty = RegisterProperty< System.String >(p => p.CategoryId);
		[System.ComponentModel.DataObjectField(true, false)]
        public System.String CategoryId
        {
            get { return GetProperty(_categoryIdProperty); }
            set{ SetProperty(_categoryIdProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _nameProperty = RegisterProperty< System.String >(p => p.Name);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
            set{ SetProperty(_nameProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _descnProperty = RegisterProperty< System.String >(p => p.Descn);
        public System.String Descn
        {
            get { return GetProperty(_descnProperty); }
            set{ SetProperty(_descnProperty, value); }
        }


        //AssociatedOneToMany
        private static readonly PropertyInfo< ProductList > _productsProperty = RegisterProperty<ProductList>(p => p.Products, Csla.RelationshipTypes.Child);
        public ProductList Products
        {
            get
            {
                if(!FieldManager.FieldExists(_productsProperty))
                {
                    if(IsNew || !PetShop.Tests.ParameterizedSQL.ProductList.Exists(new PetShop.Tests.ParameterizedSQL.ProductCriteria {CategoryId = CategoryId}))
                        LoadProperty(_productsProperty, PetShop.Tests.ParameterizedSQL.ProductList.NewList());
                    else
                        LoadProperty(_productsProperty, PetShop.Tests.ParameterizedSQL.ProductList.GetByCategoryId(CategoryId));
                }

                return GetProperty(_productsProperty);
            }
        }

        #endregion

        #region Factory Methods 

        public static Category NewCategory()
        {
            return DataPortal.Create< Category >();
        }

        public static Category GetByCategoryId(System.String categoryId)
        {
            return DataPortal.Fetch< Category >(
                new CategoryCriteria{CategoryId = categoryId});
        }

        public static void DeleteCategory(System.String categoryId)
        {
            DataPortal.Delete(new CategoryCriteria{CategoryId = categoryId});
        }

        #endregion

        #region Exists Command

        public static bool Exists(CategoryCriteria criteria)
        {
            return ExistsCommand.Execute(criteria);
        }

        #endregion

    }
}
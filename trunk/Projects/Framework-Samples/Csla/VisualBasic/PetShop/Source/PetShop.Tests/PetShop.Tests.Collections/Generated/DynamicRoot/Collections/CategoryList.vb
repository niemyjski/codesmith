﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v2.0.1.1766, CSLA Framework: v3.8.2.
'       Changes to this template will not be lost.
'
'     Template: DynamicRootList.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla

Namespace PetShop.Tests.Collections.DynamicRoot
    Public Partial Class CategoryList
        #Region "Authorization Rules"
    
        Private Sub AddAuthorizationRules()
            ''More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).
    
            'Dim canWrite As String() = { "AdminUser", "RegularUser" }
            'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
            'Dim admin As String() = { "AdminUser" }
    
            'AuthorizationRules.AllowCreate(GetType(CategoryList), admin)
            'AuthorizationRules.AllowDelete(GetType(CategoryList), admin)
            'AuthorizationRules.AllowEdit(GetType(CategoryList), canWrite)
            'AuthorizationRules.AllowGet(GetType(CategoryList), canRead)
    
            ''CategoryId
            'AuthorizationRules.AllowWrite(_categoryIdProperty, canWrite)
            'AuthorizationRules.AllowRead(_categoryIdProperty, canRead)
    
            ''Name
            'AuthorizationRules.AllowWrite(_nameProperty, canWrite)
            'AuthorizationRules.AllowRead(_nameProperty, canRead)
    
            ''Description
            'AuthorizationRules.AllowWrite(_descriptionProperty, canWrite)
            'AuthorizationRules.AllowRead(_descriptionProperty, canRead)
    
    ' NOTE: Many-To-Many support coming soon.
            ''Products
            'AuthorizationRules.AllowRead(_productsProperty, canRead)
    
        End Sub
    
        #End Region
    End Class
End Namespace
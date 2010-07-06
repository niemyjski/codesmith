﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v2.0.1.1766, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'SupplierList.vb.
'
'     Template: EditableChildList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.StoredProcedures
    <Serializable()> _
    Public Partial Class SupplierList 
        Inherits BusinessListBase(Of SupplierList, Supplier)
    
        #Region "Contructor(s)"
        Private Sub New()
            AllowNew = true
            MarkAsChild()
        End Sub
    
        #End Region
    
        #Region "Synchronous Factory Methods" 
    
        Friend Shared Function NewList() As SupplierList
            Return DataPortal.CreateChild(Of SupplierList)()
        End Function
    
        Friend Shared Function GetBySuppId(ByVal suppId As System.Int32) As SupplierList 
            Dim criteria As New SupplierCriteria()
            criteria.SuppId = suppId
    
            Return DataPortal.FetchChild(Of SupplierList)(criteria)
        End Function
    
        Friend Shared Function GetAll() As SupplierList
            Return DataPortal.FetchChild(Of SupplierList)(New SupplierCriteria())
        End Function
    
        #End Region
    
        #Region "Method Overrides"
    
        Protected Overrides Function AddNewCore() As Object
            Dim item As Supplier = PetShop.Tests.StoredProcedures.Supplier.NewSupplier()
    
            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null in the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Tests.StoredProcedures.Supplier.NewSupplier()
                End If
                Add(item)
            End If
    
            Return item
        End Function
    
        #End Region
    
    
        #Region "Exists Command"
    
        Public Shared Function Exists(ByVal criteria As SupplierCriteria) As Boolean
            Return PetShop.Tests.StoredProcedures.Supplier.Exists(criteria)
        End Function
    
        #End Region
        
        #Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As SupplierCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByVal item As Supplier, ByRef cancel As Boolean)
        End Sub
    
        #End Region
    End Class
End Namespace
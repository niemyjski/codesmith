﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v2.0.1.1766, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'AccountList.vb.
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

Namespace PetShop.Business
    <Serializable()> _
    Public Partial Class AccountList 
        Inherits BusinessListBase(Of AccountList, Account)
    
        #Region "Contructor(s)"
        Private Sub New()
            AllowNew = true
            MarkAsChild()
        End Sub
    
        #End Region
    
        #Region "Synchronous Factory Methods" 
    
        Friend Shared Function NewList() As AccountList
            Return DataPortal.CreateChild(Of AccountList)()
        End Function
    
        Friend Shared Function GetByAccountId(ByVal accountId As System.Int32) As AccountList 
            Dim criteria As New AccountCriteria()
            criteria.AccountId = accountId
    
            Return DataPortal.FetchChild(Of AccountList)(criteria)
        End Function
    
        Friend Shared Function GetByUniqueID(ByVal uniqueID As System.Int32) As AccountList 
            Dim criteria As New AccountCriteria()
            criteria.UniqueID = uniqueID
    
            Return DataPortal.FetchChild(Of AccountList)(criteria)
        End Function
    
        Friend Shared Function GetAll() As AccountList
            Return DataPortal.FetchChild(Of AccountList)(New AccountCriteria())
        End Function
    
        #End Region
    
        #Region "Method Overrides"
    
        Protected Overrides Function AddNewCore() As Object
            Dim item As Account = PetShop.Business.Account.NewAccount()
    
            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null in the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Business.Account.NewAccount()
                End If
            ' Pass the parent value down to the child.
                Dim profile As Profile = CType(Me.Parent, Profile)
                If Not(profile Is Nothing)
                    item.UniqueID = profile.UniqueID
                End If
                Add(item)
            End If
    
            Return item
        End Function
    
        #End Region
    
    
        #Region "Exists Command"
    
        Public Shared Function Exists(ByVal criteria As AccountCriteria) As Boolean
            Return PetShop.Business.Account.Exists(criteria)
        End Function
    
        #End Region
        
        #Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As AccountCriteria, ByRef cancel As Boolean)
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
        Partial Private Sub OnAddNewCore(ByVal item As Account, ByRef cancel As Boolean)
        End Sub
    
        #End Region
    End Class
End Namespace
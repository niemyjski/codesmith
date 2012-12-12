﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'ProfileList.vb.
'
'     Template: EditableRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Linq

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.OF.StoredProcedures
    <Serializable()> _
    <Csla.Server.ObjectFactory(FactoryNames.ProfileListFactoryName)> _
    Public Partial Class ProfileList 
        Inherits BusinessListBase(Of ProfileList, Profile)
    
#Region "Contructor(s)"


        public Sub New()
            AllowNew = true
        End Sub

#End Region

#Region "Method Overrides"

        Protected Overrides Function AddNewCore() As Profile
            Dim item As Profile = PetShop.Tests.OF.StoredProcedures.Profile.NewProfileChild()

            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null In the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Tests.OF.StoredProcedures.Profile.NewProfileChild()
                End If
                Add(item)
            End If

            Return item
        End Function

#End Region

#Region "Synchronous Factory Methods"

        ''' <summary>
        ''' Creates a new object of type <see cref="ProfileList"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="ProfileList"/>.</returns>
        Public Shared Function NewList() As ProfileList
            Return DataPortal.Create(Of ProfileList)()
        End Function
    
        ''' <summary>
        ''' Returns a <see cref="ProfileList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="uniqueID">No additional detail available.</param>
        ''' <returns>A <see cref="ProfileList"/> object of the specified criteria.</returns>
        Public Shared Function GetByUniqueID(ByVal uniqueID As System.Int32) As ProfileList 
            Dim criteria As New ProfileCriteria()
                        criteria.UniqueID = uniqueID
    
            Return DataPortal.Fetch(Of ProfileList)(criteria)
        End Function
    
        ''' <summary>
        ''' Returns a <see cref="ProfileList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="username">No additional detail available.</param>
        ''' <param name="applicationName">No additional detail available.</param>
        ''' <returns>A <see cref="ProfileList"/> object of the specified criteria.</returns>
        Public Shared Function GetByUsernameApplicationName(ByVal username As System.String, ByVal applicationName As System.String) As ProfileList 
            Dim criteria As New ProfileCriteria()
                        criteria.Username = username
            criteria.ApplicationName = applicationName
    
            Return DataPortal.Fetch(Of ProfileList)(criteria)
        End Function

        Public Shared Function GetByCriteria(ByVal criteria As ProfileCriteria) As ProfileList
            Return DataPortal.Fetch(Of ProfileList)(criteria)
        End Function

        Public Shared Function GetAll() As ProfileList
            Return DataPortal.Fetch(Of ProfileList)(New ProfileCriteria())
        End Function

#End Region

#Region "Asynchronous Factory Methods"
            
        Public Shared Sub NewListAsync(ByVal handler As EventHandler(Of DataPortalResult(Of ProfileList)))
            Dim dp As New DataPortal(Of ProfileList)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Public Shared Sub GetByUniqueIDAsync(ByVal uniqueID As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of ProfileList)))
            Dim dp As New DataPortal(Of ProfileList)()
            AddHandler dp.FetchCompleted, handler
    
            Dim criteria As New ProfileCriteria()
            criteria.UniqueID = uniqueID
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub GetByUsernameApplicationNameAsync(ByVal username As System.String, ByVal applicationName As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of ProfileList)))
            Dim dp As New DataPortal(Of ProfileList)()
            AddHandler dp.FetchCompleted, handler
    
            Dim criteria As New ProfileCriteria()
            criteria.Username = username
            criteria.ApplicationName = applicationName
    
            dp.BeginFetch(criteria)
        End Sub

        Public Shared Sub GetByCriteriaAsync(ByVal criteria As ProfileCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ProfileList)))
            Dim dp As New DataPortal(Of ProfileList)()
            AddHandler dp.FetchCompleted, handler

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

        Public Shared Sub GetAllAsync(ByVal handler As EventHandler(Of DataPortalResult(Of ProfileList)))
            Dim dp As New DataPortal(Of ProfileList)()
            AddHandler dp.FetchCompleted, handler
            dp.BeginFetch(New ProfileCriteria())
        End Sub

#End Region

#Region "Property overrides"
    
            ''' <summary>
            ''' Returns true if any children are dirty
            ''' </summary>
            Public Shadows ReadOnly Property IsDirty() As Boolean
                Get
                    For Each item As Profile In Me.Items
                        If item.IsDirty Then
                            Return True
                        End If
                    Next
            
                    Return False
                End Get
            End Property
    
#End Region
    
#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' CodeSmith generated stub method that is called when creating the child <see cref="Profile"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when fetching the child <see cref="Profile"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="ProfileCriteria"/> object containing the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As ProfileCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="Profile"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="Profile"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when updating the <see cref="Profile"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="Profile"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByRef item As Profile, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"

        ''' <summary>
        ''' Determines if a record exists in the Profile in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is a <see cref="ProfileList"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As ProfileCriteria) As Boolean
            Return PetShop.Tests.OF.StoredProcedures.Profile.Exists(criteria)
        End Function

        ''' <summary>
        ''' Determines if a record exists in the Profile in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As ProfileCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Tests.OF.StoredProcedures.Profile.ExistsAsync(criteria, handler)
        End Sub

#End Region
 
#region "Enhancements"

        Public Function GetProfile(ByVal uniqueID As System.Int32) As Profile
            Return Me.FirstOrDefault(Function(i As Profile) i.UniqueID = uniqueID)
        End Function
        
        Public Overloads Function Contains(ByVal uniqueID As System.Int32) As Boolean
            Return Me.Where(Function(i As Profile) i.UniqueID = uniqueID).Count() > 0
        End Function

        Public Overloads Function ContainsDeleted(ByVal uniqueID As System.Int32) As Boolean
            Return DeletedList.Where(Function(i As Profile) i.UniqueID = uniqueID).Count() > 0
        End Function

        Public Overloads Sub Remove(ByVal uniqueID As System.Int32)
            Dim item As Profile = Me.FirstOrDefault(Function(i As Profile) i.UniqueID = uniqueID)
            If item IsNot Nothing Then
                Remove(item)
            End If
        End Sub
        
#End Region
    End Class
End Namespace
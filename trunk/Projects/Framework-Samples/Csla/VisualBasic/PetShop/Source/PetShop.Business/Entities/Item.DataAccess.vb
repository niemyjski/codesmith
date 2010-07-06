﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v2.0.1.1766, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Item.vb.
'
'     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq

Imports Csla
Imports Csla.Data

Namespace PetShop.Business
    Public Partial Class Item
    
        #Region "Root Data Access"
    
        <RunLocal()> _
        Protected Overrides Sub DataPortal_Create()
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return
            End If
    
            LoadProperty(_productIdProperty, "BN")
            ValidationRules.CheckRules()
    
            OnCreated()
        End Sub
    
        Private Shadows Sub DataPortal_Fetch(ByVal criteria As ItemCriteria )
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnFetched()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Overrides Sub DataPortal_Insert()
            Dim cancel As Boolean = False
            OnInserting(cancel)
            If (cancel) Then
                Return
            End If
    
            Const commandText As String = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
			command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
			command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(Me.ListPrice))
			command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(Me.UnitCost))
			command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(Me.Supplier))
			command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(Me.Status))
			command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
			command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
    
                LoadProperty(_originalItemIdProperty, Me.ItemId)
    
    
                FieldManager.UpdateChildren(Me, connection)
            End Using
    
            OnInserted()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Overrides Sub DataPortal_Update()
            Dim cancel As Boolean = False
            OnUpdating(cancel)
            If (cancel) Then
                Return
            End If
    
            If Not OriginalItemId = ItemId Then
                ' Insert new child.
                Dim item As New Item()
                item.ItemId = ItemId
			item.ProductId = ProductId
			item.ListPrice = ListPrice.Value
			item.UnitCost = UnitCost.Value
			item.Supplier = Supplier.Value
			item.Status = Status
			item.Name = Name
			item.Image = Image
                item = item.Save()
    
                ' Mark child lists as dirty. This code may need to be updated to one-to-one relationships.
    
                ' Create a new connection.
                Using connection As New SqlConnection(ADOHelper.ConnectionString)
                    connection.Open()
                    FieldManager.UpdateChildren(Me, connection)
                End Using
    
                ' Delete the old.
                Dim criteria As New ItemCriteria()
                criteria.ItemId = OriginalItemId
                DataPortal_Delete(criteria)
    
                ' Mark the original as the new one.
                OriginalItemId = ItemId
                OnUpdated()
    
                Return
            End If
    
            Const commandText As String = "UPDATE [dbo].[Item]  SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_OriginalItemId"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_OriginalItemId", Me.OriginalItemId)
			command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
			command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
			command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(Me.ListPrice))
			command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(Me.UnitCost))
			command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(Me.Supplier))
			command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(Me.Status))
			command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
			command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
                End Using
                LoadProperty(_originalItemIdProperty, Me.ItemId)
    
    
                FieldManager.UpdateChildren(Me, connection)
            End Using
    
            OnUpdated()
        End Sub
    
        Protected Overrides Sub DataPortal_DeleteSelf()
            Dim cancel As Boolean = False
            OnSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New ItemCriteria (ItemId))
        
            OnSelfDeleted()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As ItemCriteria)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("DELETE FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
            End Using
    
            OnDeleted()
        End Sub
    
        '<Transactional(TransactionalTypes.TransactionScope)> _
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As ItemCriteria, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("DELETE FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
    
            OnDeleted()
        End Sub
    
        #End Region
    
        #Region "Child Data Access"
    
        <RunLocal()> _
        Protected Overrides Sub Child_Create()
            Dim cancel As Boolean = False
            OnChildCreating(cancel)
            If (cancel) Then
                Return
            End If
    
            LoadProperty(_productIdProperty, "BN")
            ValidationRules.CheckRules()
    
            OnChildCreated()
        End Sub
    
        Private Sub Child_Fetch(ByVal criteria As ItemCriteria)
            Dim cancel As Boolean = False
            OnChildFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnChildFetched()
    
            MarkAsChild()
        End Sub
    
        #Region "Child_Insert"
    
        Private Sub Child_Insert(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Const commandText As String = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
			command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
			command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(Me.ListPrice))
			command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(Me.UnitCost))
			command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(Me.Supplier))
			command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(Me.Status))
			command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
			command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
    
        ' Update non-identity primary key value.
        LoadProperty(_originalItemIdProperty, Me.ItemId)
    
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildInserted()
        End Sub
    
        Private Sub Child_Insert(ByVal product As Product, ByVal connection As SqlConnection)
        Child_Insert(product, Nothing, connection)
        End Sub
    
        Private Sub Child_Insert(ByVal supplier As Supplier, ByVal connection As SqlConnection)
        Child_Insert(Nothing, supplier, connection)
        End Sub
    
        Private Sub Child_Insert(ByVal product As Product, ByVal supplier As Supplier, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Const commandText As String = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
			command.Parameters.AddWithValue("@p_ProductId", If(Not(product Is Nothing), product.ProductId, Me.ProductId))
			command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(Me.ListPrice))
			command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(Me.UnitCost))
			command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(If(Not(supplier Is Nothing), supplier.SuppId, Me.Supplier)))
			command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(Me.Status))
			command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
			command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
    
            ' Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            If(Not IsNothing(product) AndAlso Not product.ProductId = Me.ProductId) Then
                LoadProperty(_productIdProperty, product.ProductId)
            End If
    
            ' Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            If(Not IsNothing(supplier) AndAlso Not supplier.SuppId = Me.Supplier) Then
                LoadProperty(_supplierProperty, supplier.SuppId)
            End If
    
        ' Update non-identity primary key value.
        LoadProperty(_originalItemIdProperty, Me.ItemId)
    
            ' A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            ' TODO: Please override OnChildInserted() and insert this child manually.
            'FieldManager.UpdateChildren(Me, connection)
    
            OnChildInserted()
        End Sub
    
    
        #End Region
    
        #Region "Child_Update"
    
        Private Sub Child_Update(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If connection.State <> ConnectionState.Open Then connection.Open()
            Const commandText As String = "UPDATE [dbo].[Item]  SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_OriginalItemId"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OriginalItemId", Me.OriginalItemId)
			command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
			command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
			command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(Me.ListPrice))
			command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(Me.UnitCost))
			command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(Me.Supplier))
			command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(Me.Status))
			command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
			command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
                ' Update non-identity primary key value.
                LoadProperty(_originalItemIdProperty, Me.ItemId)
            End Using
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
        Private Sub Child_Update(ByVal product As Product, ByVal connection As SqlConnection)
        Child_Update(product, Nothing, connection)
        End Sub
    
        Private Sub Child_Update(ByVal supplier As Supplier, ByVal connection As SqlConnection)
        Child_Update(Nothing, supplier, connection)
        End Sub
    
        Private Sub Child_Update(ByVal product As Product, ByVal supplier As Supplier, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If connection.State <> ConnectionState.Open Then connection.Open()
            Const commandText As String = "UPDATE [dbo].[Item]  SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_OriginalItemId"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OriginalItemId", Me.OriginalItemId)
			command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
			command.Parameters.AddWithValue("@p_ProductId", If(Not(product Is Nothing), product.ProductId, Me.ProductId))
			command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(Me.ListPrice))
			command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(Me.UnitCost))
			command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(If(Not(supplier Is Nothing), supplier.SuppId, Me.Supplier)))
			command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(Me.Status))
			command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
			command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
                ' Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                If(Not IsNothing(product) AndAlso Not product.ProductId = Me.ProductId) Then
                    LoadProperty(_productIdProperty, product.ProductId)
                End If
    
                ' Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                If(Not IsNothing(supplier) AndAlso Not supplier.SuppId = Me.Supplier) Then
                    LoadProperty(_supplierProperty, supplier.SuppId)
                End If
    
                ' Update non-identity primary key value.
                LoadProperty(_originalItemIdProperty, Me.ItemId)
            End Using
            ' A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            ' TODO: Please override OnChildUpdated() and update this child manually.
            'FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
    
        #End Region
    
        Private Sub Child_DeleteSelf()
            Dim cancel As Boolean = False
            OnChildSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New ItemCriteria (ItemId))
        
            OnChildSelfDeleted()
        End Sub
        
        Private Sub Child_DeleteSelf(ParamArray args As Object())
        Dim connection As SqlConnection = args.OfType(Of SqlConnection)().FirstOrDefault()
        If connection Is Nothing Then
            Throw New ArgumentNullException("args", "Must contain a SqlConnection parameter.")
        End If
        
            Dim cancel As Boolean = False
            OnChildSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New ItemCriteria (ItemId), connection)
        
            OnChildSelfDeleted()
        End Sub
    
        #End Region
    
        Private Sub Map(ByVal reader As SafeDataReader)
            Dim cancel As Boolean = False
            OnMapping(reader, cancel)
            If (cancel) Then
                Return
            End If
    
            Using(BypassPropertyChecks)
                LoadProperty(_itemIdProperty, reader.Item("ItemId"))
                LoadProperty(_originalItemIdProperty, reader.Item("ItemId"))
                LoadProperty(_productIdProperty, reader.Item("ProductId"))
                LoadProperty(_listPriceProperty, reader.Item("ListPrice"))
                LoadProperty(_unitCostProperty, reader.Item("UnitCost"))
                LoadProperty(_supplierProperty, reader.Item("Supplier"))
                LoadProperty(_statusProperty, reader.Item("Status"))
                LoadProperty(_nameProperty, reader.Item("Name"))
                LoadProperty(_imageProperty, reader.Item("Image"))
            End Using
    
            OnMapped()
    
            MarkOld()
        End Sub
    End Class
End Namespace

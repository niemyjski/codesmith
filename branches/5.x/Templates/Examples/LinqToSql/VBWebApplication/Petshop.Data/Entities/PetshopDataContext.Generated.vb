
'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO Not MODIfY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------


Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Diagnostics
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


Namespace Petshop.Data
    ''' <summary>
    ''' The DataContext class for the Petshop database.
    ''' </summary>
    Partial public Class PetshopDataContext 
    Inherits DataContext
        Private Shared mappingCache As MappingSource = New AttributeMappingSource()

        #Region "ConnectionString"
        Private Const CONNECTION_NAME As String = "PetshopConnectionString"
        Private Shared _connectionString As String
        Private Shared _connectionLock As New Object()
        
        ''' <summary>The application connection string read from web.config or app.config</summary>
        ''' <example>
        ''' Add the following key to the "connectionStrings" section of your config:
        ''' <code><![CDATA[
        ''' <configuration>
        '''     <connectionStrings>
        '''         <add name="PetshopConnectionString" 
        '''             connectionString="Data Source=(local);Initial Catalog=DATABASE;Integrated Security=True"
        '''             providerName="System.Data.SqlClient" />
        '''     </connectionStrings>
        ''' </configuration>
        ''' ]]></code>
        ''' </example>
        Public Shared ReadOnly Property ConnectionString() As String
        
            Get
                If _connectionString Is Nothing Then
                    SyncLock _connectionLock
                    If _connectionString Is Nothing Then
                        _connectionString = GetDefaultConnectionString()
                    End If
                    End SyncLock
                End If
                Return _connectionString
            End Get
        End Property
        Private Shared Function GetDefaultConnectionString() As String
            Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings(CONNECTION_NAME)
            If settings Is Nothing Then
                Dim message As String = String.Format("Could not find the connection string '{0}' in the configuration file.  " + "Please add an entry to connectionStrings section named '{0}'.", CONNECTION_NAME)
                Throw New ConfigurationErrorsException(message)
            End If
            Return settings.ConnectionString
        End Function
        #End Region

        #Region "Constructors"
        ''' <summary>
        ''' Initializes the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        <DebuggerNonUserCodeAttribute> _
        Shared Sub New()
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        <DebuggerNonUserCodeAttribute> _
        public Sub New()
            MyBase.New(ConnectionString, mappingCache)
            OnCreated()
        End Sub

        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        ''' <param name="connection">The connection string.</param>
        <DebuggerNonUserCodeAttribute> _
        public Sub New(ByVal connection As String)
            MyBase.New(connection, mappingCache)
            OnCreated()
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        ''' <param name="connection">The database connection.</param>
        <DebuggerNonUserCodeAttribute> _
        public Sub New(ByVal connection As IDbConnection)
            MyBase.New(connection, mappingCache)
            OnCreated()
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        ''' <param name="connection">The connection string.</param>
        ''' <param name="mappingSource">The mapping source.</param>
        <DebuggerNonUserCodeAttribute> _
        public Sub New(ByVal connection As String, ByVal mappingSource As MappingSource)
            MyBase.New(connection, mappingSource)
            OnCreated()
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        ''' <param name="connection">The database connection.</param>
        ''' <param name="mappingSource">The mapping source.</param>
        <DebuggerNonUserCodeAttribute> _
        public Sub New(ByVal connection As IDbConnection, ByVal mappingSource As MappingSource)
            MyBase.New(connection, mappingSource)
            OnCreated()
        End Sub
        #End Region
        
        #Region "Tables"
        ''' <summary>Represents the dbo.Account table in the underlying database.</summary>
        public ReadOnly Property Account As Table(Of Account)
            Get
                Return GetTable(Of Account)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Cart table in the underlying database.</summary>
        public ReadOnly Property Cart As Table(Of Cart)
            Get
                Return GetTable(Of Cart)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Category table in the underlying database.</summary>
        public ReadOnly Property Category As Table(Of Category)
            Get
                Return GetTable(Of Category)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Inventory table in the underlying database.</summary>
        public ReadOnly Property Inventory As Table(Of Inventory)
            Get
                Return GetTable(Of Inventory)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Item table in the underlying database.</summary>
        public ReadOnly Property Item As Table(Of Item)
            Get
                Return GetTable(Of Item)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.LineItem table in the underlying database.</summary>
        public ReadOnly Property LineItem As Table(Of LineItem)
            Get
                Return GetTable(Of LineItem)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Orders table in the underlying database.</summary>
        public ReadOnly Property Orders As Table(Of Orders)
            Get
                Return GetTable(Of Orders)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.OrderStatus table in the underlying database.</summary>
        public ReadOnly Property OrderStatus As Table(Of OrderStatus)
            Get
                Return GetTable(Of OrderStatus)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Product table in the underlying database.</summary>
        public ReadOnly Property Product As Table(Of Product)
            Get
                Return GetTable(Of Product)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Profiles table in the underlying database.</summary>
        public ReadOnly Property Profiles As Table(Of Profiles)
            Get
                Return GetTable(Of Profiles)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Supplier table in the underlying database.</summary>
        public ReadOnly Property Supplier As Table(Of Supplier)
            Get
                Return GetTable(Of Supplier)()
            End Get
        End Property
        
        #End Region

        #region "Functions"
        #End Region

        #Region "Extensibility Method Definitions"
        ''' <summary>Called after this instance is created.</summary>
        Partial Private Sub OnCreated()
        End Sub
        ''' <summary>Called before a Account is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertAccount(ByVal instance As Account)
        End Sub
        ''' <summary>Called before a Account is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateAccount(ByVal instance As Account)
        End Sub
        ''' <summary>Called before a Account is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteAccount(ByVal instance As Account)
        End Sub
        ''' <summary>Called before a Cart is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertCart(ByVal instance As Cart)
        End Sub
        ''' <summary>Called before a Cart is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateCart(ByVal instance As Cart)
        End Sub
        ''' <summary>Called before a Cart is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteCart(ByVal instance As Cart)
        End Sub
        ''' <summary>Called before a Category is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertCategory(ByVal instance As Category)
        End Sub
        ''' <summary>Called before a Category is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateCategory(ByVal instance As Category)
        End Sub
        ''' <summary>Called before a Category is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteCategory(ByVal instance As Category)
        End Sub
        ''' <summary>Called before a Inventory is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertInventory(ByVal instance As Inventory)
        End Sub
        ''' <summary>Called before a Inventory is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateInventory(ByVal instance As Inventory)
        End Sub
        ''' <summary>Called before a Inventory is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteInventory(ByVal instance As Inventory)
        End Sub
        ''' <summary>Called before a Item is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertItem(ByVal instance As Item)
        End Sub
        ''' <summary>Called before a Item is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateItem(ByVal instance As Item)
        End Sub
        ''' <summary>Called before a Item is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteItem(ByVal instance As Item)
        End Sub
        ''' <summary>Called before a LineItem is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertLineItem(ByVal instance As LineItem)
        End Sub
        ''' <summary>Called before a LineItem is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateLineItem(ByVal instance As LineItem)
        End Sub
        ''' <summary>Called before a LineItem is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteLineItem(ByVal instance As LineItem)
        End Sub
        ''' <summary>Called before a Orders is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertOrders(ByVal instance As Orders)
        End Sub
        ''' <summary>Called before a Orders is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateOrders(ByVal instance As Orders)
        End Sub
        ''' <summary>Called before a Orders is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteOrders(ByVal instance As Orders)
        End Sub
        ''' <summary>Called before a OrderStatus is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertOrderStatus(ByVal instance As OrderStatus)
        End Sub
        ''' <summary>Called before a OrderStatus is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateOrderStatus(ByVal instance As OrderStatus)
        End Sub
        ''' <summary>Called before a OrderStatus is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteOrderStatus(ByVal instance As OrderStatus)
        End Sub
        ''' <summary>Called before a Product is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertProduct(ByVal instance As Product)
        End Sub
        ''' <summary>Called before a Product is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateProduct(ByVal instance As Product)
        End Sub
        ''' <summary>Called before a Product is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteProduct(ByVal instance As Product)
        End Sub
        ''' <summary>Called before a Profiles is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertProfiles(ByVal instance As Profiles)
        End Sub
        ''' <summary>Called before a Profiles is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateProfiles(ByVal instance As Profiles)
        End Sub
        ''' <summary>Called before a Profiles is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteProfiles(ByVal instance As Profiles)
        End Sub
        ''' <summary>Called before a Supplier is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertSupplier(ByVal instance As Supplier)
        End Sub
        ''' <summary>Called before a Supplier is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateSupplier(ByVal instance As Supplier)
        End Sub
        ''' <summary>Called before a Supplier is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteSupplier(ByVal instance As Supplier)
        End Sub
        #End Region
    End Class
End Namespace


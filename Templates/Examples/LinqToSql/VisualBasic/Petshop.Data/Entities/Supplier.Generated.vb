

'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO Not MODIfY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Diagnostics
Imports System.Runtime.Serialization

Namespace Petshop.Data
    ''' <summary>
    ''' The class representing the dbo.Supplier table.
    ''' </summary>
    <Table(Name:="dbo.Supplier")> _
    <System.Runtime.Serialization.DataContractAttribute()> _
    public Partial Class Supplier
        Inherits LinqEntityBase
        
        #Region "Default Constructor"
        ''' <summary>
        ''' Initializes a new instance of the <see cref="Supplier"/> class.
        ''' </summary>
        <DebuggerNonUserCodeAttribute()> _
        public  Sub New()
            OnCreated()
            _itemList = New EntitySet(Of Item)( _
                New System.Action(Of Item)(AddressOf Me.Attach_ItemList), _
                New System.Action(Of Item)(AddressOf Me.Detach_ItemList))
        End Sub
        #End Region
        
        #Region "Column Mapped Properties"
        
        Private _suppId As Integer

        ''' <summary>
        ''' Gets or sets the SuppId column value.
        ''' </summary>
        <Column(Name:="SuppId", Storage:="_suppId", DbType:="int NOT NULL", IsPrimaryKey:=true, CanBeNull:=false)> _
        <DataMember()> _
        public Property SuppId As Integer
            Get 
				return _suppId 
			End Get
            Set
                If Not _suppId.Equals(value) Then
                    OnSuppIdChanging(value)
                    OnPropertyChanging("SuppId")
                    _suppId = value
                    OnPropertyChanged("SuppId")
                    OnSuppIdChanged()
                End If
            End Set
        End Property
        
        Private _name As String

        ''' <summary>
        ''' Gets or sets the Name column value.
        ''' </summary>
        <Column(Name:="Name", Storage:="_name", DbType:="varchar(80)")> _
        <DataMember()> _
        public Property Name As String
            Get 
				return _name 
			End Get
            Set
                If Not _name.Equals(value) Then
                    OnNameChanging(value)
                    OnPropertyChanging("Name")
                    _name = value
                    OnPropertyChanged("Name")
                    OnNameChanged()
                End If
            End Set
        End Property
        
        Private _status As String

        ''' <summary>
        ''' Gets or sets the Status column value.
        ''' </summary>
        <Column(Name:="Status", Storage:="_status", DbType:="varchar(2) NOT NULL", CanBeNull:=false)> _
        <DataMember()> _
        public Property Status As String
            Get 
				return _status 
			End Get
            Set
                If Not _status.Equals(value) Then
                    OnStatusChanging(value)
                    OnPropertyChanging("Status")
                    _status = value
                    OnPropertyChanged("Status")
                    OnStatusChanged()
                End If
            End Set
        End Property
        
        Private _addr1 As String

        ''' <summary>
        ''' Gets or sets the Addr1 column value.
        ''' </summary>
        <Column(Name:="Addr1", Storage:="_addr1", DbType:="varchar(80)")> _
        <DataMember()> _
        public Property Addr1 As String
            Get 
				return _addr1 
			End Get
            Set
                If Not _addr1.Equals(value) Then
                    OnAddr1Changing(value)
                    OnPropertyChanging("Addr1")
                    _addr1 = value
                    OnPropertyChanged("Addr1")
                    OnAddr1Changed()
                End If
            End Set
        End Property
        
        Private _addr2 As String

        ''' <summary>
        ''' Gets or sets the Addr2 column value.
        ''' </summary>
        <Column(Name:="Addr2", Storage:="_addr2", DbType:="varchar(80)")> _
        <DataMember()> _
        public Property Addr2 As String
            Get 
				return _addr2 
			End Get
            Set
                If Not _addr2.Equals(value) Then
                    OnAddr2Changing(value)
                    OnPropertyChanging("Addr2")
                    _addr2 = value
                    OnPropertyChanged("Addr2")
                    OnAddr2Changed()
                End If
            End Set
        End Property
        
        Private _city As String

        ''' <summary>
        ''' Gets or sets the City column value.
        ''' </summary>
        <Column(Name:="City", Storage:="_city", DbType:="varchar(80)")> _
        <DataMember()> _
        public Property City As String
            Get 
				return _city 
			End Get
            Set
                If Not _city.Equals(value) Then
                    OnCityChanging(value)
                    OnPropertyChanging("City")
                    _city = value
                    OnPropertyChanged("City")
                    OnCityChanged()
                End If
            End Set
        End Property
        
        Private _state As String

        ''' <summary>
        ''' Gets or sets the State column value.
        ''' </summary>
        <Column(Name:="State", Storage:="_state", DbType:="varchar(80)")> _
        <DataMember()> _
        public Property State As String
            Get 
				return _state 
			End Get
            Set
                If Not _state.Equals(value) Then
                    OnStateChanging(value)
                    OnPropertyChanging("State")
                    _state = value
                    OnPropertyChanged("State")
                    OnStateChanged()
                End If
            End Set
        End Property
        
        Private _zip As String

        ''' <summary>
        ''' Gets or sets the Zip column value.
        ''' </summary>
        <Column(Name:="Zip", Storage:="_zip", DbType:="varchar(5)")> _
        <DataMember()> _
        public Property Zip As String
            Get 
				return _zip 
			End Get
            Set
                If Not _zip.Equals(value) Then
                    OnZipChanging(value)
                    OnPropertyChanging("Zip")
                    _zip = value
                    OnPropertyChanged("Zip")
                    OnZipChanged()
                End If
            End Set
        End Property
        
        Private _phone As String

        ''' <summary>
        ''' Gets or sets the Phone column value.
        ''' </summary>
        <Column(Name:="Phone", Storage:="_phone", DbType:="varchar(40)")> _
        <DataMember()> _
        public Property Phone As String
            Get 
				return _phone 
			End Get
            Set
                If Not _phone.Equals(value) Then
                    OnPhoneChanging(value)
                    OnPropertyChanging("Phone")
                    _phone = value
                    OnPropertyChanged("Phone")
                    OnPhoneChanged()
                End If
            End Set
        End Property
        #End Region
        
        #Region "Association Mapped Properties"
        
        Private _itemList As EntitySet(Of Item)
        
        ''' <summary>
        ''' Gets or sets the Item association.
        ''' </summary>
        <Association(Name:="Supplier_Item", Storage:="_itemList", ThisKey:="SuppId", OtherKey:="Supplier")> _
        <DataMember()> _
        public Property ItemList As EntitySet(Of Item)
            Get
				return _itemList
			End GET
            Set
				_itemList.Assign(value)
			End SET
        End Property
        
        <DebuggerNonUserCodeAttribute()> _
        Private Sub Attach_ItemList(ByVal entity As Item)
            OnPropertyChanging(Nothing)
            entity.Supplier1 = Me
            OnPropertyChanged(Nothing)
        End Sub
        
        <DebuggerNonUserCodeAttribute()> _
        Private Sub Detach_ItemList(ByVal entity As Item)
            OnPropertyChanging(Nothing)
            entity.Supplier1 = Nothing
            OnPropertyChanged(Nothing)
        End Sub
        #End Region
        
        #Region "Extensibility Method Definitions"
        ''' <summary>Called when this instance is loaded.</summary>
        Private Partial Sub OnLoaded()
		End Sub
        ''' <summary>Called when this instance is being saved.</summary>
        Private Partial Sub OnValidate(ByVal action As ChangeAction)
		End Sub
        ''' <summary>Called when this instance is created.</summary>
        Private Partial Sub OnCreated()
		End Sub
        ''' <summary>Called when SuppId is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnSuppIdChanging(ByVal value As Integer)
		End Sub
        ''' <summary>Called after SuppId has Changed.</summary>
        Private Partial Sub OnSuppIdChanged()
		End Sub
        ''' <summary>Called when Name is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnNameChanging(ByVal value As String)
		End Sub
        ''' <summary>Called after Name has Changed.</summary>
        Private Partial Sub OnNameChanged()
		End Sub
        ''' <summary>Called when Status is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnStatusChanging(ByVal value As String)
		End Sub
        ''' <summary>Called after Status has Changed.</summary>
        Private Partial Sub OnStatusChanged()
		End Sub
        ''' <summary>Called when Addr1 is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnAddr1Changing(ByVal value As String)
		End Sub
        ''' <summary>Called after Addr1 has Changed.</summary>
        Private Partial Sub OnAddr1Changed()
		End Sub
        ''' <summary>Called when Addr2 is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnAddr2Changing(ByVal value As String)
		End Sub
        ''' <summary>Called after Addr2 has Changed.</summary>
        Private Partial Sub OnAddr2Changed()
		End Sub
        ''' <summary>Called when City is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnCityChanging(ByVal value As String)
		End Sub
        ''' <summary>Called after City has Changed.</summary>
        Private Partial Sub OnCityChanged()
		End Sub
        ''' <summary>Called when State is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnStateChanging(ByVal value As String)
		End Sub
        ''' <summary>Called after State has Changed.</summary>
        Private Partial Sub OnStateChanged()
		End Sub
        ''' <summary>Called when Zip is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnZipChanging(ByVal value As String)
		End Sub
        ''' <summary>Called after Zip has Changed.</summary>
        Private Partial Sub OnZipChanged()
		End Sub
        ''' <summary>Called when Phone is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnPhoneChanging(ByVal value As String)
		End Sub
        ''' <summary>Called after Phone has Changed.</summary>
        Private Partial Sub OnPhoneChanged()
		End Sub
        #End Region
        
    End Class
End Namespace


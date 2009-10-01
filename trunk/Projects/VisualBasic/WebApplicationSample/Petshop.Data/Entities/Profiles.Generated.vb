﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO Not MODIfY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------
Imports System
Imports System.Linq

Namespace Petshop.Data
    ''' <summary>
    ''' The class representing the dbo.Profiles table.
    ''' </summary>
    <System.Data.Linq.Mapping.Table(Name:="dbo.Profiles")> _
    <System.Runtime.Serialization.DataContract(IsReference:=True)> _
    <System.ComponentModel.DataAnnotations.ScaffoldTable(True)> _
    <System.ComponentModel.DataAnnotations.MetadataType(GetType(Profiles.Metadata))> _
    <System.Data.Services.Common.DataServiceKey("UniqueID")> _
    <System.Diagnostics.DebuggerDisplay("UniqueID: {UniqueID}")> _
    Partial Public Class Profiles
        Inherits LinqEntityBase
        Implements ICloneable

#Region "Static Constructor"
        ''' <summary>
        ''' Initializes the <see cref="Profiles"/> class.
        ''' </summary>
        Shared Sub New()
            CodeSmith.Data.Rules.RuleManager.AddShared(Of Profiles)()
            AddSharedRules()
        End Sub
#End Region

#Region "Default Constructor"
        ''' <summary>
        ''' Initializes a new instance of the <see cref="Profiles"/> class.
        ''' </summary>
        <System.Diagnostics.DebuggerNonUserCode()> _
        Public Sub New()
            Initialize()
        End Sub

        Private Sub Initialize()
            _accountList = New System.Data.Linq.EntitySet(Of Account)( _
                New System.Action(Of Account)(AddressOf Me.OnAccountListAdd), _
                New System.Action(Of Account)(AddressOf Me.OnAccountListRemove))
            _cartList = New System.Data.Linq.EntitySet(Of Cart)( _
                New System.Action(Of Cart)(AddressOf Me.OnCartListAdd), _
                New System.Action(Of Cart)(AddressOf Me.OnCartListRemove))
            OnCreated()
        End Sub
#End Region

#Region "Column Mapped Properties"

        Private _uniqueID As Integer = Nothing

        ''' <summary>
        ''' Gets the UniqueID column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="UniqueID", Storage:="_uniqueID", DbType:="int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True, CanBeNull:=False)> _
        <System.Runtime.Serialization.DataMember(Order:=1)> _
        Public Property UniqueID() As Integer
            Get
                Return _uniqueID
            End Get
            Set(ByVal value As Integer)
                If ((Me._uniqueID = value) = False) Then
                    OnUniqueIDChanging(value)
                    SendPropertyChanging("UniqueID")
                    _uniqueID = value
                    SendPropertyChanged("UniqueID")
                    OnUniqueIDChanged()
                End If
            End Set
        End Property

        Private _username As String

        ''' <summary>
        ''' Gets or sets the Username column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Username", Storage:="_username", DbType:="varchar(256) NOT NULL", CanBeNull:=False)> _
        <ComponentModel.DataAnnotations.StringLength(256)> _
        <System.Runtime.Serialization.DataMember(Order:=2)> _
        Public Property Username() As String
            Get
                Return _username
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._username, value) = False) Then
                    OnUsernameChanging(value)
                    SendPropertyChanging("Username")
                    _username = value
                    SendPropertyChanged("Username")
                    OnUsernameChanged()
                End If
            End Set
        End Property

        Private _applicationName As String

        ''' <summary>
        ''' Gets or sets the ApplicationName column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="ApplicationName", Storage:="_applicationName", DbType:="varchar(256) NOT NULL", CanBeNull:=False)> _
        <ComponentModel.DataAnnotations.StringLength(256)> _
        <System.Runtime.Serialization.DataMember(Order:=3)> _
        Public Property ApplicationName() As String
            Get
                Return _applicationName
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._applicationName, value) = False) Then
                    OnApplicationNameChanging(value)
                    SendPropertyChanging("ApplicationName")
                    _applicationName = value
                    SendPropertyChanged("ApplicationName")
                    OnApplicationNameChanged()
                End If
            End Set
        End Property

        Private _isAnonymous As Nullable(Of Boolean)

        ''' <summary>
        ''' Gets or sets the IsAnonymous column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="IsAnonymous", Storage:="_isAnonymous", DbType:="bit")> _
        <System.Runtime.Serialization.DataMember(Order:=4)> _
        Public Property IsAnonymous() As Nullable(Of Boolean)
            Get
                Return _isAnonymous
            End Get
            Set(ByVal value As Nullable(Of Boolean))
                If (Me._isAnonymous.Equals(value) = False) Then
                    OnIsAnonymousChanging(value)
                    SendPropertyChanging("IsAnonymous")
                    _isAnonymous = value
                    SendPropertyChanged("IsAnonymous")
                    OnIsAnonymousChanged()
                End If
            End Set
        End Property

        Private _lastActivityDate As Nullable(Of Date)

        ''' <summary>
        ''' Gets or sets the LastActivityDate column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="LastActivityDate", Storage:="_lastActivityDate", DbType:="datetime")> _
        <System.Runtime.Serialization.DataMember(Order:=5)> _
        Public Property LastActivityDate() As Nullable(Of Date)
            Get
                Return _lastActivityDate
            End Get
            Set(ByVal value As Nullable(Of Date))
                If (Me._lastActivityDate.Equals(value) = False) Then
                    OnLastActivityDateChanging(value)
                    SendPropertyChanging("LastActivityDate")
                    _lastActivityDate = value
                    SendPropertyChanged("LastActivityDate")
                    OnLastActivityDateChanged()
                End If
            End Set
        End Property

        Private _lastUpdatedDate As Nullable(Of Date)

        ''' <summary>
        ''' Gets or sets the LastUpdatedDate column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="LastUpdatedDate", Storage:="_lastUpdatedDate", DbType:="datetime")> _
        <System.Runtime.Serialization.DataMember(Order:=6)> _
        Public Property LastUpdatedDate() As Nullable(Of Date)
            Get
                Return _lastUpdatedDate
            End Get
            Set(ByVal value As Nullable(Of Date))
                If (Me._lastUpdatedDate.Equals(value) = False) Then
                    OnLastUpdatedDateChanging(value)
                    SendPropertyChanging("LastUpdatedDate")
                    _lastUpdatedDate = value
                    SendPropertyChanged("LastUpdatedDate")
                    OnLastUpdatedDateChanged()
                End If
            End Set
        End Property
#End Region

#Region "Association Mapped Properties"


        Private _accountList As System.Data.Linq.EntitySet(Of Account)

        ''' <summary>
        ''' Gets or sets the Account association.
        ''' </summary>
        <System.Data.Linq.Mapping.Association(Name:="Profiles_Account", Storage:="_accountList", ThisKey:="UniqueID", OtherKey:="UniqueID")> _
        <System.Runtime.Serialization.DataMember(Order:=7, EmitDefaultValue:=False)> _
        Public Property AccountList() As System.Data.Linq.EntitySet(Of Account)
            Get
                If (serializing AndAlso Not _accountList.HasLoadedOrAssignedValues) Then
                    Return Nothing
                Else
                    Return _accountList
                End If
            End Get
            Set(ByVal value As System.Data.Linq.EntitySet(Of Account))
                _accountList.Assign(value)
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCode()> _
        Private Sub OnAccountListAdd(ByVal entity As Account)
            SendPropertyChanging(Nothing)
            entity.Profiles = Me
            SendPropertyChanged(Nothing)
        End Sub

        <System.Diagnostics.DebuggerNonUserCode()> _
        Private Sub OnAccountListRemove(ByVal entity As Account)
            SendPropertyChanging(Nothing)
            entity.Profiles = Nothing
            SendPropertyChanged(Nothing)
        End Sub


        Private _cartList As System.Data.Linq.EntitySet(Of Cart)

        ''' <summary>
        ''' Gets or sets the Cart association.
        ''' </summary>
        <System.Data.Linq.Mapping.Association(Name:="Profiles_Cart", Storage:="_cartList", ThisKey:="UniqueID", OtherKey:="UniqueID")> _
        <System.Runtime.Serialization.DataMember(Order:=8, EmitDefaultValue:=False)> _
        Public Property CartList() As System.Data.Linq.EntitySet(Of Cart)
            Get
                If (serializing AndAlso Not _cartList.HasLoadedOrAssignedValues) Then
                    Return Nothing
                Else
                    Return _cartList
                End If
            End Get
            Set(ByVal value As System.Data.Linq.EntitySet(Of Cart))
                _cartList.Assign(value)
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCode()> _
        Private Sub OnCartListAdd(ByVal entity As Cart)
            SendPropertyChanging(Nothing)
            entity.Profiles = Me
            SendPropertyChanged(Nothing)
        End Sub

        <System.Diagnostics.DebuggerNonUserCode()> _
        Private Sub OnCartListRemove(ByVal entity As Cart)
            SendPropertyChanging(Nothing)
            entity.Profiles = Nothing
            SendPropertyChanged(Nothing)
        End Sub

#End Region

#Region "Extensibility Method Definitions"

        ''' <summary>Called by the Shared constructor to add shared rules.</summary>
        Partial Private Shared Sub AddSharedRules()
        End Sub
        ''' <summary>Called when this instance is loaded.</summary>
        Partial Private Sub OnLoaded()
        End Sub
        ''' <summary>Called when this instance is being saved.</summary>
        Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        End Sub
        ''' <summary>Called when this instance is created.</summary>
        Partial Private Sub OnCreated()
        End Sub
        ''' <summary>Called when UniqueID is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnUniqueIDChanging(ByVal value As Integer)
        End Sub
        ''' <summary>Called after UniqueID has Changed.</summary>
        Partial Private Sub OnUniqueIDChanged()
        End Sub
        ''' <summary>Called when Username is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnUsernameChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after Username has Changed.</summary>
        Partial Private Sub OnUsernameChanged()
        End Sub
        ''' <summary>Called when ApplicationName is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnApplicationNameChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after ApplicationName has Changed.</summary>
        Partial Private Sub OnApplicationNameChanged()
        End Sub
        ''' <summary>Called when IsAnonymous is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnIsAnonymousChanging(ByVal value As Nullable(Of Boolean))
        End Sub
        ''' <summary>Called after IsAnonymous has Changed.</summary>
        Partial Private Sub OnIsAnonymousChanged()
        End Sub
        ''' <summary>Called when LastActivityDate is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnLastActivityDateChanging(ByVal value As Nullable(Of Date))
        End Sub
        ''' <summary>Called after LastActivityDate has Changed.</summary>
        Partial Private Sub OnLastActivityDateChanged()
        End Sub
        ''' <summary>Called when LastUpdatedDate is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnLastUpdatedDateChanging(ByVal value As Nullable(Of Date))
        End Sub
        ''' <summary>Called after LastUpdatedDate has Changed.</summary>
        Partial Private Sub OnLastUpdatedDateChanged()
        End Sub
#End Region

#Region "Serialization"

        Private serializing As Boolean

        ''' <summary>
        ''' Called when serializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnSerializing(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnSerializing(ByVal context As System.Runtime.Serialization.StreamingContext)
            serializing = True
        End Sub

        ''' <summary>
        ''' Called when serializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnSerialized(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnSerialized(ByVal context As System.Runtime.Serialization.StreamingContext)
            serializing = False
        End Sub

        ''' <summary>
        ''' Called when deserializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnDeserializing(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnDeserializing(ByVal context As System.Runtime.Serialization.StreamingContext)
            Initialize()
        End Sub
        
        ''' <summary>
        ''' Deserializes an instance of <see cref="Profiles"/> from XML.
        ''' </summary>
        ''' <param name="xml">The XML string representing a <see cref="Profiles"/> instance.</param>
        ''' <returns>An instance of <see cref="Profiles"/> that is deserialized from the XML string.</returns>
        Public Shared Function FromXml(ByVal xml As String) As Profiles
            Dim deserializer = New System.Runtime.Serialization.DataContractSerializer(GetType(Profiles))
            
            Using sr = New System.IO.StringReader(xml)
                Using reader = System.Xml.XmlReader.Create(sr)
                    Return TryCast(deserializer.ReadObject(reader), Profiles)
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Deserializes an instance of <see cref="Profiles"/>.
        ''' </summary>
        ''' <param name="buffer">The byte array representing a <see cref="Profiles"/> instance.</param>
        ''' <returns>An instance of <see cref="Profiles"/> that is deserialized from the byte array.</returns>
        Public Shared Function FromBinary(ByVal buffer As Byte()) As Profiles
            Dim deserializer = New System.Runtime.Serialization.DataContractSerializer(GetType(Profiles))

            Using ms = New System.IO.MemoryStream(buffer)
                Using reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max)
                    Return TryCast(deserializer.ReadObject(reader), Profiles)
                End Using
            End Using
        End Function
#End Region

#Region "Clone"
        ''' <summary>
        ''' Creates a new object that is a copy of the current instance.
        ''' </summary>
        ''' <returns>
        ''' A new object that is a copy of this instance.
        ''' </returns>
        Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
            Dim serializer As New System.Runtime.Serialization.DataContractSerializer([GetType]())
            Using ms As New System.IO.MemoryStream()
                serializer.WriteObject(ms, Me)
                ms.Position = 0
                Return serializer.ReadObject(ms)
            End Using
        End Function

        ''' <summary>
        ''' Creates a new object that is a copy of the current instance.
        ''' </summary>
        ''' <returns>
        ''' A new object that is a copy of this instance.
        ''' </returns>
        ''' <remarks>
        ''' This method is equivalent to a Detach from the current <see cref="System.Data.Linq.DataContext"/>.
        ''' Only loaded EntityRef and EntitySet child accessions will be cloned.
        ''' </remarks>
        Public Function Clone() As Profiles
            Return DirectCast(DirectCast(Me, ICloneable), Profiles).Clone()
        End Function
#End Region

#Region "Detach Methods"
        ''' <summary>
        ''' Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        ''' </summary>
        ''' <remarks>
        ''' Detaching the entity will allow it to be attached to another <see cref="System.Data.Linq.DataContext"/>.
        ''' </remarks>
        Public Overrides Sub Detach()

            If (Not IsAttached()) Then
                Return
            End If

            MyBase.Detach()
            _accountList = Detach(_accountList, AddressOf OnAccountListAdd, AddressOf OnAccountListRemove)
            _cartList = Detach(_cartList, AddressOf OnCartListAdd, AddressOf OnCartListRemove)
        End Sub
#End Region
    End Class
End Namespace


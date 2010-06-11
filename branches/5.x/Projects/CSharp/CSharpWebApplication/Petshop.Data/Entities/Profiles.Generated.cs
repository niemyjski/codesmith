//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Common;
namespace Petshop.Data
{
    /// <summary>
    /// The class representing the dbo.Profiles table.
    /// </summary>
    [Table(Name="dbo.Profiles")]
    [DataContract(IsReference=true)]
    [ScaffoldTable(true)]
    [MetadataType(typeof(Metadata))]
	[DataServiceKey("UniqueID")]
    public partial class Profiles
        : LinqEntityBase
    {
        
        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Profiles"/> class.
        /// </summary>
        [DebuggerNonUserCodeAttribute()]
        public Profiles()
        {
            OnCreated();
            Initialize();
        }
        
        private void Initialize()
        {
            _accountList = new EntitySet<Account>(
                new System.Action<Account>(this.Attach_AccountList),
                new System.Action<Account>(this.Detach_AccountList));
            _cartList = new EntitySet<Cart>(
                new System.Action<Cart>(this.Attach_CartList),
                new System.Action<Cart>(this.Detach_CartList));
        }
        #endregion
        
        #region Column Mapped Properties
        
        private int _uniqueID = default(int);

        /// <summary>
        /// Gets the UniqueID column value.
        /// </summary>
        [Column(Name="UniqueID", Storage="_uniqueID", DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, CanBeNull=false)]
        [DataMember(Order=1)]
        public int UniqueID
        {
            get { return _uniqueID; }
            set
            {
                if (_uniqueID != value)
                {
                    OnUniqueIDChanging(value);
                    OnPropertyChanging("UniqueID");
                    _uniqueID = value;
                    OnPropertyChanged("UniqueID");
                    OnUniqueIDChanged();
                }
            }
        }
        
        private string _username;

        /// <summary>
        /// Gets or sets the Username column value.
        /// </summary>
        [Column(Name="Username", Storage="_username", DbType="varchar(256) NOT NULL", CanBeNull=false)]
        [DataMember(Order=2)]
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    OnUsernameChanging(value);
                    OnPropertyChanging("Username");
                    _username = value;
                    OnPropertyChanged("Username");
                    OnUsernameChanged();
                }
            }
        }
        
        private string _applicationName;

        /// <summary>
        /// Gets or sets the ApplicationName column value.
        /// </summary>
        [Column(Name="ApplicationName", Storage="_applicationName", DbType="varchar(256) NOT NULL", CanBeNull=false)]
        [DataMember(Order=3)]
        public string ApplicationName
        {
            get { return _applicationName; }
            set
            {
                if (_applicationName != value)
                {
                    OnApplicationNameChanging(value);
                    OnPropertyChanging("ApplicationName");
                    _applicationName = value;
                    OnPropertyChanged("ApplicationName");
                    OnApplicationNameChanged();
                }
            }
        }
        
        private Nullable<bool> _isAnonymous;

        /// <summary>
        /// Gets or sets the IsAnonymous column value.
        /// </summary>
        [Column(Name="IsAnonymous", Storage="_isAnonymous", DbType="bit")]
        [DataMember(Order=4)]
        public Nullable<bool> IsAnonymous
        {
            get { return _isAnonymous; }
            set
            {
                if (_isAnonymous != value)
                {
                    OnIsAnonymousChanging(value);
                    OnPropertyChanging("IsAnonymous");
                    _isAnonymous = value;
                    OnPropertyChanged("IsAnonymous");
                    OnIsAnonymousChanged();
                }
            }
        }
        
        private Nullable<System.DateTime> _lastActivityDate;

        /// <summary>
        /// Gets or sets the LastActivityDate column value.
        /// </summary>
        [Column(Name="LastActivityDate", Storage="_lastActivityDate", DbType="datetime")]
        [DataMember(Order=5)]
        public Nullable<System.DateTime> LastActivityDate
        {
            get { return _lastActivityDate; }
            set
            {
                if (_lastActivityDate != value)
                {
                    OnLastActivityDateChanging(value);
                    OnPropertyChanging("LastActivityDate");
                    _lastActivityDate = value;
                    OnPropertyChanged("LastActivityDate");
                    OnLastActivityDateChanged();
                }
            }
        }
        
        private Nullable<System.DateTime> _lastUpdatedDate;

        /// <summary>
        /// Gets or sets the LastUpdatedDate column value.
        /// </summary>
        [Column(Name="LastUpdatedDate", Storage="_lastUpdatedDate", DbType="datetime")]
        [DataMember(Order=6)]
        public Nullable<System.DateTime> LastUpdatedDate
        {
            get { return _lastUpdatedDate; }
            set
            {
                if (_lastUpdatedDate != value)
                {
                    OnLastUpdatedDateChanging(value);
                    OnPropertyChanging("LastUpdatedDate");
                    _lastUpdatedDate = value;
                    OnPropertyChanged("LastUpdatedDate");
                    OnLastUpdatedDateChanged();
                }
            }
        }
        #endregion
        
        #region Association Mapped Properties
        
        private EntitySet<Account> _accountList;
        
        /// <summary>
        /// Gets or sets the Account association.
        /// </summary>
        [Association(Name="Profiles_Account", Storage="_accountList", ThisKey="UniqueID", OtherKey="UniqueID")]
        [DataMember]
        public EntitySet<Account> AccountList
        {
            get { return _accountList; }
            set { _accountList.Assign(value); }
        }
        
        [DebuggerNonUserCodeAttribute()]
        private void Attach_AccountList(Account entity)
        {
            OnPropertyChanging(null);
            entity.Profiles = this;
            OnPropertyChanged(null);
        }
        
        [DebuggerNonUserCodeAttribute()]
        private void Detach_AccountList(Account entity)
        {
            OnPropertyChanging(null);
            entity.Profiles = null;
            OnPropertyChanged(null);
        }
        
        private EntitySet<Cart> _cartList;
        
        /// <summary>
        /// Gets or sets the Cart association.
        /// </summary>
        [Association(Name="Profiles_Cart", Storage="_cartList", ThisKey="UniqueID", OtherKey="UniqueID")]
        [DataMember]
        public EntitySet<Cart> CartList
        {
            get { return _cartList; }
            set { _cartList.Assign(value); }
        }
        
        [DebuggerNonUserCodeAttribute()]
        private void Attach_CartList(Cart entity)
        {
            OnPropertyChanging(null);
            entity.Profiles = this;
            OnPropertyChanged(null);
        }
        
        [DebuggerNonUserCodeAttribute()]
        private void Detach_CartList(Cart entity)
        {
            OnPropertyChanging(null);
            entity.Profiles = null;
            OnPropertyChanged(null);
        }
        #endregion
        
        #region Extensibility Method Definitions
        /// <summary>Called when this instance is loaded.</summary>
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        partial void OnValidate(ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        partial void OnCreated();
        /// <summary>Called when UniqueID is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnUniqueIDChanging(int value);
        /// <summary>Called after UniqueID has Changed.</summary>
        partial void OnUniqueIDChanged();
        /// <summary>Called when Username is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnUsernameChanging(string value);
        /// <summary>Called after Username has Changed.</summary>
        partial void OnUsernameChanged();
        /// <summary>Called when ApplicationName is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnApplicationNameChanging(string value);
        /// <summary>Called after ApplicationName has Changed.</summary>
        partial void OnApplicationNameChanged();
        /// <summary>Called when IsAnonymous is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnIsAnonymousChanging(Nullable<bool> value);
        /// <summary>Called after IsAnonymous has Changed.</summary>
        partial void OnIsAnonymousChanged();
        /// <summary>Called when LastActivityDate is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnLastActivityDateChanging(Nullable<System.DateTime> value);
        /// <summary>Called after LastActivityDate has Changed.</summary>
        partial void OnLastActivityDateChanged();
        /// <summary>Called when LastUpdatedDate is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnLastUpdatedDateChanging(Nullable<System.DateTime> value);
        /// <summary>Called after LastUpdatedDate has Changed.</summary>
        partial void OnLastUpdatedDateChanged();
        #endregion
        
        #region Serialization
        
        private bool serializing;
        
        [OnSerializing()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public void OnSerializing(StreamingContext context) {
            serializing = true;
        }
        
        [OnSerialized()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public void OnSerialized(StreamingContext context) {
            serializing = false;
        }
        
        [OnDeserializing()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public void OnDeserializing(StreamingContext context) {
            Initialize();
        }
        
        #endregion
        
    }
}

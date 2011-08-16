﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("MeerkatModel", "FK_Tech_File_Tech_BLOB", "Tech_BLOB", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ClassLibraryWithEntities.Tech_BLOB), "Tech_File", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ClassLibraryWithEntities.Tech_File), true)]

#endregion

namespace ClassLibraryWithEntities
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MeerkatEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MeerkatEntities object using the connection string found in the 'MeerkatEntities' section of the application configuration file.
        /// </summary>
        public MeerkatEntities() : base("name=MeerkatEntities", "MeerkatEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MeerkatEntities object.
        /// </summary>
        public MeerkatEntities(string connectionString) : base(connectionString, "MeerkatEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MeerkatEntities object.
        /// </summary>
        public MeerkatEntities(EntityConnection connection) : base(connection, "MeerkatEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Bloomberg_User> Bloomberg_User
        {
            get
            {
                if ((_Bloomberg_User == null))
                {
                    _Bloomberg_User = base.CreateObjectSet<Bloomberg_User>("Bloomberg_User");
                }
                return _Bloomberg_User;
            }
        }
        private ObjectSet<Bloomberg_User> _Bloomberg_User;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Tech_BLOB> Tech_BLOB
        {
            get
            {
                if ((_Tech_BLOB == null))
                {
                    _Tech_BLOB = base.CreateObjectSet<Tech_BLOB>("Tech_BLOB");
                }
                return _Tech_BLOB;
            }
        }
        private ObjectSet<Tech_BLOB> _Tech_BLOB;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Tech_File> Tech_File
        {
            get
            {
                if ((_Tech_File == null))
                {
                    _Tech_File = base.CreateObjectSet<Tech_File>("Tech_File");
                }
                return _Tech_File;
            }
        }
        private ObjectSet<Tech_File> _Tech_File;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Bloomberg_User EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBloomberg_User(Bloomberg_User bloomberg_User)
        {
            base.AddObject("Bloomberg_User", bloomberg_User);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tech_BLOB EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTech_BLOB(Tech_BLOB tech_BLOB)
        {
            base.AddObject("Tech_BLOB", tech_BLOB);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tech_File EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTech_File(Tech_File tech_File)
        {
            base.AddObject("Tech_File", tech_File);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MeerkatModel", Name="Bloomberg_User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Bloomberg_User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Bloomberg_User object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="login">Initial value of the Login property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="companyName">Initial value of the CompanyName property.</param>
        /// <param name="emailBloombergID">Initial value of the EmailBloombergID property.</param>
        /// <param name="timestamp">Initial value of the timestamp property.</param>
        public static Bloomberg_User CreateBloomberg_User(global::System.Int64 id, global::System.String login, global::System.String firstName, global::System.String lastName, global::System.String companyName, global::System.Int64 emailBloombergID, global::System.Byte[] timestamp)
        {
            Bloomberg_User bloomberg_User = new Bloomberg_User();
            bloomberg_User.ID = id;
            bloomberg_User.Login = login;
            bloomberg_User.FirstName = firstName;
            bloomberg_User.LastName = lastName;
            bloomberg_User.CompanyName = companyName;
            bloomberg_User.EmailBloombergID = emailBloombergID;
            bloomberg_User.timestamp = timestamp;
            return bloomberg_User;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Login
        {
            get
            {
                return _Login;
            }
            set
            {
                OnLoginChanging(value);
                ReportPropertyChanging("Login");
                _Login = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Login");
                OnLoginChanged();
            }
        }
        private global::System.String _Login;
        partial void OnLoginChanging(global::System.String value);
        partial void OnLoginChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> UUID
        {
            get
            {
                return _UUID;
            }
            set
            {
                OnUUIDChanging(value);
                ReportPropertyChanging("UUID");
                _UUID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UUID");
                OnUUIDChanged();
            }
        }
        private Nullable<global::System.Int64> _UUID;
        partial void OnUUIDChanging(Nullable<global::System.Int64> value);
        partial void OnUUIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> FirmNumber
        {
            get
            {
                return _FirmNumber;
            }
            set
            {
                OnFirmNumberChanging(value);
                ReportPropertyChanging("FirmNumber");
                _FirmNumber = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FirmNumber");
                OnFirmNumberChanged();
            }
        }
        private Nullable<global::System.Int64> _FirmNumber;
        partial void OnFirmNumberChanging(Nullable<global::System.Int64> value);
        partial void OnFirmNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
            set
            {
                OnAccountNumberChanging(value);
                ReportPropertyChanging("AccountNumber");
                _AccountNumber = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AccountNumber");
                OnAccountNumberChanged();
            }
        }
        private Nullable<global::System.Int64> _AccountNumber;
        partial void OnAccountNumberChanging(Nullable<global::System.Int64> value);
        partial void OnAccountNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                OnCompanyNameChanging(value);
                ReportPropertyChanging("CompanyName");
                _CompanyName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CompanyName");
                OnCompanyNameChanged();
            }
        }
        private global::System.String _CompanyName;
        partial void OnCompanyNameChanging(global::System.String value);
        partial void OnCompanyNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 EmailBloombergID
        {
            get
            {
                return _EmailBloombergID;
            }
            set
            {
                OnEmailBloombergIDChanging(value);
                ReportPropertyChanging("EmailBloombergID");
                _EmailBloombergID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EmailBloombergID");
                OnEmailBloombergIDChanged();
            }
        }
        private global::System.Int64 _EmailBloombergID;
        partial void OnEmailBloombergIDChanging(global::System.Int64 value);
        partial void OnEmailBloombergIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> EmailCorporateID
        {
            get
            {
                return _EmailCorporateID;
            }
            set
            {
                OnEmailCorporateIDChanging(value);
                ReportPropertyChanging("EmailCorporateID");
                _EmailCorporateID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EmailCorporateID");
                OnEmailCorporateIDChanged();
            }
        }
        private Nullable<global::System.Int64> _EmailCorporateID;
        partial void OnEmailCorporateIDChanging(Nullable<global::System.Int64> value);
        partial void OnEmailCorporateIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] timestamp
        {
            get
            {
                return StructuralObject.GetValidValue(_timestamp);
            }
            set
            {
                OntimestampChanging(value);
                ReportPropertyChanging("timestamp");
                _timestamp = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("timestamp");
                OntimestampChanged();
            }
        }
        private global::System.Byte[] _timestamp;
        partial void OntimestampChanging(global::System.Byte[] value);
        partial void OntimestampChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> PersonID
        {
            get
            {
                return _PersonID;
            }
            set
            {
                OnPersonIDChanging(value);
                ReportPropertyChanging("PersonID");
                _PersonID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PersonID");
                OnPersonIDChanged();
            }
        }
        private Nullable<global::System.Int64> _PersonID;
        partial void OnPersonIDChanging(Nullable<global::System.Int64> value);
        partial void OnPersonIDChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MeerkatModel", Name="Tech_BLOB")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Tech_BLOB : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Tech_BLOB object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="file">Initial value of the File property.</param>
        /// <param name="timestamp">Initial value of the timestamp property.</param>
        public static Tech_BLOB CreateTech_BLOB(global::System.Int64 id, global::System.Byte[] file, global::System.Byte[] timestamp)
        {
            Tech_BLOB tech_BLOB = new Tech_BLOB();
            tech_BLOB.ID = id;
            tech_BLOB.File = file;
            tech_BLOB.timestamp = timestamp;
            return tech_BLOB;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] File
        {
            get
            {
                return StructuralObject.GetValidValue(_File);
            }
            set
            {
                OnFileChanging(value);
                ReportPropertyChanging("File");
                _File = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("File");
                OnFileChanged();
            }
        }
        private global::System.Byte[] _File;
        partial void OnFileChanging(global::System.Byte[] value);
        partial void OnFileChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Extension
        {
            get
            {
                return _Extension;
            }
            set
            {
                OnExtensionChanging(value);
                ReportPropertyChanging("Extension");
                _Extension = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Extension");
                OnExtensionChanged();
            }
        }
        private global::System.String _Extension;
        partial void OnExtensionChanging(global::System.String value);
        partial void OnExtensionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] timestamp
        {
            get
            {
                return StructuralObject.GetValidValue(_timestamp);
            }
            set
            {
                OntimestampChanging(value);
                ReportPropertyChanging("timestamp");
                _timestamp = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("timestamp");
                OntimestampChanged();
            }
        }
        private global::System.Byte[] _timestamp;
        partial void OntimestampChanging(global::System.Byte[] value);
        partial void OntimestampChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MeerkatModel", "FK_Tech_File_Tech_BLOB", "Tech_File")]
        public EntityCollection<Tech_File> Tech_File
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Tech_File>("MeerkatModel.FK_Tech_File_Tech_BLOB", "Tech_File");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Tech_File>("MeerkatModel.FK_Tech_File_Tech_BLOB", "Tech_File", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MeerkatModel", Name="Tech_File")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Tech_File : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Tech_File object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="fileID">Initial value of the FileID property.</param>
        /// <param name="extension">Initial value of the Extension property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="accessGroupID">Initial value of the AccessGroupID property.</param>
        /// <param name="timestamp">Initial value of the timestamp property.</param>
        public static Tech_File CreateTech_File(global::System.Int64 id, global::System.Int64 fileID, global::System.String extension, global::System.String name, global::System.Int64 accessGroupID, global::System.Byte[] timestamp)
        {
            Tech_File tech_File = new Tech_File();
            tech_File.ID = id;
            tech_File.FileID = fileID;
            tech_File.Extension = extension;
            tech_File.Name = name;
            tech_File.AccessGroupID = accessGroupID;
            tech_File.timestamp = timestamp;
            return tech_File;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 FileID
        {
            get
            {
                return _FileID;
            }
            set
            {
                OnFileIDChanging(value);
                ReportPropertyChanging("FileID");
                _FileID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FileID");
                OnFileIDChanged();
            }
        }
        private global::System.Int64 _FileID;
        partial void OnFileIDChanging(global::System.Int64 value);
        partial void OnFileIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Extension
        {
            get
            {
                return _Extension;
            }
            set
            {
                OnExtensionChanging(value);
                ReportPropertyChanging("Extension");
                _Extension = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Extension");
                OnExtensionChanged();
            }
        }
        private global::System.String _Extension;
        partial void OnExtensionChanging(global::System.String value);
        partial void OnExtensionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Initialpath
        {
            get
            {
                return _Initialpath;
            }
            set
            {
                OnInitialpathChanging(value);
                ReportPropertyChanging("Initialpath");
                _Initialpath = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Initialpath");
                OnInitialpathChanged();
            }
        }
        private global::System.String _Initialpath;
        partial void OnInitialpathChanging(global::System.String value);
        partial void OnInitialpathChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _Date;
        partial void OnDateChanging(Nullable<global::System.DateTime> value);
        partial void OnDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Size
        {
            get
            {
                return _Size;
            }
            set
            {
                OnSizeChanging(value);
                ReportPropertyChanging("Size");
                _Size = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Size");
                OnSizeChanged();
            }
        }
        private Nullable<global::System.Int32> _Size;
        partial void OnSizeChanging(Nullable<global::System.Int32> value);
        partial void OnSizeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 AccessGroupID
        {
            get
            {
                return _AccessGroupID;
            }
            set
            {
                OnAccessGroupIDChanging(value);
                ReportPropertyChanging("AccessGroupID");
                _AccessGroupID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AccessGroupID");
                OnAccessGroupIDChanged();
            }
        }
        private global::System.Int64 _AccessGroupID;
        partial void OnAccessGroupIDChanging(global::System.Int64 value);
        partial void OnAccessGroupIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] timestamp
        {
            get
            {
                return StructuralObject.GetValidValue(_timestamp);
            }
            set
            {
                OntimestampChanging(value);
                ReportPropertyChanging("timestamp");
                _timestamp = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("timestamp");
                OntimestampChanged();
            }
        }
        private global::System.Byte[] _timestamp;
        partial void OntimestampChanging(global::System.Byte[] value);
        partial void OntimestampChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MeerkatModel", "FK_Tech_File_Tech_BLOB", "Tech_BLOB")]
        public Tech_BLOB Tech_BLOB
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Tech_BLOB>("MeerkatModel.FK_Tech_File_Tech_BLOB", "Tech_BLOB").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Tech_BLOB>("MeerkatModel.FK_Tech_File_Tech_BLOB", "Tech_BLOB").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Tech_BLOB> Tech_BLOBReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Tech_BLOB>("MeerkatModel.FK_Tech_File_Tech_BLOB", "Tech_BLOB");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Tech_BLOB>("MeerkatModel.FK_Tech_File_Tech_BLOB", "Tech_BLOB", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}

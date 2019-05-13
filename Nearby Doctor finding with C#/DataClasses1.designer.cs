﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NDS
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NDS")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLogin_info(Login_info instance);
    partial void UpdateLogin_info(Login_info instance);
    partial void DeleteLogin_info(Login_info instance);
    partial void InsertPatient_info(Patient_info instance);
    partial void UpdatePatient_info(Patient_info instance);
    partial void DeletePatient_info(Patient_info instance);
    partial void InsertDoctor_info(Doctor_info instance);
    partial void UpdateDoctor_info(Doctor_info instance);
    partial void DeleteDoctor_info(Doctor_info instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::NDS.Properties.Settings.Default.NDSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Login_info> Login_infos
		{
			get
			{
				return this.GetTable<Login_info>();
			}
		}
		
		public System.Data.Linq.Table<Patient_info> Patient_infos
		{
			get
			{
				return this.GetTable<Patient_info>();
			}
		}
		
		public System.Data.Linq.Table<Doctor_info> Doctor_infos
		{
			get
			{
				return this.GetTable<Doctor_info>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Login_info")]
	public partial class Login_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _PASSWORD;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    #endregion
		
		public Login_info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Patient_info")]
	public partial class Patient_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AppointmentId;
		
		private string _Name;
		
		private int _Age;
		
		private string _Gender;
		
		private string _ContactNo;
		
		private string _Category;
		
		private string _MaritalSatus;
		
		private string _Description;
		
		private System.DateTime _AppointmentDate;
		
		private System.TimeSpan _AppointmentTime;
		
		private int _DoctorId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAppointmentIdChanging(int value);
    partial void OnAppointmentIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAgeChanging(int value);
    partial void OnAgeChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnContactNoChanging(string value);
    partial void OnContactNoChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnMaritalSatusChanging(string value);
    partial void OnMaritalSatusChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnAppointmentDateChanging(System.DateTime value);
    partial void OnAppointmentDateChanged();
    partial void OnAppointmentTimeChanging(System.TimeSpan value);
    partial void OnAppointmentTimeChanged();
    partial void OnDoctorIdChanging(int value);
    partial void OnDoctorIdChanged();
    #endregion
		
		public Patient_info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AppointmentId
		{
			get
			{
				return this._AppointmentId;
			}
			set
			{
				if ((this._AppointmentId != value))
				{
					this.OnAppointmentIdChanging(value);
					this.SendPropertyChanging();
					this._AppointmentId = value;
					this.SendPropertyChanged("AppointmentId");
					this.OnAppointmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int NOT NULL")]
		public int Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactNo", DbType="VarChar(14) NOT NULL", CanBeNull=false)]
		public string ContactNo
		{
			get
			{
				return this._ContactNo;
			}
			set
			{
				if ((this._ContactNo != value))
				{
					this.OnContactNoChanging(value);
					this.SendPropertyChanging();
					this._ContactNo = value;
					this.SendPropertyChanged("ContactNo");
					this.OnContactNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaritalSatus", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MaritalSatus
		{
			get
			{
				return this._MaritalSatus;
			}
			set
			{
				if ((this._MaritalSatus != value))
				{
					this.OnMaritalSatusChanging(value);
					this.SendPropertyChanging();
					this._MaritalSatus = value;
					this.SendPropertyChanged("MaritalSatus");
					this.OnMaritalSatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentDate", DbType="DateTime NOT NULL")]
		public System.DateTime AppointmentDate
		{
			get
			{
				return this._AppointmentDate;
			}
			set
			{
				if ((this._AppointmentDate != value))
				{
					this.OnAppointmentDateChanging(value);
					this.SendPropertyChanging();
					this._AppointmentDate = value;
					this.SendPropertyChanged("AppointmentDate");
					this.OnAppointmentDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentTime", DbType="Time NOT NULL")]
		public System.TimeSpan AppointmentTime
		{
			get
			{
				return this._AppointmentTime;
			}
			set
			{
				if ((this._AppointmentTime != value))
				{
					this.OnAppointmentTimeChanging(value);
					this.SendPropertyChanging();
					this._AppointmentTime = value;
					this.SendPropertyChanged("AppointmentTime");
					this.OnAppointmentTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorId", DbType="Int NOT NULL")]
		public int DoctorId
		{
			get
			{
				return this._DoctorId;
			}
			set
			{
				if ((this._DoctorId != value))
				{
					this.OnDoctorIdChanging(value);
					this.SendPropertyChanging();
					this._DoctorId = value;
					this.SendPropertyChanged("DoctorId");
					this.OnDoctorIdChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Doctor_info")]
	public partial class Doctor_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _NAME;
		
		private string _EMAIL;
		
		private string _PHONE_NO;
		
		private string _LOCATION;
		
		private string _ADDRESS;
		
		private string _SPECIALIST;
		
		private System.Data.Linq.Binary _IMAGE;
		
		private System.Nullable<System.TimeSpan> _START_TIME;
		
		private System.Nullable<System.TimeSpan> _END_TIME;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    partial void OnPHONE_NOChanging(string value);
    partial void OnPHONE_NOChanged();
    partial void OnLOCATIONChanging(string value);
    partial void OnLOCATIONChanged();
    partial void OnADDRESSChanging(string value);
    partial void OnADDRESSChanged();
    partial void OnSPECIALISTChanging(string value);
    partial void OnSPECIALISTChanged();
    partial void OnIMAGEChanging(System.Data.Linq.Binary value);
    partial void OnIMAGEChanged();
    partial void OnSTART_TIMEChanging(System.Nullable<System.TimeSpan> value);
    partial void OnSTART_TIMEChanged();
    partial void OnEND_TIMEChanging(System.Nullable<System.TimeSpan> value);
    partial void OnEND_TIMEChanged();
    #endregion
		
		public Doctor_info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="VarChar(50)")]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(50)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PHONE_NO", DbType="VarChar(50)")]
		public string PHONE_NO
		{
			get
			{
				return this._PHONE_NO;
			}
			set
			{
				if ((this._PHONE_NO != value))
				{
					this.OnPHONE_NOChanging(value);
					this.SendPropertyChanging();
					this._PHONE_NO = value;
					this.SendPropertyChanged("PHONE_NO");
					this.OnPHONE_NOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOCATION", DbType="VarChar(50)")]
		public string LOCATION
		{
			get
			{
				return this._LOCATION;
			}
			set
			{
				if ((this._LOCATION != value))
				{
					this.OnLOCATIONChanging(value);
					this.SendPropertyChanging();
					this._LOCATION = value;
					this.SendPropertyChanged("LOCATION");
					this.OnLOCATIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADDRESS", DbType="VarChar(50)")]
		public string ADDRESS
		{
			get
			{
				return this._ADDRESS;
			}
			set
			{
				if ((this._ADDRESS != value))
				{
					this.OnADDRESSChanging(value);
					this.SendPropertyChanging();
					this._ADDRESS = value;
					this.SendPropertyChanged("ADDRESS");
					this.OnADDRESSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SPECIALIST", DbType="VarChar(50)")]
		public string SPECIALIST
		{
			get
			{
				return this._SPECIALIST;
			}
			set
			{
				if ((this._SPECIALIST != value))
				{
					this.OnSPECIALISTChanging(value);
					this.SendPropertyChanging();
					this._SPECIALIST = value;
					this.SendPropertyChanged("SPECIALIST");
					this.OnSPECIALISTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMAGE", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary IMAGE
		{
			get
			{
				return this._IMAGE;
			}
			set
			{
				if ((this._IMAGE != value))
				{
					this.OnIMAGEChanging(value);
					this.SendPropertyChanging();
					this._IMAGE = value;
					this.SendPropertyChanged("IMAGE");
					this.OnIMAGEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_START_TIME", DbType="Time")]
		public System.Nullable<System.TimeSpan> START_TIME
		{
			get
			{
				return this._START_TIME;
			}
			set
			{
				if ((this._START_TIME != value))
				{
					this.OnSTART_TIMEChanging(value);
					this.SendPropertyChanging();
					this._START_TIME = value;
					this.SendPropertyChanged("START_TIME");
					this.OnSTART_TIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_END_TIME", DbType="Time")]
		public System.Nullable<System.TimeSpan> END_TIME
		{
			get
			{
				return this._END_TIME;
			}
			set
			{
				if ((this._END_TIME != value))
				{
					this.OnEND_TIMEChanging(value);
					this.SendPropertyChanging();
					this._END_TIME = value;
					this.SendPropertyChanged("END_TIME");
					this.OnEND_TIMEChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
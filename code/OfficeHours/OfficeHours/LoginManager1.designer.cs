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

namespace OfficeHours
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Appointments")]
	public partial class LoginManagerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertlogin(login instance);
    partial void Updatelogin(login instance);
    partial void Deletelogin(login instance);
    #endregion
		
		public LoginManagerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AppointmentsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LoginManagerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginManagerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginManagerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginManagerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<login> logins
		{
			get
			{
				return this.GetTable<login>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.login")]
	public partial class login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _loginID;
		
		private string _firstName;
		
		private string _lastName;
		
		private string _emailAddress;
		
		private System.Data.Linq.Binary _passwordSalt;
		
		private System.Data.Linq.Binary _passwordHash;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnloginIDChanging(int value);
    partial void OnloginIDChanged();
    partial void OnfirstNameChanging(string value);
    partial void OnfirstNameChanged();
    partial void OnlastNameChanging(string value);
    partial void OnlastNameChanged();
    partial void OnemailAddressChanging(string value);
    partial void OnemailAddressChanged();
    partial void OnpasswordSaltChanging(System.Data.Linq.Binary value);
    partial void OnpasswordSaltChanged();
    partial void OnpasswordHashChanging(System.Data.Linq.Binary value);
    partial void OnpasswordHashChanged();
    #endregion
		
		public login()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loginID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int loginID
		{
			get
			{
				return this._loginID;
			}
			set
			{
				if ((this._loginID != value))
				{
					this.OnloginIDChanging(value);
					this.SendPropertyChanging();
					this._loginID = value;
					this.SendPropertyChanged("loginID");
					this.OnloginIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string firstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if ((this._firstName != value))
				{
					this.OnfirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("firstName");
					this.OnfirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if ((this._lastName != value))
				{
					this.OnlastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("lastName");
					this.OnlastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailAddress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string emailAddress
		{
			get
			{
				return this._emailAddress;
			}
			set
			{
				if ((this._emailAddress != value))
				{
					this.OnemailAddressChanging(value);
					this.SendPropertyChanging();
					this._emailAddress = value;
					this.SendPropertyChanged("emailAddress");
					this.OnemailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passwordSalt", DbType="Binary(128) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary passwordSalt
		{
			get
			{
				return this._passwordSalt;
			}
			set
			{
				if ((this._passwordSalt != value))
				{
					this.OnpasswordSaltChanging(value);
					this.SendPropertyChanging();
					this._passwordSalt = value;
					this.SendPropertyChanged("passwordSalt");
					this.OnpasswordSaltChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passwordHash", DbType="Binary(32) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary passwordHash
		{
			get
			{
				return this._passwordHash;
			}
			set
			{
				if ((this._passwordHash != value))
				{
					this.OnpasswordHashChanging(value);
					this.SendPropertyChanging();
					this._passwordHash = value;
					this.SendPropertyChanged("passwordHash");
					this.OnpasswordHashChanged();
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

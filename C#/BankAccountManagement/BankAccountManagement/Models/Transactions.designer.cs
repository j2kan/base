﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankAccountManagement.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TransactionDB")]
	public partial class TransactionsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTransaction(Transaction instance);
    partial void UpdateTransaction(Transaction instance);
    partial void DeleteTransaction(Transaction instance);
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    #endregion
		
		public TransactionsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TransactionDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TransactionsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransactionsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransactionsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransactionsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Transaction> Transactions
		{
			get
			{
				return this.GetTable<Transaction>();
			}
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Transactions")]
	public partial class Transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TransactionID;
		
		private int _AccountNumber;
		
		private decimal _Amount;
		
		private string _OtherParty;
		
		private string _OtherPartyAccount;
		
		private string _OtherPartyRoutingNumber;
		
		private System.DateTime _Date;
		
		private bool _IsOverdraftFee;
		
		private EntityRef<Account> _Account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionIDChanging(int value);
    partial void OnTransactionIDChanged();
    partial void OnAccountNumberChanging(int value);
    partial void OnAccountNumberChanged();
    partial void OnAmountChanging(decimal value);
    partial void OnAmountChanged();
    partial void OnOtherPartyChanging(string value);
    partial void OnOtherPartyChanged();
    partial void OnOtherPartyAccountChanging(string value);
    partial void OnOtherPartyAccountChanged();
    partial void OnOtherPartyRoutingNumberChanging(string value);
    partial void OnOtherPartyRoutingNumberChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnIsOverdraftFeeChanging(bool value);
    partial void OnIsOverdraftFeeChanged();
    #endregion
		
		public Transaction()
		{
			this._Account = default(EntityRef<Account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TransactionID
		{
			get
			{
				return this._TransactionID;
			}
			set
			{
				if ((this._TransactionID != value))
				{
					this.OnTransactionIDChanging(value);
					this.SendPropertyChanging();
					this._TransactionID = value;
					this.SendPropertyChanged("TransactionID");
					this.OnTransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNumber", DbType="Int NOT NULL")]
		public int AccountNumber
		{
			get
			{
				return this._AccountNumber;
			}
			set
			{
				if ((this._AccountNumber != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAccountNumberChanging(value);
					this.SendPropertyChanging();
					this._AccountNumber = value;
					this.SendPropertyChanged("AccountNumber");
					this.OnAccountNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Decimal(19,4) NOT NULL")]
		public decimal Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OtherParty", DbType="NVarChar(50)")]
		public string OtherParty
		{
			get
			{
				return this._OtherParty;
			}
			set
			{
				if ((this._OtherParty != value))
				{
					this.OnOtherPartyChanging(value);
					this.SendPropertyChanging();
					this._OtherParty = value;
					this.SendPropertyChanged("OtherParty");
					this.OnOtherPartyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OtherPartyAccount", DbType="NVarChar(50)")]
		public string OtherPartyAccount
		{
			get
			{
				return this._OtherPartyAccount;
			}
			set
			{
				if ((this._OtherPartyAccount != value))
				{
					this.OnOtherPartyAccountChanging(value);
					this.SendPropertyChanging();
					this._OtherPartyAccount = value;
					this.SendPropertyChanged("OtherPartyAccount");
					this.OnOtherPartyAccountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OtherPartyRoutingNumber", DbType="NVarChar(50)")]
		public string OtherPartyRoutingNumber
		{
			get
			{
				return this._OtherPartyRoutingNumber;
			}
			set
			{
				if ((this._OtherPartyRoutingNumber != value))
				{
					this.OnOtherPartyRoutingNumberChanging(value);
					this.SendPropertyChanging();
					this._OtherPartyRoutingNumber = value;
					this.SendPropertyChanged("OtherPartyRoutingNumber");
					this.OnOtherPartyRoutingNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsOverdraftFee", DbType="Bit NOT NULL")]
		public bool IsOverdraftFee
		{
			get
			{
				return this._IsOverdraftFee;
			}
			set
			{
				if ((this._IsOverdraftFee != value))
				{
					this.OnIsOverdraftFeeChanging(value);
					this.SendPropertyChanging();
					this._IsOverdraftFee = value;
					this.SendPropertyChanged("IsOverdraftFee");
					this.OnIsOverdraftFeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Transaction", Storage="_Account", ThisKey="AccountNumber", OtherKey="AccountNumber", IsForeignKey=true)]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.Transactions.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.Transactions.Add(this);
						this._AccountNumber = value.AccountNumber;
					}
					else
					{
						this._AccountNumber = default(int);
					}
					this.SendPropertyChanged("Account");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Last_Name;
		
		private string _First_Name;
		
		private string _Address;
		
		private string _City;
		
		private string _State;
		
		private string _Zip;
		
		private int _AccountNumber;
		
		private decimal _Balance;
		
		private bool _Overdraftable;
		
		private System.Nullable<decimal> _OverdraftAmount;
		
		private bool _IsShadowDeleted;
		
		private EntitySet<Transaction> _Transactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipChanging(string value);
    partial void OnZipChanged();
    partial void OnAccountNumberChanging(int value);
    partial void OnAccountNumberChanged();
    partial void OnBalanceChanging(decimal value);
    partial void OnBalanceChanged();
    partial void OnOverdraftableChanging(bool value);
    partial void OnOverdraftableChanged();
    partial void OnOverdraftAmountChanging(System.Nullable<decimal> value);
    partial void OnOverdraftAmountChanged();
    partial void OnIsShadowDeletedChanging(bool value);
    partial void OnIsShadowDeletedChanged();
    #endregion
		
		public Account()
		{
			this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Last Name]", Storage="_Last_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[First Name]", Storage="_First_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string Zip
		{
			get
			{
				return this._Zip;
			}
			set
			{
				if ((this._Zip != value))
				{
					this.OnZipChanging(value);
					this.SendPropertyChanging();
					this._Zip = value;
					this.SendPropertyChanged("Zip");
					this.OnZipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNumber", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AccountNumber
		{
			get
			{
				return this._AccountNumber;
			}
			set
			{
				if ((this._AccountNumber != value))
				{
					this.OnAccountNumberChanging(value);
					this.SendPropertyChanging();
					this._AccountNumber = value;
					this.SendPropertyChanged("AccountNumber");
					this.OnAccountNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Decimal(19,4) NOT NULL")]
		public decimal Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Overdraftable", DbType="Bit NOT NULL")]
		public bool Overdraftable
		{
			get
			{
				return this._Overdraftable;
			}
			set
			{
				if ((this._Overdraftable != value))
				{
					this.OnOverdraftableChanging(value);
					this.SendPropertyChanging();
					this._Overdraftable = value;
					this.SendPropertyChanged("Overdraftable");
					this.OnOverdraftableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OverdraftAmount", DbType="Decimal(19,4)")]
		public System.Nullable<decimal> OverdraftAmount
		{
			get
			{
				return this._OverdraftAmount;
			}
			set
			{
				if ((this._OverdraftAmount != value))
				{
					this.OnOverdraftAmountChanging(value);
					this.SendPropertyChanging();
					this._OverdraftAmount = value;
					this.SendPropertyChanged("OverdraftAmount");
					this.OnOverdraftAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsShadowDeleted", DbType="Bit NOT NULL")]
		public bool IsShadowDeleted
		{
			get
			{
				return this._IsShadowDeleted;
			}
			set
			{
				if ((this._IsShadowDeleted != value))
				{
					this.OnIsShadowDeletedChanging(value);
					this.SendPropertyChanging();
					this._IsShadowDeleted = value;
					this.SendPropertyChanged("IsShadowDeleted");
					this.OnIsShadowDeletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Transaction", Storage="_Transactions", ThisKey="AccountNumber", OtherKey="AccountNumber")]
		public EntitySet<Transaction> Transactions
		{
			get
			{
				return this._Transactions;
			}
			set
			{
				this._Transactions.Assign(value);
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
		
		private void attach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
	}
}
#pragma warning restore 1591

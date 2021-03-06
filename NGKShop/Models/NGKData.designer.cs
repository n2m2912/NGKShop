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

namespace NGKShop.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NGK")]
	public partial class NGKDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCHITIETHD(CHITIETHD instance);
    partial void UpdateCHITIETHD(CHITIETHD instance);
    partial void DeleteCHITIETHD(CHITIETHD instance);
    partial void InsertHOADON(HOADON instance);
    partial void UpdateHOADON(HOADON instance);
    partial void DeleteHOADON(HOADON instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertLOAINGK(LOAINGK instance);
    partial void UpdateLOAINGK(LOAINGK instance);
    partial void DeleteLOAINGK(LOAINGK instance);
    partial void InsertMATHANG(MATHANG instance);
    partial void UpdateMATHANG(MATHANG instance);
    partial void DeleteMATHANG(MATHANG instance);
    partial void InsertNCC(NCC instance);
    partial void UpdateNCC(NCC instance);
    partial void DeleteNCC(NCC instance);
    #endregion
		
		public NGKDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NGKConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NGKDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NGKDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NGKDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NGKDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<CHITIETHD> CHITIETHDs
		{
			get
			{
				return this.GetTable<CHITIETHD>();
			}
		}
		
		public System.Data.Linq.Table<HOADON> HOADONs
		{
			get
			{
				return this.GetTable<HOADON>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<LOAINGK> LOAINGKs
		{
			get
			{
				return this.GetTable<LOAINGK>();
			}
		}
		
		public System.Data.Linq.Table<MATHANG> MATHANGs
		{
			get
			{
				return this.GetTable<MATHANG>();
			}
		}
		
		public System.Data.Linq.Table<NCC> NCCs
		{
			get
			{
				return this.GetTable<NCC>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin
	{
		
		private string _UserAdmin;
		
		private string _PassAdmin;
		
		private string _Hoten;
		
		public Admin()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserAdmin", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserAdmin
		{
			get
			{
				return this._UserAdmin;
			}
			set
			{
				if ((this._UserAdmin != value))
				{
					this._UserAdmin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassAdmin", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PassAdmin
		{
			get
			{
				return this._PassAdmin;
			}
			set
			{
				if ((this._PassAdmin != value))
				{
					this._PassAdmin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hoten", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Hoten
		{
			get
			{
				return this._Hoten;
			}
			set
			{
				if ((this._Hoten != value))
				{
					this._Hoten = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETHD")]
	public partial class CHITIETHD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private int _MaMH;
		
		private decimal _DonGia;
		
		private int _SL;
		
		private EntityRef<HOADON> _HOADON;
		
		private EntityRef<MATHANG> _MATHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnMaMHChanging(int value);
    partial void OnMaMHChanged();
    partial void OnDonGiaChanging(decimal value);
    partial void OnDonGiaChanged();
    partial void OnSLChanging(int value);
    partial void OnSLChanged();
    #endregion
		
		public CHITIETHD()
		{
			this._HOADON = default(EntityRef<HOADON>);
			this._MATHANG = default(EntityRef<MATHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					if (this._HOADON.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaMH
		{
			get
			{
				return this._MaMH;
			}
			set
			{
				if ((this._MaMH != value))
				{
					if (this._MATHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaMHChanging(value);
					this.SendPropertyChanging();
					this._MaMH = value;
					this.SendPropertyChanged("MaMH");
					this.OnMaMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Money NOT NULL")]
		public decimal DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SL", DbType="Int NOT NULL")]
		public int SL
		{
			get
			{
				return this._SL;
			}
			set
			{
				if ((this._SL != value))
				{
					this.OnSLChanging(value);
					this.SendPropertyChanging();
					this._SL = value;
					this.SendPropertyChanged("SL");
					this.OnSLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_CHITIETHD", Storage="_HOADON", ThisKey="MaHD", OtherKey="MaHD", IsForeignKey=true)]
		public HOADON HOADON
		{
			get
			{
				return this._HOADON.Entity;
			}
			set
			{
				HOADON previousValue = this._HOADON.Entity;
				if (((previousValue != value) 
							|| (this._HOADON.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HOADON.Entity = null;
						previousValue.CHITIETHDs.Remove(this);
					}
					this._HOADON.Entity = value;
					if ((value != null))
					{
						value.CHITIETHDs.Add(this);
						this._MaHD = value.MaHD;
					}
					else
					{
						this._MaHD = default(int);
					}
					this.SendPropertyChanged("HOADON");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MATHANG_CHITIETHD", Storage="_MATHANG", ThisKey="MaMH", OtherKey="MaMH", IsForeignKey=true)]
		public MATHANG MATHANG
		{
			get
			{
				return this._MATHANG.Entity;
			}
			set
			{
				MATHANG previousValue = this._MATHANG.Entity;
				if (((previousValue != value) 
							|| (this._MATHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MATHANG.Entity = null;
						previousValue.CHITIETHDs.Remove(this);
					}
					this._MATHANG.Entity = value;
					if ((value != null))
					{
						value.CHITIETHDs.Add(this);
						this._MaMH = value.MaMH;
					}
					else
					{
						this._MaMH = default(int);
					}
					this.SendPropertyChanged("MATHANG");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOADON")]
	public partial class HOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private System.DateTime _NGAYLAPHD;
		
		private System.Nullable<System.DateTime> _Ngaygiaohang;
		
		private decimal _TONGTIEN;
		
		private int _MaKH;
		
		private System.Nullable<bool> _Dathanhtoan;
		
		private EntitySet<CHITIETHD> _CHITIETHDs;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnNGAYLAPHDChanging(System.DateTime value);
    partial void OnNGAYLAPHDChanged();
    partial void OnNgaygiaohangChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaygiaohangChanged();
    partial void OnTONGTIENChanging(decimal value);
    partial void OnTONGTIENChanged();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnDathanhtoanChanging(System.Nullable<bool> value);
    partial void OnDathanhtoanChanged();
    #endregion
		
		public HOADON()
		{
			this._CHITIETHDs = new EntitySet<CHITIETHD>(new Action<CHITIETHD>(this.attach_CHITIETHDs), new Action<CHITIETHD>(this.detach_CHITIETHDs));
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYLAPHD", DbType="DateTime NOT NULL")]
		public System.DateTime NGAYLAPHD
		{
			get
			{
				return this._NGAYLAPHD;
			}
			set
			{
				if ((this._NGAYLAPHD != value))
				{
					this.OnNGAYLAPHDChanging(value);
					this.SendPropertyChanging();
					this._NGAYLAPHD = value;
					this.SendPropertyChanged("NGAYLAPHD");
					this.OnNGAYLAPHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaygiaohang", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaygiaohang
		{
			get
			{
				return this._Ngaygiaohang;
			}
			set
			{
				if ((this._Ngaygiaohang != value))
				{
					this.OnNgaygiaohangChanging(value);
					this.SendPropertyChanging();
					this._Ngaygiaohang = value;
					this.SendPropertyChanged("Ngaygiaohang");
					this.OnNgaygiaohangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TONGTIEN", DbType="Money NOT NULL")]
		public decimal TONGTIEN
		{
			get
			{
				return this._TONGTIEN;
			}
			set
			{
				if ((this._TONGTIEN != value))
				{
					this.OnTONGTIENChanging(value);
					this.SendPropertyChanging();
					this._TONGTIEN = value;
					this.SendPropertyChanged("TONGTIEN");
					this.OnTONGTIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int NOT NULL")]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dathanhtoan", DbType="Bit")]
		public System.Nullable<bool> Dathanhtoan
		{
			get
			{
				return this._Dathanhtoan;
			}
			set
			{
				if ((this._Dathanhtoan != value))
				{
					this.OnDathanhtoanChanging(value);
					this.SendPropertyChanging();
					this._Dathanhtoan = value;
					this.SendPropertyChanged("Dathanhtoan");
					this.OnDathanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_CHITIETHD", Storage="_CHITIETHDs", ThisKey="MaHD", OtherKey="MaHD")]
		public EntitySet<CHITIETHD> CHITIETHDs
		{
			get
			{
				return this._CHITIETHDs;
			}
			set
			{
				this._CHITIETHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_HOADON", Storage="_KHACHHANG", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.HOADONs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.HOADONs.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(int);
					}
					this.SendPropertyChanged("KHACHHANG");
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
		
		private void attach_CHITIETHDs(CHITIETHD entity)
		{
			this.SendPropertyChanging();
			entity.HOADON = this;
		}
		
		private void detach_CHITIETHDs(CHITIETHD entity)
		{
			this.SendPropertyChanging();
			entity.HOADON = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _TenKH;
		
		private string _SDT;
		
		private string _DiaChi;
		
		private string _email;
		
		private string _TenDN;
		
		private string _MatKhau;
		
		private EntitySet<HOADON> _HOADONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnTenDNChanging(string value);
    partial void OnTenDNChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._HOADONs = new EntitySet<HOADON>(new Action<HOADON>(this.attach_HOADONs), new Action<HOADON>(this.detach_HOADONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDN", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TenDN
		{
			get
			{
				return this._TenDN;
			}
			set
			{
				if ((this._TenDN != value))
				{
					this.OnTenDNChanging(value);
					this.SendPropertyChanging();
					this._TenDN = value;
					this.SendPropertyChanged("TenDN");
					this.OnTenDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_HOADON", Storage="_HOADONs", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<HOADON> HOADONs
		{
			get
			{
				return this._HOADONs;
			}
			set
			{
				this._HOADONs.Assign(value);
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
		
		private void attach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAINGK")]
	public partial class LOAINGK : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLH;
		
		private string _TenLH;
		
		private int _MaNCC;
		
		private EntitySet<MATHANG> _MATHANGs;
		
		private EntityRef<NCC> _NCC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLHChanging(int value);
    partial void OnMaLHChanged();
    partial void OnTenLHChanging(string value);
    partial void OnTenLHChanged();
    partial void OnMaNCCChanging(int value);
    partial void OnMaNCCChanged();
    #endregion
		
		public LOAINGK()
		{
			this._MATHANGs = new EntitySet<MATHANG>(new Action<MATHANG>(this.attach_MATHANGs), new Action<MATHANG>(this.detach_MATHANGs));
			this._NCC = default(EntityRef<NCC>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaLH
		{
			get
			{
				return this._MaLH;
			}
			set
			{
				if ((this._MaLH != value))
				{
					this.OnMaLHChanging(value);
					this.SendPropertyChanging();
					this._MaLH = value;
					this.SendPropertyChanged("MaLH");
					this.OnMaLHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLH", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenLH
		{
			get
			{
				return this._TenLH;
			}
			set
			{
				if ((this._TenLH != value))
				{
					this.OnTenLHChanging(value);
					this.SendPropertyChanging();
					this._TenLH = value;
					this.SendPropertyChanged("TenLH");
					this.OnTenLHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNCC", DbType="Int NOT NULL")]
		public int MaNCC
		{
			get
			{
				return this._MaNCC;
			}
			set
			{
				if ((this._MaNCC != value))
				{
					if (this._NCC.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNCCChanging(value);
					this.SendPropertyChanging();
					this._MaNCC = value;
					this.SendPropertyChanged("MaNCC");
					this.OnMaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAINGK_MATHANG", Storage="_MATHANGs", ThisKey="MaLH", OtherKey="MaLH")]
		public EntitySet<MATHANG> MATHANGs
		{
			get
			{
				return this._MATHANGs;
			}
			set
			{
				this._MATHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NCC_LOAINGK", Storage="_NCC", ThisKey="MaNCC", OtherKey="MaNCC", IsForeignKey=true)]
		public NCC NCC
		{
			get
			{
				return this._NCC.Entity;
			}
			set
			{
				NCC previousValue = this._NCC.Entity;
				if (((previousValue != value) 
							|| (this._NCC.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NCC.Entity = null;
						previousValue.LOAINGKs.Remove(this);
					}
					this._NCC.Entity = value;
					if ((value != null))
					{
						value.LOAINGKs.Add(this);
						this._MaNCC = value.MaNCC;
					}
					else
					{
						this._MaNCC = default(int);
					}
					this.SendPropertyChanged("NCC");
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
		
		private void attach_MATHANGs(MATHANG entity)
		{
			this.SendPropertyChanging();
			entity.LOAINGK = this;
		}
		
		private void detach_MATHANGs(MATHANG entity)
		{
			this.SendPropertyChanging();
			entity.LOAINGK = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MATHANG")]
	public partial class MATHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaMH;
		
		private int _MaLH;
		
		private string _TenMH;
		
		private string _DonViTinh;
		
		private string _MoTa;
		
		private decimal _GiaBan;
		
		private string _HinhSP;
		
		private System.Nullable<double> _KhuyenMai;
		
		private EntitySet<CHITIETHD> _CHITIETHDs;
		
		private EntityRef<LOAINGK> _LOAINGK;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaMHChanging(int value);
    partial void OnMaMHChanged();
    partial void OnMaLHChanging(int value);
    partial void OnMaLHChanged();
    partial void OnTenMHChanging(string value);
    partial void OnTenMHChanged();
    partial void OnDonViTinhChanging(string value);
    partial void OnDonViTinhChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnGiaBanChanging(decimal value);
    partial void OnGiaBanChanged();
    partial void OnHinhSPChanging(string value);
    partial void OnHinhSPChanged();
    partial void OnKhuyenMaiChanging(System.Nullable<double> value);
    partial void OnKhuyenMaiChanged();
    #endregion
		
		public MATHANG()
		{
			this._CHITIETHDs = new EntitySet<CHITIETHD>(new Action<CHITIETHD>(this.attach_CHITIETHDs), new Action<CHITIETHD>(this.detach_CHITIETHDs));
			this._LOAINGK = default(EntityRef<LOAINGK>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaMH
		{
			get
			{
				return this._MaMH;
			}
			set
			{
				if ((this._MaMH != value))
				{
					this.OnMaMHChanging(value);
					this.SendPropertyChanging();
					this._MaMH = value;
					this.SendPropertyChanged("MaMH");
					this.OnMaMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLH", DbType="Int NOT NULL")]
		public int MaLH
		{
			get
			{
				return this._MaLH;
			}
			set
			{
				if ((this._MaLH != value))
				{
					if (this._LOAINGK.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLHChanging(value);
					this.SendPropertyChanging();
					this._MaLH = value;
					this.SendPropertyChanged("MaLH");
					this.OnMaLHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMH", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenMH
		{
			get
			{
				return this._TenMH;
			}
			set
			{
				if ((this._TenMH != value))
				{
					this.OnTenMHChanging(value);
					this.SendPropertyChanging();
					this._TenMH = value;
					this.SendPropertyChanged("TenMH");
					this.OnTenMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonViTinh", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string DonViTinh
		{
			get
			{
				return this._DonViTinh;
			}
			set
			{
				if ((this._DonViTinh != value))
				{
					this.OnDonViTinhChanging(value);
					this.SendPropertyChanging();
					this._DonViTinh = value;
					this.SendPropertyChanged("DonViTinh");
					this.OnDonViTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(4000)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaBan", DbType="Money NOT NULL")]
		public decimal GiaBan
		{
			get
			{
				return this._GiaBan;
			}
			set
			{
				if ((this._GiaBan != value))
				{
					this.OnGiaBanChanging(value);
					this.SendPropertyChanging();
					this._GiaBan = value;
					this.SendPropertyChanged("GiaBan");
					this.OnGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhSP", DbType="NVarChar(30)")]
		public string HinhSP
		{
			get
			{
				return this._HinhSP;
			}
			set
			{
				if ((this._HinhSP != value))
				{
					this.OnHinhSPChanging(value);
					this.SendPropertyChanging();
					this._HinhSP = value;
					this.SendPropertyChanged("HinhSP");
					this.OnHinhSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KhuyenMai", DbType="Float")]
		public System.Nullable<double> KhuyenMai
		{
			get
			{
				return this._KhuyenMai;
			}
			set
			{
				if ((this._KhuyenMai != value))
				{
					this.OnKhuyenMaiChanging(value);
					this.SendPropertyChanging();
					this._KhuyenMai = value;
					this.SendPropertyChanged("KhuyenMai");
					this.OnKhuyenMaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MATHANG_CHITIETHD", Storage="_CHITIETHDs", ThisKey="MaMH", OtherKey="MaMH")]
		public EntitySet<CHITIETHD> CHITIETHDs
		{
			get
			{
				return this._CHITIETHDs;
			}
			set
			{
				this._CHITIETHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAINGK_MATHANG", Storage="_LOAINGK", ThisKey="MaLH", OtherKey="MaLH", IsForeignKey=true)]
		public LOAINGK LOAINGK
		{
			get
			{
				return this._LOAINGK.Entity;
			}
			set
			{
				LOAINGK previousValue = this._LOAINGK.Entity;
				if (((previousValue != value) 
							|| (this._LOAINGK.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAINGK.Entity = null;
						previousValue.MATHANGs.Remove(this);
					}
					this._LOAINGK.Entity = value;
					if ((value != null))
					{
						value.MATHANGs.Add(this);
						this._MaLH = value.MaLH;
					}
					else
					{
						this._MaLH = default(int);
					}
					this.SendPropertyChanged("LOAINGK");
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
		
		private void attach_CHITIETHDs(CHITIETHD entity)
		{
			this.SendPropertyChanging();
			entity.MATHANG = this;
		}
		
		private void detach_CHITIETHDs(CHITIETHD entity)
		{
			this.SendPropertyChanging();
			entity.MATHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NCC")]
	public partial class NCC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNCC;
		
		private string _TenNCC;
		
		private string _DiaChiNCC;
		
		private string _SDTNCC;
		
		private EntitySet<LOAINGK> _LOAINGKs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNCCChanging(int value);
    partial void OnMaNCCChanged();
    partial void OnTenNCCChanging(string value);
    partial void OnTenNCCChanged();
    partial void OnDiaChiNCCChanging(string value);
    partial void OnDiaChiNCCChanged();
    partial void OnSDTNCCChanging(string value);
    partial void OnSDTNCCChanged();
    #endregion
		
		public NCC()
		{
			this._LOAINGKs = new EntitySet<LOAINGK>(new Action<LOAINGK>(this.attach_LOAINGKs), new Action<LOAINGK>(this.detach_LOAINGKs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNCC", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNCC
		{
			get
			{
				return this._MaNCC;
			}
			set
			{
				if ((this._MaNCC != value))
				{
					this.OnMaNCCChanging(value);
					this.SendPropertyChanging();
					this._MaNCC = value;
					this.SendPropertyChanged("MaNCC");
					this.OnMaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNCC", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenNCC
		{
			get
			{
				return this._TenNCC;
			}
			set
			{
				if ((this._TenNCC != value))
				{
					this.OnTenNCCChanging(value);
					this.SendPropertyChanging();
					this._TenNCC = value;
					this.SendPropertyChanged("TenNCC");
					this.OnTenNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChiNCC", DbType="NVarChar(50)")]
		public string DiaChiNCC
		{
			get
			{
				return this._DiaChiNCC;
			}
			set
			{
				if ((this._DiaChiNCC != value))
				{
					this.OnDiaChiNCCChanging(value);
					this.SendPropertyChanging();
					this._DiaChiNCC = value;
					this.SendPropertyChanged("DiaChiNCC");
					this.OnDiaChiNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDTNCC", DbType="VarChar(11)")]
		public string SDTNCC
		{
			get
			{
				return this._SDTNCC;
			}
			set
			{
				if ((this._SDTNCC != value))
				{
					this.OnSDTNCCChanging(value);
					this.SendPropertyChanging();
					this._SDTNCC = value;
					this.SendPropertyChanged("SDTNCC");
					this.OnSDTNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NCC_LOAINGK", Storage="_LOAINGKs", ThisKey="MaNCC", OtherKey="MaNCC")]
		public EntitySet<LOAINGK> LOAINGKs
		{
			get
			{
				return this._LOAINGKs;
			}
			set
			{
				this._LOAINGKs.Assign(value);
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
		
		private void attach_LOAINGKs(LOAINGK entity)
		{
			this.SendPropertyChanging();
			entity.NCC = this;
		}
		
		private void detach_LOAINGKs(LOAINGK entity)
		{
			this.SendPropertyChanging();
			entity.NCC = null;
		}
	}
}
#pragma warning restore 1591

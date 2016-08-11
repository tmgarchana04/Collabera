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

namespace HammerTimeWeb.ClassLibraries.DBLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HammerTime")]
	public partial class HammerTimeDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertproduct(product instance);
    partial void Updateproduct(product instance);
    partial void Deleteproduct(product instance);
    #endregion
		
		public HammerTimeDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HammerTimeConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HammerTimeDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HammerTimeDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HammerTimeDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HammerTimeDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<product> products
		{
			get
			{
				return this.GetTable<product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.product")]
	public partial class product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _brand;
		
		private string _material;
		
		private System.Nullable<int> _setSize;
		
		private string _color;
		
		private string _weight;
		
		private string _dimensions;
		
		private string _packcontent;
		
		private string _sku;
		
		private string _description;
		
		private System.Nullable<int> _stockunit;
		
		private System.Nullable<int> _minstockalertunit;
		
		private System.Nullable<bool> _status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnbrandChanging(string value);
    partial void OnbrandChanged();
    partial void OnmaterialChanging(string value);
    partial void OnmaterialChanged();
    partial void OnsetSizeChanging(System.Nullable<int> value);
    partial void OnsetSizeChanged();
    partial void OncolorChanging(string value);
    partial void OncolorChanged();
    partial void OnweightChanging(string value);
    partial void OnweightChanged();
    partial void OndimensionsChanging(string value);
    partial void OndimensionsChanged();
    partial void OnpackcontentChanging(string value);
    partial void OnpackcontentChanged();
    partial void OnskuChanging(string value);
    partial void OnskuChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnstockunitChanging(System.Nullable<int> value);
    partial void OnstockunitChanged();
    partial void OnminstockalertunitChanging(System.Nullable<int> value);
    partial void OnminstockalertunitChanged();
    partial void OnstatusChanging(System.Nullable<bool> value);
    partial void OnstatusChanged();
    #endregion
		
		public product()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(256)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_brand", DbType="NVarChar(256)")]
		public string brand
		{
			get
			{
				return this._brand;
			}
			set
			{
				if ((this._brand != value))
				{
					this.OnbrandChanging(value);
					this.SendPropertyChanging();
					this._brand = value;
					this.SendPropertyChanged("brand");
					this.OnbrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_material", DbType="NVarChar(256)")]
		public string material
		{
			get
			{
				return this._material;
			}
			set
			{
				if ((this._material != value))
				{
					this.OnmaterialChanging(value);
					this.SendPropertyChanging();
					this._material = value;
					this.SendPropertyChanged("material");
					this.OnmaterialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_setSize", DbType="Int")]
		public System.Nullable<int> setSize
		{
			get
			{
				return this._setSize;
			}
			set
			{
				if ((this._setSize != value))
				{
					this.OnsetSizeChanging(value);
					this.SendPropertyChanging();
					this._setSize = value;
					this.SendPropertyChanged("setSize");
					this.OnsetSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_color", DbType="NVarChar(256)")]
		public string color
		{
			get
			{
				return this._color;
			}
			set
			{
				if ((this._color != value))
				{
					this.OncolorChanging(value);
					this.SendPropertyChanging();
					this._color = value;
					this.SendPropertyChanged("color");
					this.OncolorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_weight", DbType="NVarChar(256)")]
		public string weight
		{
			get
			{
				return this._weight;
			}
			set
			{
				if ((this._weight != value))
				{
					this.OnweightChanging(value);
					this.SendPropertyChanging();
					this._weight = value;
					this.SendPropertyChanged("weight");
					this.OnweightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dimensions", DbType="NVarChar(256)")]
		public string dimensions
		{
			get
			{
				return this._dimensions;
			}
			set
			{
				if ((this._dimensions != value))
				{
					this.OndimensionsChanging(value);
					this.SendPropertyChanging();
					this._dimensions = value;
					this.SendPropertyChanged("dimensions");
					this.OndimensionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_packcontent", DbType="NVarChar(256)")]
		public string packcontent
		{
			get
			{
				return this._packcontent;
			}
			set
			{
				if ((this._packcontent != value))
				{
					this.OnpackcontentChanging(value);
					this.SendPropertyChanging();
					this._packcontent = value;
					this.SendPropertyChanged("packcontent");
					this.OnpackcontentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sku", DbType="NVarChar(256)")]
		public string sku
		{
			get
			{
				return this._sku;
			}
			set
			{
				if ((this._sku != value))
				{
					this.OnskuChanging(value);
					this.SendPropertyChanging();
					this._sku = value;
					this.SendPropertyChanged("sku");
					this.OnskuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(1024)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stockunit", DbType="Int")]
		public System.Nullable<int> stockunit
		{
			get
			{
				return this._stockunit;
			}
			set
			{
				if ((this._stockunit != value))
				{
					this.OnstockunitChanging(value);
					this.SendPropertyChanging();
					this._stockunit = value;
					this.SendPropertyChanged("stockunit");
					this.OnstockunitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_minstockalertunit", DbType="Int")]
		public System.Nullable<int> minstockalertunit
		{
			get
			{
				return this._minstockalertunit;
			}
			set
			{
				if ((this._minstockalertunit != value))
				{
					this.OnminstockalertunitChanging(value);
					this.SendPropertyChanging();
					this._minstockalertunit = value;
					this.SendPropertyChanged("minstockalertunit");
					this.OnminstockalertunitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit")]
		public System.Nullable<bool> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
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
﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace ReportsApplication1
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class pruebaEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto pruebaEntities usando la cadena de conexión encontrada en la sección 'pruebaEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public pruebaEntities() : base("name=pruebaEntities", "pruebaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto pruebaEntities.
        /// </summary>
        public pruebaEntities(string connectionString) : base(connectionString, "pruebaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto pruebaEntities.
        /// </summary>
        public pruebaEntities(EntityConnection connection) : base(connection, "pruebaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Pais> Pais
        {
            get
            {
                if ((_Pais == null))
                {
                    _Pais = base.CreateObjectSet<Pais>("Pais");
                }
                return _Pais;
            }
        }
        private ObjectSet<Pais> _Pais;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Persona> Persona
        {
            get
            {
                if ((_Persona == null))
                {
                    _Persona = base.CreateObjectSet<Persona>("Persona");
                }
                return _Persona;
            }
        }
        private ObjectSet<Persona> _Persona;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Pais. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToPais(Pais pais)
        {
            base.AddObject("Pais", pais);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Persona. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToPersona(Persona persona)
        {
            base.AddObject("Persona", persona);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="pruebaModel", Name="Pais")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Pais : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Pais.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad Id.</param>
        public static Pais CreatePais(global::System.Int32 id)
        {
            Pais pais = new Pais();
            pais.Id = id;
            return pais;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Pais1
        {
            get
            {
                return _Pais1;
            }
            set
            {
                OnPais1Changing(value);
                ReportPropertyChanging("Pais1");
                _Pais1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Pais1");
                OnPais1Changed();
            }
        }
        private global::System.String _Pais1;
        partial void OnPais1Changing(global::System.String value);
        partial void OnPais1Changed();

        #endregion

    
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="pruebaModel", Name="Persona")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Persona : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Persona.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad Id.</param>
        public static Persona CreatePersona(global::System.Int32 id)
        {
            Persona persona = new Persona();
            persona.Id = id;
            return persona;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Edad
        {
            get
            {
                return _Edad;
            }
            set
            {
                OnEdadChanging(value);
                ReportPropertyChanging("Edad");
                _Edad = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Edad");
                OnEdadChanged();
            }
        }
        private Nullable<global::System.Int32> _Edad;
        partial void OnEdadChanging(Nullable<global::System.Int32> value);
        partial void OnEdadChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> IdPais
        {
            get
            {
                return _IdPais;
            }
            set
            {
                OnIdPaisChanging(value);
                ReportPropertyChanging("IdPais");
                _IdPais = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdPais");
                OnIdPaisChanged();
            }
        }
        private Nullable<global::System.Int32> _IdPais;
        partial void OnIdPaisChanging(Nullable<global::System.Int32> value);
        partial void OnIdPaisChanged();

        #endregion

    
    }

    #endregion

    
}

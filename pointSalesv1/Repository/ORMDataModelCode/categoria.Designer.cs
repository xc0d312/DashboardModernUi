﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace pointSalesv1.Models.puntoVenta
{

    public partial class categoria : XPLiteObject
    {
        int fidCategoria;
        [Key(true)]
        public int idCategoria
        {
            get { return fidCategoria; }
            set { SetPropertyValue<int>(nameof(idCategoria), ref fidCategoria, value); }
        }
        string fcodigo;
        [Size(6)]
        public string codigo
        {
            get { return fcodigo; }
            set { SetPropertyValue<string>(nameof(codigo), ref fcodigo, value); }
        }
        string fnombre;
        [Size(45)]
        public string nombre
        {
            get { return fnombre; }
            set { SetPropertyValue<string>(nameof(nombre), ref fnombre, value); }
        }
        string fdescripcion;
        [Size(60)]
        public string descripcion
        {
            get { return fdescripcion; }
            set { SetPropertyValue<string>(nameof(descripcion), ref fdescripcion, value); }
        }
        [Association(@"productosReferencescategoria")]
        public XPCollection<productos> productosCollection { get { return GetCollection<productos>(nameof(productosCollection)); } }
    }

}
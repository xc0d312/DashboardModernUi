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

    public partial class tipounidad : XPLiteObject
    {
        int fidtipoUnidad;
        [Key(true)]
        public int idtipoUnidad
        {
            get { return fidtipoUnidad; }
            set { SetPropertyValue<int>(nameof(idtipoUnidad), ref fidtipoUnidad, value); }
        }
        string ftipoUnidad;
        [Size(45)]
        public string tipoUnidad
        {
            get { return ftipoUnidad; }
            set { SetPropertyValue<string>(nameof(tipoUnidad), ref ftipoUnidad, value); }
        }
        [Association(@"detalle_entradaReferencestipounidad")]
        public XPCollection<detalle_entrada> detalle_entradas { get { return GetCollection<detalle_entrada>(nameof(detalle_entradas)); } }
        [Association(@"productosReferencestipounidad")]
        public XPCollection<productos> productosCollection { get { return GetCollection<productos>(nameof(productosCollection)); } }
    }

}
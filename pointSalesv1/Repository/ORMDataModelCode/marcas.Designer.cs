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

    public partial class marcas : XPLiteObject
    {
        int fidMarcas;
        [Key(true)]
        public int idMarcas
        {
            get { return fidMarcas; }
            set { SetPropertyValue<int>(nameof(idMarcas), ref fidMarcas, value); }
        }
        string fcodigo;
        [Size(6)]
        public string codigo
        {
            get { return fcodigo; }
            set { SetPropertyValue<string>(nameof(codigo), ref fcodigo, value); }
        }
        string fmarcas1;
        [Persistent(@"marcas")]
        public string marcas1
        {
            get { return fmarcas1; }
            set { SetPropertyValue<string>(nameof(marcas1), ref fmarcas1, value); }
        }
        string fdescripcion;
        public string descripcion
        {
            get { return fdescripcion; }
            set { SetPropertyValue<string>(nameof(descripcion), ref fdescripcion, value); }
        }
        [Association(@"productosReferencesmarcas")]
        public XPCollection<productos> productosCollection { get { return GetCollection<productos>(nameof(productosCollection)); } }
    }

}

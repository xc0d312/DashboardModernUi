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

    public partial class clientes : XPLiteObject
    {
        int fidClientes;
        [Key(true)]
        public int idClientes
        {
            get { return fidClientes; }
            set { SetPropertyValue<int>(nameof(idClientes), ref fidClientes, value); }
        }
        string fdni;
        [Size(18)]
        public string dni
        {
            get { return fdni; }
            set { SetPropertyValue<string>(nameof(dni), ref fdni, value); }
        }
        string fnombre;
        [Size(60)]
        public string nombre
        {
            get { return fnombre; }
            set { SetPropertyValue<string>(nameof(nombre), ref fnombre, value); }
        }
        string ftelefono;
        [Size(12)]
        public string telefono
        {
            get { return ftelefono; }
            set { SetPropertyValue<string>(nameof(telefono), ref ftelefono, value); }
        }
        string fdireccion;
        public string direccion
        {
            get { return fdireccion; }
            set { SetPropertyValue<string>(nameof(direccion), ref fdireccion, value); }
        }
        char fsexo;
        public char sexo
        {
            get { return fsexo; }
            set { SetPropertyValue<char>(nameof(sexo), ref fsexo, value); }
        }
        string femail;
        public string email
        {
            get { return femail; }
            set { SetPropertyValue<string>(nameof(email), ref femail, value); }
        }
        [Association(@"ventaReferencesclientes")]
        public XPCollection<venta> ventas { get { return GetCollection<venta>(nameof(ventas)); } }
    }

}
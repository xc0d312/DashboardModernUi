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

    public partial class usuarios : XPLiteObject
    {
        int fidUsuarios;
        [Key(true)]
        public int idUsuarios
        {
            get { return fidUsuarios; }
            set { SetPropertyValue<int>(nameof(idUsuarios), ref fidUsuarios, value); }
        }
        string fuserName;
        [Size(85)]
        public string userName
        {
            get { return fuserName; }
            set { SetPropertyValue<string>(nameof(userName), ref fuserName, value); }
        }
        string fpassword;
        [Size(30)]
        public string password
        {
            get { return fpassword; }
            set { SetPropertyValue<string>(nameof(password), ref fpassword, value); }
        }
        string ffullName;
        public string fullName
        {
            get { return ffullName; }
            set { SetPropertyValue<string>(nameof(fullName), ref ffullName, value); }
        }
        string frol;
        [Size(20)]
        public string rol
        {
            get { return frol; }
            set { SetPropertyValue<string>(nameof(rol), ref frol, value); }
        }
        string femail;
        [Size(90)]
        public string email
        {
            get { return femail; }
            set { SetPropertyValue<string>(nameof(email), ref femail, value); }
        }
        [Association(@"ventaReferencesusuarios")]
        public XPCollection<venta> ventas { get { return GetCollection<venta>(nameof(ventas)); } }
    }

}
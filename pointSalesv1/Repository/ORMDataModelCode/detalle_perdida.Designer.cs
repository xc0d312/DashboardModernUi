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

    public partial class detalle_perdida : XPLiteObject
    {
        int fidDetalle;
        [Key(true)]
        public int idDetalle
        {
            get { return fidDetalle; }
            set { SetPropertyValue<int>(nameof(idDetalle), ref fidDetalle, value); }
        }
        perdida fid_perdida;
        [Association(@"detalle_perdidaReferencesperdida")]
        public perdida id_perdida
        {
            get { return fid_perdida; }
            set { SetPropertyValue<perdida>(nameof(id_perdida), ref fid_perdida, value); }
        }
        int fid_prod;
        public int id_prod
        {
            get { return fid_prod; }
            set { SetPropertyValue<int>(nameof(id_prod), ref fid_prod, value); }
        }
        double fcosto;
        public double costo
        {
            get { return fcosto; }
            set { SetPropertyValue<double>(nameof(costo), ref fcosto, value); }
        }
        int fcantidad;
        public int cantidad
        {
            get { return fcantidad; }
            set { SetPropertyValue<int>(nameof(cantidad), ref fcantidad, value); }
        }
    }

}

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

    public partial class detalle_venta : XPLiteObject
    {
        int fidDetalle;
        [Key(true)]
        public int idDetalle
        {
            get { return fidDetalle; }
            set { SetPropertyValue<int>(nameof(idDetalle), ref fidDetalle, value); }
        }
        venta fid_venta;
        [Association(@"detalle_ventaReferencesventa")]
        public venta id_venta
        {
            get { return fid_venta; }
            set { SetPropertyValue<venta>(nameof(id_venta), ref fid_venta, value); }
        }
        productos fid_prod;
        [Association(@"detalle_ventaReferencesproductos")]
        public productos id_prod
        {
            get { return fid_prod; }
            set { SetPropertyValue<productos>(nameof(id_prod), ref fid_prod, value); }
        }
        double fcostoUnitario;
        public double costoUnitario
        {
            get { return fcostoUnitario; }
            set { SetPropertyValue<double>(nameof(costoUnitario), ref fcostoUnitario, value); }
        }
        double fprecioUnitario;
        public double precioUnitario
        {
            get { return fprecioUnitario; }
            set { SetPropertyValue<double>(nameof(precioUnitario), ref fprecioUnitario, value); }
        }
        int fcantidad;
        public int cantidad
        {
            get { return fcantidad; }
            set { SetPropertyValue<int>(nameof(cantidad), ref fcantidad, value); }
        }
        double fdescuento;
        public double descuento
        {
            get { return fdescuento; }
            set { SetPropertyValue<double>(nameof(descuento), ref fdescuento, value); }
        }
    }

}
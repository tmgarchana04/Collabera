using HammerTimeWeb.ClassLibraries.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HammerTimeWeb.ClassLibraries.BO
{
    public class HammerProductBO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public string material { get; set; }
        public System.Nullable<int> setSize { get; set; }
        public string color { get; set; }
        public string weight { get; set; }
        public string dimensions { get; set; }
        public string packcontent { get; set; }
        public string sku { get; set; }
        public string description { get; set; }
        public System.Nullable<int> stockunit { get; set; }
        public System.Nullable<int> minstockalertunit { get; set; }
        public System.Nullable<bool> status { get; set; }

        public HammerProductBO() { }
        public HammerProductBO(product product)
        {
            id = product.id;
            name = product.name;
            brand = product.brand;
            material = product.material;
            setSize = product.setSize;
            color = product.color;
            weight = product.weight;
            dimensions = product.dimensions;
            packcontent = product.packcontent;
            sku = product.sku;
            description = product.description;
            stockunit = product.stockunit;
            minstockalertunit = product.minstockalertunit;
            status = product.status;
        }

    }
}
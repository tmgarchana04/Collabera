using HammerTimeWeb.ClassLibraries.BO;
using HammerTimeWeb.ClassLibraries.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HammerTimeWeb.ClassLibraries.DAL
{
    public class HammerProductDAL
    {

        /// <summary>
        /// Get all Hammer Products
        /// </summary>
        /// <returns></returns>
        internal List<HammerProductBO> GetAllHammerProducts()
        {
            List<HammerProductBO> objlist = null;
            try
            {
                using (HammerTimeDBDataContext spcontext = new HammerTimeDBDataContext())
                {
                    List<HammerProductBO> vObjects = (from temp in spcontext.products
                                                      select new HammerProductBO(temp)).ToList<HammerProductBO>();
                    if (vObjects != null)
                    {
                        if (vObjects.Count > 0)
                        {
                            return vObjects;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objlist;
        }

        /// <summary>
        /// Get HammerProduct by id
        /// </summary>
        /// <returns></returns>
        internal HammerProductBO GetHammerProductById(int _id)
        {
            HammerProductBO objlist = null;
            try
            {
                using (HammerTimeDBDataContext spcontext = new HammerTimeDBDataContext())
                {
                    HammerProductBO vObject = (from temp in spcontext.products
                                               where temp.id == _id
                                               select new HammerProductBO(temp)).SingleOrDefault<HammerProductBO>();

                    if (vObject != null)
                    {
                        return vObject;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objlist;
        }

        /// <summary>
        /// add new HammerProduct
        /// </summary>
        /// <param name="objItem"></param>
        /// <returns></returns>
        internal HammerProductBO AddHammerProduct(HammerProductBO objItem)
        {
            try
            {
                using (HammerTimeDBDataContext spcontext = new HammerTimeDBDataContext())
                {
                    product obj = new product();

                    obj.name = objItem.name;
                    obj.brand = objItem.brand;
                    obj.material = objItem.material;
                    obj.setSize = objItem.setSize;
                    obj.color = objItem.color;
                    obj.weight = objItem.weight;
                    obj.dimensions = objItem.dimensions;
                    obj.packcontent = objItem.packcontent;
                    obj.sku = objItem.sku;
                    obj.description = objItem.description;
                    obj.stockunit = objItem.stockunit;
                    obj.minstockalertunit = objItem.minstockalertunit;
                    obj.status = objItem.status;

                    spcontext.products.InsertOnSubmit(obj);
                    spcontext.SubmitChanges();
                    return new HammerProductBO(obj);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update HammerProduct
        /// </summary>
        /// <param name="objItem"></param>
        /// <returns></returns>
        internal HammerProductBO UpdateHammerProduct(HammerProductBO objItem)
        {
            try
            {
                using (HammerTimeDBDataContext spcontext = new HammerTimeDBDataContext())
                {
                    product obj = (from temp in spcontext.products
                                   where temp.id == objItem.id
                                   select temp).SingleOrDefault<product>();

                    if (obj != null)
                    {

                        if (!string.IsNullOrEmpty(objItem.name)) { obj.name = objItem.name; }
                        if (!string.IsNullOrEmpty(objItem.brand)) { obj.brand = objItem.brand; }
                        if (!string.IsNullOrEmpty(objItem.material)) { obj.material = objItem.material; }
                        if (objItem.setSize != null) { obj.setSize = objItem.setSize; }
                        if (!string.IsNullOrEmpty(objItem.color)) { obj.color = objItem.color; }
                        if (!string.IsNullOrEmpty(objItem.weight)) { obj.weight = objItem.weight; }
                        if (!string.IsNullOrEmpty(objItem.dimensions)) { obj.dimensions = objItem.dimensions; }
                        if (!string.IsNullOrEmpty(objItem.packcontent)) { obj.packcontent = objItem.packcontent; }
                        if (!string.IsNullOrEmpty(objItem.sku)) { obj.sku = objItem.sku; }
                        if (!string.IsNullOrEmpty(objItem.description)) { obj.description = objItem.description; }
                        if (objItem.stockunit != null) { obj.stockunit = objItem.stockunit; }
                        if (objItem.minstockalertunit != null) { obj.minstockalertunit = objItem.minstockalertunit; }

                        obj.status = objItem.status;

                        spcontext.SubmitChanges();
                        return new HammerProductBO(obj);
                    }
                    else
                    {
                        throw new Exception("Hammer Product does not exists");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete HammerProduct
        /// </summary>
        /// <param name="objItem"></param>
        /// <returns></returns>
        internal bool DeleteHammerProduct(HammerProductBO objItem)
        {
            try
            {
                using (HammerTimeDBDataContext spcontext = new HammerTimeDBDataContext())
                {
                    product _objExists = (from temp in spcontext.products
                                          where temp.id == objItem.id
                                          select temp).SingleOrDefault<product>();

                    if (_objExists != null)
                    {
                        spcontext.products.DeleteOnSubmit(_objExists);
                        spcontext.SubmitChanges();
                        return true;
                    }
                    else
                    {
                        throw new Exception("Hammer Product does not exists");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
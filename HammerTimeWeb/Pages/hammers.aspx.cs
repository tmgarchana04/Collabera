using HammerTimeWeb.ClassLibraries.BO;
using HammerTimeWeb.ClassLibraries.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HammerTimeWeb.Pages
{
    public partial class manage_hammer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        [WebMethod]
        public static List<HammerProductBO> GetHammerProducts()
        {
            HammerProductDAL objHammerProductDAL = new HammerProductDAL();
            return objHammerProductDAL.GetAllHammerProducts();
        }

        [WebMethod]
        public static HammerProductBO AddHammerProduct(HammerProductBO entity)
        {
            HammerProductDAL objHammerProductDAL = new HammerProductDAL();
            return objHammerProductDAL.AddHammerProduct(entity);
        }

        [WebMethod]
        public static HammerProductBO UpdateHammerProduct(HammerProductBO entity)
        {
            HammerProductDAL objHammerProductDAL = new HammerProductDAL();
            return objHammerProductDAL.UpdateHammerProduct(entity);
        }

        [WebMethod]
        public static bool DeleteHammerProduct(HammerProductBO entity)
        {
            HammerProductDAL objHammerProductDAL = new HammerProductDAL();
            return objHammerProductDAL.DeleteHammerProduct(entity);
        }
    }
}
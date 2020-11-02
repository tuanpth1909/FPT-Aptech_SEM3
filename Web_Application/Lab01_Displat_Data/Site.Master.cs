using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Display_Data.Models;


namespace Display_Data
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Category> GetCategories()
        {
            var _db = new Display_Data.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys_1_.Models;


namespace WingtipToys_1_
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Category> GetCategories()
        {
            var _db = new WingtipToys_1_.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }
    }
}
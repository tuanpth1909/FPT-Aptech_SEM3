using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys_1_.Logic;
using WingtipToys_1_.Models;

namespace WingtipToys_1_
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<CartItem> GetShoppingCartItems()
        {
            ShoppingCartAction actions = new ShoppingCartAction();
            return actions.GetCartItems();
        }
    }
}
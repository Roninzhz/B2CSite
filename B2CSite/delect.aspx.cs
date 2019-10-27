using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B2CSite
{
    public partial class delect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userInfo"] != null)
            {
                HttpCookie a = Request.Cookies["userInfo"];
                a.Values.Remove("uName");
                a.Values.Remove("uPwd");
                a.Expires = DateTime.Now.AddDays(-1);
                Response.AppendCookie(a);
                Session.Abandon();
                Response.Write("<script>alert('退出成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('用户已退出，刷新网页，已继续')</script>");
            }
        }
    }
}
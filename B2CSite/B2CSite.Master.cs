using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B2CSite
{
    public partial class B2CSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["uName"] != null)
            //{
            //    current.Text = "当前用户为：" + Session["uName"].ToString();
            //}
            //cookie
            if (Request.Cookies["userInfo"]!= null && Request.Cookies["userInfo"]["uName"]!= null)
            {
                string name = Request.Cookies["userInfo"]["uName"];
                current.Text = "已登录用户为：" + name;
            }
            else
            {
                current.Text = " ";
            }
        }
    }
}
using System;
using System.Web;

namespace B2CSite
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Request.Cookies["userInfo"] != null && Request.Cookies["userInfo"]["uName"] != null)
            {
                string name = Request.Cookies["userInfo"]["uName"];
                string pwd = Request.Cookies["userInfo"]["uPwd"];
                //Response.Write("<script>alert(name)</script>");

                if (name != null && pwd != null)
                {
                    Response.Redirect("Default.aspx");
                }

            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string name = txtUName.Text;
            string pwd = txtUPwd.Text;
            //cookie
            //HttpCookie aCookie = new HttpCookie("userinfo");
            //aCookie.Values["uName"] = name;
            //aCookie.Values["pwd"] = pwd;
            //aCookie.Expires = DateTime.Now.AddDays(1);
            //Response.Cookies.Add(aCookie);
            //if(chkState.Checked)
            //{
            //    Response.Cookies["userInfo"]["uName"] = name;
            //    Response.Cookies["userInfo"]["uPwd"] = pwd;
            //    Response.Cookies["userInfo"].Expires = DateTime.Now.AddDays(14);
            //}
            if (pwd == "admin")
            {   Response.Cookies["userInfo"]["uName"] = name;
                Response.Cookies["userInfo"]["uPwd"] = pwd;
                if (chkState.Checked)
                { 
                    Response.Cookies["userInfo"].Expires = DateTime.Now.AddDays(14);
                }
                Session["uName"] = name;
                /*Response.Redirect("ChatRoom.aspx");*/
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("<script>alert('密码不正确')</script>");
                txtUName.Text = "";
                txtUPwd.Text = "";
            }
        }
    }
}
using System;

namespace B2CSite
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string name = txtUName.Text;
            string pwd = txtUPwd.Text;
            if (pwd == "admin")
            {
                Session["uName"] = name;
                /*Response.Redirect("ChatRoom.aspx");*/
                if (chkState.Checked)
                {
                    //Session.Timeout = 5;
                }
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
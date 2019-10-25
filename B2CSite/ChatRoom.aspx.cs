using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B2CSite
{
    public partial class ChatRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uName"] != null)
            {
                lblOnlineNum.Text = "当前人数为" + Application["count"].ToString() + "人";
                txtChatRoom.Text = Application["chat"].ToString();
                lblName.Text = Session["uName"].ToString();
            }
            else
            {
                Response.Redirect("SignUp.aspx");
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string tab = "";
            string newline = "\r";
            string newMessage = lblName.Text + "." + tab + txtChat.Text + newline + Application["char"];
            if (newMessage.Length > 500)
                newMessage = newMessage.Substring(0, 499);
            if (txtChat.Text == "")
            {
                Response.Write("<script>alert('请输入有效内容')</script>");
                return;
            }
            Application.Lock();
            Application["chat"] = newMessage;
            Application.UnLock();
            txtChat.Text = "";
            txtChatRoom.Text = Application["chat"].ToString();
        }
    }
}
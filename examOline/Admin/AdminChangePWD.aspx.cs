using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;

public partial class Admin_AdminChangePWD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null && Session["adminName"]==null)
        {
            Response.Redirect("../Login.aspx");
        }
        //Session["admin"] = "10001";

    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        if (Session["adminName"] == null)
        {
            if (BaseClass.CheckAdmin(Session["admin"].ToString(), txtOldPwd.Text.Trim()))
            {
                string strsql = "update tb_Admin set AdminPwd='" + txtNewPwdA.Text.Trim() + "' where AdminID='" + Session["admin"].ToString() + "'";
                BaseClass.OperateData(strsql);
                lblMessage.ForeColor = Color.Blue;
                lblMessage.Text = "密码修改成功";
                txtNewPwd.Text = "";
                txtNewPwdA.Text = "";
                txtOldPwd.Text = "";

            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "旧密码错误";
                txtOldPwd.Text = "";
                txtOldPwd.Focus();
                return;
            }
        }
        else if (BaseClass.CheckAdminByName(Session["adminName"].ToString(), txtOldPwd.Text.Trim()))
        {
            string strsql = "update tb_Admin set AdminPwd='" + txtNewPwdA.Text.Trim() + "' where adminName='" + Session["admin"].ToString() + "'";
            BaseClass.OperateData(strsql);
            lblMessage.ForeColor = Color.Blue;
            lblMessage.Text = "密码修改成功";
            txtNewPwd.Text = "";
            txtNewPwdA.Text = "";
            txtOldPwd.Text = "";

        }
        else
        {
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = "旧密码错误";
            txtOldPwd.Text = "";
            txtOldPwd.Focus();
            return;
        }
    }

}

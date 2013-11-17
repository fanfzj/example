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

public partial class Student_studentChangePWD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["studentID"] == null)
        {
            Response.Redirect("../Login.aspx");
        }

    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        if (Session["studentID"]!=null)
        {
            if (BaseClass.CheckStudent(Session["studentID"].ToString(), txtOldPwd.Text.Trim()))
            {
                string strsql = "update tb_student set StudentPwd='" + txtNewPwdA.Text.Trim() + "' where StudentID='" + Session["studentID"].ToString() + "'";
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
}

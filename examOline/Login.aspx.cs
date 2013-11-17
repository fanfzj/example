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

//51aspx
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["accountMode"] = "id";
        }
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        if (txtCode.Text.Trim() != Session["verify"].ToString())
        {
            Response.Write("<script>alert('验证码错误');location='Login.aspx'</script>");
        }
        else
        {
            if (this.ddlstatus.SelectedValue == "学生")
            {
                if (BaseClass.CheckStudent(txtNum.Text.Trim(), txtPwd.Text.Trim()))
                {
                    Session["studentID"] = txtNum.Text.Trim();
                    Response.Redirect("student/student.aspx");
                }
                else
                {
                    Response.Write("<script>alert('您不是学生或者用户名和密码错误');location='Login.aspx'</script>");
                }
            }
            if (this.ddlstatus.SelectedValue == "教师")
                {
                    string mode=Session["accountMode"].ToString();
                    if (mode=="id")
                    {
                        if (BaseClass.CheckTeacher(txtNum.Text.Trim(), txtPwd.Text.Trim()))
                        {
                            Session["teacherID"] = txtNum.Text;
                            Response.Redirect("teacher/Teacher.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('您不是教师或者用户名和密码错误');location='Login.aspx'</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('你现在是用账户名来登录');location='Login.aspx'</script>");

                        string id = BaseClass.CheckTeacherByName(txtNum.Text.Trim(), txtPwd.Text.Trim());
                        Label1.Text = id;
                        //if (BaseClass.CheckTeacherByName(txtNum.Text.Trim(), txtPwd.Text.Trim()))
                        //{
                        //    Session["teacherIName"] = txtNum.Text;
                        //    Response.Redirect("teacher/Teacher.aspx");
                        //}
                        if (id != "")
                        {
                            Session["teacherID"] = id;
                            Response.Redirect("teacher/Teacher.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('您不是教师或者用户名和密码错误');location='Login.aspx'</script>");
                        }
                    }
                }

            //5~1~a~s~p~x
            if (this.ddlstatus.SelectedValue == "管理员")
            {
                string mode = Session["accountMode"].ToString();
                if (mode=="id")
                {
                    if (BaseClass.CheckAdmin(txtNum.Text.Trim(), txtPwd.Text.Trim()))
                    {
                        Session["admin"] = txtNum.Text;

                        Response.Redirect("admin/Admin.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('您不是管理员或者用户名和密码错误');location='Login.aspx'</script>");
                    }
                }//5@1@a@s@p@x
                else
                {
                    if (BaseClass.CheckAdminByName(txtNum.Text.Trim(), txtPwd.Text.Trim()))
                    {
                        Session["adminName"] = txtNum.Text;
                        Session["admin"] = "";
                        Response.Redirect("admin/Admin.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('您不是管理员或者用户名和密码错误');location='Login.aspx'</script>");
                    }
                }
            }
        }
    }
    protected void btnconcel_Click(object sender, EventArgs e)
    {
        RegisterStartupScript("提示", "<script>window.close();</script>");
    }
    protected void rblUserID_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rblUserID.SelectedIndex == 1)
        {
            lblAccount.Text = "账号(名)";
            Session["accountMode"] = "name"; 
            txtNum.Text = "";
            txtPwd.Text = "";
            txtCode.Text = "";
        }
        else
        {
            lblAccount.Text = "账号(ID)";
            Session["accountMode"] = "id"; 
            txtNum.Text = "";
            txtPwd.Text = "";
            txtCode.Text = "";
        }
    }
}


///////////////5//1//a//s//p//x//////////////////
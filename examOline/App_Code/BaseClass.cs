using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
/// <summary>
/// BaseClass类是本系统的公共类,用于基于数据库的操作,可实现数据库连接的建立,DataGrid的数据绑定和数据操作,
/// 用户登录后进行用户的名称及密码验证
/// </summary>
/// 
//51aspx
public class BaseClass
{
    public BaseClass()
    {

    }
    public static SqlConnection DBCon()
    {

        return new SqlConnection("server=localhost;database=xTest;Integrated Security=True");
    }
    public static void BindDDL(DropDownList ddl, string text, string value, string strSql, string Tname)
    {
        SqlConnection conn = DBCon();
        SqlDataAdapter sda = new SqlDataAdapter(strSql, conn);
        DataSet ds = new DataSet();
        sda.Fill(ds, Tname);
        ddl.DataSource = ds.Tables[Tname];
        ddl.DataTextField = text;
        ddl.DataValueField = value;
        ddl.DataBind();
    }

    public static void BindDG(GridView dg, string id, string strSql, string Tname)
    {
        SqlConnection conn = DBCon();
        SqlDataAdapter sda = new SqlDataAdapter(strSql, conn);
        DataSet ds = new DataSet();
        sda.Fill(ds, Tname);
        dg.DataSource = ds.Tables[Tname];
        dg.DataKeyNames = new string[] { id };
        dg.DataBind();
    }
    public static void OperateData(string strsql)
    {
        SqlConnection conn = DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand(strsql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    //================如果是学生登录,使用ID=========================================
    public static bool CheckStudent(string studentID, string studentPwd)
    {
        SqlConnection conn = DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from tb_Student where StudentID='" + studentID + "' and StudentPwd='" + studentPwd + "'", conn);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        if (i > 0)
        {

            return true;
        }
        else
        {
            return false;
        }
    }
    //================如果是教师登录,使用ID=========================================
    public static bool CheckTeacher(string teacherID, string teacherPwd)
    {
        SqlConnection conn = DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from tb_teacher where TeacherID='" + teacherID + "' and TeacherPwd='" + teacherPwd + "'", conn);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        if (i > 0)
        {

            return true;
        }
        else
        {
            return false;
        }
    }
    //================如果是教师登录,使用用户名=========================================
    public static string CheckTeacherByName(string teacherName, string teacherPwd)
    {
        SqlConnection conn = DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from tb_teacher where TeacherName='" + teacherName + "' and TeacherPwd='" + teacherPwd + "'", conn);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        string id = "";
        id = Convert.ToString(cmd.ExecuteScalar());
        conn.Close();

        return id;
    }

    //================如果是管理员登录,使用ID=========================================
    public static bool CheckAdmin(string adminID, string adminPwd)
    {
        SqlConnection conn = DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from tb_Admin where AdminID='" + adminID + "' and AdminPwd='" + adminPwd + "'", conn);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    //================如果是管理员登录,使用用户名=========================================
    public static bool CheckAdminByName(string adminName, string adminPwd)
    {
        SqlConnection conn = DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from tb_Admin where AdminName='" + adminName + "' and AdminPwd='" + adminPwd + "'", conn);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
   

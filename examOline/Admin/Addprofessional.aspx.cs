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
using System.Data.SqlClient;
public partial class Admin_Addprofessional : System.Web.UI.Page
{ 
    SqlConnection conn = BaseClass.DBCon();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            string str = "select * from tb_department";
            BaseClass.BindDDL(DDldttID, "DepartmentName", "DepartmentID", str, "tb_department");
            string str1 = "select * from tb_teacher";
            BaseClass.BindDDL(DDltcrNum, "TeacherName", "TeacherID", str1, "tb_teacher");
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        string str = "insert into tb_professional(ProfessionalID,ProfessionalName,DepartmentID,Description,ManagerID)  values('" + txtID.Text.Trim() + "','" + txtNum.Text.Trim() + "','" + DDldttID.SelectedValue.Trim() + "','" + txtMrID.Text.Trim() +"','" + DDltcrNum.SelectedValue.Trim() + "')";
        SqlCommand cmd = new SqlCommand(str, conn);
        conn.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Response.Write("<script>alert('您不是管理员或者用户名和密码错误');location='Addprofessional.aspx'</script>");
        }
    }
    protected void btnEsc_Click(object sender, EventArgs e)
    {
        txtID.Text = "";
        txtNum.Text = "";
    }
}

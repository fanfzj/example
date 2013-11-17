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

public partial class Admin_Addclass : System.Web.UI.Page
{
    SqlConnection conn = BaseClass.DBCon();
    protected void Page_Load(object sender, EventArgs e)
    {
        string str = "select * from tb_teacher";
        BaseClass.BindDDL(DDltcr, "TeacherName", "TeacherID", str, "tb_teacher");
        string str1 = "select * from tb_professional";
        BaseClass.BindDDL(DDlpsl, "ProfessionalName", "professionalID", str1, "tb_professional");
        string str2 = "select * from tb_department";
        BaseClass.BindDDL(DDlatt, "DepartmentName", "DepartmentID", str2, "tb_department");

        
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        string str = "insert into tb_class(ClassID,ClassName,StudenNumber,Grade,ProfessionalID,DepartmentID,ManagerID,ClassDescription)  values('" + txtclsID.Text.Trim() + "','" + txtclsNum.Text.Trim() + "','" + txtNbr.Text.Trim() + "','" + txtge.Text.Trim() + "','" + DDlpsl.SelectedValue.Trim() + "','" + DDlatt.SelectedValue.Trim() + "','" + DDltcr.SelectedValue.Trim() + "','" + txtmrID.Text.Trim() + "')";
        SqlCommand cmd = new SqlCommand(str, conn);
        conn.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Response.Write("<script>alert('插入成功！');</script>");
        }
    }
    protected void btnEsc_Click(object sender, EventArgs e)
    {
        txtclsID.Text = "";
        txtclsNum.Text = "";
        txtge.Text = "";
        txtmrID.Text = "";
        txtNbr.Text = "";
    }
}

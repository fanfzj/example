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

public partial class Admin_Adddepartment : System.Web.UI.Page
{
    SqlConnection conn = BaseClass.DBCon();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
      {
	      string str = "select * from tb_teacher";
	        BaseClass.BindDDL(ddl, "TeacherName", "TeacherID", str, "tb_teacher");
      }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        string str = "insert into tb_department(DepartmentID,DepartmentName,ManagerID,Description)  values('" + txtddtID.Text.Trim() + "','" + TextBox1.Text.Trim() + "','" + ddl.SelectedValue.Trim() + "','" + txtDtn.Text.Trim() + "')";
        SqlCommand cmd = new SqlCommand(str,conn);
        conn.Open();
        SqlDataReader reader=cmd.ExecuteReader ();
        while (reader.Read())
        {
            Response.Write("<script>alert('插入成功！');</script>");
        }

    }
    protected void btnEsc_Click(object sender, EventArgs e)
    {
        
        txtddtID.Text = "";
        txtDtn.Text = "";
        TextBox1.Text = "";
    }
}

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
//using System.Data.SqlClient;

public partial class Admin_teacherInfoView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string str = "select * from tb_teacher order by ID desc";
            BaseClass.BindDG(GridView1, "ID", str, "teacherinfo");
            
        }
    }
    
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        string strsql = "select * from tb_teacher order by ID desc";
        BaseClass.BindDG(GridView1, "ID", strsql, "teacherinfo");
    }
    
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = (int)GridView1.DataKeys[e.RowIndex].Value;
        string str = "delete from tb_teacher where ID=" + id;
        BaseClass.OperateData(str);
        string strsql = "select * from tb_teacher order by ID desc";
        BaseClass.BindDG(GridView1, "ID", strsql, "teacherinfo");
    }
    protected void btnserch_Click(object sender, EventArgs e)
    {
        if (txtKey.Text == "")
        {
            string strsql = "select * from tb_teacher order by ID desc";
            BaseClass.BindDG(GridView1, "ID", strsql, "admInfo");
        }
        else
        {
            string stype = ddlType.SelectedItem.Text;
            string strsql = "";
            switch (stype)
            {
                case "教师姓名":
                    strsql = "select * from tb_teacher where TeacherName like '%" + txtKey.Text.Trim() + "%'";
                    BaseClass.BindDG(GridView1, "ID", strsql, "admInfo"); ;
                    break;
                case "性别":
                    strsql = "select * from tb_teacher where Sex like '%" + txtKey.Text.Trim() + "%'";
                    BaseClass.BindDG(GridView1, "ID", strsql, "admInfo");
                    break;
                case "教师角色":
                    strsql = "select * from tb_teacher where TeacherRoler like '%" + txtKey.Text.Trim() + "%'";
                    BaseClass.BindDG(GridView1, "ID", strsql, "admInfo"); ;
                    break;
                case "教师编号":
                    strsql = "select * from tb_teacher where TeacherID like '%" + txtKey.Text.Trim() + "%'";
                    BaseClass.BindDG(GridView1, "ID", strsql, "admInfo");
                    break;
            }
        }
    }
}

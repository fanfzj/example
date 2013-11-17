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

public partial class Admin_teacherAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            string cmdStr = "select * from tb_teacher ";

            SqlCommand cmdDDL = new SqlCommand(cmdStr, conn);
            SqlDataReader sdrDDL = cmdDDL.ExecuteReader();

            //ddlClass.DataSource = sdrDDL;
            //ddlClass.DataTextField = "ClassName";
            //ddlClass.DataValueField = "ClassName";
            //ddlClass.DataBind();
            conn.Close();
        }
    }
    protected void btncen_Click(object sender, EventArgs e)
    {
        txtID.Text = "";
        txtname.Text = "";
        txtpwd.Text = "";
        rblroler.SelectedIndex = -1;
        rblsex.SelectedIndex = -1;
    }
    protected void btnok_Click(object sender, EventArgs e)
    {
        SqlConnection conn = BaseClass.DBCon();
        conn.Open();
        string str = "insert into tb_teacher(TeacherID,TeacherName,TeacherPwd,Sex,TeacherRoler)  values('" + txtID.Text.Trim() + "','" + txtname.Text.Trim() + "','" + txtpwd.Text.Trim() + "','" + rblsex.SelectedItem .Text+ "','" + rblroler.SelectedItem.Text + "')";
        SqlCommand cmd = new SqlCommand(str,conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        btncen_Click(sender,e);
    }
}

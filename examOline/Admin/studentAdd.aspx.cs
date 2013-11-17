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

public partial class Admin_studentAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            string cmdStr = "select * from tb_Class ";

            SqlCommand cmdDDL = new SqlCommand(cmdStr, conn);
            SqlDataReader sdrDDL = cmdDDL.ExecuteReader();
            
            ddlClass.DataSource = sdrDDL;
            ddlClass.DataTextField = "ClassName";
            ddlClass.DataValueField = "ClassName";
            ddlClass.DataBind();
            conn.Close();
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("stuInfoView.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string str = "insert into tb_Student (StudentID,StudentName,StudentPwd,Sex,ClassID)  values('" + txtStuID.Text.Trim() + "','" + txtStuName.Text.Trim() + "','"
            + txtPassWord.Text.Trim() + "','" + rblSex.SelectedItem.Text + 
           "','"+ ddlClass.SelectedValue +
            //"','" + txtDescription.Text.Trim() + 
            "' )";
        //BaseClass.OperateData(str);
        SqlConnection conn = BaseClass.DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand(str, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        Close();
        
    }
    private void Close()
    {
        txtStuID.Text = "";
        txtStuName.Text = "";

        ddlClass.SelectedIndex = -1;

        rblSex.SelectedIndex = -1;
    }

}

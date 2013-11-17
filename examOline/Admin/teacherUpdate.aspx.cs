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

public partial class Admin_teacherUpdate : System.Web.UI.Page
{
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["teacherID"].ToString();
        SqlConnection conn = BaseClass.DBCon();
       
        conn.Open();
        SqlCommand cmd = new SqlCommand("select * from tb_Teacher where ID=" + id, conn);
        SqlDataReader sdr = cmd.ExecuteReader();
        while (sdr.Read())
        {
            txtname.Text = sdr["TeacherName"].ToString();
            txtID.Text = sdr["TeacherID"].ToString();
            txtpwd.Text = sdr["TeacherPwd"].ToString();
            for (int a = 0; a < rblsex.Items.Count; a++)
            {
                if (rblsex.Items[a].Text == sdr["Sex"].ToString().Trim())
                    rblsex.Items[a].Selected = true;
            }
                //rblsex.SelectedValue = sdr["Sex"].ToString();
            for (int a = 0; a < (int) rblroler.Items.Count; a++)
            {
                if ( rblroler.Items[a].Text == sdr["TeacherRoler"].ToString().Trim())
                     rblroler.Items[a].Selected = true;
            }
            //rblroler.SelectedValue = ;
            
        }
        conn.Close();
    }
    protected void btncen_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacherInfoView.aspx");
    }
    protected void btnok_Click(object sender, EventArgs e)
    {
        if (txtname.Text.Trim() == "" || txtpwd.Text.Trim() == "")
        {
            Label1.Text = "请将姓名和密码信息填写完整。";
            return;
        }
        else
        {
            id = Request.QueryString["teacherID"].ToString();
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            string str = "update tb_Teacher set TeacherID='" + txtID.Text.Trim() + "',TeacherName='" + txtname.Text.Trim() + "',TeacherPwd='" + txtpwd.Text.Trim() + "',Sex='" + rblsex.SelectedItem.ToString() + "',TeacherRoler='" + rblroler.SelectedItem.ToString() + "'where ID='" + id + "'";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }
        Response.Redirect("teacherInfoView.aspx");
    }
}

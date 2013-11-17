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

public partial class Admin_studentUpdate : System.Web.UI.Page
{
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            id = Request.QueryString["stuid"].ToString();
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
            



            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_Student where ID=" + id, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                tbx_stuName.Text = sdr["StudentName"].ToString();
                tbx_stuId.Text = sdr["StudentID"].ToString();
                tbx_stuPwd.Text = sdr["StudentPwd"].ToString();
                for (int a = 0; a < (int)rblSex.Items.Count; a++)
                {
                    if (rblSex.Items[a].Text == sdr["Sex"].ToString().Trim())
                        rblSex.Items[a].Selected = true;
                }
                //rblSex.SelectedValue = ;

                //Label1.Text = ddlClass.Items[1].Value.ToString();
                //在"下拉列表"中查找这条记录的"ClassID"的索引值，并在"下拉列表"中显示出当前记录的值
                string classIDStr = sdr["ClassID"].ToString();
                int k = 0;
                for (int i = 0; i < ddlClass.Items.Count; i++)
                {
                    if (ddlClass.Items[i].Value.ToString() == classIDStr)
                        k = i;
                }
                ddlClass.SelectedIndex = k;

                //txtDescription.Text = sdr["Description"].ToString();
            }
            conn.Close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("stuInfoView.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (tbx_stuName.Text.Trim() == "" || tbx_stuPwd.Text.Trim() == "")
        {
            
            Label1.Text = "请将姓名和密码信息填写完整。";
            return;
        }
        else
        {
            id = Request.QueryString["stuid"].ToString();
            string str = "update tb_Student set StudentName='" + tbx_stuName.Text.Trim() + "',StudentPwd='"
            + tbx_stuPwd.Text.Trim() + "',Sex='" +rblSex.SelectedItem.ToString() +
           "',ClassID='" + ddlClass.SelectedValue.ToString() +
            //"','" + txtDescription.Text.Trim() + 
            "' where ID='" + id + "'";
        //BaseClass.OperateData(str);
        SqlConnection conn = BaseClass.DBCon();
        conn.Open();
        SqlCommand cmd = new SqlCommand(str, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
            
        }
        Response.Redirect("stuInfoView.aspx");
    }
}

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

public partial class Student_infoView : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("server=localhost;database=xTest;Integrated Security=True");
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
            conn.Open();
            string str = "select * from tb_Student where StudentID='" + Session["StudentID"].ToString() + "'";
            SqlCommand cmd = new SqlCommand(str, conn);
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
               
                string classIDStr = sdr["ClassID"].ToString();
                int k = 0;
                for (int i = 0; i < ddlClass.Items.Count; i++)
                {
                    if (ddlClass.Items[i].Value.ToString() == classIDStr)
                        k = i;
                }
                ddlClass.SelectedIndex = k;

               
            }
            conn.Close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}

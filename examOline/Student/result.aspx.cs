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

public partial class Student_result : System.Web.UI.Page
{
    //string id;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["StudentID"] == null)
        {
            Response.Redirect("Login.aspx");
         }

            if (!IsPostBack)
            {
                string str = "select * from tb_examResult where StudentID='" + Session["StudentID"].ToString() + "'";

                BaseClass.BindDG(GridView1, "ID", str, "stuinfo");
                string strsql = "select * from tb_student where StudentID='" + Session["StudentID"].ToString() + "'";
                SqlConnection conn = BaseClass.DBCon();
                conn.Open();
                SqlCommand cmd = new SqlCommand(strsql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label1.Text = sdr["StudentName"].ToString().Trim();
                }
                conn.Close();

                
            }
           
    
            
}
    protected void link_Click(object sender, EventArgs e)
    {
        //Session.Clear();
        //Response.Write("<script>javascript:location.href='index.aspx'</script>");
    }
    protected void btncx_Click(object sender, EventArgs e)
    {
        if (tbx_query.Text == "")
        {
            string strsql = "select * from tb_examResult where StudentID='" + Session["StudentID"].ToString() + "'";
            BaseClass.BindDG(GridView1, "ID", strsql, "stuinfo");
        }
        else
        {
            string stype = DropDownList1.SelectedItem.Text;
            string strsql = "";
            switch (stype)
            {
                
                case "试卷编号":
                    strsql = "select * from tb_examResult where ExamID like '%" + tbx_query.Text.Trim() + "%'";
                    BaseClass.BindDG(GridView1, "ID", strsql, "stuinfo");
                    break;
                case "总成绩":
                    strsql = "select * from tb_examResult where TotalResult like '%" + tbx_query.Text.Trim() + "%'";
                    BaseClass.BindDG(GridView1, "ID", strsql, "stuinfo");
                    break;

            }
        }
    }
}


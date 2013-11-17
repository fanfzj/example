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


//51aspx
public partial class Teacher_Teacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["studentID"] == "")
            Response.Redirect("Login.aspx");
        
        else
            if (!Page.IsPostBack)
            {

                lbl_Id.Text = Session["studentID"].ToString();
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_student where StudentID='" + Session["studentID"].ToString() + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            lbl_Name.Text = sdr["StudentName"].ToString();
            Label1.Text = sdr["Sex"].ToString();
            conn.Close();
            Session["StudentName"] = lbl_Name.Text;
            Session["Sex"] = Label1.Text;

            }
    }
}

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

public partial class Admin_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"].ToString() == "" && Session["adminName"].ToString() == "")
            Response.Redirect("../Login.aspx");
        if (!IsPostBack)
        {
            if (Session["admin"].ToString() != "")
            {
                lbl_adminId.Text = Session["admin"].ToString();
                SqlConnection conn = BaseClass.DBCon();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from tb_admin where AdminID='" + Session["admin"].ToString() + "'", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                Label1.Text = sdr["AdminName"].ToString();

                conn.Close();
                Session["AdminName"] = Label1.Text;
            }
            else {
                Label1.Text = Session["adminName"].ToString();
                SqlConnection conn = BaseClass.DBCon();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from tb_admin where AdminName='" + Session["adminName"].ToString() + "'", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                lbl_adminId.Text = sdr["AdminID"].ToString();

                conn.Close();
                Session["AdminName"] = Label1.Text;
                
            }

        }
    }
}


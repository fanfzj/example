using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Admin_ChangeAdminInfo : System.Web.UI.Page
{
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["admin"] == null)
        //{
        //    Response.Redirect("../Login.aspx");
        //}
        if (!IsPostBack)
        {
            id =Request.QueryString["admid"].ToString();
            SqlConnection conn = BaseClass.DBCon();  
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_Admin where ID=" + id, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtAdminName.Text = sdr["AdminName"].ToString();
                txtAdminID.Text = sdr["AdminID"].ToString();
                txtAdminPwd.Text = sdr["AdminPwd"].ToString();
                if ((sdr["AdminRight"].ToString().Trim()) == "0")
                    rblRight.SelectedIndex = 0;
                else
                    rblRight.SelectedIndex = 1;

            }
            conn.Close();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (txtAdminName.Text.Trim() == "" || txtAdminPwd.Text.Trim() == "")
        {
            lblMessage.Text = "请将姓名和密码的内容填写完整。";
            return;
        }
        else
        {
            //调试备忘，一定要重新获取id值，不知为何?
            id = Request.QueryString["admid"].ToString();
            string str = "update tb_Admin set AdminName='" + txtAdminName.Text.Trim() + "',AdminPwd='" + txtAdminPwd.Text.Trim() + "',AdminRight='" + rblRight.SelectedValue + "' where ID='" + id + "'";
            BaseClass.OperateData(str);
            Response.Redirect("AdminInfo.aspx");
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminInfo.aspx");
    }
}

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

public partial class Admin_AddAdminInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["admin"] == null)
        //{
        //    Response.Redirect("../Login.aspx");
        //}
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string str = "insert into tb_Admin (AdminID,AdminName,AdminPwd,AdminRight)  values('"+ txtAdminID.Text.Trim() + "','"+ txtAdminName.Text.Trim() + "','" + txtAdminPwd.Text.Trim() + "','" + rblRight.SelectedValue + "' )";
        BaseClass.OperateData(str);
        Clear();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Clear();
    }
    protected void Clear()
    { 
        txtAdminID.Text= "";
        txtAdminName.Text="";
        txtAdminPwd.Text="";
        rblRight.SelectedIndex = -1;
    }
}

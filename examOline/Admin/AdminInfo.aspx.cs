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

public partial class Admin_AdminInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string strsql = "select * from tb_Admin order by ID desc";
            BaseClass.BindDG(gvAdmInfo, "ID", strsql, "admInfo");
        }

    }
    protected void btnserch_Click(object sender, EventArgs e)
    {

        if (txtKey.Text == "")
        {
            string strsql = "select * from tb_Admin order by ID desc";
            BaseClass.BindDG(gvAdmInfo, "ID", strsql, "admInfo");
        }
        else
        {
            string stype = ddlType.SelectedItem.Text;
            string strsql = "";
            switch (stype)
            {
                case "管理员编号":
                    strsql = "select * from tb_Admin where AdminID like '%" + txtKey.Text.Trim() + "%'";
                    BaseClass.BindDG(gvAdmInfo, "ID", strsql, "admInfo"); ;
                    break;
                case "姓名":
                    strsql = "select * from tb_Admin where AdminName like '%" + txtKey.Text.Trim() + "%'";
                    BaseClass.BindDG(gvAdmInfo, "ID", strsql, "admInfo");
                    break;
            }
        }
    }

    protected void gvAdmInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = (int)gvAdmInfo.DataKeys[e.RowIndex].Value;
        string str = "delete from tb_Admin where ID=" + id;
        BaseClass.OperateData(str);
        string strsql = "select * from tb_Admin order by ID desc";
        BaseClass.BindDG(gvAdmInfo, "ID", strsql, "adminfo");
    }
    protected void gvAdmInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvAdmInfo.PageIndex = e.NewPageIndex;
        string strsql = "select * from tb_Admin order by ID desc";
        BaseClass.BindDG(gvAdmInfo, "ID", strsql, "adminfo");
    }
}

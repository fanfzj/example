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


//5-1-a-s-p-x
public partial class Admin_stuInfoView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string strsql = "select * from tb_Student order by ID desc";
            BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuInfo");
        }
    }
    protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.ToString() == "学生状态")
            DropDownList1.Visible = true;
        else DropDownList1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentAdd.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //string StudentID = getFirstSelected();
        //if (!(StudentID == "none"))
        //{
        //    Session["StudentID"] = StudentID;
        //    Response.Redirect("studentUpdate.aspx");
        //}
        //else Response.Write("<script>alert(\"请选择一个学生！\");</script>");//没有选择记录
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //foreach (DataGridItem item in gvStuInfo)
        //{
        //    CheckBox cbx = (CheckBox)item.FindControl("cbx_select");
        //    cbx.Checked = true;
        //}
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        //foreach (DataGridItem item in gvStuInfo)
        //{
        //    CheckBox cbx = (CheckBox)item.FindControl("cbx_select");
        //    cbx.Checked = false;
        //}
    }

    //5~1a~s~p~x
    protected void Button6_Click(object sender, EventArgs e)
    {
        if (tbx_query.Text == "")
        {
            string strsql = "select * from tb_Student order by ID desc";
            BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
        }
        else
        {
            string stype = DropDownList1.SelectedItem.Text;
            string strsql = "";
            switch (stype)
            {
                case "学号":
                    strsql = "select * from tb_Student where StudentID like '%" + tbx_query.Text.Trim() + "%'";
                    BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo"); ;
                    break;
                case "学生姓名":
                    strsql = "select * from tb_Student where StudentName like '%" + tbx_query.Text.Trim() + "%'";
                    BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
                    break;
                case "系别":
                        strsql = "select * from tb_Student where Descriptione like '%" + tbx_query.Text.Trim() + "%'";
                    BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
                    break;
                    
            }
        }
    }
    protected void gvStuInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
      
        int id = (int)gvStuInfo.DataKeys[e.RowIndex].Value;
        string str = "delete from tb_Student where ID=" + id;
        BaseClass.OperateData(str);
        string strsql = "select * from tb_Student order by ID desc";
        BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
    }
    protected void gvStuInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvStuInfo.PageIndex = e.NewPageIndex;
        string strsql = "select * from tb_Student order by ID desc";
        BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //int id = (int)gvStuInfo.DataKeys[e.RowIndex].Value;
        //string str = "delete from tb_Student where ID=" + id;
        //BaseClass.OperateData(str);
        //string strsql = "select * from tb_Student order by ID desc";
        //BaseClass.BindDG(gvStuInfo, "ID", strsql, "stuinfo");
    }
}

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminInfo.aspx.cs" Inherits="Admin_AdminInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        <fieldset style="width: 518px; height: 500px">
        <legend class="mailTitle">管理员基本信息</legend>
        <br />
        <asp:Label ID="Label2" runat="server" Text="关键字：" Height="24px"></asp:Label>
            <asp:TextBox ID="txtKey" runat="server" Height="19px" Font-Size="12pt"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="查询条件：" Height="23px"></asp:Label>
            &nbsp;<asp:DropDownList ID="ddlType"
            runat="server" Width="108px" Font-Size="12pt">
            <asp:ListItem Selected="True">管理员编号</asp:ListItem>
            <asp:ListItem>姓名</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnserch" runat="server" OnClick="btnserch_Click"
            Text="查看" Height="27px" Width="46px" /><br />
        <asp:GridView ID="gvAdmInfo" runat="server" AutoGenerateColumns="False" BackColor="White"
            BorderColor="DeepSkyBlue" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="537px" OnRowDeleting="gvAdmInfo_RowDeleting" AllowPaging="True" OnPageIndexChanging="gvAdmInfo_PageIndexChanging" PageSize="8">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <Columns>
                <asp:BoundField DataField="AdminID" HeaderText="管理员编号" />
                <asp:BoundField DataField="AdminName" HeaderText="姓名" />
                <asp:BoundField DataField="AdminPwd" HeaderText="密码" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="ChangeAdminInfo.aspx?admid={0}"
                    HeaderText="修改" Text="修改信息" />
            </Columns>
            <RowStyle ForeColor="#000066" Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
            <HeaderStyle BackColor="Transparent" Font-Bold="False" ForeColor="Black" Height="15px" />
        </asp:GridView>
        <br />            <br />

        <br />
            &nbsp;</fieldset>
    
    </div>
    </form>
</body>
</html>

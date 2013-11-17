<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stuInfoView.aspx.cs" Inherits="Admin_stuInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div><h1 style="text-align: center">学生信息管理</h1>
        <table align="center" border="1"  width="800">
            <tr>
                <td>
                    </td>
                <td>
                    <%--<asp:Button ID="Button2" runat="server" Text="修改" OnClick="Button2_Click" />--%>
                    </td>
                <td>
                    <%--<asp:Button ID="Button3" runat="server" Text="删除" OnClick="Button3_Click" />--%>
                    </td>
            </tr>
            <tr>
                <td colspan="4" style="height: 20px">
                   <%-- <div style="display: inline; width: 296px; color: #006666; height: 16px">
                        <font color="#666699" face="宋体" size="2">--%><%--选中修改时,如果选中多行,则只对第一个进行修改</font></div>--%>
                </td>
            </tr>
            <tr>
                <td colspan="5" style="height: 26px">
                    <asp:Button ID="Button1" runat="server" Text="新增" OnClick="Button1_Click" /><%--<font face="宋体">&nbsp;<asp:Button ID="Button4" runat="server" Text="全选" OnClick="Button4_Click" />&nbsp;
                        <asp:Button ID="Button5" runat="server" Text="全清" OnClick="Button5_Click" /></font><--%></td></tr>
            <tr>
                <td colspan="5" style="height: 14px; text-align: center;">
                    <font face="宋体">
                        <asp:Label ID="Label2" runat="server" Height="24px" Text="关键字："></asp:Label>
                        <asp:TextBox ID="tbx_query" runat="server"></asp:TextBox>查询条件:&nbsp;<asp:DropDownList ID="DropDownList1"
                            runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem Selected="True" Value="stuId">学号</asp:ListItem>
                            <asp:ListItem Value="stuName">学生姓名</asp:ListItem>
                            <asp:ListItem Value="stuStatus">系别</asp:ListItem>
                        </asp:DropDownList>
                       <%--<asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"
                            Visible="False">
                            <asp:ListItem Value="0">没有考试</asp:ListItem>
                            <asp:ListItem Value="1">考试中</asp:ListItem>
                        </asp:DropDownList>--%>
                        <asp:Button ID="Button6" runat="server" Text="查看" OnClick="Button6_Click" /></font></td>
            </tr>
            <tr>
                <td align="center" colspan="5" height="300">
                    <font face="宋体">
                        <asp:GridView ID="gvStuInfo" runat="server" AutoGenerateColumns="False" BackColor="White"
            BorderColor="DeepSkyBlue" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="537px" OnRowDeleting="gvStuInfo_RowDeleting" AllowPaging="True" OnPageIndexChanging="gvStuInfo_PageIndexChanging" PageSize="8">
                            <Columns>
                            
										
                                <asp:BoundField DataField="StudentID" HeaderText="学号" />
                                <asp:BoundField DataField="StudentName" HeaderText="学生姓名" />
                                <asp:BoundField DataField="StudentPwd" HeaderText="密码" />
                                <asp:BoundField DataField="Sex" HeaderText="性别" />
                                <asp:BoundField DataField="Description" HeaderText="系别" />
                                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                                <asp:HyperLinkField DataNavigateUrlFields="ID"　DataNavigateUrlFormatString="studentUpdate.aspx?stuid={0}" HeaderText="修改" Text="修改信息" />
                            </Columns>
                        </asp:GridView>
                        &nbsp; &nbsp;
                        &nbsp;</font><asp:Label ID="lbl_noResult" runat="server" ForeColor="Red" Visible="False">没有满足要求的记录</asp:Label></td>
            </tr>
            <tr>
                <td bgcolor="#ffccff" colspan="5">
                    <%--<font face="宋体">共有
                        <asp:Label ID="lbl_count" runat="server" ForeColor="Red">0</asp:Label>条记录</font>--%>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

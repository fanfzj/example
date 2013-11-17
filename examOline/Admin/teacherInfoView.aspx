<%@ Page Language="C#" AutoEventWireup="true" CodeFile="teacherInfoView.aspx.cs" Inherits="Admin_teacherInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div><h1 style="text-align: center">老师信息管理</h1>
       
            <table align="center" border="1">
                <tr>
                    <td style="width: 598px">
                        <br />
                        <asp:Label ID="Label2" runat="server" Height="24px" Text="关键字："></asp:Label><asp:TextBox ID="txtKey" runat="server" Font-Size="12pt" Height="19px"></asp:TextBox>
                        <asp:Label ID="Label1" runat="server" Height="23px" Text="查询条件："></asp:Label><asp:DropDownList ID="ddlType" runat="server" Font-Size="12pt" Width="108px">
                            <asp:ListItem Selected="True">教师编号</asp:ListItem>
                            <asp:ListItem>教师姓名</asp:ListItem>
                            <asp:ListItem>教师角色</asp:ListItem>
                            <asp:ListItem>性别</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="btnserch" runat="server" Height="27px" OnClick="btnserch_Click" Text="查看"
                            Width="46px" /></td>
                </tr>
                <tr>
                    <td style="width: 598px">
                        <font face="宋体">以下是所有教师的信息</font></td>
                </tr>
                <tr>
                    <td align="center" style="width: 598px">
                        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" Height="211px" Width="603px">
                            <Columns>
                                <asp:BoundField DataField="TeacherID" HeaderText="教师编号" />
                                <asp:BoundField DataField="TeacherName" HeaderText="教师姓名" />
                                <asp:BoundField DataField="Sex" HeaderText="性别" />
                                <asp:BoundField DataField="TeacherPwd" HeaderText="密码" />
                                <asp:BoundField DataField="TeacherRoler" HeaderText="教师角色" />
                                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="teacherUpdate.aspx?TeacherID={0}"
                                    HeaderText="修改" Text="信息" />
                            </Columns>
                        </asp:GridView>
                        &nbsp; &nbsp;<asp:Label ID="lbl_noResult" runat="server" ForeColor="Red" Visible="False">没有任何记录</asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 598px">
                        <font face="宋体">共有
                            <asp:Label ID="lbl_count" runat="server" ForeColor="Red">0</asp:Label>条记录</font></td>
                </tr>
                <tr bgcolor="#ccffcc">
                    <td align="center" style="width: 598px">
                      <%--  <h1 align="center">
                            添加教师</h1>
                        <table align="center" border="0" bordercolor="#0066cc" width="400">
                            <tr>
                                <td>
                                    <font face="宋体">
                                        教师ID:&nbsp;</font></td>
                                <td align="left">
                                    <asp:TextBox ID="tbx_teacherId" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <font face="宋体">
                                        教师姓名:</font></td>
                                <td align="left">
                                    <asp:TextBox ID="tbx_teacherName" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <font face="宋体">
                                        密码:</font></td>
                                <td align="left">
                                    <asp:TextBox ID="tbx_teacherPwd" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>--%>
                        <%--<asp:Button ID="Button1" runat="server" Text="确定" />--%></td>
                </tr>
            </table>
        
    
    </div>
    </form>
   
</body>
</html>

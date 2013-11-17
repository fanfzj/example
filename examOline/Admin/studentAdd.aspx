<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentAdd.aspx.cs" Inherits="Admin_studentAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" bgcolor="#cccccc" border="1" width="200">
            <tr>
                <td colspan="3">
                    <div style="display: inline; width: 112px; height: 16px">
                        添加学生记录</div>
                </td>
            </tr>
            <tr>
                <td style="width: 170px">
                    <div style="display: inline; width: 70px; height: 15px">
                        学号:</div>
                </td>
                <td>
                    <asp:TextBox ID="txtStuID" runat="server"></asp:TextBox></td>
                <td style="width: 98px">
                    <font face="宋体"></font>
                </td>
            </tr>
            <tr style="font-family: Times New Roman">
                <td style="width: 170px">
                    <div style="display: inline; width: 70px; height: 15px">
                        姓名:</div>
                </td>
                <td>
                    <asp:TextBox ID="txtStuName" runat="server"></asp:TextBox></td>
                <td style="width: 98px">
                </td>
            </tr>
            <tr style="font-family: Times New Roman">
                <td style="height: 28px; width: 170px;">
                    <div style="display: inline; width: 70px; height: 15px">
                       密码:</div>
                </td>
                <td style="height: 28px">
                <asp:TextBox ID="txtPassWord" runat="server">123</asp:TextBox>
                    
                    </td>
                <td style="height: 28px; width: 98px;">
                    <font face="宋体"></font>
                </td>
            </tr>
            <tr>
                <td style="width: 170px">
                    系别:</td>
                <td>
                    <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True">
                    </asp:DropDownList></td>
               
                <td style="width: 98px">
                </td>
            </tr>
            
            <tr>
            <td style="width: 170px; height: 16px;">
            <div style="display: inline; width: 70px; height: 15px">
                性别:</div>
            
            </td>
            <td style="height: 16px">
             <asp:RadioButtonList ID="rblSex" runat="server"
                        Height="12px" RepeatColumns="2" Width="142px">
                        <asp:ListItem Value="0">男</asp:ListItem>
                        <asp:ListItem Value="1">女</asp:ListItem>
                    </asp:RadioButtonList></td>
            
            <td style="width: 98px; height: 16px;">
            </td>
            </tr>
            
            <tr>
                <td style="width: 170px">
                    <asp:Button ID="Button2" runat="server" Text="保存" OnClick="Button2_Click" /></td>
                <td align="center">
                    <asp:Button ID="Button3" runat="server" Text="重置" OnClick="Button3_Click" /></td>
                <td style="width: 98px">
                    <font face="宋体">
                        <asp:Button ID="Button1" runat="server" Text="取消" OnClick="Button1_Click" /></font></td>
            </tr>
            <tr>
                <td colspan="3">
                    <%--<font face="宋体">--%>
                        <%--<asp:CheckBox ID="CheckBox2" runat="server" Checked="True" Text="连续添加" /></font></td>--%>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

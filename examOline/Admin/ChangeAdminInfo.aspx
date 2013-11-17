<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeAdminInfo.aspx.cs" Inherits="Admin_ChangeAdminInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    <fieldset style="WIDTH: 483px; HEIGHT: 448px">
    <legend class="mailTitle">修改管理员信息</legend>
        <br />
        <table border="0" cellpadding="0" cellspacing="0" style=" text-align:center; width: 441px; height: 357px;">
            <tr>
                <td style="text-align: center; width:120px">
                    &nbsp;管理员编号：</td>
                <td style="text-align: left; width: 281px;">
                <asp:TextBox ID="txtAdminID" runat="server" ReadOnly="True"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center">
                    &nbsp;管理员姓名：</td>
                <td style="text-align: left; width: 281px;">
                <asp:TextBox ID="txtAdminName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center">
                    &nbsp;管理员密码：</td>
                <td style="text-align: left; width: 281px;">
                    <asp:TextBox ID="txtAdminPwd" runat="server" MaxLength="12"></asp:TextBox></td>
            </tr> 
            <tr>
                <td style="text-align: center">
                    &nbsp;管理员权限：</td>
                <td style="text-align: left; width: 281px;">
                  <asp:RadioButtonList ID="rblRight" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                     <asp:ListItem Value="0">超级管理员</asp:ListItem>
                     <asp:ListItem Value="1">一般管理员</asp:ListItem>
                  </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center; height: 55px;">
                    &nbsp;
                <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="保存" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="取消" />
                    </td>
            </tr>
            <tr>
                <td style="text-align: center">
                    </td>
                <td style="text-align: left; width: 281px;">
                    <asp:Label ID="lblMessage" runat="server" style="color: red; font-family: 宋体"></asp:Label></td>
            </tr>
        </table>
    </fieldset>   
    </div>
    </form>
</body>
</html>

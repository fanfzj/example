<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddAdminInfo.aspx.cs" Inherits="Admin_AddAdminInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
    <fieldset style="WIDTH: 483px; HEIGHT: 448px">
    <legend class="mailTitle">新增管理员信息</legend>
        <br />
        <table align="center" border="0" cellpadding="0" cellspacing="0" style=" width: 441px; height: 240px;">
            <tr>
                <td style="text-align: center; width:120px; height: 43px;">
                    &nbsp;管理员编号：</td>
                <td style="text-align: left; width: 216px; height: 43px;">
                <asp:TextBox ID="txtAdminID" runat="server" Font-Size="12pt" Width="192px" ></asp:TextBox></td>
                <td style="width: 93px; height: 43px">
                    <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="txtAdminID"
                        ErrorMessage="编号不能为空">*</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="text-align: center; height: 38px;">
                    &nbsp;管理员姓名：</td>
                <td style="text-align: left; width: 216px; height: 38px;">
                <asp:TextBox ID="txtAdminName" runat="server" Font-Size="12pt" Width="190px"></asp:TextBox></td>
                <td style="width: 93px; height: 38px">
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtAdminName"
                        ErrorMessage="姓名不能为空">*</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="text-align: center; height: 38px;">
                    &nbsp;管理员密码：</td>
                <td style="text-align: left; width: 216px; height: 38px;">
                    <asp:TextBox ID="txtAdminPwd" runat="server" MaxLength="12" Font-Size="12pt" Width="189px"></asp:TextBox></td>
                <td style="width: 93px; height: 38px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdminPwd"
                        ErrorMessage="密码不能为空">*</asp:RequiredFieldValidator></td>
            </tr> 
            <tr>
                <td style="text-align: center; height: 33px;">
                    &nbsp;管理员权限：</td>
                <td style="text-align: left; width: 216px; height: 33px;">
                  <asp:RadioButtonList ID="rblRight" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" Font-Size="12pt">
                     <asp:ListItem Value="0">超级管理员</asp:ListItem>
                     <asp:ListItem Value="1">一般管理员</asp:ListItem>
                  </asp:RadioButtonList></td>
                <td style="width: 93px; height: 33px"></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center; height: 43px;">
                    &nbsp;
                <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="保存" Font-Size="12pt" Width="68px" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="取消" Font-Size="12pt" Width="65px" />
                    </td>
                <td style="width: 93px; height: 43px"></td>
            </tr>
            <tr>
                <td style="text-align: center; height: 85px;" colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                        ShowSummary="False" />
                    </td>
            </tr>
        </table>
    </fieldset>   
    </div>
    </form>
</body>
</html>

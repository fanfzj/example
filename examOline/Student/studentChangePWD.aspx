<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentChangePWD.aspx.cs" Inherits="Student_studentChangePWD" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <br />
        &nbsp;<fieldset style="width: 344px; height: 250px; text-align: left">
            <legend class="mailTitle">学生修改密码</legend>
            <br />
            &nbsp;<br />
            <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 370px;
                height: 145px">
                <tr>
                    <td style="width: 521px; height: 32px; text-align: right">
                        &nbsp;输入旧密码：</td>
                    <td style="width: 151px; height: 32px">
                        <asp:TextBox ID="txtOldPwd" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 100px; height: 32px; text-align: right">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOldPwd"
                            ErrorMessage="旧密码不能为空">*</asp:RequiredFieldValidator></td>
                </tr>
                <tr style="color: #000000">
                    <td style="width: 521px; height: 35px; text-align: right">
                        &nbsp;输入新密码：</td>
                    <td style="width: 151px; height: 35px">
                        <asp:TextBox ID="txtNewPwd" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 100px; height: 35px; text-align: right">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewPwd"
                            ErrorMessage="新密码不能为空">*</asp:RequiredFieldValidator></td>
                </tr>
                <tr style="color: #000000">
                    <td style="width: 521px; height: 31px; text-align: right">
                        再次输入新密码：</td>
                    <td style="width: 151px; height: 31px">
                        <asp:TextBox ID="txtNewPwdA" runat="server"></asp:TextBox>
                    </td>
                    <td style="width: 100px; height: 31px; text-align: right">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNewPwdA"
                            ErrorMessage="再次新密码不能为空">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewPwd"
                            ControlToValidate="txtNewPwdA" ErrorMessage="两次新密码不相同">*</asp:CompareValidator></td>
                </tr>
                <tr>
                    <td colspan="3" style="height: 56px; text-align: center">
                        &nbsp;
                        <asp:Button ID="btnChange" runat="server" Height="30px" OnClick="btnChange_Click"
                            Text="确定修改" Width="110px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="height: 40px; text-align: center">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="42px" ShowMessageBox="True"
                            ShowSummary="False" Width="326px" />
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Blue"></asp:Label>
                        &nbsp;
                    </td>
                </tr>
            </table>
        </fieldset>
    
    </div>
    </form>
</body>
</html>

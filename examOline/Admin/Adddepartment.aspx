<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Adddepartment.aspx.cs" Inherits="Admin_Adddepartment" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        <table style="width: 427px; height: 81px">
            <tr>
                <td colspan="2">
                    添加系别</td>
                <td style="width: 184px">
                </td>
            </tr>
            <tr>
                <td style="width: 87px; height: 35px">
                    系编号:</td>
                <td style="width: 230px; height: 35px">
                    <asp:TextBox ID="txtddtID" runat="server"></asp:TextBox></td>
                <td style="width: 184px; height: 35px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtddtID"
                        ErrorMessage="系编号不能为空！"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 87px; height: 32px">
                    系名:</td>
                <td style="width: 230px; height: 32px">
                    &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td style="width: 184px; height: 32px">
                </td>
            </tr>
            <tr>
                <td style="width: 87px; height: 27px">
                    教师名：</td>
                <td style="width: 230px; height: 27px">
                    <asp:DropDownList ID="ddl" runat="server" AutoPostBack="True" Width="152px">
                    </asp:DropDownList></td>
                <td style="width: 184px; height: 27px">
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 54px">
                    描述:
                    <asp:TextBox ID="txtDtn" runat="server" Height="35px" Width="186px"></asp:TextBox></td>
                <td style="width: 184px; height: 54px">
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 54px">
                    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确定" />&nbsp; &nbsp;<asp:Button
                        ID="btnEsc" runat="server" OnClick="btnEsc_Click" Text="重置" /></td>
                <td style="width: 184px; height: 54px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

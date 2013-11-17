<%@ Page Language="C#" AutoEventWireup="true" CodeFile="teacherAdd.aspx.cs" Inherits="Admin_teacherAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 531px; height: 343px" border="1">
            <tr>
                <td style="width: 153px; text-align: right">
                    教师ID：</td>
                <td style="width: 239px">
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 153px; text-align: right">
                    教师名字：</td>
                <td style="width: 239px">
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 153px; text-align: right">
                    密码：</td>
                <td style="width: 239px">
                    <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 153px; text-align: right">
                    性别：</td>
                <td style="width: 239px">
                    <asp:RadioButtonList ID="rblsex" runat="server" AutoPostBack="True" RepeatColumns="2">
                        <asp:ListItem Value="0">男</asp:ListItem>
                        <asp:ListItem Value="1">女</asp:ListItem>
                    </asp:RadioButtonList></td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 153px; text-align: right;">
                    <span style="font-size: 10.5pt; font-family: 宋体; mso-bidi-font-size: 12.0pt; mso-ascii-font-family: 'Times New Roman';
                        mso-hansi-font-family: 'Times New Roman'; mso-bidi-font-family: 'Times New Roman';
                        mso-font-kerning: 1.0pt; mso-ansi-language: EN-US; mso-fareast-language: ZH-CN;
                        mso-bidi-language: AR-SA">教师角色:</span></td>
                <td style="width: 239px">
                    <asp:RadioButtonList ID="rblroler" runat="server" AutoPostBack="True" RepeatColumns="2">
                        <asp:ListItem Value="0">主讲</asp:ListItem>
                        <asp:ListItem Value="1">副讲</asp:ListItem>
                    </asp:RadioButtonList></td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Button ID="btnok" runat="server" Text="确定" OnClick="btnok_Click" />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Button ID="btncen" runat="server" Text="取消" OnClick="btncen_Click" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

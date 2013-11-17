<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>在线考试系统</title>
    <link href="xStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
<table width="980" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td align="center" style="width: 963px; height: 513px;">
        &nbsp;<table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td style="height: 16px"><img src="images/5.jpg" width="980" height="200" /></td>
      </tr>
    </table>
      <table width="100%" border="1" cellspacing="0" cellpadding="0"  bordercolorlight="#FFFFFF">
        <tr>
          <td><table width="80%"  border="1" align="center" cellpadding="0" cellspacing="0" bordercolordark="#000000" bordercolorlight="#FFFFFF" style="height: 202px">
            <tr>
              <td rowspan="4" style="width: 100px" >&nbsp;</td>
              <td width="200" ><div align="center">
                  <asp:Label ID="lblAccount" runat="server"  Text="账号(ID)：" ></asp:Label>
                &nbsp;</div></td>
              <td align="left" style="width: 277px" ><asp:TextBox ID="txtNum" runat="server"  Height="25" Width="176px"></asp:TextBox>              </td>
              <td width="122" align="center" >
              <asp:RadioButtonList ID="rblUserID" runat="server" RepeatDirection="Horizontal"  AutoPostBack="True"  OnSelectedIndexChanged="rblUserID_SelectedIndexChanged">
                  <asp:ListItem Selected="True">ID</asp:ListItem>
                  <asp:ListItem>名</asp:ListItem>
              </asp:RadioButtonList>
              </td>
              <td width="109" align="center" ><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNum"
                        Display="Dynamic" ErrorMessage="请输入账号" ForeColor="DarkGray" Font-Size="10pt">*</asp:RequiredFieldValidator>
                &nbsp;</td>
            </tr>
            <tr>
              <td height="50" ><div align="center"> 密 码：</div></td>
              <td colspan="2" align="left" ><asp:TextBox ID="txtPwd" runat="server" MaxLength="12" TextMode="Password"  Height="25" Width="176px"></asp:TextBox>
                &nbsp;</td>
              <td align="center" ><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd"
                        Display="Dynamic" ErrorMessage="密码不能为空" ForeColor="DimGray" Font-Size="10pt">*</asp:RequiredFieldValidator>
                &nbsp;</td>
            </tr>
            <tr>
              <td height="50" ><div align="center"> 身 份：</div></td>
              <td colspan="2" align="left" ><asp:DropDownList ID="ddlstatus" runat="server"  Font-Size="Larger" Height="25" Width="121px">
                  <asp:ListItem Selected="True">学生</asp:ListItem>
                  <asp:ListItem>教师</asp:ListItem>
                  <asp:ListItem>管理员</asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
              <td align="center" style="width: 62px; height: 30px;">&nbsp;</td>
            </tr>
            <tr>
              <td style="height: 20px" ><div align="center"> 验证码：</div></td>
              <td align="left" style="width: 277px; height: 20px;" ><asp:TextBox ID="txtCode" runat="server" Height="25px" Width="112px"></asp:TextBox></td>
              <td align="center" style="height: 20px" ><asp:Image ID="Image1" runat="server" Width="100px" BorderColor="Gray" BorderWidth="1px" Height="32px" ImageUrl="~/Image.aspx" /></td>
              <td align="center" style="height: 20px" ><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCode"
                        Display="Dynamic" ErrorMessage="请输入验证码" ForeColor="DimGray" Font-Size="10pt">*</asp:RequiredFieldValidator>
                &nbsp;</td>
            </tr>
            <tr>
              <td height="50" colspan="5"  align="center">&nbsp;
                  <asp:Button ID="btnlogin" runat="server" Text="登录" OnClick="btnlogin_Click" />            
                &nbsp;&nbsp; &nbsp;
                <asp:Button ID="btnconcel" runat="server" Text="取消" OnClick="btnconcel_Click" CausesValidation="False" /></td>
            </tr>
            <tr>
              <td colspan="5" >&nbsp;
                  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            </tr>
          </table></td>
        </tr>
      </table>
      </td>
  </tr>
</table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
            ShowSummary="False" />
    </form>
</body>
</html>

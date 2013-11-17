<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin_Admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>教师后台管理</title>
<style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
-->
</style></head>

<body>
<table width="1010"  border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td><img src="../images/9.jpg"  alt="图片位置"  width="1010" height="200"/></td>
      </tr>
    </table>
      <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td width="230" style="height: 736px">
          <table>
             <tr>
          <td><iframe src="left.htm" style="width: 230px; height: 682px" frameborder="0" scrolling="no"></iframe></td></tr></table></td>
          <td style="width: 818px; height: 736px;">
              <span style="color: #ff0033">
                管理员ID:</span><asp:Label id="lbl_adminId" runat="server">未登录</asp:Label><span
                  style="color: #ff0033"> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;管理员姓名:</span><asp:Label id="Label1" runat="server">未登录</asp:Label><span style="color: #ff0033"> &nbsp; &nbsp;&nbsp;
                          &nbsp;&nbsp;
                权限:</span><asp:Label id="Label2" runat="server">管理员</asp:Label><span
                              style="color: #ff0033">
             <iframe name="menu" frameborder="0" scrolling="auto" style="width: 780px; height:682px" src="AdminChangePWD.aspx" id="IFRAME1"></iframe>
                          </span>
          </td>
        </tr>
      </table></td>
  </tr>
</table>
</body>
</html>
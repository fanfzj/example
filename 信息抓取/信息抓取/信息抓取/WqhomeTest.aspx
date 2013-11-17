<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WqhomeTest.aspx.cs" Inherits="信息抓取.WqhomeTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>信息抓取</title>
    <link href="skins/aero.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.artDialog.js" type="text/javascript"></script>

    <script type="text/javascript">
        function zhuaqu() {
            $.ajax({
                type: "POST",
                url: "WqhomeTest.aspx/insertinfo",
                data: "{'url':'" + $("#txturl").val() + "','strbtstart':'" + $("#txtbtstart").val() + "','strbtend':'" + $("#txtbtend").val() + "','strsjstart':'" + $("#txtsjstart").val() + "','strsjend':'" + $("#txtsjend").val() + "','strnrstart':'" + $("#txtnrstart").val() + "','strnrend':'" + $("#txtnrend").val() + "'}",
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                beforeSend: function () {
                    //art.dialog.tips('数据采集中。。。');
                    $("#btngo").text("数据采集中。。。");
                },
                success: function (msg) {
                    $("#btngo").text("开始抓取");
                    if (msg.d == true) {
                        art.dialog.tips('采集成功', 1);
                    } else {
                        art.dialog.tips('采集失败', 1);
                    }
                }
            })
            return false;
        }

        function selcontent(id) {
            $.ajax({
                type: "POST",
                url: "WqhomeTest.aspx/getcontent",
                data: "{'id':" + id + "}",
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                beforeSend: function () {
                    art.dialog({
                        icon: 'loading',
                        title: '正在加载'
                    })
                },
                success: function (msg) {
                    var list = art.dialog.list;
                    for (var i in list) {
                        list[i].close();
                    };
    
                    art.dialog({
                        title: id + '的详细信息',
                        lock: true,
                        content: msg.d
                    })
                }
            })
        }
    </script>
    <style type="text/css">
        body{ font-family:@微软雅黑; font-size:75%;}
    </style>
</head>

<body>
    <form id="form1" runat="server">
    <div style=" width:90%; margin:20px auto; border:1px solid #e5edf2;" id="OneInfo">
        <div style="width:95%; margin:15px; padding:10px; border-bottom:1px dashed #E6E7E1"><h2>抓取单页信息</h2></div>
        <div style="width:95%; margin:15px; padding:10px;border-bottom:1px dashed #E6E7E1">
        <p>链接地址：<input type="text" id="txturl" style="width:350px;" /></p>
        <p>匹配标题：起始：<input type="text" id="txtbtstart" style="width:120px;" />&nbsp;&nbsp;结束：<input type="text" id="txtbtend" style="width:120px;" /></p>
        <p>匹配时间：起始：<input type="text" id="txtsjstart" style="width:120px;" />&nbsp;&nbsp;结束：<input type="text" id="txtsjend" style="width:120px;" /></p>
        <p>匹配正文：起始：<input type="text" id="txtnrstart" style="width:120px;" />&nbsp;&nbsp;结束：<input type="text" id="txtnrend" style="width:120px;" /></p>
        <p>页面编码格式：&nbsp;&nbsp;<input type="text" id="txtchar" /> <button id="btngo" onclick="return zhuaqu()">开始抓取</button></p>
        </div>
        <div>
         <%=bind()%>
        </div>
    </div>
    </form>
</body>
</html>

<?php
$conn=mysql_connect("localhost:3306","root","root");//建立与SQL Server数据库的连接
mysql_query("set names 'gb2312'"); 
mysql_select_db("db_online",$conn);   //选择数据库
//error_reporting(0); 
?>

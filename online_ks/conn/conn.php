<?php
$conn=mysql_connect("localhost:3306","root","root");//������SQL Server���ݿ������
mysql_query("set names 'gb2312'"); 
mysql_select_db("db_online",$conn);   //ѡ�����ݿ�
//error_reporting(0); 
?>

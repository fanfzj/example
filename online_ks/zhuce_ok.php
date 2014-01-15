<?php 
/*//创建一个XML格式输出
header('Content-Type: text/xml');
//创建XML头
echo '<?xml version="1.0" encoding=gb2312" standalone="yes" ?>';
//创建<response>元素
echo '<response>';*/
//获取用户姓名
$online_user=trim($_POST['username']);
$online_tel=trim($_POST['tel']);
$online_address=trim($_POST['address']);
$online_number=substr(mt_rand(100000,999999),0,11);
$online_pass=substr(mt_rand(100000,999999),0,6);
echo $online_address ."<br>".$online_number ."<br>".$online_pass ."<br>" . $online_tel ."<br>". $online_user;
//根据从客户端获取的用户创建输出
include("conn/conn.php");
$query=mysql_query("insert into tb_user(user,tel,address,number,pass) values('$online_user','$online_tel','$online_address','$online_number','$online_pass')");
if($query==true){
echo $online_user;
	echo "用户注册成功，这是您的准考证号码".$online_number."和密码".$online_pass;
	echo "<script> alert('进入考试!');window.location.href='index.php?online=进入考场'; </script>";
}
 else echo  "<script> alert('请您重新输入!'); window.location.href='index.php?online=用户注册';</script>";
?>

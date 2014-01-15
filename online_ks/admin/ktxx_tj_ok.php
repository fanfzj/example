<?php session_start();
if($_SESSION['admin_user']==true){
include("../conn/conn.php");

$sql=mysql_fetch_array(mysql_query("select kt_id from tb_kt where kt_small_lb='$kt_small_lb' and kt_lb='$kt_lb' and kt_lx='$kt_lx' order by kt_id desc"));
$kt=explode($kt_lx,$sql[0]);
$ktid=$kt[0];
$ktlx=$ktid ."".$kt_lx;
$ktid2=explode( $ktlx,$sql[0]);
$ktid3=$ktid2[1]+1;
$kt_id=$ktid."".$kt_lx."".$ktid3;
if($Submit2=="提交考题"){
	$queryes=mysql_query("insert into tb_kt (kt_lb,kt_lx,kt_fs,kt_nr,kt_daan,kt_zqdaan,kt_small_lb,kt_id)values('$kt_lb','$kt_lx','$kt_fs','$kt_nr','$kt_daan','$kt_zqdaan','$kt_small_lb','$kt_id')");
	if($queryes){
			echo "<script>alert('考题添加成功');window.location.href='index.php?htgl=考题信息添加';</script>";
		}
   echo "<script>alert('考题添加失败');;history.back();</script>";
}
else echo "按键未响应";
?>

<?php 
}else{
echo "<script>alert('请重新登录!'); window.location.href='checkadmin.php';</script>";
}

?>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
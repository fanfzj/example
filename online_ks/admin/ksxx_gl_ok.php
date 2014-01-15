<?php session_start();
if($_SESSION['admin_user']==true){
include("../conn/conn.php");
if($delete_ksxx==true){
$query=mysql_query("delete from tb_user where id='".$delete_ksxx."'");
if($query){
echo "<script>alert('????????!'); window.location.href='index.php?htgl=??????';</script>";

}
}
?>

<?php 
}else{
echo "<script>alert('?????'); window.location.href='checkadmin.php';</script>";
}

?>
<meta http-equiv="Content-Type" content="text/html; charset=utf8">

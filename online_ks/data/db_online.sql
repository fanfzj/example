# Host: localhost  (Version: 5.5.34)
# Date: 2014-01-12 22:51:56
# Generator: MySQL-Front 5.3  (Build 4.43)

/*!40101 SET NAMES utf8 */;

#
# Structure for table "tb_admin"
#

CREATE TABLE `tb_admin` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL DEFAULT '' COMMENT '用户名',
  `pwd` varchar(50) NOT NULL DEFAULT '' COMMENT '密码',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=gb2312 COMMENT='管理员表';

#
# Data for table "tb_admin"
#

INSERT INTO `tb_admin` VALUES (1,'root','root');

#
# Structure for table "tb_kt"
#

CREATE TABLE `tb_kt` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `kt_lb` varchar(100) NOT NULL DEFAULT '' COMMENT '试卷',
  `kt_lx` int(11) NOT NULL DEFAULT '0' COMMENT '类型',
  `kt_small_lb` varchar(255) NOT NULL DEFAULT '' COMMENT '套题',
  `kt_id` varchar(20) NOT NULL DEFAULT 'kt_',
  `kt_nr` varchar(255) NOT NULL DEFAULT '' COMMENT '内容',
  `kt_fs` int(11) NOT NULL DEFAULT '10' COMMENT '分数',
  `kt_daan` varchar(255) DEFAULT '' COMMENT '答案',
  `kt_zqdaan` varchar(255) NOT NULL DEFAULT '' COMMENT '正确答案',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=55 DEFAULT CHARSET=gb2312 COMMENT='考题';

#
# Data for table "tb_kt"
#

INSERT INTO `tb_kt` VALUES (1,'测试',0,'第一套题','kt_01','单选测试',10,'A.a*B.b','A.a'),(2,'测试',1,'第一套题','kt_11','多选测试',10,'A.a*B.b','A.a*B.b'),(3,'测试',2,'第一套题','kt_21','简答测试',10,'','A.a'),(4,'测试',3,'第一套题','kt_31','论述测试',10,'','A.a'),(5,'测试',0,'第一套题','kt_02','测试1',10,'A.测试1*B.测试2','A.测试1'),(6,'测试',0,'第一套题','kt_03','测试3',10,'A.测试1*B.测试2','B.测试2'),(7,'测试',2,'第一套题','kt_22','简单测试2',10,'','撒的撒打算'),(53,'测试',2,'第一套题','kt_23','简答测试4',10,'','按时打算打算的大神');

#
# Structure for table "tb_ktlb"
#

CREATE TABLE `tb_ktlb` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ktlb` varchar(50) NOT NULL DEFAULT '' COMMENT '考题列表',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=gb2312 COMMENT='考题列表';

#
# Data for table "tb_ktlb"
#

INSERT INTO `tb_ktlb` VALUES (5,'测试2'),(6,'测试'),(8,'1'),(9,'a'),(10,'A'),(13,'啊');

#
# Structure for table "tb_user"
#

CREATE TABLE `tb_user` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `user` varchar(100) NOT NULL DEFAULT '' COMMENT '姓名',
  `pass` varchar(50) NOT NULL DEFAULT '' COMMENT '密码',
  `tel` varchar(13) NOT NULL DEFAULT '0' COMMENT '电话号吗',
  `address` varchar(200) NOT NULL DEFAULT '' COMMENT '地址',
  `number` varchar(10) NOT NULL DEFAULT '' COMMENT '准考证号',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=20 DEFAULT CHARSET=gb2312 COMMENT='考生信息表';

#
# Data for table "tb_user"
#

INSERT INTO `tb_user` VALUES (19,'范志俊','1234','021-63730691','上海','2012021039');

#
# Structure for table "tb_user_grade"
#

CREATE TABLE `tb_user_grade` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `number` int(11) NOT NULL DEFAULT '0' COMMENT '准考证号',
  `examsubject` varchar(100) NOT NULL DEFAULT '' COMMENT '科目',
  `grade` int(11) NOT NULL DEFAULT '0' COMMENT '分数',
  `datetime` datetime DEFAULT NULL COMMENT '考试时间',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=gb2312;

#
# Data for table "tb_user_grade"
#

INSERT INTO `tb_user_grade` VALUES (4,2012021039,'测试',40,'2014-01-12 22:32:33');

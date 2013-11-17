using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using 信息抓取.Linqs;
using System.Net;
using System.IO;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using System.Web.Services;

namespace 信息抓取
{
    public partial class WqhomeTest : System.Web.UI.Page
    {
        public static ZhuaQuDataContext zhua = new ZhuaQuDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //获取网页源码
        public static string Get_Http(string a_strUrl, int timeout)
        {
            string strResult;
            try
            {
                HttpWebRequest myReq = (HttpWebRequest)HttpWebRequest.Create(a_strUrl);
                
                myReq.Timeout = timeout;
                HttpWebResponse HttpWResp = (HttpWebResponse)myReq.GetResponse();
                Stream myStream = HttpWResp.GetResponseStream();
                Encoding encoding = Encoding.GetEncoding("UTF-8");

                //如果是gb2312编码
                //StreamReader sr = new StreamReader(myStream, Encoding.UTF8);
                //如果是utf-8编码
                //StreamReader sr = new StreamReader(myStream, Encoding.UTF8);
                //如果是GBK编码
                StreamReader sr = new StreamReader(myStream, Encoding.GetEncoding("GBK"));
                
                StringBuilder strBuilder = new StringBuilder();
                while (-1 != sr.Peek())
                {
                    strBuilder.Append(sr.ReadLine() + "/r/n");
                }
                strResult = strBuilder.ToString();
            }
            catch (Exception exp)
            {
                strResult = "错误：" + exp.Message;
            }
            return strResult;
        }

        //转换成实体
        public static MsgInfo getinfomation(string strhtml, string strbtstart, string strbtend,string strsjstart,string strsjend,string strnrstart,string strnrend) {
            string retitle = string.Format("{0}(?<g>(.|[\r\n])+?){1}", strbtstart, strbtend);//匹配标题
            string redate = string.Format("{0}(?<g>(.|[\r\n])+?){1}", strsjstart, strsjend);//匹配日期
            string recontent = string.Format("{0}(?<g>(.|[\r\n])+?){1}", strnrstart, strnrend);//匹配正文
            string title = Regex.Match(strhtml, retitle).Groups["g"].Value;
            string date = Regex.Match(strhtml, redate).Groups["g"].Value;
            string contents = Regex.Match(strhtml, recontent).Groups["g"].Value;
            MsgInfo msg = new MsgInfo();
            msg.title = title;
            msg.pubdate = Convert.ToDateTime(date);
            msg.content = contents;
            return msg;
        }

        //插入数据库
        [WebMethod]
        public static bool insertinfo(string url, string strbtstart, string strbtend, string strsjstart, string strsjend, string strnrstart, string strnrend)
        {
            bool bol = false;
            try
            {
                string pagehtml =Get_Http(url, 5000);
                MsgInfo minfo = getinfomation(pagehtml, strbtstart, strbtend, strsjstart, strsjend, strnrstart, strnrend);
                zhua.MsgInfo.InsertOnSubmit(minfo);
                zhua.SubmitChanges();
                bol = true;
            }
            catch (Exception)
            {
                bol = false; 
            }
            return bol;
        }

        //绑定
        public string  bind() {
            string strlist = "";
            StringBuilder sb = new StringBuilder();
            List<MsgInfo> list = (from info in zhua.MsgInfo select info).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append("<p style=\" margin:5px 15px 0px 15px;padding:5px; height:25px; line-height:25px;\"><a style=\"float:left;\" onclick=\"selcontent("+list[i].id+")\">"+list[i].title+"</a><span style=\"float:right;\">"+list[i].pubdate+"</span></p>");
            }
            strlist = sb.ToString();
            return strlist;
        }

        //根据id查询
        [WebMethod]
        public static string getcontent(int id) {
            string contents = "";
            contents = (from info in zhua.MsgInfo where info.id == id select info.content).ToList()[0];
            return contents;
        }
    }
}
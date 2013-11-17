using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace 信息抓取
{
    public partial class Index2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            string url = this.txturl.Text;
            string strcontent = Get_Http(url, 5000);
            string start = "<div class=\"zz\">";
            string end = "<a href=";
            List<String> list = GetHtmls(start, end, strcontent);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i].ToString() + "<br/>");
            }
            this.msg.InnerHtml = sb.ToString();
        }

        //获取网页源码
        public string Get_Http(string a_strUrl, int timeout)
        {
            string strResult;
            try
            {
                HttpWebRequest myReq = (HttpWebRequest)HttpWebRequest.Create(a_strUrl);
                myReq.Timeout = timeout;
                HttpWebResponse HttpWResp = (HttpWebResponse)myReq.GetResponse();
                Stream myStream = HttpWResp.GetResponseStream();
                Encoding encoding = Encoding.GetEncoding("UTF-8");
                StreamReader sr = new StreamReader(myStream, Encoding.UTF8);
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

        /// <summary>
        /// 返回匹配多个的集合值
        /// </summary>
        /// <param name="start">开始html tag</param>
        /// <param name="end">结束html tag</param>
        /// <param name="html">html</param>
        /// <returns></returns>
        public static List<string> GetHtmls(string start, string end, string html)
        {
            List<String> list = new List<string>();
            try
            {
                string pattern = string.Format("{0}(?<g>(.|[\r\n])+?){1}", start, end);//匹配URL的模式,并分组
                MatchCollection mc = Regex.Matches(html, pattern);//满足pattern的匹配集合
                if (mc.Count != 0)
                {
                    foreach (Match match in mc)
                    {
                        GroupCollection gc = match.Groups;
                        list.Add(gc["g"].Value);
                    }
                }
            }
            catch { }
            return list;
        }
    }
}
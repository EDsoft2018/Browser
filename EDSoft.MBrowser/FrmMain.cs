using CefSharp;
using CefSharp.WinForms;
using EDSoft.DLL;
using EDSoft.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDSoft.MBrowser
{
    public partial class FrmMain : Form
    {

        private readonly ChromiumWebBrowser browser;
        readonly string baseUrlqq = "https://www.shendenglicai.com/jiaoyudai/uweb/index?page=order/myorder#!/contract/contract?orderno=JYD1036766";
        readonly string baseUrl = "https://www.shendenglicai.com/jiaoyudai/uweb/index?page=order/myorder#!/contract/contract?orderno=JYD1000000";
        public FrmMain()
        {
            InitializeComponent();
            Text = "MyWeb";
            WindowState = FormWindowState.Maximized;
            browser = new ChromiumWebBrowser(baseUrl)
            {
                Height = this.Height,
                Width = this.Width,
                Dock = DockStyle.Fill,
            };
            this.Controls.Add(browser);

        }

        #region 窗体事件

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                while (true)
                {
                    // lbl_url.Text = Url2N(baseUrl);
                    //LoadUrl(baseUrl);
                    string urlnn = Url2N(baseUrl);

                    LoadUrl(urlnn);

                    VClick();
                    var task1 = browser.GetSourceAsync();
                    task1.Wait();
                    string html = task1.Result;
                    string strin = html2string(html);

                    if (strin != null)
                    {
                        var urlt = urlnn.Split(new char[3] { 'J', 'Y', 'D' });
                        Logmsg(strin, urlt[3], "D://JYD");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private string html2string(string html)
        {
            var strin = "";
            try
            {
                HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);
                HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes(@"//ul//li");
                strin = nodes[2].InnerText.ToString();

            }
            catch (Exception ex)
            {
                return null;
                //throw ex;
            }
            return strin;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            string strurl = txt_url.Text;
            LoadUrl(strurl);
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        { }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //TODO testing
            VClick();



        }

        #endregion
        #region 函数

        /// <summary>
        /// 将html 关键信息，提取，添加到数据库
        /// </summary>
        /// <param name="html"></param>
        public void String2DB(string html)
        {
            try
            {

                string r = Regex.Replace(html, @"\s", "");
                int a = r.IndexOf('名');
                int b = r.IndexOf('身');
                int c = r.IndexOf('开');
                int d = r.IndexOf('行');




                //string name = r.Substring();
                Logmsg(html, "原", "D://");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// log日志，txt版
        /// </summary>
        /// <param name="Log1">内容</param>
        /// <param name="name">名字</param>
        /// <param name="path">路径</param>
        public static void Logmsg(string Log1, string name, string path)
        {
            #region 创建日志
            string Log = "";
            Log += Log1 + "\r\n";

            //生成目录
            //创建文件夹
            if (Directory.Exists(path) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(path);
            }

            // 判断文件是否存在，不存在则创建，否则读取值显示到txt文档
            if (!System.IO.File.Exists(path + "/" + name + "_Log" + DateTime.Today.ToString("yyyy-MM-dd HH") + ".txt"))
            {
                FileStream fs1 = new FileStream(path + "/" + name + "_Log" + DateTime.Today.ToString("yyyy-MM-dd") + ".txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(Log);//开始写入值
                sw.Close();
                fs1.Close();
            }
            else
            {
                FileStream fs = new FileStream(path + "/" + name + "_Log" + DateTime.Today.ToString("yyyy-MM-dd") + ".txt" + "", FileMode.Append, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(Log);//开始写入值
                sr.Close();
                fs.Close();
            }
            #endregion
        }
        /// 清除文本中Html的标签 
        /// </summary> 
        /// <param name="Content"></param> 
        /// <returns></returns> 
        public static string ClearHtml(string Content)
        {
            Content = Zxj_ReplaceHtml("&#[^>]*;", "", Content);
            Content = Zxj_ReplaceHtml("</?marquee[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?object[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?param[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?embed[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?table[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml(" ", "", Content);
            Content = Zxj_ReplaceHtml("</?tr[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?th[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?p[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?a[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?img[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?tbody[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?li[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?span[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?div[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?th[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?td[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?script[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("(javascript|jscript|vbscript|vbs):", "", Content);
            Content = Zxj_ReplaceHtml("on(mouse|exit|error|click|key)", "", Content);
            Content = Zxj_ReplaceHtml("<\\?xml[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("<\\/?[a-z]+:[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?font[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?b[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?u[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?i[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?strong[^>]*>", "", Content);
            Content = Zxj_ReplaceHtml("</?strong[^>]*>", "", Content);

            Content = Zxj_ReplaceHtml(" ", "", Content);
            Regex r = new Regex(@"\s+");
            Content = r.Replace(Content, "");

            Content.Trim();
            string clearHtml = Content;
            return clearHtml;
        }

        /// <summary> 
        /// 清除文本中的Html标签 
        /// </summary> 
        /// <param name="patrn">要替换的标签正则表达式</param> 
        /// <param name="strRep">替换为的内容</param> 
        /// <param name="content">要替换的内容</param> 
        /// <returns></returns> 
        private static string Zxj_ReplaceHtml(string patrn, string strRep, string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                content = "";
            }
            Regex rgEx = new Regex(patrn, RegexOptions.IgnoreCase);
            string strTxt = rgEx.Replace(content, strRep);
            return strTxt;
        }

        /// <summary>
        ///打开新链接
        /// </summary>
        /// <param name="url"></param>
        private void LoadUrl(string url)
        {
            try
            {
                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    browser.Load(url);
                    lbl_url.Text = url;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// 模拟点击
        /// </summary>
        private void VClick()
        {
            Thread.Sleep(1000);
            browser.EvaluateScriptAsync("document.getElementsByTagName('a')[2].click()");
            browser.EvaluateScriptAsync("document.getElementsByTagName('a')[3].click()");

            //string a_length = "";
            //Task<CefSharp.JavascriptResponse> t5 = browser.EvaluateScriptAsync("document.getElementsByTagName('a').length");
            //t5.Wait();
            //if (t5.Result.Result != null)
            //{
            //    a_length = t5.Result.Result.ToString();
            //}

            //if (a_length != "")
            //{
            //    for (int i = 0; i < Convert.ToInt32(a_length); i++)
            //    {
            //        browser.EvaluateScriptAsync("document.getElementsByTagName('a')[" + i + "].click()");
            //    }
            //    t5.Dispose();
            //}

        }

        /// <summary>
        /// 生产新的链接
        /// </summary>
        /// <param name="urlo"></param>
        /// <returns></returns>
        private string Url2N(string urlo)
        {
            var url = "";
            try
            {
                var urlt = urlo.Split(new char[3] { 'J', 'Y', 'D' });
                url = urlt[0] + "JYD" + (Convert.ToInt64(urlt[3]) + 1);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return url;
        }

        /// <summary>
        /// 保存人员信息
        /// </summary>
        /// <param name="_TYXX"></param>
        private void Save(T_TYXX _TYXX)
        {
            using (var db = new MyDbContext())
            {

                db.T_TYXX.Add(_TYXX);
                db.SaveChanges();
                MessageBox.Show("OK");
            }
        }
        /// <summary>
        /// 批量保存人员信息
        /// </summary>
        /// <param name="_TYXX"></param>
        private void Save(List<T_TYXX> _TYXX)
        {
            using (var db = new MyDbContext())
            {

                db.T_TYXX.AddRange(_TYXX);
                db.SaveChanges();
                MessageBox.Show("OK");
            }
        }

        #endregion

    }
}

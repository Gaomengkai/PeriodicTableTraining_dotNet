using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Pt2
{
    public class CheckUpdate
    {
        private static string s_downUrl;
        private static string s_localTag;
        private static string s_lastTag;
        private static string s_body;

        public static String GetC(String url)
        {
            string retString = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.119 Safari/537.36";
            request.KeepAlive = false;
            //request.Timeout = Timeout;
            Stream fuckedStream = null;
            StreamReader myStreamReader = null;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                fuckedStream = response.GetResponseStream();
                myStreamReader = new StreamReader(fuckedStream, Encoding.GetEncoding("utf-8"));
                retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                fuckedStream.Close();
            }
            catch(WebException e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString() + "\n\n网络错误");
                retString = "-1";
            }
            return retString;
        }

        public static String LastTag { get => s_lastTag; set => s_lastTag = value; }
        public static String LocalTag { get => s_localTag; set => s_localTag = value; }
        public static String DownUrl { get => s_downUrl; set => s_downUrl = value; }
        public static String Body { get => s_body; set => s_body = value; }

        public class FirstJson
        {
            private string _url;

            public String url { get => _url; set => _url = value; }
        }

        public class SecondJson
        {
            private string _tag_name;
            private FuckedAssets[] _assets;
            private string _body;

            public String tag_name { get => _tag_name; set => _tag_name = value; }
            public FuckedAssets[] assets { get => _assets; set => _assets = value; }
            public String body { get => _body; set => _body = value; }
        }

        public class FuckedAssets
        {
            private string _browser_download_url;

            public String browser_download_url { get => _browser_download_url; set => _browser_download_url = value; }
        }


        public CheckUpdate(String Tag) => LocalTag = Tag;

        public bool HasNewVersion() => LocalTag != LastTag;

        public bool StartCheckNewVersion()
        {
            String url = "https://api.github.com/repos/Gaomengkai/PeriodicTableTraining_dotNet/releases";
            String Cont = GetC(url);
            FirstJson[] data1 = null;
            SecondJson data2 = null;
            if (Cont == "-1") return false;
            if (Cont != "-1") { data1 = JsonConvert.DeserializeObject<FirstJson[]>(Cont); }
            String FirstUrl = data1[0].url;

            String Cont2 = GetC(FirstUrl);
            if (Cont2 != "-1") { data2 = JsonConvert.DeserializeObject<SecondJson>(Cont2); }
            LastTag = data2.tag_name;
            Body = data2.body;
            DownUrl = data2.assets[0].browser_download_url;
            return true;
        }

        public String GetDownUrl() => DownUrl;

        public String GetLastTag() => LastTag;

        public String GetBody() => Body;
    }
}

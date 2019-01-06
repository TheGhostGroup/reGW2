using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class StsTransaction
    {
        private string function;
        private string version;
        private string content;
        private Dictionary<string, string> headers;

        public string Method
        {
            get { return function; }
            set { function = value; }
        }

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public Dictionary<string, string> Headers
        {
            get { return headers; }
            set { headers = value; }
        }

        public StsTransaction(string function, string version, string content, Dictionary<string, string> headers)
        {
            this.function = function;
            this.version = version;
            this.content = content;
            this.headers = headers;
        }

        protected static Dictionary<string, string> ParseHeader(string header)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            
            int idx;
            do
            {
                idx = header.IndexOf("\r\n");
                string line;
                if (idx > 0)
                {
                    line = header.Substring(0, idx);
                    header = header.Substring(idx + 2);
                }
                else
                    line = header;

                int colon = line.IndexOf(':');
                string key = line.Substring(0, colon);
                string data = line.Substring(colon + 1);

                headers.Add(key, data);
            } while (idx != -1);

            return headers;
        }

        public static StsTransaction Build(string raw, out int offset)
        {
            int fof = 0;
            StsTransaction trans = null;

            if (raw[0] == 'P')
            {
                raw = raw.Substring(2); fof += 2;
                
                int of = raw.IndexOf(' '); 
                
                string method = raw.Substring(0, of);
                raw = raw.Substring(of + 1); fof += of + 1;

                of = raw.IndexOf("\r\n"); 
                string version = raw.Substring(0, of);
                raw = raw.Substring(of + 2); fof += of + 2;

                of = raw.IndexOf("\r\n\r\n"); 

                var headers = ParseHeader(raw.Substring(0, of));

                raw = raw.Substring(of + 4); fof += of + 4;

                int val = int.Parse(headers["l"]);

                if (val <= raw.Length)
                {
                    fof += val;
                    trans = new StsTransaction(method, version, raw.Substring(0, val), headers);
                }
            }

            offset = fof;
            return trans;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            if(Method != null && Method.Length > 0) 
                builder.Append("P " + Method + " "); 
            builder.Append(Version + "\r\n");
            builder.Append("l:" + (Content.Length + 1) + "\r\n");
            foreach(var entry in Headers)
            {
                if (entry.Key == "l") continue;
                builder.Append(entry.Key + ":" + entry.Value + "\r\n");
            }
            builder.Append("\r\n");
            builder.Append(Content);
            builder.Append("\n");

            return builder.ToString();
        }
    }
}

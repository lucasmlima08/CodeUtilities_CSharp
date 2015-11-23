using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;

namespace CodeUtilities
{
    class WebClientPHP
    {
        public void methodPost(String string1, String string2)
        {
            WebClient webClient = new WebClient();
            var data = new NameValueCollection();
            data["string1"] = string1;
            data["string2"] = string2;
            var read = webClient.UploadValues("http://example.com.br/script.php", data);
            Console.WriteLine(read);
        }

        public void methodGet(String string1, String string2)
        {
            WebClient webClient = new WebClient();
            string read = webClient.DownloadString("http://example.com.br/script.php?value1="+string1+"&value2="+string2);
            Console.WriteLine(read);
        }
    }
}

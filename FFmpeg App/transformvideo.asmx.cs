using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Services;

namespace FFmpeg_App
{
    /// <summary>
    /// Summary description for transformvideo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class transformvideo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
            //ffmpeg -i input.mp4 output.webm
        }
        public string convertmp4towebm(string inputvid)
        {
            //ffmpeg -i "inputvid.mp4"
            return;
        }
    }
}

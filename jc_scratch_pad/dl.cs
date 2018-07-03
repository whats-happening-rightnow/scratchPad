using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace jc_scratch_pad
{    

        //static void wl(string msg) {
        //    Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.f")}|{(ct++).ToString("00000")}|{msg}");
        //}

    class allofem
    {
        public string sid { get; set; }
        public bool success { get; set; }
        public string gotfile { get; set; }
        public List<bzurlfile> bzuf { get; set; }
        public string file { get; set; }
    }
    class bzurlfile {
        public string url { get; set; }
        public string file { get; set; }
    }
}

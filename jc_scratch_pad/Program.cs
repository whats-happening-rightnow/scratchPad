using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace jc_scratch_pad
{
    class Program
    {
        static void Main(string[] args)
        {
            var zipPath = @"\\jfs\q$\00\BigWetButts\picsets\";
            var zipFiles = Directory.GetFiles(zipPath, "*.zip").Select(x => new FileInfo(x)).ToList();

            var tot = 0;
            foreach (var zipFile in zipFiles)
            {
                tot++;
                using (var zipZip = ZipFile.OpenRead(zipFile.FullName)) {

                    var imgCt = zipZip.Entries.Count;
                    var imgStart = Convert.ToInt16(imgCt * 0.73);
                    var imgEnd = Convert.ToInt16(imgCt * 0.02);

                    var imgs = zipZip.Entries.Skip(imgStart).Take(1).Select(x => x).ToList();

                    var ct = 0;
                    foreach (var img in imgs)
                    {
                        var imgname = $@"{Path.Combine(@"\\jfs\q$\00\BigWetButts\picsets\__", $"{zipFile.Name}_{(++ct).ToString("000")}.jpg")}";
                        if (!File.Exists(imgname))
                        {
                            img.ExtractToFile(imgname);
                        }
                        Console.WriteLine($@"{(tot).ToString("000")}/{zipFiles.Count} : {imgname}");
                    }
                }
            }
        }
    }
}

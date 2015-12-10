using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace downloadChenChiKwan
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 11; x++)
            {
                string catalog = x.ToString().PadLeft(2, '0');

                for (int i = 1; i <= 100; i++)
                {
                    string urlpath = "http://www.chenchikwan.com/images/gallery/catalogue/new/";
                    string filename = i.ToString().PadLeft(2, '0') + ".jpg";
                    string savepath = @"C:\Users\kevin\Pictures\陳其寬\";

                    WebClient wc = new WebClient();

                    try
                    {    
                        wc.DownloadFile(urlpath + catalog + "/" + filename, savepath + catalog + "\\" + filename);

                        FileInfo f = new FileInfo(savepath + catalog + "\\" + filename);
                        if (f.Length < 1000){
                            File.Delete(savepath + catalog + "\\" + filename);
                        }

                    }
                    catch (Exception ex)
                    {
                        i = 101;
                    }
                    finally
                    {
                        wc.Dispose();
                    }
                }
            }
        }


    }
}

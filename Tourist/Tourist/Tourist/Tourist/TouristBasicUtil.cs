using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GMap;

namespace Tourist.Tourist
{
    public static class TouristBasicUtil
    {

        // 해당파일이 정상적인 EXIF Format을 가진 파일인지 체크하는 메소드
        public static bool checkExifFile(string path)
        {
            bool result = false;
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                br.BaseStream.Position = 0;
                if (fs.Length >= 3)
                {
                    byte[] headers = br.ReadBytes(3);
                    if (headers[0] == 255 && headers[1] == 216 && headers[2] == 255)
                        result = true;
                }
                br.Close();
                fs.Close();
            }
            return result;
        }
        
        public static string GetFileSize(double byteCount)
        {
            // Reference - http://www.vcskicks.com/csharp_filesize.php
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";

            return size;
        }
        public static double ConvertGPSLocation(string location)
        {
            string[] first_data = location.Split(new string[] { "°" }, StringSplitOptions.None);
            double temp1 = Convert.ToInt32(first_data[0]);

            char[] split_article = { '\'' };
            string[] second_data = first_data[1].Split(split_article);

            double temp2 = Convert.ToDouble(second_data[0].Trim()) / 60;
            double temp3 = Convert.ToDouble(second_data[1].Replace("\"", "").Trim()) / 3600;

            return temp1 + temp2 + temp3;
        }

        
        }

    }




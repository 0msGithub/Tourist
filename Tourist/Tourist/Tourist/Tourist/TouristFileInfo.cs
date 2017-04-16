using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tourist.Tourist
{
    public static class TouristFileInfo
    {

        // 해당파일의 기본정보를 가져오는 메소드
        public static PropertyFileInfo getFileInfo(string filePath)
        {
            PropertyFileInfo pf = new PropertyFileInfo();
            pf.filename = Path.GetFileName(filePath);

            FileInfo fi = new FileInfo(filePath);
            pf.filesize = fi.Length;
            return pf;
        }
        
    }

    public class PropertyFileInfo
    {
        public string filename { get; set; }
        public long filesize { get; set; }

    }
}

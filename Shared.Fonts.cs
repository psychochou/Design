using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media;
using System.IO;
using System.Drawing.Text;

namespace Shared
{
    class Fonts
    {

        public static void ReNameFont(string fileName)
        {
            var f = System.Windows.Media.Fonts.GetFontFamilies(fileName);
 
          
            var ls = new List<string>();
            foreach (var item in f)
            {
               // var ff = ;
                foreach (var i in item.FamilyNames)
                {
                    ls.Add(i.Value);
                }


                ls.Add(" - "+item.GetTypefaces().First().FaceNames.First().Value);
            }

            var fn = string.Join(" ", ls) + Path.GetExtension(fileName);
            var ft = Path.Combine(Path.GetDirectoryName(fileName), fn);
            if (ft != fileName)
            {
                try
                {
                    File.Move(fileName, ft);
                }
                catch
                {

                }
            }
                
        }
    }
}

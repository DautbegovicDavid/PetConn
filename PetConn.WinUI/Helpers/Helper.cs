using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetConn.WinUI.Helpers
{
    public class Helper
    {
        public static byte[] FromImageToByte(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static Image FromByteToImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            return Image.FromStream(ms);
        }
        public static byte[] FromImageToByteTHUMB(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Gif);
            return ms.ToArray();
        }
        public static void DodajKontrolu(UserControl uc, string nazivKontrole, Point p,Panel panel)
        {
           
            if (panel.Controls.Find(nazivKontrole, true).Length == 1)
                return;
            uc.Name = nazivKontrole;
            uc.Location = p;
            uc.Show();
            panel.Controls.Add(uc);
            uc.Visible = true;//za dgv


        }
        public static void UcDodajKontrolu(Control c,UserControl uc, string nazivKontrole, Point p)
        {
          
            if (c.Controls.Find(nazivKontrole, true).Length == 1)
                return;
            
            uc.Name = nazivKontrole;
            uc.Location = p;
            uc.Show();
            c.Controls.Add(uc);
        }
        public static void UkloniKontrolu(Control c, string nazivKontrole)
        {
            foreach (UserControl item in c.Controls.OfType<UserControl>())
            {
                if (item.Name == nazivKontrole)
                    c.Controls.Remove(item);
            }
           
        }
       
    }
}

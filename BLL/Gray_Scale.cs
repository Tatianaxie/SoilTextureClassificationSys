using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoilType
{
    class Gray_Scale
    {
        public static Hashtable SoilTypeUSA = new Hashtable();
        public static Hashtable SoilAreaUSA = new Hashtable();
        public static Hashtable SoilTypeUK = new Hashtable();
        public static Hashtable SoilAreaUK = new Hashtable();
        public static Hashtable SoilTypeISSS = new Hashtable();
        public static Hashtable SoilAreaISSS = new Hashtable();

        public Gray_Scale()
        {
            if (SoilTypeUSA.Count <1)
            {
                SetValue();
            }
        }

        public void SetValue()
        {
            SoilTypeUSA.Add(235, "Clay");
            SoilTypeUSA.Add(215, "Sandy Clay");
            SoilTypeUSA.Add(195, "Silty Clay");
            SoilTypeUSA.Add(175, "Sandy Clay Loam");
            SoilTypeUSA.Add(155, "Clay Loam");
            SoilTypeUSA.Add(135, "Silty Clay Loa");
            SoilTypeUSA.Add(115, "Silt");
            SoilTypeUSA.Add(95, "Silt Loam");
            SoilTypeUSA.Add(75, "Loam");
            SoilTypeUSA.Add(55, "Sandy Loam");
            SoilTypeUSA.Add(35, "Loamy Sand");
            SoilTypeUSA.Add(15, "Sand");
            SoilTypeUSA.Add(0, "Boundary");

            SoilAreaUSA.Add(235, 1288);
            SoilAreaUSA.Add(215, 173);
            SoilAreaUSA.Add(195, 173);
            SoilAreaUSA.Add(175, 333);
            SoilAreaUSA.Add(155, 271);
            SoilAreaUSA.Add(135, 217);
            SoilAreaUSA.Add(115, 158);
            SoilAreaUSA.Add(95, 798);
            SoilAreaUSA.Add(75, 223);
            SoilAreaUSA.Add(55, 501);
            SoilAreaUSA.Add(35, 130);
            SoilAreaUSA.Add(15, 65);
            SoilAreaUSA.Add(0, 0);

            SoilTypeUK.Add(233, "Clay");
            SoilTypeUK.Add(211, "Sandy Clay");
            SoilTypeUK.Add(190, "Silt Clay");
            SoilTypeUK.Add(168, "Sandy Clay Loam");
            SoilTypeUK.Add(146, "Clay Loam");
            SoilTypeUK.Add(124, "Silty Clay Loam");
            SoilTypeUK.Add(102, "Silty Sand");
            SoilTypeUK.Add(80, "Sandy Silt Loam");
            SoilTypeUK.Add(59, "Sandy Loam");
            SoilTypeUK.Add(36, "Loamy Sand");
            SoilTypeUK.Add(15, "Sand");
            SoilTypeUK.Add(0, "Boundary");

            SoilAreaUK.Add(233, 1713);
            SoilAreaUK.Add(211, 300);
            SoilAreaUK.Add(190, 200);
            SoilAreaUK.Add(168, 360);
            SoilAreaUK.Add(146, 528);
            SoilAreaUK.Add(124, 318);
            SoilAreaUK.Add(102, 360);
            SoilAreaUK.Add(80, 540);
            SoilAreaUK.Add(59, 700);
            SoilAreaUK.Add(36, 87);
            SoilAreaUK.Add(15, 43);
            SoilAreaUK.Add(0, "Boundary");

            SoilTypeISSS.Add(235, "Heavy Clay");
            SoilTypeISSS.Add(215, "Clay");
            SoilTypeISSS.Add(195, "Sandy Clay");
            SoilTypeISSS.Add(175, "Loamy Clay");
            SoilTypeISSS.Add(155, "Silty Clay");
            SoilTypeISSS.Add(135, "Sandy Clay Loam");
            SoilTypeISSS.Add(115, "Clay Loam");
            SoilTypeISSS.Add(95, "Silty Clay Loam");
            SoilTypeISSS.Add(75, "Sandy Soil and Sandy Loam Soil");
            SoilTypeISSS.Add(55, "Sandy Loam");
            SoilTypeISSS.Add(35, "Loam");
            SoilTypeISSS.Add(15, "Silty Sand");
            SoilTypeISSS.Add(0, "Boundary");

            SoilAreaISSS.Add(235, 707);
            SoilAreaISSS.Add(215, 1112);
            SoilAreaISSS.Add(195, 231);
            SoilAreaISSS.Add(175, 640);
            SoilAreaISSS.Add(155, 400);
            SoilAreaISSS.Add(135, 250);
            SoilAreaISSS.Add(115, 180);
            SoilAreaISSS.Add(95, 350);
            SoilAreaISSS.Add(75, 113);
            SoilAreaISSS.Add(55, 450);
            SoilAreaISSS.Add(35, 105);
            SoilAreaISSS.Add(15, 713);
            SoilAreaISSS.Add(0, "Boundary");
        }

        /// <summary>
        /// 归一化处理
        /// </summary>
        public void Normalization(ref double sand, ref double clay, ref double silt)
        {
            double sum = sand + clay + silt;
          
            sand =100 * sand / sum;
            clay = 100 * clay / sum;
            silt = 100 * silt / sum;
        }

        /// <summary>
        /// 土壤质地判别主流程
        /// </summary>
        /// <param name="sand"></param>
        /// <param name="clay"></param>
        /// <param name="silt"></param>
        /// <param name="NamePic"></param>
        /// <param name="GrayPic"></param>
        /// <returns></returns>
        public string MainProcess(double sand, double clay, double silt, PictureBox NamePic, PictureBox GrayPic,int Method)
        {
            Bitmap remap = new Bitmap(NamePic.Image,500,433);
            Bitmap bitmap = new Bitmap(GrayPic.Image,500,433);

            Normalization(ref sand, ref clay, ref silt);
            //Calculate original location (x,y)计算原始坐标
            int origonX = Convert.ToInt32(100 - sand - (clay / (Math.Sqrt(3))));
            int origonY = Convert.ToInt32(clay);

            //Calculate projection coordinate计算屏幕坐标
            int screenX = Convert.ToInt32(Math.Floor(origonX * bitmap.Width / 100 + 0.5));
            int screenY = Convert.ToInt32(Math.Floor((100 - origonY) * bitmap.Height / 100 + 0.5));

            CastPoint(screenX, screenY, NamePic, GrayPic);
            //return "边界";
            string soilTextureType = "";
            if (Method == 0)
            {
                soilTextureType=GVtoType(screenX, screenY, bitmap, SoilTypeUSA, SoilAreaUSA);//美国图版
            }
            else if(Method==1)
            {
                soilTextureType = GVtoType(screenX, screenY, bitmap, SoilTypeISSS, SoilAreaISSS);//国际图版
            }
            else
            {
                soilTextureType = GVtoType(screenX, screenY, bitmap, SoilTypeUK, SoilAreaUK);//英国图版
            }
            return soilTextureType;            
        }
       /// <summary>
       /// 画点
       /// </summary>
       /// <param name="screenX"></param>
       /// <param name="screenY"></param>
       /// <param name="NamePic"></param>
       /// <param name="GrayPic"></param>
       /// <returns></returns>
        private bool CastPoint(int screenX, int screenY, PictureBox NamePic, PictureBox GrayPic)
        {
            Bitmap remap = new Bitmap(NamePic.Image,500,433);
            Bitmap bitmap = new Bitmap(GrayPic.Image,500,433);
          
            for (int i = screenX - 3; i < screenX + 3; i++)
            {
                for (int j = screenY - 3; j < screenY + 3; j++)
                {
                    if ((i >= 0) && (i < bitmap.Width) && (j >= 0) && (j < bitmap.Height))
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(255, 0, 0));
                        remap.SetPixel(i, j, Color.FromArgb(255, 0, 0));
                    }
                }
            }
            GrayPic.Image = bitmap;
            NamePic.Image = remap;
            return true;
        }
        /// <summary>
        /// search for soil type from the grayvalue table从灰度值查询类型
        /// </summary>
        /// <param name="screenX"></param>
        /// <param name="screenY"></param>
        /// <param name="bitmap"></param>
        private string GVtoType(int screenX, int screenY, Bitmap GrayPic, Hashtable SoilType, Hashtable SoilArea)
        {
            string Type = "";
            Color pixel = GrayPic.GetPixel(screenX, screenY);
            int red = pixel.R;
            int blue = pixel.B;
            int green = pixel.G;
            int gv = Convert.ToInt32 ((red + green + blue)/3);
            if (SoilType[gv] != null)
                {
                     Type = SoilType[gv].ToString();
               
                }
            else 
                {
                    int k = 0;
                    int[] d8 = new int[8];
                    for (int i = screenX - 3; i <= screenX + 3; i++)
                    {
                        for (int j = screenY - 3; j <= screenY + 3; j++)
                        {
                            if (i != screenX && j != screenY)
                            {
                                Color pixel1 = GrayPic.GetPixel(i, j);
                                int gv1 = (pixel1.R + pixel1.G + pixel1.B) / 3;
                                 if (k<d8.Length)
                                 {
                                     d8[k++] = Convert.ToInt32(SoilArea[gv1]);
                                 }
                            }
                        }
                    }
                
            
                     foreach (DictionaryEntry de in SoilArea)
                     {
  
                        if (Convert.ToInt32(de.Value) == d8.Max())
                        {
          
                            Type = SoilType[de.Key].ToString();
                            break;
                         }
                     }
                }
            return Type;
        }

    }
    
}

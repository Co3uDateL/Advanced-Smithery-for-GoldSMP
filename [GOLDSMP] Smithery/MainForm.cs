using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _GOLDSMP__Smithery
{
    public partial class MainForm : Form
    {
        static private Random random = new Random();
        //avaliable char list for generating resourcepack code
        //Всего 72 элемента = 10 + 26 + 26 + 10
        //Всего 5 мест с
        static public string alphabet =
            "0123456789" +
            "abcdefghijklmnopqrstuvwxyz" +
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "!{}[]@#$%^";

        static public string ignoredChars = "()0123456789 ";

        static public string[] ignoredWords = {
            "- copia",
            "- копия"
        };

        private Sword tempSword;

        public MainForm()
        {
            InitializeComponent();
            //layer0.Image = new sword().finImage;
            CountTextures.Text = "" + CountAllFilesSum();
            CountVariations.Text = "" + CountAllVariety();
        }

        private void ConfigureGenerator(object sender, EventArgs e)
        {
            
        }

        static public Bitmap GetRandomBitmapFromDir(string path)
        {
            string way = "../../textures/";
            string[] files = Directory.GetFiles(way + path, "*.png", SearchOption.TopDirectoryOnly);
            return new Bitmap(files[random.Next(files.Length)]);
        }
        static public Bitmap GetRandomBitmapFromDir(string path, out int id)
        {
            string way = "../../textures/";
            string[] files = Directory.GetFiles(way + path, "*.png", SearchOption.TopDirectoryOnly);
            id = random.Next(files.Length);
            return new Bitmap(files[id]);
        }
        static public Bitmap GetBitmap(string pathToBmap)
        {
            return new Bitmap(pathToBmap);
        }
        //static public Bitmap GetBitmap(int id)
        //{
        //    string[] files = Directory.GetFiles(dirPath, "*.png*", SearchOption.TopDirectoryOnly);
        //    id = random.Next(files.Length);
        //    return new Bitmap(files[id]);
        //}

        static public int CountFileInDir(string path)
        {
            return Directory.GetFiles("../../textures/" + path, "*.png*", SearchOption.AllDirectories).Length;
        }

        static public int[] CountAllFiles()
        {
            int[] res = new int[5];

            res[0] = CountFileInDir(Sword.sppath[(int)sp.blade]);
            res[1] = CountFileInDir(Sword.sppath[(int)sp.handle]);
            res[2] = CountFileInDir(Sword.sppath[(int)sp.guard]);
            res[3] = CountFileInDir(Sword.sppath[(int)sp.pommel]);
            res[4] = CountFileInDir(Sword.sppath[(int)sp.decor]);

            return res;
        }
        static public int CountAllVariety()
        {
            int[] res = CountAllFiles();
            int re = 0;

            for(int i = 0; i<res[1]; i++)
            {
                for (int j = 0; j < res[2]; j++)
                {
                    for (int k = 0; k < res[3]; k++)
                    {
                        for (int l = 0; l < res[4]; l++)
                        {
                            for (int m = 0; m < res[0]; m++)
                            {
                                re++;
                            }

                        }

                    }

                }

            }

            
            return re;
        }
        static public int MeasureId(string targetID)
        {
            int[] res = CountAllFiles();
            int re = 0;

            for (int i = 0; i < res[0]; i++)
            {
                for (int j = 0; j < res[1]; j++)
                {
                    for (int k = 0; k < res[2]; k++)
                    {
                        for (int l = 0; l < res[3]; l++)
                        {
                            for (int m = 0; m < res[4]; m++)
                            {
                                re++;
                                int[] ids = { i, j, k, l, m };
                                if (EndodeTexturePath(ids) == targetID)
                                {
                                    return re;
                                }
                            }

                        }

                    }

                }

            }
            return re;
        }

        static public int CountAllFilesSum()
        {
            int[] res = new int[5];

            res[0] = CountFileInDir(Sword.sppath[(int)sp.blade]);
            res[1] = CountFileInDir(Sword.sppath[(int)sp.handle]);
            res[2] = CountFileInDir(Sword.sppath[(int)sp.guard]);
            res[3] = CountFileInDir(Sword.sppath[(int)sp.pommel]);
            res[4] = CountFileInDir(Sword.sppath[(int)sp.decor]);

            return res[0]+res[1]+res[2]+res[3]+res[4];
        }

        static public string EndodeTexturePath(int[] ids)
        {
            return
                "[" +
                alphabet.ToCharArray()[ids[0]] +
                alphabet.ToCharArray()[ids[1]] +
                alphabet.ToCharArray()[ids[2]] +
                alphabet.ToCharArray()[ids[3]] +
                alphabet.ToCharArray()[ids[4]] +
                "]";
        }

        //Адаптировано с https://stackoverflow.com/questions/4623165/make-overlapping-picturebox-transparent-in-c-net/4623525#4623525?newreg=b277c8b04acc4bc4917aba200a9e077c
        /// <summary>
        /// Возвращает результат рисования картинки 2 поверх картинки 1
        /// </summary>
        /// <param name="image1"></param>
        /// <param name="image2"></param>
        /// <returns></returns>
        static public Bitmap Combine(Image image1, Image image2/*, int width, int height*/)
        {
            int width = image1.Width;
            int height = width;
            //a holder for the result
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                //draw the images into the target bitmap
                graphics.DrawImage(image1, 0, 0, result.Width, result.Height);
                graphics.DrawImage(image2, 0, 0, result.Width, result.Height);
            }

            //return the resulting bitmap
            return result;
        }

        static public Bitmap Scale(Image image, int width, int height)
        {
            //a holder for the result
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.AssumeLinear;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                //draw the image into the target bitmap
                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
            }

            //return the resulting bitmap
            return result;
        }

        private void Generate0(object sender, EventArgs e)
        {
            //TODO List<sword> RescentSwords;
            Sword tempSword = new Sword();
            int[] ids = new int[5];
            ids[0] = 0; ids[1] = 0; ids[2] = 0; ids[3] = 0; ids[4] = 0;




            //if (tempSword.parts[(byte)sp.blade].Width == 32)
            //{
                //tempSword.scaleFactor = tempSword.parts[0].Width;
            //}
            //else
                //(tempSword.blade.Width == 16)
                //{
                    //tempSword.scaleFactor = 16; //tempSword.blade.Width;
                //}

            tempSword.parts[(byte)sp.blade] = new Bitmap(GetRandomBitmapFromDir(Sword.sppath[(int)sp.blade], out ids[0]));
            tempSword.parts[(byte)sp.handle] = new Bitmap(GetRandomBitmapFromDir(Sword.sppath[(int)sp.handle], out ids[1]));
            tempSword.parts[(byte)sp.guard] = new Bitmap(GetRandomBitmapFromDir(Sword.sppath[(int)sp.guard], out ids[2]));
            tempSword.parts[(byte)sp.pommel] = new Bitmap(GetRandomBitmapFromDir(Sword.sppath[(int)sp.pommel], out ids[3]));
            tempSword.parts[(byte)sp.decor] = new Bitmap(GetRandomBitmapFromDir(Sword.sppath[(int)sp.decor], out ids[4]));

            //TODO resourcepack_code

            //Соединяем 5 картинок в 1
            pb_sword.Image =
                Combine( 
                    tempSword.parts[(byte)sp.decor],
                    Combine(
                        Combine(
                            tempSword.parts[(byte)sp.blade],
                            tempSword.parts[(byte)sp.handle]),
                        Combine(
                            tempSword.parts[(byte)sp.guard],
                            tempSword.parts[(byte)sp.pommel])) 
                    );

            layer_0.Image = Scale(tempSword.parts[(byte)sp.blade], tempSword.finFrame * 10, tempSword.finFrame * 10);
            layer_1.Image = Scale(tempSword.parts[(byte)sp.handle], tempSword.finFrame * 10, tempSword.finFrame * 10);
            layer_2.Image = Scale(tempSword.parts[(byte)sp.guard], tempSword.finFrame * 10, tempSword.finFrame * 10);
            layer_3.Image = Scale(tempSword.parts[(byte)sp.pommel], tempSword.finFrame * 10, tempSword.finFrame * 10);
            layer_4.Image = Scale(tempSword.parts[(byte)sp.decor], tempSword.finFrame * 10, tempSword.finFrame * 10);

            pb_sword.Refresh();

            tempSword.resourcepack_code = EndodeTexturePath(ids);
            //REDO inefficient VariationId.Text = "" + MeasureId(tempSword.resourcepack_code);
            Code2.Text = "" + (tempSword.resourcepack_code);



            textBox2.Text = textBox1.Text + tempSword.resourcepack_code;
        }
        private void Print()
        {
            pb_sword.Image = Scale(tempSword.fin, tempSword.finFrame, tempSword.finFrame);

            layer_0.Image = Scale(tempSword.parts[(byte)sp.blade], tempSword.finFrame, tempSword.finFrame);
            layer_1.Image = Scale(tempSword.parts[(byte)sp.handle], tempSword.finFrame, tempSword.finFrame);
            layer_2.Image = Scale(tempSword.parts[(byte)sp.guard], tempSword.finFrame, tempSword.finFrame);
            layer_3.Image = Scale(tempSword.parts[(byte)sp.pommel], tempSword.finFrame, tempSword.finFrame);
            layer_4.Image = Scale(tempSword.parts[(byte)sp.decor], tempSword.finFrame, tempSword.finFrame);
        }
        private void Generate(object sender, EventArgs e)
        {
            tempSword = new Sword();
            Print();
        }




        private void StartSaving(object sender, EventArgs e)
        {
            FolderBro.ShowDialog();
        }

        private void layer_0_Click(object sender, EventArgs e)
        {
            tempSword.parts[(int)sp.blade] = GetRandomBitmapFromDir(Sword.sppath[(int)sp.blade]);
            tempSword.fin = tempSword.updateFin();
            Print();
        }

        private void layer_1_Click(object sender, EventArgs e)
        {
            tempSword.parts[(int)sp.handle] = GetRandomBitmapFromDir(Sword.sppath[(int)sp.handle]);
            tempSword.fin = tempSword.updateFin();
            Print();
        }

        private void layer_2_Click(object sender, EventArgs e)
        {
            tempSword.parts[(int)sp.guard] = GetRandomBitmapFromDir(Sword.sppath[(int)sp.guard]);
            tempSword.fin = tempSword.updateFin();
            Print();

        }

        private void layer_3_Click(object sender, EventArgs e)
        {
            tempSword.parts[(int)sp.pommel] = GetRandomBitmapFromDir(Sword.sppath[(int)sp.pommel]);
            tempSword.fin = tempSword.updateFin();
            Print();
        }

        private void layer_4_Click(object sender, EventArgs e)
        {
            tempSword.parts[(int)sp.decor] = GetRandomBitmapFromDir(Sword.sppath[(int)sp.decor]);
            tempSword.fin = tempSword.updateFin();
            Print();
        }
    }

    //Sword Parts enumerator
    enum sp
    {
        blade = 0,
        handle = 1,
        guard = 2,
        pommel = 3,
        decor = 4,
        decor2 = 5,
    }

    //TODO history
    class Sword
    {
        //public Bitmap blade;
        //public Bitmap handle;
        //public Bitmap guard;
        //public Bitmap pommel;
        //public Bitmap decor;

        public Bitmap[] parts;

        public Bitmap fin;
        
        public int finFrame; //0.5 = 16 | 1 = 32 | 2 = 64

        public string resourcepack_code;

        //aka Sword Parts Path enumerator
        public static readonly string[] sppath = new string[5]
        {
                "0. blade", //0
                "1. handle", //1
                "2. guard", //2
                "3. pommel", //3
                "4. decor" //4
        };

        public Bitmap updateFin()
        {
            return 
                MainForm.Combine(
                    MainForm.Combine(
                        MainForm.Combine(
                            parts[(byte)sp.blade],
                            parts[(byte)sp.handle]
                        ),
                        MainForm.Combine(
                            parts[(byte)sp.guard],
                            parts[(byte)sp.pommel]
                        )
                    ),
                    parts[(byte)sp.decor]
                    );
        }
        public Sword()
        {

            parts = new Bitmap[5];
            int[] ids = new int[5];


            //Загрузить картинки для каждой части
            for (int i=0; i < parts.Length;  i++)
            {
                parts[i] = MainForm.GetRandomBitmapFromDir(sppath[i], out ids[i]);
            }

            resourcepack_code = MainForm.EndodeTexturePath(ids);    

            finFrame = 160;
            //TODO resourcepack_code

            //Соединяем 5 картинок в 1
            fin = updateFin();
        }

    }
}

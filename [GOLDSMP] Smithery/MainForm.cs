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

        //avaliable char list for generating resourcepack code
        //Всего 72 элемента = 10 + 26 + 26 + 10
        //Всего 5 мест с
        public string alphabet =
            "0123456789" +
            "abcdefghijklmnopqrstuvwxyz" +
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "!{}[]@#$%^";

        public string ignoredChars = "()0123456789 ";

        public string[] ignoredWords = {
            "- copia",
            "- копия"
        };


        private Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConfigureGenerator(object sender, EventArgs e)
        {
            CountTextures.Text = "" + CountAllFilesSum();
            CountVariations.Text = "" + CountAllVariety();
            
        }

        private Bitmap GetRandomBitmapFromDir(string path, out int id)
        {
            string[] files = Directory.GetFiles(path, "*.png*", SearchOption.AllDirectories);
            id = random.Next(files.Length);
            return new Bitmap(files[id]);
        }
        private Bitmap GetBitmapByID(string path, out int id)
        {
            string[] files = Directory.GetFiles(path, "*.png*", SearchOption.AllDirectories);
            id = random.Next(files.Length);
            return new Bitmap(files[id]);
        }

        private int CountFileInDir(string path)
        {
            return Directory.GetFiles("../../textures/" + path, "*.png*", SearchOption.AllDirectories).Length;
        }

        private int[] CountAllFiles()
        {
            int[] res = new int[5];

            res[0] = CountFileInDir("1. blade/");
            res[1] = CountFileInDir("2. handle/");
            res[2] = CountFileInDir("3. guard/");
            res[3] = CountFileInDir("4. pommel/");
            res[4] = CountFileInDir("5. decor/");

            return res;
        }
        private int CountAllVariety()
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
        private int MeasureId(string targetID)
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

        private int CountAllFilesSum()
        {
            int[] res = new int[5];

            res[0] = CountFileInDir("1. blade/");
            res[1] = CountFileInDir("2. handle/");
            res[2] = CountFileInDir("3. guard/");
            res[3] = CountFileInDir("4. pommel/");
            res[4] = CountFileInDir("5. decor/");

            return res[0]+res[1]+res[2]+res[3]+res[4];
        }

        private string EndodeTexturePath(int[] ids)
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
        public static Bitmap Combine(Image image1, Image image2/*, int width, int height*/)
        {
            int width = 160;
            int height = 160;
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

        public static Bitmap Scale(Image image, int width, int height)
        {
            //a holder for the result
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                //draw the image into the target bitmap
                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
            }

            //return the resulting bitmap
            return result;
        }

        private void Generate(object sender, EventArgs e)
        {
            //TODO List<sword> RescentSwords;
            sword tempSword;
            int[] ids = new int[5];
            ids[0] = 0; ids[1] = 0; ids[2] = 0; ids[3] = 0; ids[4] = 0;


            string way = "../../textures/";

            tempSword.blade = GetRandomBitmapFromDir(way+ "1. blade/", out ids[0]);

            if (tempSword.blade.Width == 32)
            {
                tempSword.Frame = tempSword.blade.Width;
            }
            else
                //(tempSword.blade.Width == 16)
                {
                    tempSword.Frame = 16; //tempSword.blade.Width;
                }

            tempSword.handle = GetRandomBitmapFromDir(way + "2. handle/", out ids[1]);
            tempSword.guard = GetRandomBitmapFromDir(way + "3. guard/", out ids[2]);
            tempSword.pommel = GetRandomBitmapFromDir(way + "4. pommel/", out ids[3]);
            tempSword.decor = GetRandomBitmapFromDir(way + "5. decor/", out ids[4]);

            //TODO resourcepack_code

            //Соединяем 5 картинок в 1
            layer0.Image = Combine( tempSword.decor, Combine(Combine(tempSword.blade, tempSword.handle), Combine(tempSword.guard, tempSword.pommel)) );

            latest1.Image = Scale(tempSword.blade, tempSword.Frame * 10, tempSword.Frame * 10);
            latest2.Image = Scale(tempSword.handle, tempSword.Frame * 10, tempSword.Frame * 10);
            latest3.Image = Scale(tempSword.guard, tempSword.Frame * 10, tempSword.Frame * 10);
            latest4.Image = Scale(tempSword.pommel, tempSword.Frame * 10, tempSword.Frame * 10);
            latest5.Image = Scale(tempSword.decor, tempSword.Frame * 10, tempSword.Frame * 10);

            layer0.Refresh();

            //у каждой позиции максимум 62 варианта!
            tempSword.resourcepack_code = EndodeTexturePath(ids);
            //VariationId.Text = "" + MeasureId(tempSword.resourcepack_code);
            Code2.Text = "" + (tempSword.resourcepack_code);
            //CountAllVariety().ToString()+" ok "; 
            //Всего доступно суммарно 916 132 832 варианта текстуры



            textBox2.Text = textBox1.Text + tempSword.resourcepack_code;
        }

        private void StartSaving(object sender, EventArgs e)
        {
            FolderBro.ShowDialog();
        }
    }

    //TODO history
    struct sword
    {
        public Bitmap blade;
        public Bitmap handle;
        public Bitmap guard;
        public Bitmap pommel;
        public Bitmap decor;

        public int Frame; //32 | 64

        public string resourcepack_code;
        public string name;

    }
}

using System.Timers;
using System;

namespace tetris_questionMark_
{
    public partial class Form1 : Form
    {
        Graphics g;
        Shape shape;
        static int gridSize = 43;
        public static int[,] occupiedGrid = new int[10, 20];
        static int[,] coords = new int[10, 20];
        static int NormalTimer = 500;
        static int totalShapes = 0;
        static int points = 0;
        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private static int totalTime = 0;
        private static int Next_rnd = 0;
        private static int Current_rnd = 0;

        private static System.Timers.Timer aTimer;


        public Form1()
        {
            this.Load += Form1_Load;

            InitializeComponent();       

            init();

            timer = timer1;

            setNormalTimer();

            Current_rnd = initRndShapes();



        }

        public void init()
        {
            setScore();
            shape = generateShape();
            shape.createShape();
            Shape.turn = 1;
        }


   


            private void Form1_Paint(object sender, PaintEventArgs e)
        {          
        }


        private int[,] OccupyGrid(int[,] cords)
        {
            for (int i = 0; i < 4; i++)
            {
                occupiedGrid[cords[i,0], cords[i,1]] = 1;
            }
            return occupiedGrid;
        }
     
        private void drawShape(int[,] coords)
        {
            g = CreateGraphics();
            Bitmap bmp = new Bitmap(GridPictureBox.Width, GridPictureBox.Height);
            Graphics graph = Graphics.FromImage(bmp);
            SolidBrush cellBrush = new SolidBrush(Color.FromArgb(240, 230, 140));
            
            
            graph.FillRectangle(cellBrush, coords[0, 0] * gridSize, coords[0, 1] * gridSize, gridSize, gridSize);
            graph.FillRectangle(cellBrush, coords[1, 0] * gridSize, coords[1, 1] * gridSize, gridSize, gridSize);
            graph.FillRectangle(cellBrush, coords[2, 0] * gridSize, coords[2, 1] * gridSize, gridSize, gridSize);
            graph.FillRectangle(cellBrush, coords[3, 0] * gridSize, coords[3, 1] * gridSize, gridSize, gridSize);

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (occupiedGrid[x, y] == 1)
                    {
                        graph.FillRectangle(cellBrush,x * gridSize, (y) * gridSize, gridSize, gridSize);
                    }
                }
            }


            GridPictureBox.Image = bmp;
            cellBrush.Dispose();
            graph.Dispose();
        }

        private void DrawLoseScreen( object sender, PaintEventArgs e)
        {
            Thread.Sleep(5000);
            g = CreateGraphics();
            g.Clear(Color.Aqua);

            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            string drawString = "YOU LOX";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 150.0F;
            float y = 50.0F;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
            g.Dispose();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)1092://a
                    coords = shape.MoveLeft(coords);
                    drawShape(coords);
                    break;
                case (char)1074://d
                    coords = shape.MoveRight(coords);
                    drawShape(coords);
                    break;               
                case (char)1094://w
                    coords = shape.rotateShape(coords,occupiedGrid);
                    drawShape(coords);
                    break;
                case (char)1099://s
                    drawShape(coords);
                    timer1.Interval = 1;
                    break;
            }
    }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)//Главный метод
        {


            setTimeLabel();
            
            setNormalTimer();//Фиксация таймера для возможности последовательного ускорения времени в будущем

            if (shape.ifDefeated(occupiedGrid))
            {
                Thread.Sleep(20000);
            }//В случае поражение

            int[,] timeVar = occupiedGrid.Clone() as int[,];


            
            occupiedGrid = shape.ifFallen(coords, occupiedGrid);

            if (Utils.Compare(timeVar, occupiedGrid))//Проверка фигуры на падение
            {
            }
            else
            {
                cutLine(occupiedGrid);//Срезание заполненных слоев
                init();
            }//Эта система позволяет фигурам падать и оставаться лежать
            shape.Fall(coords,occupiedGrid);
            

            drawShape(coords);//Отрисовка

            
        }

        private void setPreview(int i)
        {
            switch(i)
            {
                case (0):
                    preview_label.Image = Image.FromFile("C:/Users/Max/Мои документы/tetrisProject/L.png");
                    break;
                case (1):
                    preview_label.Image = Image.FromFile("C:/Users/Max/Мои документы/tetrisProject/I.png");
                    break;
                case (2):
                    preview_label.Image = Image.FromFile("C:/Users/Max/Мои документы/tetrisProject/D.png");
                    break;
                case (3):
                    preview_label.Image = Image.FromFile("C:/Users/Max/Мои документы/tetrisProject/O.png");
                    break;
                case (4):
                    preview_label.Image = Image.FromFile("C:/Users/Max/Мои документы/tetrisProject/J.png");
                    break;
                case (5):
                    preview_label.Image = Image.FromFile("C:/Users/Max/Мои документы/tetrisProject/N.png");
                    break;
                case (6):
                    preview_label.Image = Image.FromFile("C:/Users/Max/Мои документы/tetrisProject/M.png");
                    break;
            }
        }

        private static string convertTime(float time)
        {
            string result = "";
            if (time % 60 < 10)
            {
                result = (time - time % 60) / 60 + ":0" + time % 60;
            } else
            {
                result = (time - time % 60) / 60 + ":" + time % 60;
            }
            
                
           

            return result;
        }

        private void setTimeLabel(int time = 0)
        {
            if(time != 0)
            {
                timeLabel.Text = "__:__";
            } else
            {
                timeLabel.Text = convertTime(totalTime);               
            }
            
        }

        public static void activateTimer()
        {
            timer.Interval =1;
        }

        private void setScore()
        {
            score_label.Text = points.ToString();
        }

        private int initRndShapes()
        {
            Random random = new Random();
            return random.Next(0, 7);
        }

        private Shape generateShape()//Создание новых фигур
        {
            Current_rnd = Next_rnd;

            Shape[] shapes = new Shape[7];
            shapes[0] = new LShape();
            shapes[1] = new IShape();
            shapes[2] = new DShape();
            shapes[3] = new OShape();
            shapes[4] = new JShape();
            shapes[5] = new NShape();
            shapes[6] = new MShape();

            Random random = new Random();

            Next_rnd = random.Next(0,7);


            shape = shapes[Current_rnd];
            Shape.isShapeDead = false;
            coords = shape.createShape();
            totalShapes++;
            setPreview(Next_rnd);
            return shape;



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void setNormalTimer(int time = 999999999)
        {
            if (NormalTimer > 250)
            {
                NormalTimer = 500 - totalShapes * 2;
            }
            else if (NormalTimer > 100)
            {
                NormalTimer -= 100 - totalShapes * 1;
            }
            else if (NormalTimer <= 100) 
            {
                NormalTimer = 100;
            }
            if(time != 999999999)
            {
                timer1.Interval = time; 
            } else
            {
                timer1.Interval = NormalTimer;
            }          
        }


        private void debug(int[,] occupiedGrid,int lines)
        {
            for(int y = 19; y > -1;y--)
            {
                if(lines == 0)
                {
                    break;
                }
                for(int x = 9;x > -1;x--)
                {
                    occupiedGrid[x, y] = 1;
                }
                lines--;
            }
        }
        private int[,] cutLine(int[,] occupiedGrid)
        {
            int[] line = new int[4] {-1,-1,-1,-1};
            int lineCount = 0;
            int timeVar = 0;
            int additionalPoint = 200;
            int X = 9;
            int Y = 19;
            while (Y>=0)
            {
                while(X>=0)
                {
                    if (occupiedGrid[X, Y] == 1)
                    {
                        timeVar++;
                    }
                    if (timeVar == 10)
                    {
                        line[lineCount] = Y;
                        lineCount++;
                    }
                    X--;
                }
                X = 9;
                timeVar = 0;
                Y--;
            }
            int upperLine = line[0];
            foreach (int i in line)
            {
                if(i == -1)
                {
                    break;
                }
                if (i < upperLine)
                {
                    upperLine = i;
                }
                points += 400;
                for(int _X = 9; _X > -1; _X--)
                {
                    occupiedGrid[_X, i] = 0;
                }
            }
            
            for(int y = upperLine;y >-1; y--)
            {
                 for(int x = 0; x < 9;x++)
                {
                    if (occupiedGrid[x,y] == 1)
                    {
                        occupiedGrid[x, y] = 0;
                        occupiedGrid[x, y + lineCount] = 1;
                    }
                }
            }
            
            if (lineCount == 2)
            {
                points += additionalPoint;
            }
            if (lineCount == 3)
            {
                points += additionalPoint * 2;
            }
            if (lineCount == 4)
            {
                points += additionalPoint * 3;
            }
            return occupiedGrid;
        }

        private void TimerUpdate(object sender, EventArgs e)
        {
            totalTime++;
        }
    }
}
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private const float ballRadius = 40f; 
        private float mass1, mass2;
        private PointF position1, position2;
        private PointF velocity1, velocity2;
        private SizeF containerSize;
        private Label txtBox1,txtBox2,txtBox3,txtBox4,txtBox5,txtBox6,txtBox7,txtBox8;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true; 
            InitializeSimulation();
        }

        private void InitializeSimulation()
        {
            timer = new Timer();
            timer.Interval = 16;
            timer.Tick += UpdateSimulation;
            timer.Start();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Чтение пользовательского ввода
            if (float.TryParse(txtMass1.Text, out mass1) &&
                float.TryParse(txtMass2.Text, out mass2) &&
                float.TryParse(txtSpeed1.Text, out float speed1) &&
                float.TryParse(txtSpeed2.Text, out float speed2) &&
                float.TryParse(txtAngle1.Text, out float angle1) &&
                float.TryParse(txtAngle2.Text, out float angle2) &&
                float.TryParse(txtContainerWidth.Text, out float containerWidth) &&
                float.TryParse(txtContainerHeight.Text, out float containerHeight))
            {
                // Конвертация углов в радианы
                angle1 = angle1 * (float)Math.PI / 180f;
                angle2 = angle2 * (float)Math.PI / 180f;

                // Инициализация начальных скоростей
                velocity1 = new PointF(speed1 * (float)Math.Cos(angle1), speed1 * (float)Math.Sin(angle1));
                velocity2 = new PointF(speed2 * (float)Math.Cos(angle2), speed2 * (float)Math.Sin(angle2));

                // Начальные позиции
                position1 = new PointF(100, 100);
                position2 = new PointF(300, 300);

                // Установка размеров контейнера
                containerSize = new SizeF(containerWidth, containerHeight);
                ClientSize = new Size((int)containerWidth, (int)containerHeight);
            }
            else
            {
                MessageBox.Show("Введите корректные значения.");
            }
        }

        private void UpdateSimulation(object sender, EventArgs e)
        {
            // Обновление позиции шариков
            position1.X += velocity1.X;
            position1.Y += velocity1.Y;
            position2.X += velocity2.X;
            position2.Y += velocity2.Y;

            // Проверка столкновения с границами
            HandleWallCollision(ref position1, ref velocity1);
            HandleWallCollision(ref position2, ref velocity2);

            // Проверка столкновения между шариками
            HandleBallCollision();

            Invalidate(); // Перерисовка формы
        }

        private void HandleWallCollision(ref PointF position, ref PointF velocity)
        {
            // Проверка столкновения с вертикальными границами
            if (position.X - ballRadius < 0 || position.X + ballRadius > containerSize.Width)
            {
                velocity.X = -velocity.X; // Меняем направление по X
            }

            // Проверка столкновения с горизонтальными границами
            if (position.Y - ballRadius < 0 || position.Y + ballRadius > containerSize.Height)
            {
                velocity.Y = -velocity.Y; // Меняем направление по Y
            }
        }

        private void HandleBallCollision()
        {
            float dx = position2.X - position1.X;
            float dy = position2.Y - position1.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance < 2 * ballRadius) // Если произошло столкновение
            {
                // Нормализация вектора столкновения
                float nx = dx / distance;
                float ny = dy / distance;

                // Проекции скоростей на нормаль
                float p1 = velocity1.X * nx + velocity1.Y * ny;
                float p2 = velocity2.X * nx + velocity2.Y * ny;

                // Обмен скоростями
                float optimizedP = (2 * (p1 - p2)) / (mass1 + mass2);
                velocity1.X -= optimizedP * mass2 * nx;
                velocity1.Y -= optimizedP * mass2 * ny;
                velocity2.X += optimizedP * mass1 * nx;
                velocity2.Y += optimizedP * mass1 * ny;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Рисование границ контейнера
            g.DrawRectangle(Pens.Black, 0, 0, containerSize.Width - 10, containerSize.Height - 10);
            //g.FillRectangle();

            // Рисование шариков
            g.FillEllipse(Brushes.Indigo, position1.X - ballRadius, position1.Y - ballRadius, 2 * ballRadius, 2 * ballRadius);
            g.FillEllipse(Brushes.Lime, position2.X - ballRadius, position2.Y - ballRadius, 2 * ballRadius, 2 * ballRadius);
        }
    }
}

using System; 
using System.Drawing;


namespace lab6
{
    class Particle
    {
        public int Radius;
        public float X;
        public float Y;
        public float SpeedX;
        public float SpeedY;
        public float Life;
        public Color Color; // Цвет частицы из Drawing

        public static Random rand = new Random();

        public Particle()
        {
            Radius = 2 + rand.Next(5);//Генерирует случайное число от 0 до 4
            Life = 20 + rand.Next(80);

            // Случайное направление и скорость (падение вниз)
            //NextDouble() случайное число с плавающей точкой от 0.0 до 1.0
            //делаем отклонение Math.PI / 4
            double direction = Math.PI / 2 + (rand.NextDouble() - 0.5) * Math.PI / 4; // Падение вниз с небольшим разбросом
            float speed = 1 + rand.Next(3);

            SpeedX = (float)(Math.Cos(direction) * speed); //горизонтальная скорость
            SpeedY = (float)(Math.Sin(direction) * speed); //вертикальная скорость
        }

        public virtual void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);//кисть SolidBrush с цветом Color (цвет частицы).
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }


        // Класс для цветных частиц 
        public class ParticleColorful : Particle
        {
            public Color FromColor { get; //для чтения значения
                set; } //для установки значения
            public Color ToColor { get; set; }//конечный цвет частицы
            public float TransitionProgress { get; set; } = 0; // Прогресс перехода

            public override void Draw(Graphics g)
            {
                // Используем TransitionProgress для плавного перехода между FromColor и ToColor
                Color = MixColor(FromColor, ToColor, TransitionProgress);
                base.Draw(g);
            }

            public static Color MixColor(Color color1, Color color2, float k) //смешивает 2 цвета
            {
                return Color.FromArgb(
                    (int)(color2.A * k + color1.A * (1 - k)),// альфа-канал (прозрачность)
                    (int)(color2.R * k + color1.R * (1 - k)),//красный канал
                    (int)(color2.G * k + color1.G * (1 - k)), //зеленый канал
                    (int)(color2.B * k + color1.B * (1 - k)) //синий канал
                );
            }
        } }

        // Класс для точек перекрашивания
        public class RepaintPoint
        {
            public float X { get; set; } //координаты точки перекрашивания
            public float Y { get; set; }
            public int Radius { get; set; }
            public Color BorderColor { get; set; } // Цвет границы

            public void Render(Graphics g)
            {
                // Отрисовка только контура окружности
                g.DrawEllipse(new Pen(BorderColor, 2), X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }
        }
    }


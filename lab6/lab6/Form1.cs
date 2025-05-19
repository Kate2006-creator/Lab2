using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1: Form
    {

        Emitter emitter;
        List<RepaintPoint> repaintPoints = new List<RepaintPoint>(); // Список точек перекрашивания
        Random rand = new Random();
        List<Color> rainbowPalette = new List<Color>(); // Радужная палитра
        List<Color> initialColors = new List<Color>() // Список начальных цветов
        {
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.LightBlue,
            Color.Blue,
            Color.Purple
        };

        public Form1()
        {
            InitializeComponent();

            //создает новое пустое изображение
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            emitter = new Emitter
            {
                X = picDisplay.Width / 2,
                Y = 50, // Частицы сверху
                Width = picDisplay.Width,
                ColorFrom = Color.White, // Изначально белые
                ColorTo = Color.White 
            };

            // Создаем точки перекрашивания
            int numPoints = 7;
            float spacing = 80; // Расстояние между точками
            float startX = picDisplay.Width / 2 - (numPoints - 1) * spacing / 2;

            for (int i = 0; i < numPoints; i++)
            {
                RepaintPoint point = new RepaintPoint
                {
                    X = startX + i * spacing,
                    Y = picDisplay.Height / 2,
                    Radius = 30
                };
                repaintPoints.Add(point);
                emitter.RepaintPoints.Add(point);
            }

            // Назначаем начальные цвета точкам перекрашивания
            for (int i = 0; i < repaintPoints.Count; i++)
            {
                //поочередно присваиваем точкам перекрашивания радужные цвета через остаток от деления
                repaintPoints[i].BorderColor = initialColors[i % initialColors.Count];
            }

            // Инициализируем TrackBar'ы
            InitializeTrackBars();

            // Создаем радужную палитру, исключая начальные цвета
            GenerateRainbowPalette();

            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        { // Меняем цвета границ точек на случайные из радужной палитры, избегая повторений
            List<Color> availableColors = new List<Color>(rainbowPalette); // Создаем копию палитры

            for (int i = 0; i < repaintPoints.Count; i++)
            {
                // Если остался только один цвет, используем его
                if (availableColors.Count == 1)
                {
                    repaintPoints[i].BorderColor = availableColors[0];
                    availableColors.RemoveAt(0);
                    break;
                }

                // Выбираем случайный цвет из доступных
                int randomIndex = rand.Next(availableColors.Count);
                repaintPoints[i].BorderColor = availableColors[randomIndex];
                availableColors.RemoveAt(randomIndex); // Удаляем использованный цвет из доступных
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            //гарантирует, что объект, созданный внутри скобок,
            //будет правильно освобожден после использования

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }

            picDisplay.Invalidate(); //заставляет перерисовать себя
        }


        // Привязываем TrackBar'ы к точкам перекрашивания через Tag
        // Связываем trackBar1 с первой точкой (индекс 0)
        //Tag используется для хранения произвольных данных, связанных с элементом управления
        private void InitializeTrackBars()
        {
            // Создаем список TrackBar'ов
            List<TrackBar> trackBars = new List<TrackBar> { trackBar1, trackBar2, trackBar3, trackBar4, trackBar5, trackBar6, trackBar7 };

            // Привязываем Tag и Scroll через цикл
            for (int i = 0; i < trackBars.Count; i++)
            {
                trackBars[i].Tag = i; // Связываем TrackBar с соответствующей точкой (индекс i)
                trackBars[i].Scroll += TrackBar_Scroll;
            }
        }
        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            // Общий обработчик для всех TrackBar'ов
            TrackBar trackBar = (TrackBar)sender; 
            int index = (int)trackBar.Tag; // Получаем индекс точки
            repaintPoints[index].Radius = trackBar.Value; // Обновляем радиус точки
        }



        private void GenerateRainbowPalette()
        {
            rainbowPalette.Clear();
            int numColors = 3600; // Увеличиваем количество цветов для большей вариативности
            for (int i = 0; i < numColors; i++)
            {
                //вычисляем оттенок: i превращаем в float
                float hue = (float)i / numColors * 360;

                //HSBColor(оттенок, saturation (насыщенность), Brightness (яркость)
                HSBColor hsbColor = new HSBColor(hue, 1, 1); // Насыщенность и яркость на максимум


                // Исключаем цвета, которые уже используются в initialColors
                // цвет из формата HSB в формат RGB (структура Color в C#).
                Color color = hsbColor.ToColor();
                if (!initialColors.Contains(color)) //если не содержится
                {
                    rainbowPalette.Add(color); //то добавляем
                }
            }

            
        }

        // Вспомогательный класс для работы с HSB (HSV) цветами
        //представления цвета в формате HSB (Hue, Saturation, Brightness).
        public class HSBColor
        {
            private float h, s, b;

            public HSBColor(float h, float s, float b)
            {
                this.h = h;
                this.s = s;
                this.b = b;
            }

            public Color ToColor()
            {
                if (s == 0) //если насыщенность ноль
                {
            //каждый цветовой канал (красный, зеленый, синий)
            //в структуре Color представляется целым числом в диапазоне от 0 до 255
                    int v = (int)(b * 255);
                    return Color.FromArgb(v, v, v); //возврашаем оттенок серого
                }

                float hh = h;
                if (hh >= 3600) hh = 0; //Если оттенок больше или равен 360 (градусам), то устанавливает его в 0
                //нужно, чтобы гарантировать, что оттенок находится в допустимом диапазоне (от 0 до 3599).
                hh /= 60;

                int i = (int)hh; //Получает целочисленную часть от оттенка
               //значение i определяет, в каком секторе цветового круга находится оттенок.
                
                float ff = hh - i;//дробная часть от оттенка
                 //ff представляет собой положение оттенка внутри текущего сектора
                
                float p = b * (1 - s); //базовое значение, которое будет использоваться для одного из цветовых каналов (R, G или B)
                float q = b * (1 - s * ff); //для другого цветового канала
                //учитывает не только яркость и насыщенность, но и положение оттенка (hue)

                //чем ближе оттенок к границе сектора, тем сильнее влияние ff
                
                float t = b * (1 - s * (1 - ff));
                //учитывает яркость, насыщенность и положение оттенка внутри сектора

                switch (i)
                {
                    case 0: return Color.FromArgb((int)(b * 255), (int)(t * 255), (int)(p * 255)); //красный сектор
                    case 1: return Color.FromArgb((int)(q * 255), (int)(b * 255), (int)(p * 255)); //желтый сектор
                    case 2: return Color.FromArgb((int)(p * 255), (int)(b * 255), (int)(t * 255)); //зеленый
                    case 3: return Color.FromArgb((int)(p * 255), (int)(q * 255), (int)(b * 255)); //голубой
                    case 4: return Color.FromArgb((int)(t * 255), (int)(p * 255), (int)(b * 255)); //синий
                    default: return Color.FromArgb((int)(b * 255), (int)(p * 255), (int)(q * 255)); //фиолетовый
                }
            }
        }
    }
}





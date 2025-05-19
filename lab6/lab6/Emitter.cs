using System;
using System.Collections.Generic; //Подключает пространство имен для работы с коллекциями, такими как List<T>.
using System.Drawing;
using static lab6.Particle;

namespace lab6
{
    class Emitter
    {
        public List<Particle> particles = new List<Particle>(); //список частиц которыми будет управлять эмиттер
        public int X; //коорд эмиттера
        public int Y;
        public Color ColorFrom = Color.White;
        public Color ColorTo;
        public int Width;  // Ширина области эмиттера (вся ширина)

        public List<RepaintPoint> RepaintPoints = new List<RepaintPoint>(); //наши круги перекрашивания

        public virtual Particle CreateParticle()//создаём частицу
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom; // Изначально белые
            return particle;
        }

        public virtual void ResetParticle(Particle particle) //пересоздаём частицу, когда умерла
        {
            particle.Life = Particle.rand.Next(20, 100); 
            particle.X = X + Particle.rand.Next(-Width / 2, Width / 2); //по ширине эмиттера
            particle.Y = Y;

            //изн. направл + Spreading (ранд) с приведением типа - делённое/2
            var direction = 90 + (double)Particle.rand.Next(45) - 45 / 2; //в диапазоне от -22 до 22 
            var speed = Particle.rand.Next(1, 5);
             
            //переводим в радианы    X/Y - проекция вектора скорости на ось X    speed - величина вектора скорости
            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed); 
            particle.SpeedY = (float)(Math.Sin(direction / 180 * Math.PI) * speed);
            //доп-но преобразуем в float тк SpeedX имеет тип float

            particle.Radius = Particle.rand.Next(2, 5);
            particle.Color = ColorFrom; // Изначальный цвет
            ((ParticleColorful)particle).FromColor = ColorFrom;
            ((ParticleColorful)particle).ToColor = ColorFrom;
            ((ParticleColorful)particle).TransitionProgress = 0;
        }

        public void UpdateState() //при каждом новом тике
        {
            // сколько частиц на этом тике
            int particlesToCreate = 10;

            foreach (var particle in particles)
            {
                particle.Life -= 1; //уменьшаем время жизни частицы
                if (particle.Life <= 0)
                {
                    ResetParticle(particle); //если истекло, создаем новую
                    particlesToCreate--; //уменьшаем кол-во для создания
                }
                else //если не истекло
                {
                    particle.X += particle.SpeedX; //обновляем координаты частицы
                    particle.Y += particle.SpeedY;

                    ParticleColorful colorfulParticle = (ParticleColorful)particle; 
                    bool inRepaintZone = false; // флаг, находится ли частица в зоне перекрашивания

                    // Проверяем точки перекрашивания
                    foreach (var point in RepaintPoints)
                    {
                        float dx = point.X - particle.X; //разница X координаты частицы и зоны перекрашивания
                        float dy = point.Y - particle.Y;

                        //distance - гипотенуза в прямоуг треуг
                        double distance = Math.Sqrt(dx * dx + dy * dy); //растояние вычисляем

                        if (distance <= point.Radius) //если частица в зоне перекрашивания
                        {
                            inRepaintZone = true; // Частица находится в зоне перекрашивания

                            // Инициируем переход, если это необходимо
                            if (colorfulParticle.ToColor != point.BorderColor) //цвет частицы не явл цветом окружности
                            {
                                colorfulParticle.FromColor = colorfulParticle.Color;
                                colorfulParticle.ToColor = point.BorderColor;
                                colorfulParticle.TransitionProgress = 0; // Начинаем переход заново
                            }
                            break; // Достаточно попасть в одну зону
                        }
                    }

                    // Если частица находится в процессе перехода, продолжаем его
                    if (colorfulParticle.TransitionProgress < 1)
                    {
                        colorfulParticle.TransitionProgress = Math.Min(1, colorfulParticle.TransitionProgress + 0.05f); // 
                        particle.Color = ParticleColorful.MixColor(colorfulParticle.FromColor, colorfulParticle.ToColor, colorfulParticle.TransitionProgress);
                    }
                }
            }

            // Создаем новые частицы, когда нужно
            while (particlesToCreate > 0)
            {
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
                particlesToCreate--;
            }
        }

        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            // Рендерим точки перекрашивания
            foreach (var point in RepaintPoints)
            {
                point.Render(g);
            }
        }
    }
}

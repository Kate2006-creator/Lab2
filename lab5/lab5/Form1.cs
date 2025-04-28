using lab5.Objects;
using System.Drawing;


namespace lab5
{
    public partial class Form1 : Form
    {
        
        List<BaseObject> objects = new();//������ ���� �������� �� �����
        Player player;
        Marker marker;

        private List<Circle> _collectibleCircles = new List<Circle>(); //����� ��� ���������� �����
        private int score = 0;
        private Random rand = new Random();



        public Form1()
        {
            InitializeComponent();
            player = new Player(pbMain.Width / 2, pbMain.Height / 2, 0);


            //������� ����� ������ ������
            player.OnCollectibleCircleOverlap += (circle) =>
            {
                score += 10; // ���� 10 ����� �� ������
                UpdateScoreLabel();
                RemoveCollectibleCircle(circle); // ������� ������
                AddCollectibleCircle(); // ��������� ����� ������ �� ����
            };

            //������� ����� ��������� � ��� ����� � ������
            player.OnOverlap += (p, obj) =>
            {
                txtLog.Text = $"[{DateTime.Now:HH:mm:ss:ff}] ����� ��������� � {obj}\n" + txtLog.Text;
            };

            //������� ����� ��������� � ��������
            player.OnMarkerOverlap += (m) =>
            {
                objects.Remove(m);//������� ������ �� ������ ��������
                marker = null; 
            };

            marker = new Marker(pbMain.Width / 2 + 50, pbMain.Height / 2 + 50, 0);

            objects.Add(marker);
            objects.Add(player);
            AddCollectibleCircle();
            AddCollectibleCircle();

            // ������� ��������� ���������� �����
            UpdateScoreLabel();
        }

        private void AddCollectibleCircle()
        {
            var circle = new Circle(
                rand.Next(50, pbMain.Width - 50),
                rand.Next(50, pbMain.Height - 50)
            ); //����� ���� �������� ������ pbMain

            // ������� ��������� �������
            circle.OnSizeZero += () =>
            {
                // ���������� ������ � ��������� ����� � ������ ����� ������
                circle.X = rand.Next(50, pbMain.Width - 50);
                circle.Y = rand.Next(50, pbMain.Height - 50);
                circle.Size = rand.Next(20, 40); // ������ ��������� ��������� ������
            };

            _collectibleCircles.Add(circle);
            objects.Add(circle);
        }

        private void RemoveCollectibleCircle(Circle circle)
        {
            _collectibleCircles.Remove(circle);
            objects.Remove(circle);
        }

        private void UpdateScoreLabel()
        {
            scoreLabel.Text = $"����: {score}";
        }

        //����� ���������� ������� Paint � pbMain, �������� ����� pbMain_Paint
        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics; //�������� ������ Graphics ��� ���������

            g.Clear(Color.White);
            updatePlayer();

            foreach (var obj in objects.ToList()) //����� objects ��� ����������� �������� ��������
            {
                if (obj is Circle collectibleCircle) //�������� �� ������� ������ obj ����������� ������ Circle
                {
                    collectibleCircle.Size -= 0.1f; //��������� ������ ������� ������
                }

                if (obj != player && player.Overlaps(obj, g)) //��������� �� ������������ � ������� (�� ������ ����� ������ ��� �� ��� �������)
                {
                    player.Overlap(obj); //���� �����������, �� �������� ����� Overlap 
                    obj.Overlap(player);
                }
            }

            foreach (var obj in objects)
            {
                g.Transform = obj.GetTransform();
                obj.Render(g);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbMain.Invalidate(); //����������� 
        }

        private void updatePlayer()
        {
            if (marker != null) //���� ������ ���������� �� ����
            {
                float dx = marker.X - player.X; //������� ��������� ����� �������� � �������
                float dy = marker.Y - player.Y;
                float length = MathF.Sqrt(dx * dx + dy * dy); //���������� ����� �������� � �������
                dx /= length; //����������� ������ ����������� � �������(������ ��� ���������)
                dy /= length;

                player.vX += dx * 0.5f; //���������� �������� ������ �� ��� X � ����������� �������
                player.vY += dy * 0.5f;

                player.Angle = 90 - MathF.Atan2(player.vX, player.vY) * 180 / MathF.PI;//��������� ���� �������� ������
            }

            player.vX += -player.vX * 0.1f; //��������� �������� ������
            player.vY += -player.vY * 0.1f;

            player.X += player.vX;//��������� ������� ������
            player.Y += player.vY;
        }
        
        
        private void pbMain_MouseClick(object sender, MouseEventArgs e)
        {

            if (marker == null)
            {
                marker = new Marker(0, 0, 0); //���� ������� ��� �� ����, �� ����� ��������
                objects.Add(marker);
            }

            marker.X = e.X; //���������� � �� ����� ����
            marker.Y = e.Y;
        }
    }
}

namespace lab4
{
    public partial class Form1 : Form
    {

        List<Plant> plantsList = new List<Plant>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.plantsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.plantsList.Add(Flower.Generate());
                        break;
                    case 1:
                        this.plantsList.Add(Shrub.Generate());
                        break;
                    case 2:
                        this.plantsList.Add(Tree.Generate());
                        break;

                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {

            int flowersCount = 0;
            int shrubsCount = 0;
            int treesCount = 0;

            foreach (var plant in this.plantsList)
            {

                if (plant is Flower)
                {
                    flowersCount += 1;
                }
                else if (plant is Shrub)
                {
                    shrubsCount += 1;
                }
                else if (plant is Tree)
                {
                    treesCount += 1;
                }
            }

            txtInfo.Text = "Цветы\tКустар.\tДеревья";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", flowersCount, shrubsCount, treesCount);

            queue(); 
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.plantsList.Count == 0)
            {
                txtOut.Text = "В автомате пусто!";
                return;
            }
            var plant = this.plantsList[0];

            this.plantsList.RemoveAt(0);


            txtOut.Text = plant.GetInfo();

            ShowInfo();
        }

        private void queue()
        {
            listBoxQueue.Items.Clear();
            foreach (var plant in plantsList)
            {
                string plantType = "";
                if (plant is Flower)
                {
                    plantType = "Цветок";
                }
                else if (plant is Shrub)
                {
                    plantType = "Куст";
                }
                else if (plant is Tree)
                {
                    plantType = "Дерево";
                }
                else
                {
                    plantType = "Растение"; 
                }

                listBoxQueue.Items.Add(plantType); 
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab4
{
    public class Plant
    {
        public int Height = 0;
        public virtual String GetInfo()
        {
            var str = String.Format("\nВысота: {0} см", this.Height);
            return str;
        }

        public static Random rnd = new Random();
    }
    public enum TreeType { conifer, leafy };
    public class Tree: Plant
    { 
        public int Radius = 0; 
        public TreeType type = TreeType.leafy;

        public static Tree Generate()
        {
            return new Tree
            {
                Height = rnd.Next() % 100,
                Radius = 5 + rnd.Next() % 20,
                type = (TreeType)rnd.Next(2)
            };
        }
        public override String GetInfo()
        {
            var str = "Я дерево!";
            str += base.GetInfo();

            str += String.Format("\nРадиус основания: {0}", this.Radius);
            str += String.Format("\nТип дерева: {0}", this.type);

            return str;
        }
    }

    public class Shrub: Plant
    {
        public int BranchAmount = 0;
        public bool HasFlowers = false;

        public static Shrub Generate()
        {
            return new Shrub
            {
                Height = rnd.Next() % 100,
                BranchAmount = 5 + rnd.Next() % 20,
                HasFlowers = rnd.Next() % 2 == 0
            };
        }

        public override String GetInfo()
        {
            var str = "Я кустарник!";
            str += base.GetInfo();

            str += String.Format("\nКоличество веточек: {0}", this.BranchAmount);
            str += String.Format("\nНаличие цветочков: {0}", this.HasFlowers);

            return str;
        }

    }

    public class Flower: Plant
    {
        public int ListAmount = 0;
        public bool IsAnnualFlower = false;

        public static Flower Generate()
        {
            return new Flower
            {
                Height = rnd.Next() % 100,
                ListAmount = 5 + rnd.Next() % 20,
                IsAnnualFlower = rnd.Next() % 2 == 0
            };
        }

        public override String GetInfo()
        {
            var str = "Я цветочек!";
            str += base.GetInfo();

            str += String.Format("\nКоличество листиков: {0}", this.ListAmount);
            str += String.Format("\nОднолетник?: {0}", this.IsAnnualFlower);

            return str;

        }
    }
}
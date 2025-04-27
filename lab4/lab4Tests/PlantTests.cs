using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Tests
{
    [TestClass()]
    public class PlantTests
    {
        [TestMethod]
        public void Tree_Test()
        {
            
            Tree tree = Tree.Generate();
            Assert.IsTrue(tree.Height >= 0 && tree.Height <= 100);
            Assert.IsTrue(tree.Radius >= 5 && tree.Radius <= 25);
            Assert.IsTrue(tree.type == TreeType.conifer || tree.type == TreeType.leafy);
        }

        [TestMethod]
        public void Shrub_Test()
        {
            
            Shrub shrub = Shrub.Generate();
            Assert.IsTrue(shrub.Height >= 0 && shrub.Height <= 100);
            Assert.IsTrue(shrub.BranchAmount >= 5 && shrub.BranchAmount <= 25);
            Assert.IsTrue(shrub.HasFlowers == true || shrub.HasFlowers == false);
        }

        [TestMethod]
        public void Flower_Test()
        {
            
            Flower flower = Flower.Generate();
            Assert.IsTrue(flower.Height >= 0 && flower.Height <= 100);
            Assert.IsTrue(flower.ListAmount >= 5 && flower.ListAmount <= 25);
            Assert.IsTrue(flower.IsAnnualFlower == true || flower.IsAnnualFlower == false);
        }

        [TestMethod]
        public void Tree_GetInfo_Test()
        {
            Tree tree = new Tree { Height = 50, Radius = 10, type = TreeType.conifer };
            string info = tree.GetInfo();
            Assert.IsTrue(info.Contains("Я дерево!"));
            Assert.IsTrue(info.Contains("Высота: 50 см"));
            Assert.IsTrue(info.Contains("Радиус основания: 10"));
            Assert.IsTrue(info.Contains("Тип дерева: conifer"));
        }

    }
}

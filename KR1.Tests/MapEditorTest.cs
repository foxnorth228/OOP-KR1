using NUnit.Framework;
using KR1;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace KR1.Tests
{
    public class MapEditorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KeyPressedTest()
        {
            char[] arr = new char[] { 'a', 'b', 'c' };
            List<char> list = new List<char>(arr);
            Assert.False(MapEditor.KeyPressed('a', list));
            Assert.True(MapEditor.KeyPressed('d', list));
            Assert.True(MapEditor.KeyPressed('a', null));
        }

        [Test]
        public void BorderChangedTest()
        {
            Assert.AreEqual(MapEditor.BorderChanged("5", 20), "5");
            Assert.AreEqual(MapEditor.BorderChanged("s", 20), "");
            Assert.AreEqual(MapEditor.BorderChanged("21", 20), "20");
        }

        [Test]
        public void CreateBorderTest()
        {
            Assert.AreEqual(MapEditor.CreateBorder(1, "5", 20), 5);
            Assert.AreEqual(MapEditor.CreateBorder(1, "21", 20), 20);
            Assert.AreEqual(MapEditor.CreateBorder(1, "", 20), 1);
            Assert.Throws<ArgumentException>(() => MapEditor.CreateBorder(1, "ss", 20));
        }

        [Test]
        public void IsAllowedCombTest()
        {
            void CellSampleFuncTest(object sender, EventArgs e)
            {

            }
            Image grassImage = Properties.Resources.grass;
            Image groundImage = Properties.Resources.ground;
            Image sandImage = Properties.Resources.sand;
            Image waterImage = Properties.Resources.water;
            Image bridgeImage = Properties.Resources.bridge;

            Image noneImage = Properties.Resources.noneM;
            Image mountImage = Properties.Resources.mountM;
            Image treeImage = Properties.Resources.treeM;
            Image houseImage = Properties.Resources.houseM;
            Image animalImage = Properties.Resources.animalM;

            Modificator modNone = new Modificator(null);
            Modificator modTree = new Modificator(Properties.Resources.tree);
            Modificator modMount = new Modificator(Properties.Resources.mount);
            Modificator modHouse = new Modificator(Properties.Resources.house);
            Modificator modAnimal = new Modificator(Properties.Resources.animal);

            CellSampleGenerator gen = new CellSampleGenerator(50, CellSampleFuncTest, CellSampleFuncTest, CellSampleFuncTest);
            Bitmap bit = new Bitmap(grassImage);

            CellSample[] cellItems = new CellSample[5]
            {
                gen.GetCellSample(0  , 0, grassImage , false, null, new Modificator[5] { modNone, modTree, modMount, modHouse, modAnimal}),
                gen.GetCellSample(50 , 0, groundImage, false, null, new Modificator[5] { modNone, modTree, modMount, modHouse, modAnimal}),
                gen.GetCellSample(100, 0, sandImage  , false, null, new Modificator[3] { modNone, modHouse, modAnimal }),
                gen.GetCellSample(150, 0, waterImage , false, null, new Modificator[1] { modNone }),
                gen.GetCellSample(200, 0, bridgeImage, false, null, new Modificator[3] { modNone, modHouse, modAnimal})
            };

            CellSample[] cellModItems = new CellSample[5]
            {
                gen.GetCellSample(0  , 0, noneImage  , true, modNone),
                gen.GetCellSample(50 , 0, treeImage  , true, modTree),
                gen.GetCellSample(100, 0, houseImage , true, modHouse),
                gen.GetCellSample(150, 0, mountImage , true, modMount),
                gen.GetCellSample(200, 0, animalImage, true, modAnimal)
            };
            Assert.True(MapEditor.IsAllowedComb(cellItems, el => el.Image == grassImage, cellModItems[0], true));
            Assert.False(MapEditor.IsAllowedComb(cellItems, el => el.Image == waterImage, cellModItems[1], true));
            Assert.True(MapEditor.IsAllowedComb(cellModItems, el => el.mod.image == null, cellItems[2], false));
            Assert.False(MapEditor.IsAllowedComb(cellModItems, el => el.mod.image == modMount.image, cellItems[4], false));
        }
    }
}
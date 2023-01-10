﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KR1
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
            grassImage = Image.FromFile("E:\\oop-kr1-textures\\grass.png");
            groundImage = Image.FromFile("E:\\oop-kr1-textures\\ground.png");
            sandImage = Image.FromFile("E:\\oop-kr1-textures\\sand.png");
            waterImage = Image.FromFile("E:\\oop-kr1-textures\\water.png");
            bridgeImage = Image.FromFile("E:\\oop-kr1-textures\\bridge.png");

            noneImage = Image.FromFile("E:\\oop-kr1-textures\\modifyImage\\none.png");
            mountImage = Image.FromFile("E:\\oop-kr1-textures\\modifyImage\\mount.png");
            treeImage = Image.FromFile("E:\\oop-kr1-textures\\modifyImage\\tree.png");
            houseImage = Image.FromFile("E:\\oop-kr1-textures\\modifyImage\\house.png");
            animalImage = Image.FromFile("E:\\oop-kr1-textures\\modifyImage\\animal.png");

            Modificator modNone = new Modificator(null);
            Modificator modTree = new Modificator(Image.FromFile("E:\\oop-kr1-textures\\tree.png"));
            Modificator modMount = new Modificator(Image.FromFile("E:\\oop-kr1-textures\\mount.png"));
            Modificator modHouse = new Modificator(Image.FromFile("E:\\oop-kr1-textures\\house.png"));
            Modificator modAnimal = new Modificator(Image.FromFile("E:\\oop-kr1-textures\\animal.png"));

            CellSampleGenerator gen = new CellSampleGenerator(50, CellSampleEntered, CellSampleLeft, СellSampleClicked);
            Bitmap bit = new Bitmap(grassImage);

            cellItems = new CellSample[5]
            {
                gen.GetCellSample(0  , 0, grassImage , false, null, new Modificator[5] { modNone, modTree, modMount, modHouse, modAnimal}),
                gen.GetCellSample(50 , 0, groundImage, false, null, new Modificator[5] { modNone, modTree, modMount, modHouse, modAnimal}),
                gen.GetCellSample(100, 0, sandImage  , false, null, new Modificator[3] { modNone, modHouse, modAnimal }),
                gen.GetCellSample(150, 0, waterImage , false, null, new Modificator[1] { modNone }),
                gen.GetCellSample(200, 0, bridgeImage, false, null, new Modificator[3] { modNone, modHouse, modAnimal})
            };
            typeCellMenu.Controls.AddRange(cellItems);

            cellModItems = new CellSample[5]
            {
                gen.GetCellSample(0  , 0, noneImage  , true, modNone),
                gen.GetCellSample(50 , 0, treeImage  , true, modTree),
                gen.GetCellSample(100, 0, houseImage , true, modHouse),
                gen.GetCellSample(150, 0, mountImage , true, modMount),
                gen.GetCellSample(200, 0, animalImage, true, modAnimal)
            };
            typeModifyMenu.Controls.AddRange(cellModItems);

            selectImage = grassImage;
            activeCell.SizeMode = PictureBoxSizeMode.StretchImage;
            activeCell.Image = grassImage;

            selectModify = null;
            activeModify.SizeMode = PictureBoxSizeMode.StretchImage;
            activeModify.Image = noneImage;
        }

        private void WidthKeyPressed(object sender, KeyPressEventArgs e)
        {
            char[] allowArr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', (char)Keys.Delete, (char)Keys.Back };
            List<char> allow = new List<char>(allowArr);
            e.Handled = MapEditor.KeyPressed(e.KeyChar, allow);
        }

        private void WidthTextChanged(object sender, EventArgs e)
        {
            widthBox.Text = MapEditor.BorderChanged(widthBox.Text, maxSize);
        }

        private void HeightKeyPressed(object sender, KeyPressEventArgs e)
        {
            char[] allowArr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', (char)Keys.Delete, (char)Keys.Back };
            List<char> allow = new List<char>(allowArr);
            e.Handled = MapEditor.KeyPressed(e.KeyChar, allow);
        }

        private void HeightTextChanged(object sender, EventArgs e)
        {
            heightBox.Text = MapEditor.BorderChanged(heightBox.Text, maxSize);
        }

        private void CreateCardClicked(object sender, EventArgs e)
        {
            Size size = playground.Size;
            int width = MapEditor.CreateBorder(1, widthBox.Text, maxSize);
            int height = MapEditor.CreateBorder(1, heightBox.Text, maxSize);
            widthBox.Text = width.ToString();
            heightBox.Text = height.ToString();
            int cellSize = size.Width / width;

            if (isAdded == true)
            {
                return;
            }
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    playground.Controls.Add(new Cell(cellSize * j, cellSize * i, cellSize, selectImage, selectModify, CellClicked));
                }
            }
            isAdded = true;
        }

        private void ClearCardСlicked(object sender, EventArgs e)
        {
            if (isAdded == false)
            {
                return;
            }
            playground.Controls.Clear();
            isAdded = false;
        }

        private void CellClicked(object sender, EventArgs e)
        {
            Cell cell = (Cell)sender;
            cell.Rewrite(selectImage, selectModify);
        }

        private void CellSampleEntered(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(CellSample))
            {
                CellSample a = (CellSample)sender;
                a.BackColor = Color.Blue;
            }
        }
        private void CellSampleLeft(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(CellSample))
            {
                CellSample a = (CellSample)sender;
                a.BackColor = Color.Black;
            }
        }

        private void СellSampleClicked(object sender, EventArgs e)
        {
            CellSample a = (CellSample)sender;
            if (a.isModificator)
            {
                CellSample b = Array.Find(cellItems, el => el.Image == selectImage);
                bool isExist = false;
                for (int i = 0; i < b.allowedMods.Length; ++i)
                {
                    if (b.allowedMods[i] == a.mod)
                    {
                        isExist = true;
                    }
                }
                if (isExist)
                {
                    selectModify = a.mod.image;
                    activeModify.Image = a.Image;
                }
            }
            else
            {
                CellSample b = Array.Find(cellModItems, el => el.mod.image == selectModify);
                bool isExist = false;
                for (int i = 0; i < a.allowedMods.Length; ++i)
                {
                    if (a.allowedMods[i] == b.mod)
                    {
                        isExist = true;
                    }
                }
                if (isExist)
                {
                    selectImage = a.Image;
                    activeCell.Image = a.Image;
                }
            }
        }
    }
}

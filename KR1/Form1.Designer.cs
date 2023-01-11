
using System.Windows.Forms;
using System.Drawing;

namespace KR1
{
    partial class Editor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.Panel();
            this.activeCell = new System.Windows.Forms.PictureBox();
            this.activeModify = new System.Windows.Forms.PictureBox();
            this.typeModifyMenu = new System.Windows.Forms.Panel();
            this.typeCellMenu = new System.Windows.Forms.Panel();
            this.clearCard = new System.Windows.Forms.Button();
            this.createCard = new System.Windows.Forms.Button();
            this.heightName = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthName = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.playground = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeModify)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu.Controls.Add(this.activeCell);
            this.menu.Controls.Add(this.activeModify);
            this.menu.Controls.Add(this.typeModifyMenu);
            this.menu.Controls.Add(this.typeCellMenu);
            this.menu.Controls.Add(this.clearCard);
            this.menu.Controls.Add(this.createCard);
            this.menu.Controls.Add(this.heightName);
            this.menu.Controls.Add(this.heightBox);
            this.menu.Controls.Add(this.widthName);
            this.menu.Controls.Add(this.widthBox);
            this.menu.Location = new System.Drawing.Point(14, 14);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(356, 758);
            this.menu.TabIndex = 0;
            // 
            // activeCell
            // 
            this.activeCell.Location = new System.Drawing.Point(38, 570);
            this.activeCell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.activeCell.Name = "activeCell";
            this.activeCell.Size = new System.Drawing.Size(88, 87);
            this.activeCell.TabIndex = 5;
            this.activeCell.TabStop = false;
            // 
            // activeModify
            // 
            this.activeModify.Location = new System.Drawing.Point(224, 570);
            this.activeModify.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.activeModify.Name = "activeModify";
            this.activeModify.Size = new System.Drawing.Size(88, 87);
            this.activeModify.TabIndex = 2;
            this.activeModify.TabStop = false;
            // 
            // typeModifyMenu
            // 
            this.typeModifyMenu.Location = new System.Drawing.Point(22, 368);
            this.typeModifyMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.typeModifyMenu.Name = "typeModifyMenu";
            this.typeModifyMenu.Size = new System.Drawing.Size(292, 115);
            this.typeModifyMenu.TabIndex = 4;
            // 
            // typeCellMenu
            // 
            this.typeCellMenu.Location = new System.Drawing.Point(22, 174);
            this.typeCellMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.typeCellMenu.Name = "typeCellMenu";
            this.typeCellMenu.Size = new System.Drawing.Size(292, 115);
            this.typeCellMenu.TabIndex = 2;
            // 
            // clearCard
            // 
            this.clearCard.Location = new System.Drawing.Point(224, 118);
            this.clearCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearCard.Name = "clearCard";
            this.clearCard.Size = new System.Drawing.Size(88, 27);
            this.clearCard.TabIndex = 2;
            this.clearCard.Text = "Clear";
            this.clearCard.UseVisualStyleBackColor = true;
            this.clearCard.Click += new System.EventHandler(this.ClearCardСlicked);
            // 
            // createCard
            // 
            this.createCard.Location = new System.Drawing.Point(38, 118);
            this.createCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createCard.Name = "createCard";
            this.createCard.Size = new System.Drawing.Size(88, 27);
            this.createCard.TabIndex = 2;
            this.createCard.Text = "Create";
            this.createCard.UseVisualStyleBackColor = true;
            this.createCard.Click += new System.EventHandler(this.CreateCardClicked);
            // 
            // heightName
            // 
            this.heightName.AutoSize = true;
            this.heightName.Location = new System.Drawing.Point(247, 36);
            this.heightName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightName.Name = "heightName";
            this.heightName.Size = new System.Drawing.Size(43, 15);
            this.heightName.TabIndex = 3;
            this.heightName.Text = "Height";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(208, 65);
            this.heightBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(116, 23);
            this.heightBox.TabIndex = 1;
            this.heightBox.TextChanged += new System.EventHandler(this.HeightTextChanged);
            this.heightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightKeyPressed);
            // 
            // widthName
            // 
            this.widthName.AutoSize = true;
            this.widthName.Location = new System.Drawing.Point(62, 36);
            this.widthName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthName.Name = "widthName";
            this.widthName.Size = new System.Drawing.Size(39, 15);
            this.widthName.TabIndex = 2;
            this.widthName.Text = "Width";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(22, 65);
            this.widthBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(116, 23);
            this.widthBox.TabIndex = 0;
            this.widthBox.TextChanged += new System.EventHandler(this.WidthTextChanged);
            this.widthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthKeyPressed);
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.SystemColors.ControlDark;
            this.playground.Location = new System.Drawing.Point(694, 14);
            this.playground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(766, 758);
            this.playground.TabIndex = 1;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 786);
            this.Controls.Add(this.playground);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Editor";
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeModify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menu;
        private Panel playground;
        private Panel typeModifyMenu;
        private Panel typeCellMenu;
        private TextBox heightBox;
        private TextBox widthBox;
        private Label heightName;
        private Label widthName;
        private Button createCard;
        private Button clearCard;

        private bool isAdded = false;
        private int maxSize = 20;
        private static Image grassImage;
        private static Image groundImage;
        private static Image sandImage;
        private static Image bridgeImage;
        private static Image waterImage;
        private static CellSample[] cellItems;
        private static CellSample[] cellModItems;

        private static Image noneImage;
        private static Image mountImage;
        private static Image treeImage;
        private static Image houseImage;
        private static Image animalImage;
        private Image selectImage;
        private PictureBox activeCell;
        private Image selectModify;
        private PictureBox activeModify;
    }
}
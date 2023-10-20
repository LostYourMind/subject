namespace 팀과제.UI
{
    partial class Menu_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.basket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu_list = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drink_view = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Side_view = new System.Windows.Forms.ListView();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // basket
            // 
            this.basket.BackColor = System.Drawing.Color.White;
            this.basket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basket.BackgroundImage")));
            this.basket.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.basket.Location = new System.Drawing.Point(22, 270);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(62, 58);
            this.basket.TabIndex = 0;
            this.basket.UseVisualStyleBackColor = false;
            this.basket.Click += new System.EventHandler(this.basket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼편지체", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "햄버거";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-38, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "가";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "나";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "다";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "라";
            this.columnHeader4.Width = 175;
            // 
            // Menu_list
            // 
            this.Menu_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Menu_list.HideSelection = false;
            this.Menu_list.LargeImageList = this.imageList1;
            this.Menu_list.Location = new System.Drawing.Point(113, 40);
            this.Menu_list.Name = "Menu_list";
            this.Menu_list.Size = new System.Drawing.Size(1485, 640);
            this.Menu_list.SmallImageList = this.imageList1;
            this.Menu_list.TabIndex = 2;
            this.Menu_list.UseCompatibleStateImageBehavior = false;
            this.Menu_list.Click += new System.EventHandler(this.Menu_list_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "치킨버거.bmp");
            this.imageList1.Images.SetKeyName(1, "새우버거.bmp");
            this.imageList1.Images.SetKeyName(2, "치즈버거.bmp");
            this.imageList1.Images.SetKeyName(3, "불고기버거.bmp");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(7)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.basket);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 679);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼편지체", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "사이드";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼편지체", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "음료수";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(7)))), ((int)(((byte)(24)))));
            this.label3.Font = new System.Drawing.Font("휴먼편지체", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(119, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "❊ 클릭시 장바구니에 자동으로 담김 ❊";
            // 
            // drink_view
            // 
            this.drink_view.HideSelection = false;
            this.drink_view.LargeImageList = this.imageList2;
            this.drink_view.Location = new System.Drawing.Point(113, 40);
            this.drink_view.Name = "drink_view";
            this.drink_view.Size = new System.Drawing.Size(1485, 640);
            this.drink_view.SmallImageList = this.imageList2;
            this.drink_view.TabIndex = 4;
            this.drink_view.UseCompatibleStateImageBehavior = false;
            this.drink_view.SelectedIndexChanged += new System.EventHandler(this.drink_view_SelectedIndexChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "사이다.bmp");
            this.imageList2.Images.SetKeyName(1, "콜라.bmp");
            this.imageList2.Images.SetKeyName(2, "아메리카노.bmp");
            // 
            // Side_view
            // 
            this.Side_view.HideSelection = false;
            this.Side_view.LargeImageList = this.imageList3;
            this.Side_view.Location = new System.Drawing.Point(113, 40);
            this.Side_view.Name = "Side_view";
            this.Side_view.Size = new System.Drawing.Size(1485, 640);
            this.Side_view.SmallImageList = this.imageList2;
            this.Side_view.TabIndex = 11;
            this.Side_view.UseCompatibleStateImageBehavior = false;
            this.Side_view.SelectedIndexChanged += new System.EventHandler(this.Side_view_SelectedIndexChanged);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "콘샐러드.bmp");
            this.imageList3.Images.SetKeyName(1, "감자튀김.bmp");
            this.imageList3.Images.SetKeyName(2, "치즈볼.bmp");
            this.imageList3.Images.SetKeyName(3, "치킨.bmp");
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1613, 675);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu_list);
            this.Controls.Add(this.drink_view);
            this.Controls.Add(this.Side_view);
            this.Name = "Menu_Form";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Menu_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button basket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView Menu_list;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView drink_view;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView Side_view;
        private System.Windows.Forms.ImageList imageList3;
    }
}
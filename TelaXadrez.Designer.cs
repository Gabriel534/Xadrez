namespace Xadrez
{
    partial class TelaXadrez
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
            tabuleiro = new PictureBox();
            table = new TableLayoutPanel();
            p8 = new Button();
            p7 = new Button();
            p6 = new Button();
            p5 = new Button();
            p4 = new Button();
            p3 = new Button();
            p2 = new Button();
            p1 = new Button();
            p16 = new Button();
            p15 = new Button();
            p14 = new Button();
            p13 = new Button();
            p12 = new Button();
            p11 = new Button();
            p10 = new Button();
            p9 = new Button();
            p24 = new Button();
            p23 = new Button();
            p22 = new Button();
            p21 = new Button();
            p20 = new Button();
            p19 = new Button();
            p18 = new Button();
            p17 = new Button();
            p32 = new Button();
            p31 = new Button();
            p30 = new Button();
            p29 = new Button();
            p28 = new Button();
            p27 = new Button();
            p26 = new Button();
            p25 = new Button();
            p40 = new Button();
            p39 = new Button();
            p38 = new Button();
            p37 = new Button();
            p36 = new Button();
            p35 = new Button();
            p34 = new Button();
            p33 = new Button();
            p48 = new Button();
            p47 = new Button();
            p46 = new Button();
            p45 = new Button();
            p44 = new Button();
            p43 = new Button();
            p42 = new Button();
            p41 = new Button();
            p56 = new Button();
            p55 = new Button();
            p54 = new Button();
            p53 = new Button();
            p52 = new Button();
            p51 = new Button();
            p50 = new Button();
            p49 = new Button();
            p64 = new Button();
            p63 = new Button();
            p62 = new Button();
            p61 = new Button();
            p60 = new Button();
            p58 = new Button();
            p59 = new Button();
            p57 = new Button();
            statusStrip1 = new StatusStrip();
            statusPlayer = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)tabuleiro).BeginInit();
            table.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabuleiro
            // 
            tabuleiro.Dock = DockStyle.Fill;
            tabuleiro.Image = Properties.Resources.Tabuleiro;
            tabuleiro.Location = new Point(0, 0);
            tabuleiro.Name = "tabuleiro";
            tabuleiro.Size = new Size(551, 561);
            tabuleiro.SizeMode = PictureBoxSizeMode.Zoom;
            tabuleiro.TabIndex = 0;
            tabuleiro.TabStop = false;
            // 
            // table
            // 
            table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table.AutoSize = true;
            table.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            table.BackColor = Color.Transparent;
            table.BackgroundImage = Properties.Resources.Tabuleiro2;
            table.BackgroundImageLayout = ImageLayout.Zoom;
            table.ColumnCount = 8;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            table.Controls.Add(p8, 7, 7);
            table.Controls.Add(p7, 6, 7);
            table.Controls.Add(p6, 5, 7);
            table.Controls.Add(p5, 4, 7);
            table.Controls.Add(p4, 3, 7);
            table.Controls.Add(p3, 2, 7);
            table.Controls.Add(p2, 1, 7);
            table.Controls.Add(p1, 0, 7);
            table.Controls.Add(p16, 7, 6);
            table.Controls.Add(p15, 6, 6);
            table.Controls.Add(p14, 5, 6);
            table.Controls.Add(p13, 4, 6);
            table.Controls.Add(p12, 3, 6);
            table.Controls.Add(p11, 2, 6);
            table.Controls.Add(p10, 1, 6);
            table.Controls.Add(p9, 0, 6);
            table.Controls.Add(p24, 7, 5);
            table.Controls.Add(p23, 6, 5);
            table.Controls.Add(p22, 5, 5);
            table.Controls.Add(p21, 4, 5);
            table.Controls.Add(p20, 3, 5);
            table.Controls.Add(p19, 2, 5);
            table.Controls.Add(p18, 1, 5);
            table.Controls.Add(p17, 0, 5);
            table.Controls.Add(p32, 7, 4);
            table.Controls.Add(p31, 6, 4);
            table.Controls.Add(p30, 5, 4);
            table.Controls.Add(p29, 4, 4);
            table.Controls.Add(p28, 3, 4);
            table.Controls.Add(p27, 2, 4);
            table.Controls.Add(p26, 1, 4);
            table.Controls.Add(p25, 0, 4);
            table.Controls.Add(p40, 7, 3);
            table.Controls.Add(p39, 6, 3);
            table.Controls.Add(p38, 5, 3);
            table.Controls.Add(p37, 4, 3);
            table.Controls.Add(p36, 3, 3);
            table.Controls.Add(p35, 2, 3);
            table.Controls.Add(p34, 1, 3);
            table.Controls.Add(p33, 0, 3);
            table.Controls.Add(p48, 7, 2);
            table.Controls.Add(p47, 6, 2);
            table.Controls.Add(p46, 5, 2);
            table.Controls.Add(p45, 4, 2);
            table.Controls.Add(p44, 3, 2);
            table.Controls.Add(p43, 2, 2);
            table.Controls.Add(p42, 1, 2);
            table.Controls.Add(p41, 0, 2);
            table.Controls.Add(p56, 7, 1);
            table.Controls.Add(p55, 6, 1);
            table.Controls.Add(p54, 5, 1);
            table.Controls.Add(p53, 4, 1);
            table.Controls.Add(p52, 3, 1);
            table.Controls.Add(p51, 2, 1);
            table.Controls.Add(p50, 1, 1);
            table.Controls.Add(p49, 0, 1);
            table.Controls.Add(p64, 7, 0);
            table.Controls.Add(p63, 6, 0);
            table.Controls.Add(p62, 5, 0);
            table.Controls.Add(p61, 4, 0);
            table.Controls.Add(p60, 3, 0);
            table.Controls.Add(p58, 1, 0);
            table.Controls.Add(p59, 2, 0);
            table.Controls.Add(p57, 0, 0);
            table.ImeMode = ImeMode.On;
            table.Location = new Point(36, 42);
            table.Name = "table";
            table.RowCount = 8;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            table.Size = new Size(480, 480);
            table.TabIndex = 1;
            // 
            // p8
            // 
            p8.BackgroundImageLayout = ImageLayout.Zoom;
            p8.Dock = DockStyle.Fill;
            p8.FlatAppearance.BorderSize = 0;
            p8.FlatStyle = FlatStyle.Flat;
            p8.Location = new Point(423, 423);
            p8.Name = "p8";
            p8.Size = new Size(54, 54);
            p8.TabIndex = 66;
            p8.UseVisualStyleBackColor = true;
            p8.Click += Piece_Click;
            // 
            // p7
            // 
            p7.BackgroundImageLayout = ImageLayout.Zoom;
            p7.Dock = DockStyle.Fill;
            p7.FlatAppearance.BorderSize = 0;
            p7.FlatStyle = FlatStyle.Flat;
            p7.Location = new Point(363, 423);
            p7.Name = "p7";
            p7.Size = new Size(54, 54);
            p7.TabIndex = 65;
            p7.UseVisualStyleBackColor = true;
            p7.Click += Piece_Click;
            // 
            // p6
            // 
            p6.BackgroundImageLayout = ImageLayout.Zoom;
            p6.Dock = DockStyle.Fill;
            p6.FlatAppearance.BorderSize = 0;
            p6.FlatStyle = FlatStyle.Flat;
            p6.Location = new Point(303, 423);
            p6.Name = "p6";
            p6.Size = new Size(54, 54);
            p6.TabIndex = 64;
            p6.UseVisualStyleBackColor = true;
            p6.Click += Piece_Click;
            // 
            // p5
            // 
            p5.BackgroundImageLayout = ImageLayout.Zoom;
            p5.Dock = DockStyle.Fill;
            p5.FlatAppearance.BorderSize = 0;
            p5.FlatStyle = FlatStyle.Flat;
            p5.Location = new Point(243, 423);
            p5.Name = "p5";
            p5.Size = new Size(54, 54);
            p5.TabIndex = 63;
            p5.UseVisualStyleBackColor = true;
            // 
            // p4
            // 
            p4.BackgroundImageLayout = ImageLayout.Zoom;
            p4.Dock = DockStyle.Fill;
            p4.FlatAppearance.BorderSize = 0;
            p4.FlatStyle = FlatStyle.Flat;
            p4.Location = new Point(183, 423);
            p4.Name = "p4";
            p4.Size = new Size(54, 54);
            p4.TabIndex = 62;
            p4.UseVisualStyleBackColor = true;
            p4.Click += Piece_Click;
            // 
            // p3
            // 
            p3.BackgroundImageLayout = ImageLayout.Zoom;
            p3.Dock = DockStyle.Fill;
            p3.FlatAppearance.BorderSize = 0;
            p3.FlatStyle = FlatStyle.Flat;
            p3.Location = new Point(123, 423);
            p3.Name = "p3";
            p3.Size = new Size(54, 54);
            p3.TabIndex = 61;
            p3.UseVisualStyleBackColor = true;
            p3.Click += Piece_Click;
            // 
            // p2
            // 
            p2.BackgroundImageLayout = ImageLayout.Zoom;
            p2.Dock = DockStyle.Fill;
            p2.FlatAppearance.BorderSize = 0;
            p2.FlatStyle = FlatStyle.Flat;
            p2.Location = new Point(63, 423);
            p2.Name = "p2";
            p2.Size = new Size(54, 54);
            p2.TabIndex = 60;
            p2.UseVisualStyleBackColor = true;
            p2.Click += Piece_Click;
            // 
            // p1
            // 
            p1.BackgroundImageLayout = ImageLayout.Zoom;
            p1.Dock = DockStyle.Fill;
            p1.FlatAppearance.BorderSize = 0;
            p1.FlatStyle = FlatStyle.Flat;
            p1.Location = new Point(3, 423);
            p1.Name = "p1";
            p1.Size = new Size(54, 54);
            p1.TabIndex = 59;
            p1.UseVisualStyleBackColor = true;
            p1.Click += Piece_Click;
            // 
            // p16
            // 
            p16.BackgroundImageLayout = ImageLayout.Zoom;
            p16.Dock = DockStyle.Fill;
            p16.FlatAppearance.BorderSize = 0;
            p16.FlatStyle = FlatStyle.Flat;
            p16.Location = new Point(423, 363);
            p16.Name = "p16";
            p16.Size = new Size(54, 54);
            p16.TabIndex = 58;
            p16.UseVisualStyleBackColor = true;
            p16.Click += Piece_Click;
            // 
            // p15
            // 
            p15.BackgroundImageLayout = ImageLayout.Zoom;
            p15.Dock = DockStyle.Fill;
            p15.FlatAppearance.BorderSize = 0;
            p15.FlatStyle = FlatStyle.Flat;
            p15.Location = new Point(363, 363);
            p15.Name = "p15";
            p15.Size = new Size(54, 54);
            p15.TabIndex = 57;
            p15.UseVisualStyleBackColor = true;
            p15.Click += Piece_Click;
            // 
            // p14
            // 
            p14.BackgroundImageLayout = ImageLayout.Zoom;
            p14.Dock = DockStyle.Fill;
            p14.FlatAppearance.BorderSize = 0;
            p14.FlatStyle = FlatStyle.Flat;
            p14.Location = new Point(303, 363);
            p14.Name = "p14";
            p14.Size = new Size(54, 54);
            p14.TabIndex = 56;
            p14.UseVisualStyleBackColor = true;
            p14.Click += Piece_Click;
            // 
            // p13
            // 
            p13.BackgroundImageLayout = ImageLayout.Zoom;
            p13.Dock = DockStyle.Fill;
            p13.FlatAppearance.BorderSize = 0;
            p13.FlatStyle = FlatStyle.Flat;
            p13.Location = new Point(243, 363);
            p13.Name = "p13";
            p13.Size = new Size(54, 54);
            p13.TabIndex = 55;
            p13.UseVisualStyleBackColor = true;
            p13.Click += Piece_Click;
            // 
            // p12
            // 
            p12.BackgroundImageLayout = ImageLayout.Zoom;
            p12.Dock = DockStyle.Fill;
            p12.FlatAppearance.BorderSize = 0;
            p12.FlatStyle = FlatStyle.Flat;
            p12.Location = new Point(183, 363);
            p12.Name = "p12";
            p12.Size = new Size(54, 54);
            p12.TabIndex = 54;
            p12.UseVisualStyleBackColor = true;
            p12.Click += Piece_Click;
            // 
            // p11
            // 
            p11.BackgroundImageLayout = ImageLayout.Zoom;
            p11.Dock = DockStyle.Fill;
            p11.FlatAppearance.BorderSize = 0;
            p11.FlatStyle = FlatStyle.Flat;
            p11.Location = new Point(123, 363);
            p11.Name = "p11";
            p11.Size = new Size(54, 54);
            p11.TabIndex = 53;
            p11.UseVisualStyleBackColor = true;
            p11.Click += Piece_Click;
            // 
            // p10
            // 
            p10.BackgroundImageLayout = ImageLayout.Zoom;
            p10.Dock = DockStyle.Fill;
            p10.FlatAppearance.BorderSize = 0;
            p10.FlatStyle = FlatStyle.Flat;
            p10.Location = new Point(63, 363);
            p10.Name = "p10";
            p10.Size = new Size(54, 54);
            p10.TabIndex = 52;
            p10.UseVisualStyleBackColor = true;
            p10.Click += Piece_Click;
            // 
            // p9
            // 
            p9.BackgroundImageLayout = ImageLayout.Zoom;
            p9.Dock = DockStyle.Fill;
            p9.FlatAppearance.BorderSize = 0;
            p9.FlatStyle = FlatStyle.Flat;
            p9.Location = new Point(3, 363);
            p9.Name = "p9";
            p9.Size = new Size(54, 54);
            p9.TabIndex = 51;
            p9.UseVisualStyleBackColor = true;
            p9.Click += Piece_Click;
            // 
            // p24
            // 
            p24.BackgroundImageLayout = ImageLayout.Zoom;
            p24.Dock = DockStyle.Fill;
            p24.FlatAppearance.BorderSize = 0;
            p24.FlatStyle = FlatStyle.Flat;
            p24.Location = new Point(423, 303);
            p24.Name = "p24";
            p24.Size = new Size(54, 54);
            p24.TabIndex = 50;
            p24.UseVisualStyleBackColor = true;
            p24.Click += Piece_Click;
            // 
            // p23
            // 
            p23.BackgroundImageLayout = ImageLayout.Zoom;
            p23.Dock = DockStyle.Fill;
            p23.FlatAppearance.BorderSize = 0;
            p23.FlatStyle = FlatStyle.Flat;
            p23.Location = new Point(363, 303);
            p23.Name = "p23";
            p23.Size = new Size(54, 54);
            p23.TabIndex = 49;
            p23.UseVisualStyleBackColor = true;
            p23.Click += Piece_Click;
            // 
            // p22
            // 
            p22.BackgroundImageLayout = ImageLayout.Zoom;
            p22.Dock = DockStyle.Fill;
            p22.FlatAppearance.BorderSize = 0;
            p22.FlatStyle = FlatStyle.Flat;
            p22.Location = new Point(303, 303);
            p22.Name = "p22";
            p22.Size = new Size(54, 54);
            p22.TabIndex = 48;
            p22.UseVisualStyleBackColor = true;
            p22.Click += Piece_Click;
            // 
            // p21
            // 
            p21.BackgroundImageLayout = ImageLayout.Zoom;
            p21.Dock = DockStyle.Fill;
            p21.FlatAppearance.BorderSize = 0;
            p21.FlatStyle = FlatStyle.Flat;
            p21.Location = new Point(243, 303);
            p21.Name = "p21";
            p21.Size = new Size(54, 54);
            p21.TabIndex = 47;
            p21.UseVisualStyleBackColor = true;
            p21.Click += Piece_Click;
            // 
            // p20
            // 
            p20.BackgroundImageLayout = ImageLayout.Zoom;
            p20.Dock = DockStyle.Fill;
            p20.FlatAppearance.BorderSize = 0;
            p20.FlatStyle = FlatStyle.Flat;
            p20.Location = new Point(183, 303);
            p20.Name = "p20";
            p20.Size = new Size(54, 54);
            p20.TabIndex = 46;
            p20.UseVisualStyleBackColor = true;
            p20.Click += Piece_Click;
            // 
            // p19
            // 
            p19.BackgroundImageLayout = ImageLayout.Zoom;
            p19.Dock = DockStyle.Fill;
            p19.FlatAppearance.BorderSize = 0;
            p19.FlatStyle = FlatStyle.Flat;
            p19.Location = new Point(123, 303);
            p19.Name = "p19";
            p19.Size = new Size(54, 54);
            p19.TabIndex = 45;
            p19.UseVisualStyleBackColor = true;
            p19.Click += Piece_Click;
            // 
            // p18
            // 
            p18.BackgroundImageLayout = ImageLayout.Zoom;
            p18.Dock = DockStyle.Fill;
            p18.FlatAppearance.BorderSize = 0;
            p18.FlatStyle = FlatStyle.Flat;
            p18.Location = new Point(63, 303);
            p18.Name = "p18";
            p18.Size = new Size(54, 54);
            p18.TabIndex = 44;
            p18.UseVisualStyleBackColor = true;
            p18.Click += Piece_Click;
            // 
            // p17
            // 
            p17.BackgroundImageLayout = ImageLayout.Zoom;
            p17.Dock = DockStyle.Fill;
            p17.FlatAppearance.BorderSize = 0;
            p17.FlatStyle = FlatStyle.Flat;
            p17.Location = new Point(3, 303);
            p17.Name = "p17";
            p17.Size = new Size(54, 54);
            p17.TabIndex = 43;
            p17.UseVisualStyleBackColor = true;
            p17.Click += Piece_Click;
            // 
            // p32
            // 
            p32.BackgroundImageLayout = ImageLayout.Zoom;
            p32.Dock = DockStyle.Fill;
            p32.FlatAppearance.BorderSize = 0;
            p32.FlatStyle = FlatStyle.Flat;
            p32.Location = new Point(423, 243);
            p32.Name = "p32";
            p32.Size = new Size(54, 54);
            p32.TabIndex = 42;
            p32.UseVisualStyleBackColor = true;
            p32.Click += Piece_Click;
            // 
            // p31
            // 
            p31.BackgroundImageLayout = ImageLayout.Zoom;
            p31.Dock = DockStyle.Fill;
            p31.FlatAppearance.BorderSize = 0;
            p31.FlatStyle = FlatStyle.Flat;
            p31.Location = new Point(363, 243);
            p31.Name = "p31";
            p31.Size = new Size(54, 54);
            p31.TabIndex = 41;
            p31.UseVisualStyleBackColor = true;
            p31.Click += Piece_Click;
            // 
            // p30
            // 
            p30.BackgroundImageLayout = ImageLayout.Zoom;
            p30.Dock = DockStyle.Fill;
            p30.FlatAppearance.BorderSize = 0;
            p30.FlatStyle = FlatStyle.Flat;
            p30.Location = new Point(303, 243);
            p30.Name = "p30";
            p30.Size = new Size(54, 54);
            p30.TabIndex = 40;
            p30.UseVisualStyleBackColor = true;
            p30.Click += Piece_Click;
            // 
            // p29
            // 
            p29.BackgroundImageLayout = ImageLayout.Zoom;
            p29.Dock = DockStyle.Fill;
            p29.FlatAppearance.BorderSize = 0;
            p29.FlatStyle = FlatStyle.Flat;
            p29.Location = new Point(243, 243);
            p29.Name = "p29";
            p29.Size = new Size(54, 54);
            p29.TabIndex = 39;
            p29.UseVisualStyleBackColor = true;
            p29.Click += Piece_Click;
            // 
            // p28
            // 
            p28.BackgroundImageLayout = ImageLayout.Zoom;
            p28.Dock = DockStyle.Fill;
            p28.FlatAppearance.BorderSize = 0;
            p28.FlatStyle = FlatStyle.Flat;
            p28.Location = new Point(183, 243);
            p28.Name = "p28";
            p28.Size = new Size(54, 54);
            p28.TabIndex = 38;
            p28.UseVisualStyleBackColor = true;
            p28.Click += Piece_Click;
            // 
            // p27
            // 
            p27.BackgroundImageLayout = ImageLayout.Zoom;
            p27.Dock = DockStyle.Fill;
            p27.FlatAppearance.BorderSize = 0;
            p27.FlatStyle = FlatStyle.Flat;
            p27.Location = new Point(123, 243);
            p27.Name = "p27";
            p27.Size = new Size(54, 54);
            p27.TabIndex = 37;
            p27.UseVisualStyleBackColor = true;
            p27.Click += Piece_Click;
            // 
            // p26
            // 
            p26.BackgroundImageLayout = ImageLayout.Zoom;
            p26.Dock = DockStyle.Fill;
            p26.FlatAppearance.BorderSize = 0;
            p26.FlatStyle = FlatStyle.Flat;
            p26.Location = new Point(63, 243);
            p26.Name = "p26";
            p26.Size = new Size(54, 54);
            p26.TabIndex = 36;
            p26.UseVisualStyleBackColor = true;
            p26.Click += Piece_Click;
            // 
            // p25
            // 
            p25.BackgroundImageLayout = ImageLayout.Zoom;
            p25.Dock = DockStyle.Fill;
            p25.FlatAppearance.BorderSize = 0;
            p25.FlatStyle = FlatStyle.Flat;
            p25.Location = new Point(3, 243);
            p25.Name = "p25";
            p25.Size = new Size(54, 54);
            p25.TabIndex = 35;
            p25.UseVisualStyleBackColor = true;
            p25.Click += Piece_Click;
            // 
            // p40
            // 
            p40.BackgroundImageLayout = ImageLayout.Zoom;
            p40.Dock = DockStyle.Fill;
            p40.FlatAppearance.BorderSize = 0;
            p40.FlatStyle = FlatStyle.Flat;
            p40.Location = new Point(423, 183);
            p40.Name = "p40";
            p40.Size = new Size(54, 54);
            p40.TabIndex = 34;
            p40.UseVisualStyleBackColor = true;
            p40.Click += Piece_Click;
            // 
            // p39
            // 
            p39.BackgroundImageLayout = ImageLayout.Zoom;
            p39.Dock = DockStyle.Fill;
            p39.FlatAppearance.BorderSize = 0;
            p39.FlatStyle = FlatStyle.Flat;
            p39.Location = new Point(363, 183);
            p39.Name = "p39";
            p39.Size = new Size(54, 54);
            p39.TabIndex = 33;
            p39.UseVisualStyleBackColor = true;
            p39.Click += Piece_Click;
            // 
            // p38
            // 
            p38.BackgroundImageLayout = ImageLayout.Zoom;
            p38.Dock = DockStyle.Fill;
            p38.FlatAppearance.BorderSize = 0;
            p38.FlatStyle = FlatStyle.Flat;
            p38.Location = new Point(303, 183);
            p38.Name = "p38";
            p38.Size = new Size(54, 54);
            p38.TabIndex = 32;
            p38.UseVisualStyleBackColor = true;
            p38.Click += Piece_Click;
            // 
            // p37
            // 
            p37.BackgroundImageLayout = ImageLayout.Zoom;
            p37.Dock = DockStyle.Fill;
            p37.FlatAppearance.BorderSize = 0;
            p37.FlatStyle = FlatStyle.Flat;
            p37.Location = new Point(243, 183);
            p37.Name = "p37";
            p37.Size = new Size(54, 54);
            p37.TabIndex = 31;
            p37.UseVisualStyleBackColor = true;
            p37.Click += Piece_Click;
            // 
            // p36
            // 
            p36.BackgroundImageLayout = ImageLayout.Zoom;
            p36.Dock = DockStyle.Fill;
            p36.FlatAppearance.BorderSize = 0;
            p36.FlatStyle = FlatStyle.Flat;
            p36.Location = new Point(183, 183);
            p36.Name = "p36";
            p36.Size = new Size(54, 54);
            p36.TabIndex = 30;
            p36.UseVisualStyleBackColor = true;
            p36.Click += Piece_Click;
            // 
            // p35
            // 
            p35.BackgroundImageLayout = ImageLayout.Zoom;
            p35.Dock = DockStyle.Fill;
            p35.FlatAppearance.BorderSize = 0;
            p35.FlatStyle = FlatStyle.Flat;
            p35.Location = new Point(123, 183);
            p35.Name = "p35";
            p35.Size = new Size(54, 54);
            p35.TabIndex = 29;
            p35.UseVisualStyleBackColor = true;
            p35.Click += Piece_Click;
            // 
            // p34
            // 
            p34.BackgroundImageLayout = ImageLayout.Zoom;
            p34.Dock = DockStyle.Fill;
            p34.FlatAppearance.BorderSize = 0;
            p34.FlatStyle = FlatStyle.Flat;
            p34.Location = new Point(63, 183);
            p34.Name = "p34";
            p34.Size = new Size(54, 54);
            p34.TabIndex = 28;
            p34.UseVisualStyleBackColor = true;
            p34.Click += Piece_Click;
            // 
            // p33
            // 
            p33.BackgroundImageLayout = ImageLayout.Zoom;
            p33.Dock = DockStyle.Fill;
            p33.FlatAppearance.BorderSize = 0;
            p33.FlatStyle = FlatStyle.Flat;
            p33.Location = new Point(3, 183);
            p33.Name = "p33";
            p33.Size = new Size(54, 54);
            p33.TabIndex = 27;
            p33.UseVisualStyleBackColor = true;
            p33.Click += Piece_Click;
            // 
            // p48
            // 
            p48.BackgroundImageLayout = ImageLayout.Zoom;
            p48.Dock = DockStyle.Fill;
            p48.FlatAppearance.BorderSize = 0;
            p48.FlatStyle = FlatStyle.Flat;
            p48.Location = new Point(423, 123);
            p48.Name = "p48";
            p48.Size = new Size(54, 54);
            p48.TabIndex = 26;
            p48.UseVisualStyleBackColor = true;
            p48.Click += Piece_Click;
            // 
            // p47
            // 
            p47.BackgroundImageLayout = ImageLayout.Zoom;
            p47.Dock = DockStyle.Fill;
            p47.FlatAppearance.BorderSize = 0;
            p47.FlatStyle = FlatStyle.Flat;
            p47.Location = new Point(363, 123);
            p47.Name = "p47";
            p47.Size = new Size(54, 54);
            p47.TabIndex = 25;
            p47.UseVisualStyleBackColor = true;
            p47.Click += Piece_Click;
            // 
            // p46
            // 
            p46.BackgroundImageLayout = ImageLayout.Zoom;
            p46.Dock = DockStyle.Fill;
            p46.FlatAppearance.BorderSize = 0;
            p46.FlatStyle = FlatStyle.Flat;
            p46.Location = new Point(303, 123);
            p46.Name = "p46";
            p46.Size = new Size(54, 54);
            p46.TabIndex = 24;
            p46.UseVisualStyleBackColor = true;
            p46.Click += Piece_Click;
            // 
            // p45
            // 
            p45.BackgroundImageLayout = ImageLayout.Zoom;
            p45.Dock = DockStyle.Fill;
            p45.FlatAppearance.BorderSize = 0;
            p45.FlatStyle = FlatStyle.Flat;
            p45.Location = new Point(243, 123);
            p45.Name = "p45";
            p45.Size = new Size(54, 54);
            p45.TabIndex = 23;
            p45.UseVisualStyleBackColor = true;
            p45.Click += Piece_Click;
            // 
            // p44
            // 
            p44.BackgroundImageLayout = ImageLayout.Zoom;
            p44.Dock = DockStyle.Fill;
            p44.FlatAppearance.BorderSize = 0;
            p44.FlatStyle = FlatStyle.Flat;
            p44.Location = new Point(183, 123);
            p44.Name = "p44";
            p44.Size = new Size(54, 54);
            p44.TabIndex = 22;
            p44.UseVisualStyleBackColor = true;
            p44.Click += Piece_Click;
            // 
            // p43
            // 
            p43.BackgroundImageLayout = ImageLayout.Zoom;
            p43.Dock = DockStyle.Fill;
            p43.FlatAppearance.BorderSize = 0;
            p43.FlatStyle = FlatStyle.Flat;
            p43.Location = new Point(123, 123);
            p43.Name = "p43";
            p43.Size = new Size(54, 54);
            p43.TabIndex = 21;
            p43.UseVisualStyleBackColor = true;
            p43.Click += Piece_Click;
            // 
            // p42
            // 
            p42.BackgroundImageLayout = ImageLayout.Zoom;
            p42.Dock = DockStyle.Fill;
            p42.FlatAppearance.BorderSize = 0;
            p42.FlatStyle = FlatStyle.Flat;
            p42.Location = new Point(63, 123);
            p42.Name = "p42";
            p42.Size = new Size(54, 54);
            p42.TabIndex = 20;
            p42.UseVisualStyleBackColor = true;
            p42.Click += Piece_Click;
            // 
            // p41
            // 
            p41.BackgroundImageLayout = ImageLayout.Zoom;
            p41.Dock = DockStyle.Fill;
            p41.FlatAppearance.BorderSize = 0;
            p41.FlatStyle = FlatStyle.Flat;
            p41.Location = new Point(3, 123);
            p41.Name = "p41";
            p41.Size = new Size(54, 54);
            p41.TabIndex = 19;
            p41.UseVisualStyleBackColor = true;
            p41.Click += Piece_Click;
            // 
            // p56
            // 
            p56.BackgroundImageLayout = ImageLayout.Zoom;
            p56.Dock = DockStyle.Fill;
            p56.FlatAppearance.BorderSize = 0;
            p56.FlatStyle = FlatStyle.Flat;
            p56.Location = new Point(423, 63);
            p56.Name = "p56";
            p56.Size = new Size(54, 54);
            p56.TabIndex = 18;
            p56.UseVisualStyleBackColor = true;
            p56.Click += Piece_Click;
            // 
            // p55
            // 
            p55.BackgroundImageLayout = ImageLayout.Zoom;
            p55.Dock = DockStyle.Fill;
            p55.FlatAppearance.BorderSize = 0;
            p55.FlatStyle = FlatStyle.Flat;
            p55.Location = new Point(363, 63);
            p55.Name = "p55";
            p55.Size = new Size(54, 54);
            p55.TabIndex = 17;
            p55.UseVisualStyleBackColor = true;
            p55.Click += Piece_Click;
            // 
            // p54
            // 
            p54.BackgroundImageLayout = ImageLayout.Zoom;
            p54.Dock = DockStyle.Fill;
            p54.FlatAppearance.BorderSize = 0;
            p54.FlatStyle = FlatStyle.Flat;
            p54.Location = new Point(303, 63);
            p54.Name = "p54";
            p54.Size = new Size(54, 54);
            p54.TabIndex = 16;
            p54.UseVisualStyleBackColor = true;
            p54.Click += Piece_Click;
            // 
            // p53
            // 
            p53.BackgroundImageLayout = ImageLayout.Zoom;
            p53.Dock = DockStyle.Fill;
            p53.FlatAppearance.BorderSize = 0;
            p53.FlatStyle = FlatStyle.Flat;
            p53.Location = new Point(243, 63);
            p53.Name = "p53";
            p53.Size = new Size(54, 54);
            p53.TabIndex = 15;
            p53.UseVisualStyleBackColor = true;
            p53.Click += Piece_Click;
            // 
            // p52
            // 
            p52.BackgroundImageLayout = ImageLayout.Zoom;
            p52.Dock = DockStyle.Fill;
            p52.FlatAppearance.BorderSize = 0;
            p52.FlatStyle = FlatStyle.Flat;
            p52.Location = new Point(183, 63);
            p52.Name = "p52";
            p52.Size = new Size(54, 54);
            p52.TabIndex = 14;
            p52.UseVisualStyleBackColor = true;
            p52.Click += Piece_Click;
            // 
            // p51
            // 
            p51.BackgroundImageLayout = ImageLayout.Zoom;
            p51.Dock = DockStyle.Fill;
            p51.FlatAppearance.BorderSize = 0;
            p51.FlatStyle = FlatStyle.Flat;
            p51.Location = new Point(123, 63);
            p51.Name = "p51";
            p51.Size = new Size(54, 54);
            p51.TabIndex = 13;
            p51.UseVisualStyleBackColor = true;
            p51.Click += Piece_Click;
            // 
            // p50
            // 
            p50.BackgroundImageLayout = ImageLayout.Zoom;
            p50.Dock = DockStyle.Fill;
            p50.FlatAppearance.BorderSize = 0;
            p50.FlatStyle = FlatStyle.Flat;
            p50.Location = new Point(63, 63);
            p50.Name = "p50";
            p50.Size = new Size(54, 54);
            p50.TabIndex = 12;
            p50.UseVisualStyleBackColor = true;
            p50.Click += Piece_Click;
            // 
            // p49
            // 
            p49.BackgroundImageLayout = ImageLayout.Zoom;
            p49.Dock = DockStyle.Fill;
            p49.FlatAppearance.BorderSize = 0;
            p49.FlatStyle = FlatStyle.Flat;
            p49.Location = new Point(3, 63);
            p49.Name = "p49";
            p49.Size = new Size(54, 54);
            p49.TabIndex = 11;
            p49.UseVisualStyleBackColor = true;
            p49.Click += Piece_Click;
            // 
            // p64
            // 
            p64.BackgroundImageLayout = ImageLayout.Zoom;
            p64.Dock = DockStyle.Fill;
            p64.FlatAppearance.BorderSize = 0;
            p64.FlatStyle = FlatStyle.Flat;
            p64.Location = new Point(423, 3);
            p64.Name = "p64";
            p64.Size = new Size(54, 54);
            p64.TabIndex = 10;
            p64.UseVisualStyleBackColor = true;
            p64.Click += Piece_Click;
            // 
            // p63
            // 
            p63.BackgroundImageLayout = ImageLayout.Zoom;
            p63.Dock = DockStyle.Fill;
            p63.FlatAppearance.BorderSize = 0;
            p63.FlatStyle = FlatStyle.Flat;
            p63.Location = new Point(363, 3);
            p63.Name = "p63";
            p63.Size = new Size(54, 54);
            p63.TabIndex = 9;
            p63.UseVisualStyleBackColor = true;
            p63.Click += Piece_Click;
            // 
            // p62
            // 
            p62.BackgroundImageLayout = ImageLayout.Zoom;
            p62.Dock = DockStyle.Fill;
            p62.FlatAppearance.BorderSize = 0;
            p62.FlatStyle = FlatStyle.Flat;
            p62.Location = new Point(303, 3);
            p62.Name = "p62";
            p62.Size = new Size(54, 54);
            p62.TabIndex = 8;
            p62.UseVisualStyleBackColor = true;
            p62.Click += Piece_Click;
            // 
            // p61
            // 
            p61.BackgroundImageLayout = ImageLayout.Zoom;
            p61.Dock = DockStyle.Fill;
            p61.FlatAppearance.BorderSize = 0;
            p61.FlatStyle = FlatStyle.Flat;
            p61.Location = new Point(243, 3);
            p61.Name = "p61";
            p61.Size = new Size(54, 54);
            p61.TabIndex = 7;
            p61.UseVisualStyleBackColor = true;
            p61.Click += Piece_Click;
            // 
            // p60
            // 
            p60.BackgroundImageLayout = ImageLayout.Zoom;
            p60.Dock = DockStyle.Fill;
            p60.FlatAppearance.BorderSize = 0;
            p60.FlatStyle = FlatStyle.Flat;
            p60.Location = new Point(183, 3);
            p60.Name = "p60";
            p60.Size = new Size(54, 54);
            p60.TabIndex = 6;
            p60.UseVisualStyleBackColor = true;
            p60.Click += Piece_Click;
            // 
            // p58
            // 
            p58.BackgroundImageLayout = ImageLayout.Zoom;
            p58.Dock = DockStyle.Fill;
            p58.FlatAppearance.BorderSize = 0;
            p58.FlatStyle = FlatStyle.Flat;
            p58.Location = new Point(63, 3);
            p58.Name = "p58";
            p58.Size = new Size(54, 54);
            p58.TabIndex = 5;
            p58.UseVisualStyleBackColor = true;
            p58.Click += Piece_Click;
            // 
            // p59
            // 
            p59.BackgroundImageLayout = ImageLayout.Zoom;
            p59.Dock = DockStyle.Fill;
            p59.FlatAppearance.BorderSize = 0;
            p59.FlatStyle = FlatStyle.Flat;
            p59.Location = new Point(123, 3);
            p59.Name = "p59";
            p59.Size = new Size(54, 54);
            p59.TabIndex = 4;
            p59.UseVisualStyleBackColor = true;
            p59.Click += Piece_Click;
            // 
            // p57
            // 
            p57.BackgroundImageLayout = ImageLayout.Zoom;
            p57.Dock = DockStyle.Fill;
            p57.FlatAppearance.BorderSize = 0;
            p57.FlatStyle = FlatStyle.Flat;
            p57.Location = new Point(3, 3);
            p57.Name = "p57";
            p57.Size = new Size(54, 54);
            p57.TabIndex = 1;
            p57.UseVisualStyleBackColor = true;
            p57.Click += Piece_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusPlayer });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(551, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusPlayer
            // 
            statusPlayer.Name = "statusPlayer";
            statusPlayer.Size = new Size(66, 17);
            statusPlayer.Text = "statusLabel";
            // 
            // TelaXadrez
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(551, 561);
            Controls.Add(statusStrip1);
            Controls.Add(table);
            Controls.Add(tabuleiro);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TelaXadrez";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xadrez";
            Load += TelaXadrez_Load;
            ((System.ComponentModel.ISupportInitialize)tabuleiro).EndInit();
            table.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox tabuleiro;
        private TableLayoutPanel table;
        private Button p57;
        private Button p58;
        private Button p59;
        private Button p8;
        private Button p7;
        private Button p6;
        private Button p5;
        private Button p4;
        private Button p3;
        private Button p2;
        private Button p1;
        private Button p16;
        private Button p15;
        private Button p14;
        private Button p13;
        private Button p12;
        private Button p11;
        private Button p10;
        private Button p9;
        private Button p24;
        private Button p23;
        private Button p22;
        private Button p21;
        private Button p20;
        private Button p19;
        private Button p18;
        private Button p17;
        private Button p32;
        private Button p31;
        private Button p30;
        private Button p29;
        private Button p28;
        private Button p27;
        private Button p26;
        private Button p25;
        private Button p40;
        private Button p39;
        private Button p38;
        private Button p37;
        private Button p36;
        private Button p35;
        private Button p34;
        private Button p33;
        private Button p48;
        private Button p47;
        private Button p46;
        private Button p45;
        private Button p44;
        private Button p43;
        private Button p42;
        private Button p41;
        private Button p56;
        private Button p55;
        private Button p54;
        private Button p53;
        private Button p52;
        private Button p51;
        private Button p50;
        private Button p49;
        private Button p64;
        private Button p63;
        private Button p62;
        private Button p61;
        private Button p60;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusPlayer;
    }
}
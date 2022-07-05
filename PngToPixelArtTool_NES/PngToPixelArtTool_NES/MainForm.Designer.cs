namespace PngToPixelArtTool_NES
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_LinkWidthAndHeight = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_NumPaletteValues = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_PixelHeight = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_PixelWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_FinalNESPaletteCodes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Pixelated = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_ClosestMatch = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox_ClosestMatchFour = new System.Windows.Forms.PictureBox();
            this.panel0 = new System.Windows.Forms.Panel();
            this.pictureBox_Original = new System.Windows.Forms.PictureBox();
            this.pictureBox_PaletteImage = new System.Windows.Forms.PictureBox();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nESPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalNESPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumPaletteValues)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PixelHeight)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PixelWidth)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pixelated)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClosestMatch)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClosestMatchFour)).BeginInit();
            this.panel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PaletteImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1201, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_PaletteImage, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1201, 378);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(303, 305);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 70);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.checkBox_LinkWidthAndHeight, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(141, 29);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Link width and height";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_LinkWidthAndHeight
            // 
            this.checkBox_LinkWidthAndHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_LinkWidthAndHeight.AutoSize = true;
            this.checkBox_LinkWidthAndHeight.Checked = true;
            this.checkBox_LinkWidthAndHeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LinkWidthAndHeight.Location = new System.Drawing.Point(105, 7);
            this.checkBox_LinkWidthAndHeight.Name = "checkBox_LinkWidthAndHeight";
            this.checkBox_LinkWidthAndHeight.Size = new System.Drawing.Size(15, 14);
            this.checkBox_LinkWidthAndHeight.TabIndex = 2;
            this.checkBox_LinkWidthAndHeight.UseVisualStyleBackColor = true;
            this.checkBox_LinkWidthAndHeight.CheckedChanged += new System.EventHandler(this.checkBox_LinkWidthAndHeight_CheckedChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown_NumPaletteValues, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(141, 29);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // numericUpDown_NumPaletteValues
            // 
            this.numericUpDown_NumPaletteValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_NumPaletteValues.Location = new System.Drawing.Point(87, 3);
            this.numericUpDown_NumPaletteValues.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown_NumPaletteValues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_NumPaletteValues.Name = "numericUpDown_NumPaletteValues";
            this.numericUpDown_NumPaletteValues.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_NumPaletteValues.TabIndex = 4;
            this.numericUpDown_NumPaletteValues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_NumPaletteValues.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_NumPaletteValues.ValueChanged += new System.EventHandler(this.numericUpDown_NumPaletteValues_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number NES palette values";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_PixelHeight, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(150, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(141, 29);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "pixel height";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_PixelHeight
            // 
            this.numericUpDown_PixelHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_PixelHeight.Location = new System.Drawing.Point(87, 3);
            this.numericUpDown_PixelHeight.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDown_PixelHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_PixelHeight.Name = "numericUpDown_PixelHeight";
            this.numericUpDown_PixelHeight.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_PixelHeight.TabIndex = 1;
            this.numericUpDown_PixelHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_PixelHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_PixelHeight.ValueChanged += new System.EventHandler(this.numericUpDown_PixelHeight_ValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.numericUpDown_PixelWidth, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(150, 38);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(141, 29);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // numericUpDown_PixelWidth
            // 
            this.numericUpDown_PixelWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_PixelWidth.Location = new System.Drawing.Point(87, 3);
            this.numericUpDown_PixelWidth.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDown_PixelWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_PixelWidth.Name = "numericUpDown_PixelWidth";
            this.numericUpDown_PixelWidth.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_PixelWidth.TabIndex = 2;
            this.numericUpDown_PixelWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_PixelWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_PixelWidth.ValueChanged += new System.EventHandler(this.numericUpDown_PixelWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "pixel width";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox_FinalNESPaletteCodes, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(903, 305);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(295, 70);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "NES Palette:";
            // 
            // textBox_FinalNESPaletteCodes
            // 
            this.textBox_FinalNESPaletteCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_FinalNESPaletteCodes.Location = new System.Drawing.Point(3, 24);
            this.textBox_FinalNESPaletteCodes.Name = "textBox_FinalNESPaletteCodes";
            this.textBox_FinalNESPaletteCodes.ReadOnly = true;
            this.textBox_FinalNESPaletteCodes.Size = new System.Drawing.Size(289, 20);
            this.textBox_FinalNESPaletteCodes.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox_Pixelated);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(303, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 296);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox_Pixelated
            // 
            this.pictureBox_Pixelated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Pixelated.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Pixelated.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Pixelated.Name = "pictureBox_Pixelated";
            this.pictureBox_Pixelated.Size = new System.Drawing.Size(294, 296);
            this.pictureBox_Pixelated.TabIndex = 2;
            this.pictureBox_Pixelated.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox_ClosestMatch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(603, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 296);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox_ClosestMatch
            // 
            this.pictureBox_ClosestMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_ClosestMatch.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_ClosestMatch.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_ClosestMatch.Name = "pictureBox_ClosestMatch";
            this.pictureBox_ClosestMatch.Size = new System.Drawing.Size(294, 296);
            this.pictureBox_ClosestMatch.TabIndex = 3;
            this.pictureBox_ClosestMatch.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox_ClosestMatchFour);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(903, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 296);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox_ClosestMatchFour
            // 
            this.pictureBox_ClosestMatchFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_ClosestMatchFour.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_ClosestMatchFour.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_ClosestMatchFour.Name = "pictureBox_ClosestMatchFour";
            this.pictureBox_ClosestMatchFour.Size = new System.Drawing.Size(295, 296);
            this.pictureBox_ClosestMatchFour.TabIndex = 4;
            this.pictureBox_ClosestMatchFour.TabStop = false;
            // 
            // panel0
            // 
            this.panel0.AutoScroll = true;
            this.panel0.Controls.Add(this.pictureBox_Original);
            this.panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel0.Location = new System.Drawing.Point(3, 3);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(294, 296);
            this.panel0.TabIndex = 9;
            // 
            // pictureBox_Original
            // 
            this.pictureBox_Original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Original.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Original.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Original.Name = "pictureBox_Original";
            this.pictureBox_Original.Size = new System.Drawing.Size(294, 296);
            this.pictureBox_Original.TabIndex = 1;
            this.pictureBox_Original.TabStop = false;
            // 
            // pictureBox_PaletteImage
            // 
            this.pictureBox_PaletteImage.BackgroundImage = global::PngToPixelArtTool_NES.Properties.Resources.NESPalette;
            this.pictureBox_PaletteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_PaletteImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_PaletteImage.InitialImage = global::PngToPixelArtTool_NES.Properties.Resources.NESPalette;
            this.pictureBox_PaletteImage.Location = new System.Drawing.Point(603, 305);
            this.pictureBox_PaletteImage.Name = "pictureBox_PaletteImage";
            this.pictureBox_PaletteImage.Size = new System.Drawing.Size(294, 70);
            this.pictureBox_PaletteImage.TabIndex = 10;
            this.pictureBox_PaletteImage.TabStop = false;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelatedToolStripMenuItem,
            this.nESPaletteToolStripMenuItem,
            this.finalNESPaletteToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            // 
            // pixelatedToolStripMenuItem
            // 
            this.pixelatedToolStripMenuItem.Name = "pixelatedToolStripMenuItem";
            this.pixelatedToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pixelatedToolStripMenuItem.Text = "Pixelated";
            this.pixelatedToolStripMenuItem.Click += new System.EventHandler(this.pixelatedToolStripMenuItem_Click);
            // 
            // nESPaletteToolStripMenuItem
            // 
            this.nESPaletteToolStripMenuItem.Name = "nESPaletteToolStripMenuItem";
            this.nESPaletteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.nESPaletteToolStripMenuItem.Text = "NES palette";
            this.nESPaletteToolStripMenuItem.Click += new System.EventHandler(this.nESPaletteToolStripMenuItem_Click);
            // 
            // finalNESPaletteToolStripMenuItem
            // 
            this.finalNESPaletteToolStripMenuItem.Name = "finalNESPaletteToolStripMenuItem";
            this.finalNESPaletteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.finalNESPaletteToolStripMenuItem.Text = "Final NES palette";
            this.finalNESPaletteToolStripMenuItem.Click += new System.EventHandler(this.finalNESPaletteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "PngToPixelArtTool_NES";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumPaletteValues)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PixelHeight)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PixelWidth)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pixelated)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClosestMatch)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClosestMatchFour)).EndInit();
            this.panel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PaletteImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_PixelHeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown numericUpDown_PixelWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_LinkWidthAndHeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumPaletteValues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_FinalNESPaletteCodes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Pixelated;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_ClosestMatch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox_ClosestMatchFour;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.PictureBox pictureBox_Original;
        private System.Windows.Forms.PictureBox pictureBox_PaletteImage;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nESPaletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalNESPaletteToolStripMenuItem;
    }
}


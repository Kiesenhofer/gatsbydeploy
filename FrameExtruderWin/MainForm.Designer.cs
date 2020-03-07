namespace FrameExtruderWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TbWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbSaveUnextrudedCopies = new System.Windows.Forms.CheckBox();
            this.PbColorBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbColorOpacity = new System.Windows.Forms.TextBox();
            this.BtnSelectBgColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TbSpacing = new System.Windows.Forms.TextBox();
            this.TbMargin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSelectManually = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PbDrag = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDrag)).BeginInit();
            this.SuspendLayout();
            // 
            // TbWidth
            // 
            this.TbWidth.Location = new System.Drawing.Point(81, 24);
            this.TbWidth.Name = "TbWidth";
            this.TbWidth.Size = new System.Drawing.Size(44, 20);
            this.TbWidth.TabIndex = 0;
            this.TbWidth.Text = "16";
            this.TbWidth.TextChanged += new System.EventHandler(this.TbWidth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frame Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frame Width:";
            // 
            // TbHeight
            // 
            this.TbHeight.Location = new System.Drawing.Point(81, 53);
            this.TbHeight.Name = "TbHeight";
            this.TbHeight.Size = new System.Drawing.Size(44, 20);
            this.TbHeight.TabIndex = 4;
            this.TbHeight.Text = "16";
            this.TbHeight.TextChanged += new System.EventHandler(this.TbHeight_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbSaveUnextrudedCopies);
            this.groupBox1.Controls.Add(this.PbColorBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TbColorOpacity);
            this.groupBox1.Controls.Add(this.BtnSelectBgColor);
            this.groupBox1.Controls.A
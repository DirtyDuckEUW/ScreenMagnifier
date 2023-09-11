
namespace Bildschirmlupe
{
  partial class Mainwindow
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.ScreenView = new System.Windows.Forms.PictureBox();
      this.RecordTimer = new System.Windows.Forms.Timer(this.components);
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.LabelHeigth = new System.Windows.Forms.Label();
      this.WidthInput = new System.Windows.Forms.NumericUpDown();
      this.LabelWidth = new System.Windows.Forms.Label();
      this.YInput = new System.Windows.Forms.NumericUpDown();
      this.LabelX = new System.Windows.Forms.Label();
      this.XInput = new System.Windows.Forms.NumericUpDown();
      this.LabelY = new System.Windows.Forms.Label();
      this.HeightInput = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.YInput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.XInput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).BeginInit();
      this.SuspendLayout();
      // 
      // ScreenView
      // 
      this.ScreenView.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.ScreenView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ScreenView.Location = new System.Drawing.Point(420, 147);
      this.ScreenView.Name = "ScreenView";
      this.ScreenView.Size = new System.Drawing.Size(400, 400);
      this.ScreenView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.ScreenView.TabIndex = 0;
      this.ScreenView.TabStop = false;
      // 
      // RecordTimer
      // 
      this.RecordTimer.Enabled = true;
      this.RecordTimer.Interval = 1;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.ScreenView, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 657);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.ColumnCount = 8;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tableLayoutPanel2.Controls.Add(this.LabelHeigth, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.WidthInput, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.LabelWidth, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.YInput, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.LabelX, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.XInput, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.LabelY, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.HeightInput, 1, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1234, 31);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // LabelHeigth
      // 
      this.LabelHeigth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.LabelHeigth.Location = new System.Drawing.Point(649, 0);
      this.LabelHeigth.Name = "LabelHeigth";
      this.LabelHeigth.Size = new System.Drawing.Size(87, 31);
      this.LabelHeigth.TabIndex = 8;
      this.LabelHeigth.Text = "Width:";
      this.LabelHeigth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // WidthInput
      // 
      this.WidthInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.WidthInput.AutoSize = true;
      this.WidthInput.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.WidthInput.Location = new System.Drawing.Point(773, 3);
      this.WidthInput.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
      this.WidthInput.Name = "WidthInput";
      this.WidthInput.Size = new System.Drawing.Size(62, 23);
      this.WidthInput.TabIndex = 7;
      this.WidthInput.ThousandsSeparator = true;
      this.WidthInput.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.WidthInput.ValueChanged += new System.EventHandler(this.WidthInput_ValueChanged);
      // 
      // LabelWidth
      // 
      this.LabelWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.LabelWidth.Location = new System.Drawing.Point(957, 0);
      this.LabelWidth.Name = "LabelWidth";
      this.LabelWidth.Size = new System.Drawing.Size(87, 31);
      this.LabelWidth.TabIndex = 6;
      this.LabelWidth.Text = "Height:";
      this.LabelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // YInput
      // 
      this.YInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.YInput.AutoSize = true;
      this.YInput.Location = new System.Drawing.Point(465, 3);
      this.YInput.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
      this.YInput.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
      this.YInput.Name = "YInput";
      this.YInput.Size = new System.Drawing.Size(62, 23);
      this.YInput.TabIndex = 5;
      this.YInput.ThousandsSeparator = true;
      // 
      // LabelX
      // 
      this.LabelX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.LabelX.Location = new System.Drawing.Point(33, 0);
      this.LabelX.Name = "LabelX";
      this.LabelX.Size = new System.Drawing.Size(87, 31);
      this.LabelX.TabIndex = 4;
      this.LabelX.Text = "X:";
      this.LabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // XInput
      // 
      this.XInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.XInput.AutoSize = true;
      this.XInput.Location = new System.Drawing.Point(157, 3);
      this.XInput.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
      this.XInput.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
      this.XInput.Name = "XInput";
      this.XInput.Size = new System.Drawing.Size(62, 23);
      this.XInput.TabIndex = 3;
      this.XInput.ThousandsSeparator = true;
      // 
      // LabelY
      // 
      this.LabelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.LabelY.Location = new System.Drawing.Point(341, 0);
      this.LabelY.Name = "LabelY";
      this.LabelY.Size = new System.Drawing.Size(87, 31);
      this.LabelY.TabIndex = 2;
      this.LabelY.Text = "Y:";
      this.LabelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // HeightInput
      // 
      this.HeightInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.HeightInput.AutoSize = true;
      this.HeightInput.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.HeightInput.Location = new System.Drawing.Point(1081, 3);
      this.HeightInput.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
      this.HeightInput.Name = "HeightInput";
      this.HeightInput.Size = new System.Drawing.Size(62, 23);
      this.HeightInput.TabIndex = 1;
      this.HeightInput.ThousandsSeparator = true;
      this.HeightInput.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.HeightInput.ValueChanged += new System.EventHandler(this.HeightInput_ValueChanged);
      // 
      // Mainwindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1264, 681);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Mainwindow";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Mainwindow";
      this.Load += new System.EventHandler(this.Mainwindow_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.YInput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.XInput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox ScreenView;
    private System.Windows.Forms.Timer RecordTimer;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label LabelY;
    private System.Windows.Forms.NumericUpDown HeightInput;
    private System.Windows.Forms.Label LabelHeigth;
    private System.Windows.Forms.NumericUpDown WidthInput;
    private System.Windows.Forms.Label LabelWidth;
    private System.Windows.Forms.NumericUpDown YInput;
    private System.Windows.Forms.Label LabelX;
    private System.Windows.Forms.NumericUpDown XInput;
  }
}


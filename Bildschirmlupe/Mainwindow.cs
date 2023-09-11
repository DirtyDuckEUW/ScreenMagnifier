using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Bildschirmlupe
{
  public partial class Mainwindow : Form
  {
    Bitmap bitmap;
    Graphics graphic;
    int ScreenWidth = 1920;
    int ScreenHeight = 1080;
    int scaleFactor = 5;
    public Mainwindow()
    {
      InitializeComponent();
    }

    private void Mainwindow_Load(object sender, EventArgs e)
    {
      ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
      ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

      ScreenView.Width = (int)WidthInput.Value;
      ScreenView.Height = (int)HeightInput.Value;
      RecordTimer.Tick += new EventHandler(RecordTimer_Tick);
      CaptureScreenShot();
    }

    private void CreateImage()
    {
      Clear();
      CaptureScreenShot();
    }

    private void CaptureScreenShot()
    {
      int newWidth = (int)WidthInput.Value / scaleFactor;
      int newHeight = (int)HeightInput.Value / scaleFactor;
      int sourceX = ScreenWidth - newWidth + (int)XInput.Value;
      int sourceY = ScreenHeight - newHeight + (int)YInput.Value;
      Bitmap tmpbitmap = new Bitmap(newWidth, newHeight);
      graphic = Graphics.FromImage(tmpbitmap);
      graphic.CopyFromScreen(sourceX, sourceY, 0, 0, tmpbitmap.Size, CopyPixelOperation.SourceCopy);
      bitmap = new Bitmap(tmpbitmap, (int)WidthInput.Value, (int)HeightInput.Value);
      ScreenView.Image = bitmap;
      tmpbitmap.Dispose();
    }

    private void Clear()
    {
      graphic.Dispose();
      bitmap.Dispose();
      
    }

    private void RecordTimer_Tick(object sender, EventArgs e)
    {
      CreateImage();
    }

    private void WidthInput_ValueChanged(object sender, EventArgs e)
    {
      ScreenView.Width = (int)WidthInput.Value;
    }

    private void HeightInput_ValueChanged(object sender, EventArgs e)
    {
      ScreenView.Height = (int)HeightInput.Value;
    }
  } 
}

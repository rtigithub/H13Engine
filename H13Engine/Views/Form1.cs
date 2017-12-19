using System;
using System.Drawing;
using System.Windows.Forms;
using H13Engine.Models;
using HalconDotNet;
using Rti.Halcon;

namespace H13Engine
{
     public partial class Form1 : Form
     {
          #region Private Fields

          private HalconEngine halconEngine;
          private HalconImage halconImage;
          private HWindow halconWindow;

          #endregion Private Fields

          #region Public Constructors

          public Form1()
          {
               try
               {
                    InitializeComponent();
                    openImageDialog.InitialDirectory = Environment.GetEnvironmentVariable("HalconImages");
                    openHdevDialog.InitialDirectory = Environment.GetEnvironmentVariable("halconexamples") + @"\hdevengine\hdevelop";
                    openHdevDialog.FileName = "fin_detection";
               }
               catch (Exception)
               {
                    throw;
               }
          }

          #endregion Public Constructors

          #region Private Methods

          private void DisplayHdevelopProcedures()
          {
               foreach (var procedureName in halconEngine.HalconProcedures)
               {
                    listView1.Items.Add(procedureName);
               }
          }

          private void HalconMouseWheel(object sender, MouseEventArgs e)
          {
               Point pt = (sender as HSmartWindowControl).Location;
               MouseEventArgs newe = new MouseEventArgs(e.Button, e.Clicks,
                                                        e.X - pt.X, e.Y - pt.Y, e.Delta);
               (sender as HSmartWindowControl).HSmartWindowControl_MouseWheel(sender, newe);
          }

          private void HalconProcedureRun_Click(object sender, EventArgs e)
          {
          }

          private void HalconWindowControl_Load(object sender, EventArgs e)
          {
               if (sender is HSmartWindowControl)
               {
                    halconImage = new HalconImage();
                    halconEngine = new HalconEngine();
                    (sender as HSmartWindowControl).HKeepAspectRatio = true;
                    halconWindow = (sender as HSmartWindowControl).HalconWindow;
                    (sender as HSmartWindowControl).MouseWheel += HalconMouseWheel;
               }
          }

          private void HalconWindowControl_SizeChanged(object sender, EventArgs e)
          {
               if (sender is HSmartWindowControl)
               {
                    if (halconImage.IsValid())
                    {
                         halconWindow.SetPart(0, 0, halconImage.Height, halconImage.Width);
                         halconWindow.DispImage(halconImage);
                    }
                    //toolStripStatusLabel1.Text = "Width = " + (sender as HSmartWindowControl).Width;
                    //toolStripStatusLabel2.Text = "Height = " + (sender as HSmartWindowControl).Height;
               }
          }

          private void LoadAndDisplayHalconImage(string fileName)
          {
               halconImage.FileName = fileName;
               halconWindow.DispImage(halconImage);
               HalconWindowControl.SetFullImagePart(null);
               textBoxImageName.Text = openImageDialog.FileName;
          }

          private void LoadHdevelopProgram(string filename)
          {
               halconEngine.FileName = filename;
          }

          private void OpenHdevelopItem_Click(object sender, EventArgs e)
          {
               if (openHdevDialog.ShowDialog() == DialogResult.OK)
               {
                    LoadHdevelopProgram(openHdevDialog.FileName);
                    DisplayHdevelopProcedures();
               }
          }

          private void OpenImageItem_Click(object sender, EventArgs e)
          {
               toolStripStatusLabel1.Text = String.Empty;
               textBoxImageName.Text = String.Empty;
               try
               {
                    if (openImageDialog.ShowDialog() == DialogResult.OK)
                    {
                         LoadAndDisplayHalconImage(openImageDialog.FileName);
                    }
               }
               catch (HalconException halconException)
               {
                    toolStripStatusLabel1.Text = halconException.Message;
               }
          }

          #endregion Private Methods
     }
}
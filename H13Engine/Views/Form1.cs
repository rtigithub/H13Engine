// ***********************************************************************
// Assembly         : H13Engine
// Author           :
// Created          : 12-08-2017
// Last Modified On : 12-19-2017
// <copyright file="Form1.cs" company="Resolution Technology, Inc.">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Drawing;
using System.Windows.Forms;
using H13Engine.Models;
using HalconDotNet;
using Rti.Halcon;

namespace H13Engine
{
     /// <summary>
     /// Class Form1.
     /// </summary>
     /// <seealso cref="System.Windows.Forms.Form" />
     public partial class Form1 : Form
     {
          #region Private Fields

          /// <summary>
          /// The halcon engine
          /// </summary>
          private HalconEngine halconEngine;

          /// <summary>
          /// The halcon image
          /// </summary>
          private HalconImage halconImage;

          /// <summary>
          /// The halcon window
          /// </summary>
          private HWindow halconWindow;

          #endregion Private Fields

          #region Public Constructors

          /// <summary>
          /// Initializes a new instance of the <see cref="Form1"/> class.
          /// </summary>
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

          /// <summary>
          /// Displays the hdevelop procedures.
          /// </summary>
          private void DisplayHdevelopProcedures()
          {
               foreach (var procedureName in halconEngine.HalconProcedureNames)
               {
                    listView1.Items.Add(procedureName);
               }
          }

          /// <summary>
          /// Halcons the mouse wheel.
          /// </summary>
          /// <param name="sender">The sender.</param>
          /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
          private void HalconMouseWheel(object sender, MouseEventArgs e)
          {
               Point pt = (sender as HSmartWindowControl).Location;
               MouseEventArgs newe = new MouseEventArgs(e.Button, e.Clicks,
                                                        e.X - pt.X, e.Y - pt.Y, e.Delta);
               (sender as HSmartWindowControl).HSmartWindowControl_MouseWheel(sender, newe);
          }

          /// <summary>
          /// Handles the Click event of the HalconProcedureRun control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void HalconProcedureRun_Click(object sender, EventArgs e)
          {
          }

          /// <summary>
          /// Handles the Load event of the HalconWindowControl control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

          /// <summary>
          /// Handles the SizeChanged event of the HalconWindowControl control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

          /// <summary>
          /// Loads the and display halcon image.
          /// </summary>
          /// <param name="fileName">Name of the file.</param>
          private void LoadAndDisplayHalconImage(string fileName)
          {
               halconImage.FileName = fileName;
               halconWindow.DispImage(halconImage);
               HalconWindowControl.SetFullImagePart(null);
               textBoxImageName.Text = openImageDialog.FileName;
          }

          /// <summary>
          /// Loads the hdevelop program.
          /// </summary>
          /// <param name="filename">The filename.</param>
          private void LoadHdevelopProgram(string filename)
          {
               halconEngine.FileName = filename;
          }

          /// <summary>
          /// Handles the Click event of the OpenHdevelopItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void OpenHdevelopItem_Click(object sender, EventArgs e)
          {
               if (openHdevDialog.ShowDialog() == DialogResult.OK)
               {
                    LoadHdevelopProgram(openHdevDialog.FileName);
                    DisplayHdevelopProcedures();
               }
          }

          /// <summary>
          /// Handles the Click event of the OpenImageItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
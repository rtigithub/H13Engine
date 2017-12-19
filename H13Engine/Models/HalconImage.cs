// ***********************************************************************
// Assembly         : H13Engine
// Author           :
// Created          : 12-08-2017
// Last Modified On : 12-19-2017
// <copyright file="HalconImage.cs" company="Resolution Technology, Inc.">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using HalconDotNet;

namespace H13Engine.Models
{
     /// <summary>
     /// Class HalconImage.
     /// </summary>
     /// <seealso cref="HalconDotNet.HImage" />
     internal class HalconImage : HImage
     {
          #region Private Fields

          /// <summary>
          /// The file name
          /// </summary>
          private string _fileName;

          /// <summary>
          /// The height
          /// </summary>
          private int height = 480;

          /// <summary>
          /// The width
          /// </summary>
          private int width = 640;

          #endregion Private Fields

          #region Public Constructors

          /// <summary>
          /// Initializes a new instance of the <see cref="HalconImage"/> class.
          /// </summary>
          public HalconImage()
          {
               this.GenImageConst("byte", width, height);
          }

          #endregion Public Constructors

          #region Public Properties

          /// <summary>
          /// Gets or sets the name of the file.
          /// </summary>
          /// <value>The name of the file.</value>
          public string FileName
          {
               get
               {
                    return _fileName;
               }

               internal set
               {
                    _fileName = value;
                    this.Dispose();
                    this.ReadImage(_fileName);
                    this.GetImageSize(out width, out height);
               }
          }

          /// <summary>
          /// Gets the height.
          /// </summary>
          /// <value>The height.</value>
          public int Height => this.height;

          /// <summary>
          /// Gets the width.
          /// </summary>
          /// <value>The width.</value>
          public int Width => this.width;

          #endregion Public Properties
     }
}
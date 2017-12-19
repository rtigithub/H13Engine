using HalconDotNet;

namespace H13Engine.Models
{
     internal class HalconImage : HImage
     {
          #region Private Fields

          private string _fileName;
          private int height = 480;
          private int width = 640;

          #endregion Private Fields

          #region Public Constructors

          public HalconImage()
          {
               this.GenImageConst("byte", width, height);
          }

          #endregion Public Constructors

          #region Public Properties

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

          public int Height => this.height;
          public int Width => this.width;

          #endregion Public Properties
     }
}
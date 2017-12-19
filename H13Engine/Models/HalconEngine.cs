// ***********************************************************************
// Assembly         : H13Engine
// Author           :
// Created          : 12-08-2017
// Last Modified On : 12-19-2017
// <copyright file="HalconEngine.cs" company="Resolution Technology, Inc.">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.IO;
using HalconDotNet;

namespace H13Engine.Models
{
     /// <summary>
     /// Class HalconEngine.
     /// </summary>
     /// <seealso cref="System.IDisposable" />
     internal class HalconEngine : IDisposable
     {
          #region Private Fields

          /// <summary>
          /// The halcon procedure names
          /// </summary>
          private string[] _halconProcedureNames;

          /// <summary>
          /// The disposed value
          /// </summary>
          private bool disposedValue = false;

          /// <summary>
          /// The file name
          /// </summary>
          private string fileName;

          #endregion Private Fields

          #region Public Constructors

          /// <summary>
          /// Initializes a new instance of the <see cref="HalconEngine"/> class.
          /// </summary>
          public HalconEngine()
          {
               try
               {
                    HalconProgramEngine = new HDevEngine();
               }
               catch (HDevEngineException halconEngineException)
               {
                    throw;
               }
          }

          #endregion Public Constructors

          #region Public Properties

          /// <summary>
          /// Sets the name of the file.
          /// </summary>
          /// <value>The name of the file.</value>
          public string FileName
          {
               //get { };
               set
               {
                    if (File.Exists(value))
                    {
                         fileName = value;
                         try
                         {
                              HalconProgramEngine.SetProcedurePath(Environment.GetEnvironmentVariable("halconexamples") + @"\hdevengine\procedures");
                              HalconProgram = new HDevProgram(value);
                              HalconProgramCall = new HDevProgramCall(HalconProgram);
                              HalconProcedureNames = HalconProgram.GetLocalProcedureNames().ToSArr();
                         }
                         catch (HDevEngineException halconEngineException)
                         {
                              throw;
                         }
                    }
               }
          }

          /// <summary>
          /// Gets the halcon procedure names.
          /// </summary>
          /// <value>The halcon procedure names.</value>
          public string[] HalconProcedureNames
          {
               get
               {
                    return _halconProcedureNames;
               }
               private set
               {
                    _halconProcedureNames = value;
               }
          }

          /// <summary>
          /// Gets the halcon program.
          /// </summary>
          /// <value>The halcon program.</value>
          public HDevProgram HalconProgram { get; private set; }

          /// <summary>
          /// Gets the halcon program call.
          /// </summary>
          /// <value>The halcon program call.</value>
          public HDevProgramCall HalconProgramCall { get; private set; }

          /// <summary>
          /// Gets the halcon program engine.
          /// </summary>
          /// <value>The halcon program engine.</value>
          public HDevEngine HalconProgramEngine { get; private set; }

          #endregion Public Properties

          // To detect redundant calls

          #region Public Methods

          // This code added to correctly implement the disposable pattern.
          /// <summary>
          /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
          /// </summary>
          public void Dispose()
          {
               // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
               Dispose(true);
               // TODO: uncomment the following line if the finalizer is overridden above.
               // GC.SuppressFinalize(this);
          }

          #endregion Public Methods

          #region Protected Methods

          /// <summary>
          /// Releases unmanaged and - optionally - managed resources.
          /// </summary>
          /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
          protected virtual void Dispose(bool disposing)
          {
               if (!disposedValue)
               {
                    if (disposing)
                    {
                         // TODO: dispose managed state (managed objects).
                         HalconProgramCall?.Dispose();
                         HalconProgram?.Dispose();
                    }

                    // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                    // TODO: set large fields to null.

                    disposedValue = true;
               }
          }

          #endregion Protected Methods

          // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
          // ~HalconEngine() {
          //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
          //   Dispose(false);
          // }
     }
}
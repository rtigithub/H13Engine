using System;
using System.IO;
using HalconDotNet;

namespace H13Engine.Models
{
     internal class HalconEngine
     {
          #region Private Fields

          private string[] _halconProcedures;
          private string fileName;

          #endregion Private Fields

          #region Public Constructors

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
                              HalconProcedures = HalconProgram.GetLocalProcedureNames().ToSArr();
                         }
                         catch (HDevEngineException halconEngineException)
                         {
                              throw;
                         }
                    }
               }
          }

          public string[] HalconProcedures
          {
               get
               {
                    return _halconProcedures;
               }
               private set
               {
                    _halconProcedures = value;
               }
          }

          public HDevProgram HalconProgram { get; private set; }
          public HDevProgramCall HalconProgramCall { get; private set; }
          public HDevEngine HalconProgramEngine { get; private set; }

          #endregion Public Properties
     }
}
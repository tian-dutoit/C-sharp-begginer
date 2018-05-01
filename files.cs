using System;
using System.IO;

namespace C_sharp_begginer
{
  public class Files {
    static void fileDemo () {
      File.Copy("c:\\temp\\tocopy.jpg", "c:\\temp\\myflie.jpg");
      File.Delete("path");
      if (File.Exists("path"))
      {
          //do something
      }
      var content = File.ReadAllText("path");
    }

    static void fileInfoDemo () {
      var fileInfo = new FileInfo("path");
      fileInfo.CopyTo("...");
      fileInfo.Delete();
    }

      static void directoryDemo () {
        Directory.CreateDirectory("path");
        Directory.GetFiles("path", "search patter like .jpg", SearchOption.AllDirectories);
    }
  }
}
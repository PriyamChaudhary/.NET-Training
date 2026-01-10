using System.Collections.Concurrent;
using System.IO;


namespace FileIODemo;

public class DirectoryDemo
{
    public void DirectoryDemoFunc(string directoryName)
    {
        if (Directory.Exists(directoryName)) //USING DIRECTORY CLASS
        {
            System.Console.WriteLine("Folder already exists");
        }
        else
        {
            Directory.CreateDirectory(directoryName);
            System.Console.WriteLine("Folder created...");
        }
    }
    public void DriveInfoFunc(string driveName)
    {
        DriveInfo dInfo=new DriveInfo(driveName);
        System.Console.WriteLine($"Drive Name {dInfo.Name}");
        System.Console.WriteLine($"Drive FileSystem {dInfo.DriveType}");
        System.Console.WriteLine($"Drive Size {dInfo.TotalSize}");
        System.Console.WriteLine($"Drive Free Space {dInfo.AvailableFreeSpace}");

    }
    public void PathDemo()
    {
        //USING PATH CLASS
        string s=@"C:\temp\MyData.text\machine.config"; //here @ is path separator, it's not feasible here to write double slash multiple times
        System.Console.WriteLine(Path.GetFileName(s));
        System.Console.WriteLine(Path.GetTempPath());
    }
    

}

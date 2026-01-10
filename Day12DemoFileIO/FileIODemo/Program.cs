using FileIODemo;

DirectoryDemo dirObj=new DirectoryDemo();
// dirObj.DirectoryDemoFunc("LPU_FileIO"); //DIRECTORY

// dirObj.DriveInfoFunc("D:\\");

FileStreamDemo fsDemoObj = new FileStreamDemo(); //FILE STREAM
// fsDemoObj.CreateFile(@"d:\.NET\Sampledata.txt");
fsDemoObj.ReadFile(@"d:\.Net\myconsoleapp\test.cs");


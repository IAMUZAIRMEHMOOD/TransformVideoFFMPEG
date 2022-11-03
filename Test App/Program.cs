// See https://aka.ms/new-console-template for more information
using TransformVideo;

Console.WriteLine("Enter Input File Location:");
Console.ReadKey();
string input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4";
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4");
Console.ReadKey();
Console.WriteLine("Enter Output Path: ");
Console.ReadKey();
string output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\";
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\");
transformvideo FF = new transformvideo();
//int quaity = 480;
FF.convertvideo(inputPath: input, outputPath: output);
Console.ReadKey();
// See https://aka.ms/new-console-template for more information
using TransformVideo;

Console.WriteLine("Enter Input File Location:");
string input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4";
Console.WriteLine("Enter Output Path: ");
string output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\";
ffmpeglib FF = new ffmpeglib();
FF.convert(inputPath: input, outputPath: output);
Console.ReadKey();
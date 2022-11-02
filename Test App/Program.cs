// See https://aka.ms/new-console-template for more information
using TransformVideo;

Console.WriteLine("Enter Input File Location:");
string input = Console.ReadLine();
Console.WriteLine("Enter Output Path: ");
string output = Console.ReadLine();
ffmpeglib FF = new ffmpeglib();
FF.convert(inputPath: input, outputPath: output);
// See https://aka.ms/new-console-template for more information
using TransformVideo;
//-----------------Converting 480------------------
//Declaring Variables
//int quality; 
string input, output;
//Input Video Location
Console.WriteLine("Enter Input File Location: ");
Console.ReadKey();
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4";
//Output Path 
Console.WriteLine("Enter Output Path: ");
Console.ReadKey();
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\";
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\");
//Console.Write("Enter video quality: ");
//quality = 480;
transformvideo Transform = new transformvideo();
Transform.convertvideo(inputPath: input, outputPath: output);
Console.ReadKey();
////-----------------Converting 720------------------
////Input Video Location
//Console.Write("Enter Input File Location: ");
//Console.ReadKey();
//Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4");
//input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4";
////Output Path 
//Console.Write("Enter Output Path: ");
//Console.ReadKey();
//output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\";
//Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\");
//Console.Write("Enter video quality: ");
//quality = 720;
//Console.WriteLine("720p");
//Console.ReadKey();
//Transform.convertvideo(inputPath: input, outputPath: output, quality);
//Console.ReadKey();
////-----------------Converting 1080------------------
////Input Video Location
//Console.Write("Enter Input File Location: ");
//Console.ReadKey();
//Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4");
//input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4";
////Output Path 
//Console.Write("Enter Output Path: ");
//Console.ReadKey();
//output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\";
//Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\");
//Console.Write("Enter video quality: ");
//quality = 1080;
//Console.WriteLine("1080p");
//Console.ReadKey();
//Transform.convertvideo(inputPath: input, outputPath: output, quality);
//Console.ReadKey();
// See https://aka.ms/new-console-template for more information
using TransformVideo;
//-----------------Converting 480------------------
//Declaring Variables
int quality;
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
//Video Quality
Console.WriteLine("Enter video quality: ");
Console.ReadKey();
quality = 480;
Console.WriteLine("480p");
transformvideo Transform = new transformvideo();
Transform.convertvideo(inputPath: input, outputPath: output, vidQuality: quality);
Console.ReadKey();
////-----------------Converting 720------------------
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
//Video Quality
Console.WriteLine("Enter video quality: ");
Console.ReadKey();
quality = 720;
Console.WriteLine("720p");
transformvideo Transform1 = new transformvideo();
Transform1.convertvideo(inputPath: input, outputPath: output, vidQuality: quality);
Console.ReadKey();
////-----------------Converting 1080------------------
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
//Video Quality
Console.WriteLine("Enter video quality: ");
Console.ReadKey();
quality = 1080;
Console.WriteLine("1080p");
transformvideo Transform2 = new transformvideo();
Transform2.convertvideo(inputPath: input, outputPath: output, vidQuality: quality);
Console.ReadKey();
// See https://aka.ms/new-console-template for more information
using TransformVideo;
//Declaring Variables
string input, input2, output, watermark;
int time, start, end;
////-----------------Combine Video------------------
/////Input1 Video Location
Console.WriteLine("Enter 1st Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\comb1.mp4");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\comb1.mp4";
Console.ReadKey();
//Input2 Video Location
Console.WriteLine("Enter 2st Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\comb2.mp4");
input2 = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\comb2.mp4";
//Output Path 
Console.WriteLine("Enter Output Path: ");
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\";
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\");
Console.ReadKey();
Console.WriteLine("\n\t\tCombining Videos....");
transformvideo Transform6 = new transformvideo();
Transform6.combinevideos(inputPath1: input, inputPath2: input2, outputPath: output);
Console.ReadKey();
////-----------------Split Video------------------
/////Input Video Location
Console.WriteLine("Entering Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\video.mp4");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\video.mp4";
Console.ReadKey();
//Output Path 
Console.WriteLine("Enter Output Path: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\");
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\";
Console.ReadKey();
Console.WriteLine("Enter Start Time in Seconds: ");
Console.WriteLine("60");
start = 60;
Console.ReadKey();
Console.WriteLine("Enter Split in Seconds: ");
Console.WriteLine("15");
end = 15;
Console.ReadKey();
Console.WriteLine("\n\t\tSplitting Video....");
transformvideo Transform8 = new transformvideo();
Transform8.splitvideo(inputPath: input, outputPath: output, startTime: start, endTime: end);
Console.ReadKey();
////-----------------Take Snapshot------------------
/////Input Video Location
Console.WriteLine("Enter Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\video.mp4");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\video.mp4";
Console.ReadKey();
//Output Path 
Console.WriteLine("Enter Output Path: ");
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\";
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\");
Console.ReadKey();
//Watermark Path
Console.WriteLine("Enter Time in Second to Take Snapshot: ");
Console.WriteLine("30");
time = 30;
Console.WriteLine("\n\t\tSnapshot Saved....");
transformvideo Transform7 = new transformvideo();
Transform7.takesnapshot(inputPath: input, outputPath: output, timeinsec: time);
Console.ReadKey();
////-----------------Add Watermark------------------
/////Input Video Location
Console.WriteLine("Enter Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4";
Console.ReadKey();
//Output Path 
Console.WriteLine("Enter Output Path: ");
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\";
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\");
Console.ReadKey();
//Watermark Path
Console.WriteLine("Enter Watermark Path: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\watermark.png");
watermark = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\watermark.png";
Console.WriteLine("\n\t\tAdding Watermark....");
transformvideo Transform5 = new transformvideo();
Transform5.addwatermark(inputPath: input, outputPath: output, watermark);
Console.ReadKey();
////-----------------Trimming Video------------------
/////Input Video Location
Console.WriteLine("Entering Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\video.mp4");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\video.mp4";
Console.ReadKey();
//Output Path 
Console.WriteLine("Enter Output Path: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\");
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\";
Console.ReadKey();
Console.WriteLine("Enter Start Time in Seconds: ");
Console.WriteLine("11");
start = 11;
Console.ReadKey();
Console.WriteLine("Enter End Time in Seconds: ");
Console.WriteLine("40");
end = 40;
Console.ReadKey();
Console.WriteLine("\n\t\tTrimming Video....");
transformvideo Transform4 = new transformvideo();
Transform4.trimmingvideo(inputPath: input, outputPath: output, startTime: start, endTime: end);
Console.ReadKey();
////-----------------Converting To MP4------------------
/////Input Video Location
Console.WriteLine("Enter Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\convert.webm");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\convert.webm";
Console.ReadKey();
//Output Path 
Console.WriteLine("Enter Output Path: ");
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\";
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\");
Console.ReadKey();
Console.WriteLine("\n\t\tConverting Video To mp4....");
transformvideo Transform3 = new transformvideo();
Transform3.converttomp4(inputPath: input, outputPath: output);
Console.ReadKey();
////-----------------Converting 480------------------
//Declaring Variables
int quality;
//Input Video Location
Console.WriteLine("Enter Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4";
Console.ReadKey();
//Output Path 
Console.WriteLine("Enter Output Path: ");
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\";
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\");
Console.ReadKey();
//Video Quality
Console.WriteLine("Enter video quality: ");
Console.WriteLine("480p");
quality = 480;
Console.ReadKey();
Console.WriteLine("\n\t\tConverting Video To 480p....");
transformvideo Transform = new transformvideo();
Transform.convertvideo(inputPath: input, outputPath: output, vidQuality: quality);
Console.ReadKey();
////-----------------Converting 720------------------
//Input Video Location
Console.WriteLine("Enter Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4";
Console.ReadKey();
//Output Path 
Console.WriteLine("Enter Output Path: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\");
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\";
Console.ReadKey();
//Video Quality
Console.WriteLine("Enter video quality: ");
Console.WriteLine("720p");
quality = 720;
Console.ReadKey();
Console.WriteLine("\n\t\tConverting Video To 720p....");
transformvideo Transform1 = new transformvideo();
Transform1.convertvideo(inputPath: input, outputPath: output, vidQuality: quality);
Console.ReadKey();
////-----------------Converting 1080------------------
//Input Video Location
Console.WriteLine("Enter Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4";
Console.ReadKey();
//Output Path 
Console.WriteLine("Enter Output Path: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\");
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\";
Console.ReadKey();
//Video Quality
Console.WriteLine("Enter video quality: ");
Console.WriteLine("1080p");
quality = 1080;
Console.ReadKey();
transformvideo Transform2 = new transformvideo();
Transform2.convertvideo(inputPath: input, outputPath: output, vidQuality: quality);
Console.WriteLine("\n\t\tConverting Video To 1080p....");
Console.ReadKey();
/*
//////-----------------Stop Conversion------------------
//Input Video Location
Console.WriteLine("Enter Input File Location: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4");
input = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\input.mp4";
Console.ReadKey();
//Output Path 
Console.WriteLine("Enter Output Path: ");
Console.WriteLine(@"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\");
output = @"C:\Users\uzair.mehmood\Desktop\ffmpeg\converted\";
Console.ReadKey();
transformvideo Transform5 = new transformvideo();
Transform5.stopconversion(inputPath: input, outputPath: output);
Console.WriteLine("\n\t\tStopping Conversion....");
Console.ReadKey();
*/
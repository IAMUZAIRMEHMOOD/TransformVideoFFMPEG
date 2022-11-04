using Xabe.FFmpeg;
using System.IO;
using static System.Net.WebRequestMethods;
using Xabe.FFmpeg.Exceptions;
using System.Resources;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TransformVideo
{
    public class transformvideo
    {
        static transformvideo()
        {
            FFmpeg.SetExecutablesPath(@"C:\Users\uzair.mehmood\Desktop\ffmpeg");
        }
        /*  public async Task<bool> stopconversion(string inputPath, string outputPath)
          {
              try
              {  
                  var CancellationTokenSource = new CancellationTokenSource();
                  outputPath = Path.Combine(outputPath, "StoppedVideo.mp4");
                  IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                  IStream audioStream = mediaInfo.AudioStreams.FirstOrDefault()
                  .SetCodec(AudioCodec.aac);
                  IStream videoStream = mediaInfo.VideoStreams.FirstOrDefault()
                  .SetCodec(VideoCodec.h264);
                   await FFmpeg.Conversions.New()
                  .AddStream(audioStream, videoStream)
                  .SetOutput(outputPath)
                  .Start(CancellationTokenSource.Token);
                  CancellationTokenSource.Cancel();
              }
              catch (Exception e)
                  {
                      Console.WriteLine(e.Message);
                  }
                  return true;
          }*/
            public async Task<bool> splitvideo(string inputPath, string outputPath, int startTime, int endTime)
            {
                try
                {
                    outputPath = Path.Combine(outputPath, "splittedvideo.mp4");
                    IConversion conversion = await FFmpeg.Conversions
                   .FromSnippet
                   .Split(inputPath, outputPath, TimeSpan.FromSeconds(startTime),TimeSpan.FromSeconds(endTime));
                    IConversionResult result = await conversion.Start();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                return true;
            }
            public async Task<bool> takesnapshot(string inputPath, string outputPath, int timeinsec)
                {
                    try
                    {
                        //outputPath = Path.Combine(outputPath, "snapshot",Path.GetTempFileName(),".png");
                        outputPath = Path.Combine(outputPath, "snapshot.png");
                        IConversion conversion = await FFmpeg.Conversions
                       .FromSnippet
                       .Snapshot(inputPath,outputPath,TimeSpan.FromSeconds(timeinsec));
                        IConversionResult result =   await conversion.Start();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                    return true;
                }
            public async Task<bool> combinevideos(string inputPath1, string inputPath2,string outputPath)
                {
                    try
                    {
                        outputPath = Path.Combine(outputPath, "Combinedvideo.mp4");
                         var conversion = await FFmpeg.Conversions
                        .FromSnippet
                        .Concatenate(outputPath, inputPath1, inputPath2);
                        await conversion.Start();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                    return true;
                }

            public async Task<bool> addwatermark(string inputPath, string outputPath, string watermarkPath)
                {
                    try
                    {
                         outputPath = Path.Combine(outputPath, "Videowithwatermark.mp4");
                         IConversion conversion = await FFmpeg.Conversions
                        .FromSnippet
                        .SetWatermark(inputPath, outputPath, watermarkPath, Position.BottomRight);
                         IConversionResult result = await conversion.Start();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                    return true;
                }
            public async Task<bool> trimmingvideo(string inputPath, string outputPath,int startTime,int endTime)
                {
                    try
                    {
                        outputPath = Path.Combine(outputPath, "Trimmedvideo.mp4");
                        IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                        IStream audioStream = mediaInfo.AudioStreams.FirstOrDefault()
                       .SetCodec(AudioCodec.aac);
                        IStream videoStream = mediaInfo.VideoStreams.FirstOrDefault()
                       .SetCodec(VideoCodec.h264);
                        await FFmpeg.Conversions.New()
                       .AddParameter($"-ss {startTime} -t {endTime}")
                       //.AddParameter("-s 1010x1080")
                       .AddStream(audioStream,videoStream)
                       .SetOutput(outputPath)
                       .Start();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                    return true;
                }
            public async Task<bool> converttomp4(string inputPath, string outputPath)
            {
                try
                {
                    outputPath = Path.Combine(outputPath, "convertedtomp4.mp4");
                    IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                    IStream audioStream = mediaInfo.AudioStreams.FirstOrDefault()
                   .SetCodec(AudioCodec.aac);
                    IStream videoStream = mediaInfo.VideoStreams.FirstOrDefault()
                   .SetCodec(VideoCodec.h264);
                    await FFmpeg.Conversions.New()
                   .AddStream(audioStream, videoStream)
                   .SetOutput(outputPath)
                   .Start();
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
           
                }
            return true;
            }
            public async Task<bool> convertvideo(string inputPath, string outputPath, int vidQuality)
            {

                try
                {

                    //IStream mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                    //IStream videoStream = mediaInfo.VideoStreams.First();
                    switch (vidQuality)
                    {

                        case 480:
                            outputPath = Path.Combine(outputPath, "convertedto480p.mp4");
                            IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                            IStream audioStream = mediaInfo.AudioStreams.FirstOrDefault()
                           .SetCodec(AudioCodec.aac);
                            IStream videoStream = mediaInfo.VideoStreams.FirstOrDefault()
                           .SetCodec(VideoCodec.h264)
                           .SetSize(VideoSize.Hd480);
                            await FFmpeg.Conversions.New()
                           .AddStream(audioStream, videoStream)
                           .SetOutput(outputPath)
                           .Start();
                            break;
                        case 720:
                            outputPath = Path.Combine(outputPath, "convertedto720p.mp4");
                            mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                            audioStream = mediaInfo.AudioStreams.FirstOrDefault()
                            .SetCodec(AudioCodec.aac);
                            videoStream = mediaInfo.VideoStreams.FirstOrDefault()
                           .SetCodec(VideoCodec.h264)
                           .SetSize(VideoSize.Hd720);
                            await FFmpeg.Conversions.New()
                           .AddStream(audioStream, videoStream)
                           .SetOutput(outputPath)
                           .Start();
                            break;
                        case 1080:
                            outputPath = Path.Combine(outputPath, "convertedto1080p.mp4");
                            mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                            audioStream = mediaInfo.AudioStreams.FirstOrDefault()
                            .SetCodec(AudioCodec.aac);
                            videoStream = mediaInfo.VideoStreams.FirstOrDefault()
                           .SetCodec(VideoCodec.h264)
                           .SetSize(VideoSize.Hd1080);
                            await FFmpeg.Conversions.New()
                           .AddStream(audioStream, videoStream)
                           .SetOutput(outputPath)
                           .Start();
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return true;
            }

    }
}
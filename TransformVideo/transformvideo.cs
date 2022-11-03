using Xabe.FFmpeg;
using System.IO;
using static System.Net.WebRequestMethods;
using Xabe.FFmpeg.Exceptions;
using System.Resources;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace TransformVideo
{
    public class transformvideo
    {
        static transformvideo()
        {
             FFmpeg.SetExecutablesPath(@"C:\Users\uzair.mehmood\Desktop\ffmpeg");
        }
        public async Task<bool> convertvideo(string inputPath, string outputPath)
        {


            //try
            //{

            //    outputPath = Path.Combine(outputPath, "convertedto480p.mp4");
            //    var mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
            //    var videoStream = mediaInfo.VideoStreams.First()
            //   .SetCodec(VideoCodec.h264)
            //   .SetSize(VideoSize.Hd480);
            //    await FFmpeg.Conversions.New()
            //   .AddStream(videoStream)
            //   .SetOutput(outputPath)
            //   .Start();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //return true;




            try
            {
                //var mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                //var videoStream = mediaInfo.VideoStreams.First();
                //switch (vidQuality)
                //{

                //    case 480:
                        outputPath = Path.Combine(outputPath, "convertedto480p.mp4");
                        IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                        IStream audioStream = mediaInfo.AudioStreams.FirstOrDefault()
                       .SetCodec(AudioCodec.aac);
                        IStream videoStream = mediaInfo.VideoStreams.FirstOrDefault()
                       .SetCodec(VideoCodec.h264)
                       .SetSize(VideoSize.Hd480);
                        FFmpeg.Conversions.New()
                       .AddStream(audioStream,videoStream)
                       .SetOutput(outputPath)
                       .Start();

                //        break;
                //    case 720:
                //        outputPath = Path.Combine(outputPath, "convertedto720p.mp4");
                //        mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                //        videoStream = mediaInfo.VideoStreams.First()
                //       .SetCodec(VideoCodec.h264)
                //       .SetSize(VideoSize.Hd720);
                //        await FFmpeg.Conversions.New()
                //       .AddStream(videoStream)
                //       .SetOutput(outputPath)
                //       .Start();
                //        break;
                //    case 1080:
                //        outputPath = Path.Combine(outputPath, "convertedto1080p.mp4");
                //        mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                //        videoStream = mediaInfo.VideoStreams.First()
                //       .SetCodec(VideoCodec.h264)
                //       .SetSize(VideoSize.Hd720);
                //        await FFmpeg.Conversions.New()
                //       .AddStream(videoStream)
                //       .SetOutput(outputPath)
                //       .Start();
                //        break;
                //}


            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        }
}
using Xabe.FFmpeg;
using System.IO;
using static System.Net.WebRequestMethods;
using Xabe.FFmpeg.Exceptions;
using System.Resources;
using System.Linq.Expressions;

namespace TransformVideo
{
    public class ffmpeglib
    {
        public static void setffmpegpath()
        {
            FFmpeg.SetExecutablesPath(@"C:\Users\uzair.mehmood\Desktop\GTP\TransformVideo\ffmpeg");
        }
        public async Task<bool> convert(string inputPath, string outputPath)
        {
            try 
            { 
            outputPath = Path.Combine(outputPath, "converted.mp4");
            var mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
            var videoStream = mediaInfo.VideoStreams.First()
                .SetCodec(VideoCodec.h264)
                .SetSize(VideoSize.Hd480);
            await FFmpeg.Conversions.New()
                .AddStream(videoStream)
                .SetOutput(outputPath)
                .Start();
            }
        
            catch(Exception e)
                {
                     Console.WriteLine(e.Message);
                }
            return true;
        }
        
    }
}
using System;
namespace FairyFileRenamerProject
{
    public class YouTubeVideo
    {
        public string id, title, description;
        public DateTime publishDate;

        public YouTubeVideo(string id)
        {
            this.id = id;
            YouTubeApi.GetVideoInfo(this);
        }
    }
}
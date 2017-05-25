using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Discovery.v1;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace FairyFileRenamerProject
{
    class YouTubeApi
    {
        private static YouTubeService ytService = Auth();

        private static YouTubeService Auth()
        {
            UserCredential creds;
            using (var stream = new FileStream("youtube_client_secret.json", FileMode.Open, FileAccess.Read))
            {
                creds = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.YoutubeReadonly },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("YouTubeAPI")
                    ).Result;

            }

            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = creds,
                ApplicationName = "FairyDownloader"
            });
            return service;
            
        }

        internal static YouTubeVideo[] GetPlayList(string playListID)
        {
            var request = ytService.PlaylistItems.List("contentDetails");
            request.PlaylistId = playListID;
           

            LinkedList<YouTubeVideo> videos = new LinkedList<YouTubeVideo>();
            string nextPage = "";
            while (nextPage != null)
            {
                request.PageToken = nextPage;
                var response = request.Execute();

                foreach (var item in response.Items)
                {
                    videos.AddLast(new YouTubeVideo(item.ContentDetails.VideoId));
                }
                nextPage = response.NextPageToken;
            }
            return videos.ToArray<YouTubeVideo>();
        }

        public static void GetVideoInfo(YouTubeVideo video)
        {

            var videoRequest = ytService.Videos.List("snippet");
            videoRequest.Id = video.id;

            var response = videoRequest.Execute();
            if (response.Items.Count > 0)
            {
                video.title = response.Items[0].Snippet.Title;
                video.description = response.Items[0].Snippet.Description;
                video.publishDate = response.Items[0].Snippet.PublishedAt.Value;
            }
            else
            {
                //Error handling
            }
        }

    }
}

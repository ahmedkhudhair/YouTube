using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;


namespace YouTube.Models
{
    public class Post
    {

        public int ID { get; set; }

        public string PostTitle { get; set; }

        public PostType Post_Type { get; set; }

        public HttpPostedFileBase PostViewImage { get; set; }

        private string _postViewImagePath;

        public string PostViewImagePath
        {
            get
            {
                return _postViewImagePath;
            }
            set
            {
                value = System.Web.HttpContext.Current.Server.MapPath("~\\Content\\Images\\PostViewImage") + _postViewImagePath;
            }
        }

        private string _PostPath;

        public string PostPath
        {
            get
            {
                return _PostPath;
            }
            set
            {
                if (Post_Type == PostType.Video)
                {
                    _PostPath = System.Web.HttpContext.Current.Server.MapPath("~\\Content\\Videos");
                }
                else
                {
                    _PostPath = System.Web.HttpContext.Current.Server.MapPath("~\\Content\\Images");
                }
            }
        }

        //public byte[] Data { get; set; }

        //public string Base64String { get; set; }

        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();


        //public static Byte[] ConvertVideoToBytes(Stream Stream)
        //{
        //    MemoryStream target = new MemoryStream();
        //    Stream.CopyTo(target);
        //    Byte[] data = target.ToArray();
        //    return data;
        //}
    }

    public enum PostType
    {
        Video,
        Image
    }


}
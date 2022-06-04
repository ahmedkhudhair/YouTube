using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YouTube.Models;

namespace YouTube.Controllers.Video
{
    public class VideoController :ControllerBase //ApiController
    {

        //  /api/VideoApi/GetAllVideos
        [System.Web.Http.HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Post>> GetAllVideos()
        {

            DBMS db = new DBMS();
            DataTable table = db.ExecuteSelectQuery("select post_title,postpath from post");

            //User usr = new User();
            List<Post> posts = new List<Post>();
            foreach (DataRow item in table.Rows)
            {
                //post.PostTitle = item["post_title"].ToString();
                //post.Data = (Byte[])item["poststream"];
                //post.Base64String = Convert.ToBase64String(post.Data, 0, post.Data.Length);
                //usr.Posts.Add(post);
                posts.Add(new Post() { PostTitle = item["post_title"].ToString(), PostPath = item["postpath"].ToString() });
            }    //Post post = new Post();
            

            return posts;
        }


        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Post> GetVideo(string id)
        {

            DBMS db = new DBMS();
            DataTable table = db.ExecuteSelectQuery("select post_title,postpath from post where postid = " + id + " ");

            //User usr = new User();
            Post post = new Post();
            foreach (DataRow item in table.Rows)
            {
                //Post post = new Post();
                //post.PostTitle = item["post_title"].ToString();
                //post.Data = (Byte[])item["poststream"];
                //post.Base64String = Convert.ToBase64String(post.Data, 0, post.Data.Length);
                //usr.Posts.Add(post);
                post.PostTitle = item["post_title"].ToString();
                post.PostPath = item["postpath"].ToString();
            }

            return post;
        }


        [System.Web.Http.HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Post> UploadVideo([Microsoft.AspNetCore.Mvc.FromBody] Post post)
        {
            DBMS db = new DBMS();
            //bool ok = db.ExecuteInsertQuery(" insert into post (post_title, post_type, poststream) values" +" ('" + post.PostTitle + "' ,'" + post.PostType  + "' ,'" + Post.ConvertVideoToBytes(post.PostStream.InputStream) + "' )");
            var bytes = post.PostPath;
            //post.Base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
            bool ok = db.ExecuteInsertQuery(" insert into post (post_title, postpath) values" + " ('" + post.PostTitle + "' ,'" + post.PostPath + "' )");
            return CreatedAtAction(nameof(GetVideo), new { post.ID }, post);
        }

    }
}

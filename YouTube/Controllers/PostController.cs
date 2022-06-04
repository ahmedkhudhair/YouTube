using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouTube.Models;

namespace YouTube.Controllers
{
    public class PostController : Controller
    {
        // GET: Video
        [HttpGet]
        public ActionResult All()
        {

            DBMS db = new DBMS();
            DataTable table = db.ExecuteSelectQuery("select * from post");

            User usr = new User();
            foreach (DataRow item in table.Rows)
            {
                Post post = new Post();
                //post.PostViewImage = item["PostViewImagePath"].ToString();
                post.PostTitle = item["post_title"].ToString();
                post.PostPath = item["postpath"].ToString();                
                usr.Posts.Add(post);
            }

            return View(usr); 
        }

        public ActionResult AllPosts()
        {
            return View();
        }

        #region Upload video

        
            [HttpGet]
            public ActionResult UploadVideo()
            {
                return View();
            }

            [HttpPost]
            public ActionResult UploadVideo(Post post)
            {
                DBMS db = new DBMS();
                bool ok = db.ExecuteInsertQuery(" insert into post (post_title, post_type, postpath) values" + " ('" + post.PostTitle + "' ,'" + post.Post_Type + "' ,'" + post.PostPath + "' )");
                return View();
            }

        #endregion

#region UploadPost

        [HttpGet]
        public ActionResult UploadPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadPost(Post post)
        {
            DBMS db = new DBMS();

            bool ok = db.ExecuteInsertQuery($" insert into post (userid , post_title, post_type , PostViewImagePath, postpath) values ('1, {post.PostTitle}' ,'{post.Post_Type}' ,'{post.PostPath }' )");
            return View();
        }
        #endregion

        
    }
}
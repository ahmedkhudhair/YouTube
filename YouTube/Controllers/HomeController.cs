using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouTube.Models;
namespace YouTube.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Class1 class1 = new Class1();
            //class1.setvalue();

            //Class2 class2 = new Class2();
            //class2.getvalue();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Home()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {

            User user1 = new User();
            //user1.ID = 1 ;
            user1.FullName = " ahmed ";


            Post post1 = new Post();
            post1.ID = 1;
            post1.PostTitle = " learn c# ";
            user1.Posts.Add(post1);


            Post post2 = new Post();
            post2.ID = 2;
            post2.PostTitle = " learn c# ";
            user1.Posts.Add(post2);


            Comment comment1 = new Comment();
            comment1.commentid = 1;
            comment1.CommentContent = "good job";



            Comment comment2 = new Comment();
            comment2.commentid = 2;
            comment2.CommentContent = "very nice";


            Comment comment3 = new Comment();
            comment3.commentid = 3;
            comment3.CommentContent = "wow";


            Comment comment4 = new Comment();
            comment4.commentid = 4;
            comment4.CommentContent = "explain more";

            post1.Comments.Add(comment1);
            post1.Comments.Add(comment2);
            post2.Comments.Add(comment3);
            post2.Comments.Add(comment4);

            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            ViewBag.Message = "Your contact page.";
            DBMS db = new DBMS();
            bool ok = db.ExecuteInsertQuery(" insert into user (fullname, email, date_of_birth, username, password) values" +
                " ('" + user.FullName + "' ,'" + user.Email + "' ,'" + user.DateOfBirth + "' ,'" + user.UserName + "' , '" + user.Password + "' )");
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Message = "Login page";
            return View();
        }
    } 
}
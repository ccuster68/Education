﻿using System;
using System.Linq;
using AspNetCoreVideo.Entities;
using AspNetCoreVideo.Services;
using AspNetCoreVideo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    public class HomeController : Controller
    {
        private IVideoData _videos;

        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }
        public ViewResult Index()
        {
            var model = _videos.GetAll().Select(v =>
                new VideoViewModel
                {
                    Id = v.Id,
                    Title = v.Title,
                    Genre = v.Genre.ToString()
                });
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _videos.Get(id);
            if (model == null)
                return RedirectToAction("Index");

            return View(new VideoViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Genre = model.Genre.ToString()
            });
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VideoEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var video = new Video {Title = model.Title, Genre = model.Genre};
                _videos.Add(video);

                return RedirectToAction("Details", new {id = video.Id});
            }

            return View();
        }
    }
}

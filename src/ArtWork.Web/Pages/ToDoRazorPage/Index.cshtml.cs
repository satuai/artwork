﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using ArtWork.Core.Entities;
using ArtWork.Core.Interfaces;

namespace ArtWork.Web.Pages.ToDoRazorPage
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;

        public List<ToDoItem> ToDoItems { get; set; }

        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            ToDoItems = _repository.List<ToDoItem>();
        }
    }
}

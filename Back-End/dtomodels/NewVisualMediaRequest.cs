using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using MyWebAPi.Services;
using Microsoft.Extensions.Logging;
using System.Web;

namespace MyWebAPi.dtomodels
{
    public class NewVisualMediaRequest
    {
        public Guid Id{get;set;}
        public string Category {get;set;}
        public string Caption {get;set;}
    }
}
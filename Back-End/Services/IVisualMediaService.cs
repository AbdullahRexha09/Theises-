using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using MyWebAPi.models;

namespace MyWebAPi.Services
{
    public interface IVisualMediaService
    {
        VisualMedia GetById(Guid id);
        void Post(VisualMedia visualMedia);
        void Put(VisualMedia visualMedia);
        bool Delete(Guid id);

    }
}
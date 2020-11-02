using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyWebAPi.models;

namespace MyWebAPi.Services
{
    public class VisualMediaService : IVisualMediaService
    {
        public readonly MyAPiContext _db;
        public VisualMediaService(MyAPiContext db)
        {
            _db = db;
        }
        public bool Delete(Guid id)
        {
            var item = _db.VisualMedia.FirstOrDefault(visual => visual.Id == id);
            var isDeleted = _db.VisualMedia.Remove(item);
            _db.SaveChanges();
            return true;
        }

        public VisualMedia GetById(Guid id)
        {
            return _db.VisualMedia.FirstOrDefault(visual => visual.Id == id);
        }

        public void Post(VisualMedia visualMedia)
        {
            var item = _db.VisualMedia.Add(visualMedia);
            _db.SaveChanges();
        }

        public void Put(VisualMedia visualMedia)
        {
            var item = _db.VisualMedia.Find(visualMedia.Id);
            if(item != null){
                item = visualMedia;
                _db.VisualMedia.Update(item);
            }else throw new InvalidOperationException("Can't Update, row doesnt exists!");
        }
    }
}
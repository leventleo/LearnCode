using LearnCode.Bussiness.Interfaces;
using LearnCode.Entities;
using LearnCode.WepApi.Model;
using LLearnCode.Bussiness.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCode.WepApi.Controllers
{   [Route("api/[controller]")]
    public class LessonController : Controller
    {
        private readonly ILesson _lesson;
        private readonly ISubject _subject;
        private readonly IContent _content;

        public LessonController(ILesson lesson, ISubject subject, IContent content)
        {
            _lesson = lesson;
            _subject = subject;
            _content = content;
        }

        [HttpGet("[action]")]
        public List<Lesson> Getlist()
        {

            var list = _lesson.GetList().Result;

            return list;
        }

        [HttpGet("[action]/{id}")]
        public List<Subject> Getsubject(int id)
        {

            var list = _subject.GetList(x => x.Lessonid == id).Result;

            return list;
        }

        [HttpGet("getcontent")]
        public List<CalendarModel> GetContent()
        {

            var model = _content.GetList().Result;

         var modelCalendar=  model.Select(x => new CalendarModel {

                 Title=x.ContentName,
                  Start= ConvertToIsoDate(x.CreatTime),
                  End= ConvertToIsoDate(x.CreatTime),

         }).ToList();

            return modelCalendar;
        }

        private string ConvertToIsoDate(DateTime creatTime)
        {
           var strArray=  creatTime.ToShortDateString().Split('.');
            var strDate = strArray[2]+"-"+strArray[1] + "-" + strArray[0];
            return strDate;

        }
    }
}

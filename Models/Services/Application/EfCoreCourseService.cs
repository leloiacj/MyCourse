using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCourse.Models.ViewModels;
using MyCourse.Models.InputModels;
using MyCourse.Models.Services.Infrastructure;
using MyCourse.Models.Entities;

namespace MyCourse.Models.Services.Application
{
    public class EfCoreCourseService:ICourseService
    {

            //tramite questo oggetto eseguiremo le operazioni CRUD per i Corsi e le Lezioni
            private readonly MyCourseDbContext dbContext;

            public EfCoreCourseService(MyCourseDbContext dbContext){
                this.dbContext = dbContext;
            }
        
            //Deve recuperare tutti i corsi presenti nella tabella Courses del db
            //SELECT * FROM Courses
            public List<CourseViewModel> GetCourses(){
                List<CourseViewModel> courses = dbContext.Courses.Select(course =>
                new CourseViewModel {
                    Id = course.Id,
                    Title = course.Title,
                    ImagePath = course.ImagePath,
                    Author = course.Author,
                    Rating = course.Rating,
                    CurrentPrice = course.CurrentPrice,
                    FullPrice = course.FullPrice
                }).ToList();//dopo che ha recuperarto tutte le righe della tabella inserirsci tutto nella lista courses

                return courses;
            }
            public CourseDetailViewModel GetCourse(int id){
                return null;
            }

            public CourseDetailViewModel CreateCourse(CourseCreateInputModel input){
                return null;
            }
    }
}
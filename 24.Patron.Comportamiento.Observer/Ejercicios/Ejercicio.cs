using System;

namespace _24.Patron.Comportamiento.Observer.Ejercicios
{
    public class StudentEventHandler : EventArgs
    {
        public string Name { get; set; }
    }
    public class Course
    {
        public string CourseName { get; set; }
        public event EventHandler<StudentEventHandler> Updates;
        public Course(string courseName)
        {
            CourseName = courseName;
        }
        public void CourseUpdate()
        {
            var args = new StudentEventHandler{
                Name = CourseName
            };
            Updates?.Invoke(this, args);
        }
      
    }

    public static class Notification
    {
        public static string Message;
        public static void EmailStudent(object sender, StudentEventHandler e)
        {
            Message =  $"Hola el curso {e.Name} ha sido actualizado";
        }
    }
    
}
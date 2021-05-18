using System;

namespace _24.Patron.Comportamiento.Observer.Eventos
{
    public class Recruiter
    {
        public event EventHandler<InterviewUpdateEventArgs> InterviewUpdate;
        public void LastInterview(string name)
        {
            //InterviewUpdate?.Invoke(this, EventArgs.Empty);
            var args  = new InterviewUpdateEventArgs{Name = name};
            InterviewUpdate?.Invoke(this, args);
        }
    }
}
using System;

namespace _24.Patron.Comportamiento.Observer.Eventos
{
    public class Listener : IDisposable
    {
        private readonly Recruiter _recruiter;
        public Listener(Recruiter recruiter)
        {
            _recruiter = recruiter;
        }
        public void StartListener()
        {
            _recruiter.InterviewUpdate += CallApplicant;

            _recruiter.LastInterview("ivan");
        }

        public void Dispose()
        {
            _recruiter.InterviewUpdate -= CallApplicant;
        }

        private void CallApplicant(object sender, InterviewUpdateEventArgs e)
        {
            Console.WriteLine($"El postulante {e.Name} fue contactado");
        }
    }
}
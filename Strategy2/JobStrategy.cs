using static System.Console;

namespace DesignPatterns.Strategy2
{
    public class JobStrategy 
    {
        private readonly Job _job;
        public JobStrategy(Job job)
        {
            _job = job;
        }

        public void Determine()
        {
            WriteLine(_job.DoingJob());
        }
    }
}
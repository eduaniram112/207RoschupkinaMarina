using System;

namespace Task02
{
    public class PlayIsStartedEventArgs : EventArgs
    {
        public int SoundNumber { get; set; }
    }


    public class Bandmaster
    {
        public event EventHandler<PlayIsStartedEventArgs> ev;
        public void StartPlay()
        {
            Random r = new Random();
            ev?.Invoke(this, new PlayIsStartedEventArgs() { SoundNumber = r.Next(2, 6) });
        }

    }

    public abstract class OrchestraPlayer
    {
        public string Name { get; set; }
        public abstract void PlayIsStartedEventHandler(object sender, PlayIsStartedEventArgs ev);

    }
    class Violinist : OrchestraPlayer
    {
        public override void PlayIsStartedEventHandler(object sender, PlayIsStartedEventArgs ev)
        {
            Console.WriteLine($"Violinist {Name} plays composition {ev.SoundNumber}: Trun trun trun");
        }
    }

    class Hornist : OrchestraPlayer
    {
        public override void PlayIsStartedEventHandler(object sender, PlayIsStartedEventArgs ev)
        {
            Console.WriteLine($"Hornist {Name} plays composition {ev.SoundNumber}: Du du du");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bandmaster master = new Bandmaster();
            Random r = new Random();
            OrchestraPlayer[] yama = new OrchestraPlayer[10];
            for (int i = 0; i < 10; i++)
            {
                int n = r.Next(0, 2);
                if (n == 0)
                {
                    yama[i] = new Violinist() { Name = r.Next(1000, 2000).ToString() };
                }
                else
                {
                    yama[i] = new Hornist() { Name = r.Next(1000, 2000).ToString() };
                }
                master.ev += yama[i].PlayIsStartedEventHandler;
            }
            int k = 3;
            Console.WriteLine("-------");
            for (int i = 0; i < k; i++)
            {
                master.StartPlay();
                Console.WriteLine("-------");
            }

        }
    }
}

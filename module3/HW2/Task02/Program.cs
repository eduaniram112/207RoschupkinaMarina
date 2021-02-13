using System;
// задача про голосование
namespace Task02
{
    class VetoEventArgs : EventArgs
    {
        public string Proposal { get; set; }
        public VetoVoter VetoBy { get; set; }
        public VetoEventArgs(string proposal)
        {
            Proposal = proposal;
        }
    }

    class VetoComission
    {
        public event EventHandler<VetoEventArgs> OnVote;

        public VetoEventArgs Vote(string Proposal)
        {
            VetoEventArgs vetoVoteArgs = new VetoEventArgs(Proposal);
            OnVote?.Invoke(this, vetoVoteArgs);
            return vetoVoteArgs;
        }
    }

    class VetoVoter
    {
        public string Name { get; private set; }

        public void VetoVote(object sender, VetoEventArgs e)
        {
            Random r = new Random();
            if (e.VetoBy != null) return;
            if (r.Next(0, 5) == 1) e.VetoBy = this;
        }

        public VetoVoter(string name)
        {
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VetoComission vetoC = new VetoComission();
            VetoVoter[] voters = new VetoVoter[5];
            string[] voterNames = { "maria", "marina", "mariana", "masha", "marusia" };

            for (int i = 0; i < voters.Length; i++)
            {
                voters[i] = new VetoVoter(voterNames[i]);
                vetoC.OnVote += voters[i].VetoVote;
            }

            VetoEventArgs voteResults = vetoC.Vote("убрать дистант");

            Console.WriteLine($"proposal: {voteResults.Proposal}. vote result: {(voteResults.VetoBy == null ? "approved" : "vetoed")}.");
            if (voteResults.VetoBy != null) Console.WriteLine($"vetoed by: {voteResults.VetoBy.Name}.");
        }
    }
}
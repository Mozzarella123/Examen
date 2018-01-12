using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProj
{
    class Session
    {
        private string name;
        private string description;
        private DateTime release;
        private DateTime endDate;
        private ICollection<Session> sessions;

        public string GetName { get => name; }
        public string GetDescription { get => description; }
        public DateTime GetRelease { get => release;}
        public DateTime GetEndDate { get => endDate; }
        internal ICollection<Session> GetSessions { get => sessions; }

        public Session(string Name,DateTime release,DateTime End,ICollection<Session> Sessions,string Description = null)
        {
            this.name = Name;
            this.release = release;
            this.endDate = End;
            this.sessions = Sessions;
            this.description = Description;
        }
    }
}

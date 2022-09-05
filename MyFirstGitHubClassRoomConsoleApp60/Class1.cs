using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    internal class Class1
    {
        private int _tal;

        private int _dag;

        private string _navn;

        private string _title;

        private string _description;

        public int Tal
        {
            get { return _tal; }
            set { _tal = value; }
        }

        public int Dag
        {
            get { return _dag; }
            set { _dag = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set
            {
                _navn = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }

    }
}

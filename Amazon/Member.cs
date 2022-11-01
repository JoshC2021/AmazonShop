using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Member
    {

        public string Name { get; set; }

        public int RewardPoints { get; set; }

        public Member (string Name, int RewardPoints)
        {
            this.Name = Name;
            this.RewardPoints = RewardPoints;
        }

        //private string Name;

        //public string GetName() 
        //{
        //    return Name;
        //}

        //public void SetName(string name)
        //{
        //    this.Name = name;
        //}

    }
}

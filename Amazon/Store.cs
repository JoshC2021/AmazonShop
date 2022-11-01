using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Store
    {

        public List<Member> Members { get; set; }

        public Store( List<Member> members)
        {
            this.Members = members;
        }

        public void AddRewardPoints(string name, int pointsAdded)
        {
            if( Members.Where(m => m.Name == name).Count() > 0)
            {
               Member member = Members.Where(m => m.Name == name).First();
               member.RewardPoints += pointsAdded;
            }
            else
            {
                Console.WriteLine("No Member Found with that name");
            }
        }


    }
}

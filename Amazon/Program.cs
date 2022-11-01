using Amazon;



List<Member> members = new List<Member>()
{
    new Member("Josh",100),
    new Member("Jeff",1),
    new Member("Jae",44),
    new Member("John",56)
};

Store store1 = new Store(members);

Console.WriteLine(store1.Members[0].Name + " " + store1.Members[0].RewardPoints);

store1.AddRewardPoints("Josh", 500);

Console.WriteLine(store1.Members[0].Name + " " + store1.Members[0].RewardPoints);

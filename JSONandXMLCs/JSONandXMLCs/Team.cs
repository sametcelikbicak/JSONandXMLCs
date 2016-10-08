namespace JSONandXMLCs
{
    public class Team
    {
        public Member[] GetTeamMembers()
        {
            Member[] teamMembers = new Member[]
            {
            new Member() { Id=1,Name="Samet",Salary=10000,Position="Software Specialist"},
            new Member() { Id=2,Name="Kubilay",Salary=10000,Position="Software Specialist"},
            new Member() { Id=3,Name="Erkan",Salary=10000,Position="Software Specialist"},
            };

            return teamMembers;
        }
    }
}
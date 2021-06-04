using System;
using System.Collections.Generic;
using System.Text;

namespace PROJE2_ToDo
{
    public static class MemberManager
    {
        public static List<Member> Members;

        static MemberManager()
        {
            Members = DefaultMembers();
        }

        public static List<Member> DefaultMembers()
        {
            return new List<Member>(){
            new Member(1,"İrem Gülten"),
            new Member(2,"Elif Gülten"),
            new Member(3,"Merve Metinoğlu"),
            new Member(4,"Nurdan Kaya"),
            new Member(5,"Rana Akkuş"),
            };
        }
    }
}

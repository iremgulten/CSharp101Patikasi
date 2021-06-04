using System;
using System.Collections.Generic;
using System.Text;

namespace PROJE2_ToDo
{
    public class Member
    {
        public int ID { get; set; }
        public string NameSurname { get; set; }

        public Member(int id,string nameSurname)
        {
            this.ID = id;
            this.NameSurname = nameSurname;
        }
    }
}

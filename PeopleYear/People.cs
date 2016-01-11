using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PeopleYear
{
  public  class People
    {
        public int Birth { get; set; }
        public int end { get; set; }

        public People()
        {

        }

        public People(int birth, int end)
        {
            this.Birth = birth;
            this.end = end;
        }

            public List<People> GetPopleFromTextFile() {
            string line;
            var list = new List<People>();
            using (StreamReader reader = new StreamReader("important.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] ls = line.Split(',');
                    var person = new People(Convert.ToInt32(ls[0]), Convert.ToInt32(ls[1]));
                    list.Add(person);
                }
            }
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Week_4_Day_7_List_box
{
    public class People //The default is always internal make sure to change it to public
    {
        //fields

        string _firstName;

        string _lastName;

        List<string> _personalList;


        //Highlight hit alt enter in order to access quick actions

        //click constructor,then click properties,either option will work
        public People(string firstName, string lastName, List<string> personalList)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalList = personalList;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public List<string> PersonalList { get => _personalList; set => _personalList = value; }

        ////constructor

        //public People(string firstName, string lastName)
        //{
        //    _firstName = firstName;
        //    _lastName = lastName;
        //}

        ////properties

        //public string FirstName { get => _firstName; set => }

        //public string LastName { get => _lastName; set =>}

        //new: override ToString()

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}

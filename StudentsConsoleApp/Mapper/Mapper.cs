using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    class Mapper
    {
        public static string NameMap(string name)
        {
            return name.Substring(0, 1).ToUpper() + (name.Length > 1 ? name.Substring(1, name.Length - 1) : "").ToLower();
        }
        public static string GenderMap(string gender)
        {
            switch (gender)
            {
                case "М":
                    {
                        return "Male";
                    }
                case "Ж":
                    {
                        return "Female";
                    }
                case "муж":
                    {
                        return "Male";
                    }
                case "жен":
                    {
                        return "Female";
                    }
                case "мужской":
                    {
                        return "Male";
                    }
                case "женский":
                    {
                        return "Female";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
}

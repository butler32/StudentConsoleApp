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
                        return "Мужской";
                    }
                case "Ж":
                    {
                        return "Женский";
                    }
                case "муж":
                    {
                        return "Мужской";
                    }
                case "жен":
                    {
                        return "Женский";
                    }
                case "мужской":
                    {
                        return "Мужской";
                    }
                case "женский":
                    {
                        return "Женский";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
}

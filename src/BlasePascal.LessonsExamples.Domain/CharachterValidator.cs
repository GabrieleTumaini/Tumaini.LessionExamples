using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.LessonsExamples.Domain
{
    internal static class CharachterValidator

    {
        //Health Constants

        public const int MinHealth = 0;

        public const int MaxHealth = 100;
        public static string ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name.Trim()))
                throw new ArgumentException("Name cannot be null or empty or whitespace.");

            return name;

        }

        //TODO: Add ValidateHealth method
    }
}

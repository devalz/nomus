using System.Text.RegularExpressions;

namespace Nomus
{
    public class Naming
    {
        public static string DetectNamingStyle(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "";

            // PascalCase: It begins with a capital letter and each word begins with a capital letter
            if (Regex.IsMatch(input, @"^[A-Z][a-zA-Z0-9]*$") &&
                Regex.IsMatch(input, @"[A-Z][a-z0-9]+"))
                return "PascalCase";

            // camelCase: It begins with a lowercase letter and contains words with internal capital letters
            if (Regex.IsMatch(input, @"^[a-z]+[A-Za-z0-9]*$") &&
                Regex.IsMatch(input, @"[A-Z]"))
                return "camelCase";

            // snake_case: All lowercase letters separated by _
            if (Regex.IsMatch(input, @"^[a-z]+(_[a-z0-9]+)+$"))
                return "snake_case";

            // SCREAMING_SNAKE_CASE: All capital letters separated by _
            if (Regex.IsMatch(input, @"^[A-Z]+(_[A-Z0-9]+)+$"))
                return "SCREAMING_SNAKE_CASE";

            // kebab-case: Lowercase letters separated by -
            if (Regex.IsMatch(input, @"^[a-z]+(-[a-z0-9]+)+$"))
                return "kebab-case";

            // UPPER-KEBAB-CASE: Capital letters separated by -
            if (Regex.IsMatch(input, @"^[A-Z]+(-[A-Z0-9]+)+$"))
                return "UPPER-KEBAB-CASE";

            // Title Case: Words with the first letter capitalized, separated by a space
            if (Regex.IsMatch(input, @"^[A-Z][a-z]+(\s[A-Z][a-z]+)*$"))
                return "Title Case";

            // lowercase: simple lowercase
            if (Regex.IsMatch(input, @"^[a-z]+$") || Regex.IsMatch(input, @"^[a-z]+(\s[a-z]+)+$"))
                return "lowercase";

            // UPPERCASE: simple uppercase
            if (Regex.IsMatch(input, @"^[A-Z]+$") || Regex.IsMatch(input, @"^[A-Z]+(\s[A-Z]+)+$"))
                return "UPPERCASE";

            return "Unknown / Mixed";
        }

        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public static string ToLowerCase(string input)
        {
            return input.ToLower();
        }

        public static string ToPascalCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            // Insert spaces between lower+Upper (camelCase / PascalCase)
            string norm = Regex.Replace(input, "([a-z0-9])([A-Z])", "$1 $2");

            // Uniformizes separators
            norm = norm.Replace("_", " ").Replace("-", " ").ToLower();

            // Capitalize all words
            return Regex.Replace(norm, @"(^\w|\s\w)", m => m.Value.Trim().ToUpper());
        }

        public static string ToCamelCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            // First, convert to PascalCase
            string pascal = ToPascalCase(input);

            // Then go down the first letter
            return char.ToLower(pascal[0]) + pascal.Substring(1);
        }

        public static string ToSnakeCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            // Normalize everything by dividing it into words
            string norm = Regex.Replace(input, "([a-z0-9])([A-Z])", "$1 $2");
            norm = norm.Replace("-", " ").Replace("_", " ");

            // Lowercase letters and joined by _
            return Regex
                .Replace(norm, @"\s+", "_")
                .ToLower();
        }

        public static string ToScreamingSnakeCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            // Normalize everything by dividing it into words
            string norm = Regex.Replace(input, "([a-z0-9])([A-Z])", "$1 $2");
            norm = norm.Replace("-", " ").Replace("_", " ");

            // Capital letters and joining by _
            return Regex
                .Replace(norm, @"\s+", "_")
                .ToUpper();
        }

        public static string ToKebabCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            // Normalize everything by dividing it into words
            string norm = Regex.Replace(input, "([a-z0-9])([A-Z])", "$1 $2");
            norm = norm.Replace("_", " ").Replace("-", " ");

            // Lowercase letters and joined by -
            return Regex
                .Replace(norm, @"\s+", "-")
                .ToLower();
        }

        public static string ToUpperKebabCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            // Normalize everything by dividing it into words
            string norm = Regex.Replace(input, "([a-z0-9])([A-Z])", "$1 $2");
            norm = norm.Replace("_", " ").Replace("-", " ");

            // Capital letters and joining by -
            return Regex
                .Replace(norm, @"\s+", "-")
                .ToUpper();
        }

        public static string ToTitleCase(string input)
        {
            // First, convert to PascalCase
            string pascal = ToPascalCase(input);

            // Then insert spaces before each capital letter (except the first one)
            return Regex.Replace(pascal, @"([A-Z][a-z0-9]*)", " $1").TrimStart(' ');
        }
    }
}

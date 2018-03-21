using System;
using System.Reflection;

class MainClass
{
    private static bool IsMemberTested(MemberInfo member)
    {
        foreach (object attribute in member.GetCustomAttributes(true))
        {
            if (attribute is IsTestedAttribute)
            {
                return true;
            }
        }
        return false;
    }

    private static void DumpAttributes(MemberInfo member)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Attributes for : " + member.Name);
        
        foreach (object attribute in member.GetCustomAttributes(true))
        {
            var authorAttr = attribute as AuthorAttribute;
            if (authorAttr != null)
            {
                Console.WriteLine(authorAttr.Version + "-" + authorAttr.Name);
            }

            Console.WriteLine(attribute);
        }
        
        Console.ResetColor();
    }

    public static void Main()
    {
        // display attributes for Account class
        DumpAttributes(typeof(Account));

        // display list of tested members
        foreach (MethodInfo method in (typeof(Account)).GetMethods())
        {
            if (IsMemberTested(method))
            {
                Console.WriteLine("Member {0} is tested!", method.Name);
            }
            else
            {
                Console.WriteLine("Member {0} is NOT tested!", method.Name);
            }
        }
        Console.WriteLine();

        // display attributes for Order class
        DumpAttributes(typeof(Order));

        // display attributes for methods on the Order class
        foreach (MethodInfo method in (typeof(Order)).GetMethods())
        {
            if (IsMemberTested(method))
            {
                Console.WriteLine("Member {0} is tested!", method.Name);
            }
            else
            {
                Console.WriteLine("Member {0} is NOT tested!", method.Name);
            }
        }
        Console.WriteLine();
    }
}
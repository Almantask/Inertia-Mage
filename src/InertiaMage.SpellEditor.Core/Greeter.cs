// This is a comment. It will be ignored.

// We use a code module which comes from a different namespace.
// With a using keyword, we can include it to our code
// What using does in reality, is, it copies all the code text in our own namespace.
using System;

// This is a namespace- a place of this project, where this class is virtually located.
// Virtual and physical locations usually match, but they don't have to.
// Namespace is a place, which you will have to include,
// in order to use the code which lies within it.
namespace InertiaMage.SpellEditor.Core
// { } defines a scope. A code file will have at least 2 scopes: namespace, some code structure.
// You cannot access code elements outside scope.
{
    // This is a class. Don't pay too much attention to it yet as it will be covered in more detail
    // in the upcoming lessons.
    // For now, the class is a holder for code, through which we can call functions
    // Class is defined like this:
    // (we will use [optional], <nameable>
    // [access modifier] [static] class <name>
    public static class Greeter
    {
        // This is a function
        // It does whatever is writen in its' scope
        // A function is defined like this:
        // [access modifier] [static] <return type> <name>([<inputType> <intputName>, ...])
        // In this case, our function returns a text- greeting
        public static string Greet(string person)
        {
            string greeting = $"Hello, {person}! :)";
            //string greeting = $"Konichiwa, {person}! :)"; // Error- greeting already exists!
            return greeting;
        }

        // This function is overloaded- meaning that it has the same the same definition, 
        // but different input.
        // Runtime determines which function to call based on the parameters passed to function.
        // Function, which has no access modifier defaults to private.
        private static string Greet()
        {
            // Works, because it is outside of scope of Greet(string person) function
            string greeting = $"Welcome! :)";
            return greeting;
        }

        // void return type is used for functions which don't return any data.
        // It might seem weird, why it still need a "return type".
        // The reason behind this is that it return to the place where it was called from.
        public static void Print(string greeting)
        {
            Console.WriteLine(greeting);
        }
    }

    // Class without access modifier defaults to internal.
    // Writing internal static class InternalGreeter would be the same.
    static class InternalGreeter
    {
        // This is a function
        public static string Greet(string person)
        {
            return $"Hello, {person}! :)";
        }
    }
}

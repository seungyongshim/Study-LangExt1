using System;
using System.IO;
using LanguageExt;
using LanguageExt.Common;
using static LanguageExt.Prelude;

namespace ConsoleApp1
{
    public delegate Either<Error, A> IO<A>();
    internal class Program
    {
        private static void Main(string[] args)
        {

        }

        static Func<Option<string>> readAllText(string path) => () =>
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch
            {
                return None;
            }
        };

        static IO<string> readAllText(string path) =>
            () => File.ReadAllText(path);
    }
}

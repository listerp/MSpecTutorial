using System;
using MSpec.Services;
using Ninject;

namespace MSpec
{
    class Program
    {
        static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Bind<ITranslationService>().To<TranslationService>();

            var translationService = kernel.Get<ITranslationService>();

            Console.WriteLine("Enter your sentence for translation.");
            var sentence = Console.ReadLine();

            if (string.IsNullOrEmpty(sentence))
            {
                Console.WriteLine("Nothing to do.  Press Enter to quit.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine(translationService.TranslateSentence(sentence));
            Console.WriteLine("Press Enter to quit");
            Console.ReadLine();
        }
    }
}

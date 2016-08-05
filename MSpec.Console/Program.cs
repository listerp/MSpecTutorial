using MSpec.Console.Services;
using Ninject;

namespace MSpec.Console
{
    class Program
    {
        static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Bind<ITranslationService>().To<TranslationService>();

            var translationService = kernel.Get<ITranslationService>();

            System.Console.WriteLine("Enter your sentence for translation.");
            var sentence = System.Console.ReadLine();

            if (string.IsNullOrEmpty(sentence))
            {
                System.Console.WriteLine("Nothing to do.  Press Enter to quit.");
                System.Console.ReadLine();
                return;
            }

            System.Console.WriteLine(translationService.TranslateSentence(sentence));
            System.Console.WriteLine("Press Enter to quit");
            System.Console.ReadLine();
        }
    }
}

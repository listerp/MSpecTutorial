using Machine.Specifications;
using MSpec.Console.Extensions;

namespace MSpec.Tests.Extensions.StringExtensionTests
{
    [Subject(typeof (StringExtensions))]
    public class when_word_is_translated
    {
        private static string firstWordToTranslate;
        private static string firstTranslatedWord;

        private static string secondWordToTranslate;
        private static string secondTranslatedWord;

        Establish context = () =>
        {
            firstWordToTranslate = Constants.SimpleWordToTranslate;
            secondWordToTranslate = Constants.ComplexWordToTranslate;
        };

        Because of = () =>
        {
            firstTranslatedWord = firstWordToTranslate.Translate();
            secondTranslatedWord = secondWordToTranslate.Translate();
        };

        It should_return_f1o = () =>
        {
            firstTranslatedWord.ShouldEqual("f1o");
        };

        It should_return_S3h = () =>
        {
            secondTranslatedWord.ShouldEqual("S3h");
        };
    }
}

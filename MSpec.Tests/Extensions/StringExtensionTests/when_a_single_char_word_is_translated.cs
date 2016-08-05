using Machine.Specifications;
using MSpec.Console.Extensions;

namespace MSpec.Tests.Extensions.StringExtensionTests
{
    [Subject(typeof (StringExtensions))]
    public class when_a_single_char_word_is_translated
    {
        private static string wordToTranslate;
        private static string translatedWord;

        Establish context = () => 
        {
            wordToTranslate = "a";
        };

        Because of = () =>
        {
            translatedWord = wordToTranslate.Translate();
        };

        It should_return_same_word = () =>
        {
            translatedWord.ShouldEqual(wordToTranslate);
        };
    }
}

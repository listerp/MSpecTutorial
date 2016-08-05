using Machine.Specifications;
using MSpec.Extensions;

namespace MSpec.Tests.Extensions.StringExtensionTests
{
    [Subject(typeof(StringExtensions))]
    public class when_a_non_alpha_word_is_translated
    {
        private static string wordToTranslate;
        private static string translatedWord;

        Establish context = () =>
        {
            wordToTranslate = ";";
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

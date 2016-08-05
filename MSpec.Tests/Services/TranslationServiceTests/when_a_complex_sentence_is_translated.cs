using Machine.Specifications;
using MSpec.Console.Services;

namespace MSpec.Tests.Services.TranslationServiceTests
{
    [Subject(typeof(TranslationService))]
    public class when_a_complex_sentence_is_translated
    {
        private static ITranslationService _translationService;

        private static string sentenceToParse;
        private static string parsedSentence;
        private static string expectedResult;

        Establish context = () =>
        {
            expectedResult = "N0o m1n, i0n a1l t1e p6n o0f f4s m1n, i0s r4n o0r i8n, o0r t2t e4e w0e w2e l4g f1r; b1t i0s a0n e6n, i0n s2e q5r, o0f n1w p7s. - R3h W3o E5n";
            _translationService = new TranslationService();

            sentenceToParse = Constants.ComplexSentence;
        };

        Because of = () =>
        {
            parsedSentence = _translationService.TranslateSentence(sentenceToParse);
        };

        It should_correctly_translate_and_reassemble_the_sentence = () =>
        {
            parsedSentence.ShouldEqual(expectedResult);
        };
    }
}

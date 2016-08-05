using Machine.Specifications;
using MSpec.Services;

namespace MSpec.Tests.Services.TranslationServiceTests
{
    [Subject(typeof(TranslationService))]
    public class when_a_simple_sentence_is_parsed
    {
        private static ITranslationService _translationService;

        private static string sentenceToParse;
        private static string parsedSentence;
        private static string expectedResult;

        Establish context = () =>
        {
            expectedResult = "T1e q3k b3n f1x j4d o2r t1e l2y d1g.";
            _translationService = new TranslationService();

            sentenceToParse = Constants.SimpleSentence;
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

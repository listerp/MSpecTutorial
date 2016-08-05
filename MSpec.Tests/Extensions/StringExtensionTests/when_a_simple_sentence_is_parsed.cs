using System.Collections.Generic;
using Machine.Specifications;
using MSpec.Extensions;

namespace MSpec.Tests.Extensions.StringExtensionTests
{
    [Subject(typeof(StringExtensions))]
    public class when_a_simple_sentence_is_parsed
    {
        private static string sentenceToParse;
        private static List<string> parsedSentence;

        Establish context = () =>
        {
            sentenceToParse = Constants.SimpleSentence;
        };

        Because of = () =>
        {
            parsedSentence = sentenceToParse.ParseSentence();
        };

        It should_return_18_words = () =>
        {
            parsedSentence.Count.ShouldEqual(18);
        };

        It should_have_parsed_the_sentence_correctly = () =>
        {
            parsedSentence[0].ShouldEqual("The");
            parsedSentence[1].ShouldEqual(" ");
            parsedSentence[2].ShouldEqual("quick");
            parsedSentence[3].ShouldEqual(" ");
            parsedSentence[4].ShouldEqual("brown");
            parsedSentence[5].ShouldEqual(" ");
            parsedSentence[6].ShouldEqual("fox");
            parsedSentence[7].ShouldEqual(" ");
            parsedSentence[8].ShouldEqual("jumped");
            parsedSentence[9].ShouldEqual(" ");
            parsedSentence[10].ShouldEqual("over");
            parsedSentence[11].ShouldEqual(" ");
            parsedSentence[12].ShouldEqual("the");
            parsedSentence[13].ShouldEqual(" ");
            parsedSentence[14].ShouldEqual("lazy");
            parsedSentence[15].ShouldEqual(" ");
            parsedSentence[16].ShouldEqual("dog");
            parsedSentence[17].ShouldEqual(".");
        };
    }
}

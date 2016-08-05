using System.Collections.Generic;
using Machine.Specifications;
using MSpec.Extensions;

namespace MSpec.Tests.Extensions.StringExtensionTests
{
    [Subject(typeof(StringExtensions))]
    public class when_a_complex_sentence_is_parsed
    {
        private static string sentenceToParse;
        private static List<string> parsedSentence;

        Establish context = () =>
        {
            sentenceToParse = Constants.ComplexSentence;
        };

        Because of = () =>
        {
            parsedSentence = sentenceToParse.ParseSentence();
        };

        It should_return_74_words = () =>
        {
            parsedSentence.Count.ShouldEqual(74);
        };

        It should_have_parsed_the_sentence_correctly = () =>
        {
            parsedSentence[0].ShouldEqual("No");
            parsedSentence[1].ShouldEqual(" ");
            parsedSentence[2].ShouldEqual("man");
            parsedSentence[3].ShouldEqual(",");
            parsedSentence[4].ShouldEqual(" ");
            parsedSentence[5].ShouldEqual("in");
            parsedSentence[6].ShouldEqual(" ");
            parsedSentence[7].ShouldEqual("all");
            parsedSentence[8].ShouldEqual(" ");
            parsedSentence[9].ShouldEqual("the");
            parsedSentence[10].ShouldEqual(" ");
            parsedSentence[11].ShouldEqual("procession");
            parsedSentence[12].ShouldEqual(" ");
            parsedSentence[13].ShouldEqual("of");
            parsedSentence[14].ShouldEqual(" ");
            parsedSentence[15].ShouldEqual("famous");
            parsedSentence[16].ShouldEqual(" ");
            parsedSentence[17].ShouldEqual("men");
            parsedSentence[18].ShouldEqual(",");
            parsedSentence[19].ShouldEqual(" ");
            parsedSentence[20].ShouldEqual("is");
            parsedSentence[21].ShouldEqual(" ");
            parsedSentence[22].ShouldEqual("reason");
            parsedSentence[23].ShouldEqual(" ");
            parsedSentence[24].ShouldEqual("or");
            parsedSentence[25].ShouldEqual(" ");
            parsedSentence[26].ShouldEqual("illumination");
            parsedSentence[27].ShouldEqual(",");
            parsedSentence[28].ShouldEqual(" ");
            parsedSentence[29].ShouldEqual("or");
            parsedSentence[30].ShouldEqual(" ");
            parsedSentence[31].ShouldEqual("that");
            parsedSentence[32].ShouldEqual(" ");
            parsedSentence[33].ShouldEqual("essence");
            parsedSentence[34].ShouldEqual(" ");
            parsedSentence[35].ShouldEqual("we");
            parsedSentence[36].ShouldEqual(" ");
            parsedSentence[37].ShouldEqual("were");
            parsedSentence[38].ShouldEqual(" ");
            parsedSentence[39].ShouldEqual("looking");
            parsedSentence[40].ShouldEqual(" ");
            parsedSentence[41].ShouldEqual("for");
            parsedSentence[42].ShouldEqual(";");
            parsedSentence[43].ShouldEqual(" ");
            parsedSentence[44].ShouldEqual("but");
            parsedSentence[45].ShouldEqual(" ");
            parsedSentence[46].ShouldEqual("is");
            parsedSentence[47].ShouldEqual(" ");
            parsedSentence[48].ShouldEqual("an");
            parsedSentence[49].ShouldEqual(" ");
            parsedSentence[50].ShouldEqual("exhibition");
            parsedSentence[51].ShouldEqual(",");
            parsedSentence[52].ShouldEqual(" ");
            parsedSentence[53].ShouldEqual("in");
            parsedSentence[54].ShouldEqual(" ");
            parsedSentence[55].ShouldEqual("some");
            parsedSentence[56].ShouldEqual(" ");
            parsedSentence[57].ShouldEqual("quarter");
            parsedSentence[58].ShouldEqual(",");
            parsedSentence[59].ShouldEqual(" ");
            parsedSentence[60].ShouldEqual("of");
            parsedSentence[61].ShouldEqual(" ");
            parsedSentence[62].ShouldEqual("new");
            parsedSentence[63].ShouldEqual(" ");
            parsedSentence[64].ShouldEqual("possibilities");
            parsedSentence[65].ShouldEqual(".");
            parsedSentence[66].ShouldEqual(" ");
            parsedSentence[67].ShouldEqual("-");
            parsedSentence[68].ShouldEqual(" ");
            parsedSentence[69].ShouldEqual("Ralph");
            parsedSentence[70].ShouldEqual(" ");
            parsedSentence[71].ShouldEqual("Waldo");
            parsedSentence[72].ShouldEqual(" ");
            parsedSentence[73].ShouldEqual("Emerson");
        };
    }
}

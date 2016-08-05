using System.Linq;
using System.Text;
using MSpec.Extensions;

namespace MSpec.Services
{
    public class TranslationService : ITranslationService
    {
        public string TranslateSentence(string sentenceToTranslate)
        {
            var parsedSentece = sentenceToTranslate.ParseSentence();
            var translatedSentence = new StringBuilder();

            foreach (var word in parsedSentece)
            {
                if (word.Length == 1 && !char.IsLetter(word.First()))
                    translatedSentence.Append(word);
                else
                    translatedSentence.Append(word.Translate());
            }

            return translatedSentence.ToString().TrimStart();
        }
    }
}

using GameDataParser.Model;
using GameDataParser.UserInteraction;
using System.Text.Json;

namespace GameDataParser.DataAccess
{
    public class VideoGamesDeserialiser : IVideoGamesDeserialiser
    {

        private IUserInteractor _userInteractor;

        public VideoGamesDeserialiser(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public List<VideoGame> DeserialiseGameFrom(string fileName, string jsonString)
        {
            try
            {
                // Okay to return here, compiler acccepts exception as return type.
                return JsonSerializer.Deserialize<List<VideoGame>>(jsonString);
            }
            catch (JsonException ex)
            {
                _userInteractor.PrintError($"JSON in {fileName} file was not in a valid format");
                throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
            }
        }

    }
}
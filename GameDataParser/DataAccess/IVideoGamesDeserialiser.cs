using GameDataParser.Model;

namespace GameDataParser.DataAccess
{
    public interface IVideoGamesDeserialiser
    {
        List<VideoGame> DeserialiseGameFrom(string fileName, string jsonString);
    }
}
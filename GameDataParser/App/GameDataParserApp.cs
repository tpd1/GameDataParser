using GameDataParser.DataAccess;
using GameDataParser.Model;
using GameDataParser.UserInteraction;

namespace GameDataParser.App
{
    public class GameDataParserApp
    {
        private readonly IUserInteractor _userInteractor;
        private readonly IGamesPrinter _gamesPrinter;
        private readonly IVideoGamesDeserialiser _gameDeserialiser;
        private readonly IFileReader _fileReader;


        public GameDataParserApp(IUserInteractor userInteractor,
            IGamesPrinter gamesPrinter,
            IVideoGamesDeserialiser gameDeserialiser,
            IFileReader fileReader)
        {
            _userInteractor = userInteractor;
            _gamesPrinter = gamesPrinter;
            _gameDeserialiser = gameDeserialiser;
            _fileReader = fileReader;
        }

        public void Run()
        {
            string fileName = _userInteractor.ReadValidFilePath();
            string jsonString = _fileReader.Read(fileName);
            List<VideoGame> videoGames = _gameDeserialiser.DeserialiseGameFrom(fileName, jsonString);
            _gamesPrinter.Print(videoGames);
        }



    }
}
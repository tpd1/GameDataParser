using GameDataParser.UserInteraction;
using GameDataParser.Logging;
using GameDataParser.DataAccess;
using GameDataParser.App;

var consoleUserInteractor = new ConsoleUserInteractor();
var gamesPrinter = new GamesPrinter(consoleUserInteractor);
var gameDeserialiser = new VideoGamesDeserialiser(consoleUserInteractor);
var fileReader = new LocalFileReader();
var app = new GameDataParserApp(consoleUserInteractor,
    gamesPrinter,
    gameDeserialiser,
    fileReader);
var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The application has exerienced an unexpected error.");
    logger.Log(ex);
}

Console.ReadKey();


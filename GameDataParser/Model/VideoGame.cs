namespace GameDataParser.Model
{
    public class VideoGame
    {
        public string Title { get; private set; }

        public int ReleaseYear { get; private set; }

        public double Rating { get; private set; }

        public VideoGame(string title, int releaseYear, double rating)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Title}, released in {ReleaseYear}, rating: {Rating}";
        }

    }
}

using Newtonsoft.Json;

namespace _2048ClassLibrary
{
    public class GameResultStorage
    {
        private FileProvider _fileProvider { get; }
        public GameResultStorage()
        {
            _fileProvider = new FileProvider(@".\gameResults.json");
        }
        public void Save(GameResult gameResult)
        {
            var results = GetAll() ?? new List<GameResult>();
            results.Add(gameResult);
            var json = JsonConvert.SerializeObject(results);
            _fileProvider.Write(json);
        }

        public List<GameResult> GetAll()
        {
            var json = _fileProvider.Get();
            return JsonConvert.DeserializeObject<List<GameResult>>(json);
        }
    }
}

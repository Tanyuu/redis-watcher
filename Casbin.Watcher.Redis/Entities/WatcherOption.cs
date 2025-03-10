namespace Casbin.Watcher.Redis.Entities
{
    public class WatcherOption : IWatcherOption
    {
        public bool Async { get; set; } 
        public string Channel { get; set; } 
        public bool IgnoreSelf { get; set; } 
        public string LocalId { get; set; }
    }
}
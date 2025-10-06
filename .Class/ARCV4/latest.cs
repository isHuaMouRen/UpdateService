public class JsonConfig
{
    public class Root
    {
        public JsonConfig.VersionInfo release{ get; set; }
    }

    public class VersionInfo
    {
        public string latest_version { get; set; }
        public string release_time { get; set; }
        public string release_log { get; set; }
        public string download_url { get; set; }
        public string release_url { get; set; }
        public bool is_full_update{ get; set; }
    }
}
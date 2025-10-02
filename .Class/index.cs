public class JsonConfig
{
    public class Root
    {
        public JsonConfig.Project your_proj_name{ get; set; }
    }

    public class Project
    {
        public string[] owner { get; set; }
        public string repo { get; set; }
        public JsonConfig.UrlInfo url { get; set; }
    }

    public class UrlInfo
    {
        public string github { get; set; }
        public string bgithub { get; set; }
        public string gitee { get; set; }
        public string gitcode { get; set; }
    }
}
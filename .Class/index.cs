public class JsonConfig
{
    public class Root//根
    {
        public string[] root_url{ get; set; }//根url
        public JsonConfig.Projects url_paths { get; set; }//项目集
    }

    public class UrlPaths
    {
        public string test{ get; set; }//填写你的项目名，此以test为示例
    }
}
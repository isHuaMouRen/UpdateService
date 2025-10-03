public class JsonConfig
{
    public class Root//根
    {
        public string[] root_url{ get; set; }//根url
        public JsonConfig.Projects projects { get; set; }//项目集
    }

    public class Projects
    {
        public JsonConfig.ProjectInfo test{ get; set; }//填写你的项目名，此以test为示例
    }

    public class ProjectInfo//项目信息，根据你的情况改变
    {
        public string repo { get; set; }//仓库
        public string url_path { get; set; }//url路径，需与根url拼接
    }
}
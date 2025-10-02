public class JsonConfig
{
    public class Root
    {
        public JsonConfig.VersionInfo release { get; set; }//正式版更新通道
        public JsonConfig.VersionInfo pre_release{ get; set; }//预发布版更新通道
    }

    public class VersionInfo
    {
        public string latest_version { get; set; }//最新版本
        public string release_time { get; set; }//发布时间
        public string release_log { get; set; }//更新日志
        public string download_url { get; set; }//下载链接，通常为蓝奏云直链解析的zip压缩包
        public string release_url { get; set; }//github release链接
        public bool is_full_update { get; set; }//是否全量更新
    }
}
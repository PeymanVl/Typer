namespace Typer.Classes
{
    public class Config
    {
        public static string Show { get; set; }
        public static string Type { get; set; }
        public static int Time { get; set; }
        public static bool SmallWord { get; set; }
        public Config()
        {
            Type = "انگلیسی";
            Show = "words";
            Time = 1;
            SmallWord = false;
        }


        public bool SaveInFile(bool overWrite)
        {
            return false;
        }

        public bool SaveAsDefault()
        {
            return false;
        }

        public void DefaultSetting()
        {

        }

        public void SettingSeter()
        {

        }
    }

    public class Setting:Config
    {
        public Setting()
        {
            Type = Config.Type;
            ShowType = Show;
            Time = Config.Time;
            SmallWord = Config.SmallWord;
        }

        public Setting(string type, string showtype, int time)
        {
            Type = type;
            ShowType = showtype;
            Time = time;
        }
        public string Type { get; set; }
        public string ShowType { get; set; }
        public int Time { get; set; }
        public static bool SmallWord { get; set; }

    }

}

namespace DesignPatterns.Singleton
{
    public class SiteView
    {
        public int View { get; set; }        
        private SiteView(){}
        public static readonly SiteView _instance = new SiteView();
        public static SiteView Instance 
        {
            get{ return _instance;}
        }
    }
}
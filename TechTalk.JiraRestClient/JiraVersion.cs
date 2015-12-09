namespace TechTalk.JiraRestClient
{
    public class JiraVersion
    {
        public string self { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public bool archived { get; set; }
        public bool released { get; set; }
        public string releaseDate { get; set; }
        public bool overdue { get; set; }
        public string userReleaseDate { get; set; }
        public int projectId { get; set; }
    }
}
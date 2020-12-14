namespace dim.Models
{
    public class EmailViewModel
    {
        public string fromEmail { get; set; }

        public string fromName { get; set; }

        public string subjectEmail { get; set; }

        public string toEmail { get; set; }

        public string toEmailName { get; set; }

        public string content { get; set; }

        public string htmlContents { get; set; }
    }
}

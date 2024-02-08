namespace Paper.Models
{
    public class User
    {
        public string UserId { get; set; }

        public string AppleSubId { get; set; }

        public string Email { get; set; }

        public Settings Settings { get; set; }

        public List<Workbook> Workbooks { get; set; }

    }
}

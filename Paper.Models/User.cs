namespace Paper.Models
{
    public class User
    {
        public string UserId { get; set; }

        public string AppleId { get; set; }

        public Settings Settings { get; set; }

        public List<Workbook> Workbooks { get; set; }

    }
}

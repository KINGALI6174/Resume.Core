namespace Resume.Models.Entities.Exprience
{
    public class Exprience
    {
        public int Id { get; set; }
        public string ExprienceTitle { get; set; }
        public string ExprienceDescription { get;set; }
        public string ExprienceDuration { get;set; }    

        public string CompanyName { get; set; }
        public string? CompanySite { get; set;}
    }
}

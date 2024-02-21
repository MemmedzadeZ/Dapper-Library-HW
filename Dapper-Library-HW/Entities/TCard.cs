namespace Dapper_Library_HW.Entities;

public class TCard
{
    public int Id { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    public int TeacherId { get; set; }
    public int BookId { get; set; }
    public int LibId { get; set; }
    public TCard()
    {

    }
   

}

namespace Ham30.Server.Entites.Common;

public interface ISoftDelete
{
    DateTime? DeletedOn { get; set; }
    string DeletedBy { get; set; }
}
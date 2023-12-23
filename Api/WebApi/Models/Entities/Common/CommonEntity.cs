namespace WebApi.Models.Entities.Common
{
    public abstract class CommonEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

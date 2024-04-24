namespace LibraryCore.Domain.Entities
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public int ModifierId { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
        public string Row { get; set; }
        public string Column { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

﻿namespace LibraryCore.Domain.Entities
{
    public class Genre : IEntity
    {
        public int Id { get; set; }
        public int ModifierId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public User Modifier { get; set; }
    }
}

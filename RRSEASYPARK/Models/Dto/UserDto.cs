﻿namespace RRSEASYPARK.Models.Dto
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
        public Guid RolId { get; set; }
    }
}

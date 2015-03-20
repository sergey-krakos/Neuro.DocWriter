namespace DAL.Entities
{
    /// <summary>
    /// Entity, that represents user of a system
    /// </summary>
    public class User
    {
        public int UserId { get; set; }

        public string ExternalAccountName { get; set; }

        public string Email { get; set; }
    }
}
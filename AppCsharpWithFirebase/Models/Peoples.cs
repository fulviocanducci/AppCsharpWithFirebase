using System;

namespace AppCsharpWithFirebase.Models
{
    public class Peoples
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }


        public Peoples(Guid id, string name, DateTime createdAt)
        {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
        }

        public Peoples(string name, DateTime createdAt)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatedAt = createdAt;
        }

        public Peoples(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatedAt = DateTime.Now;
        }
        public Peoples()
        {

        }
    }
}

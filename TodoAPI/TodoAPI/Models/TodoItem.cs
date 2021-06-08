#define First

namespace TodoAPI.Models
{
#if First
    
    public class TodoItem
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsComplete { get; set; }
    }

#else
    // Use this to test you can over-post
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; }
    }
#endif
}
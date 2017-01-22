using System;

namespace SIT.Microblog.Entities
{
    public class Post
    {
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime Created { get; set; }
		public int UserId { get; set; }
	}
}
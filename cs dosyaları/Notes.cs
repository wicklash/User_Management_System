using System;

namespace WindowsFormsApp2
{
    public class Note
    {
        public int Id { get; set; } // Added an Id property to uniquely identify notes
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        public Note()
        {
            Timestamp = DateTime.Now;
        }

        public Note(int id, string content) : this()
        {
            Id = id;
            Content = content;
        }
        public Note(int ıd, string content, DateTime timestamp) : this(ıd, content)
        {
            Timestamp = timestamp;
        }

        public void UpdateContent(string newContent)
        {
            Content = newContent;
            Timestamp = DateTime.Now;
        }
    }
}

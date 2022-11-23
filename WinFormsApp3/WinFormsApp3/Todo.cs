namespace WinFormsApp3
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}

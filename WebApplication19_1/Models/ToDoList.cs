using System.ComponentModel.DataAnnotations;

namespace WebApplication19_1.Models
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        [Required]
        public string? PeriodOfExecution { get; set; }
        public Condition Condition { get; set; }
        public Priority Priority { get; set; }
        public Category Category { get; set; }
    }

    public enum Condition
    {
        Completed,
        notCompleted
    }

    public class ConditionViewModel
    {
        public Condition Condition { get; set; }
    }

    public enum Priority
    {
        Important,
        notImportant
    }
    public enum Category
    {
        Bad,
        Good,
        Excellent
    }
}

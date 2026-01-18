using System.Collections.Generic;

namespace TodoAppWPF
{
    /// <summary>
    /// Hanterar logiken för att lägga till, ta bort och visa todo-items
    /// </summary>
    public class TodoList
    {
        /// <summary>
        /// Represents a collection of tasks stored as a list of strings.
        /// </summary>
        /// <remarks>This field is used to maintain a list of task descriptions. It is initialized as an
        /// empty list and can be populated or modified as needed.</remarks>
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }
        /// <summary>
        /// Removes the task at the specified index from the task list.
        /// </summary>
        /// <param name="index">The zero-based index of the task to remove. Must be within the range of the task list.</param>
        public void RemoveTask(int index)
        {
            if(index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }
        /// <summary>
        /// Retrieves all tasks in the current collection.
        /// </summary>
        /// <returns>A list of strings representing the tasks. The list may be empty if no tasks are present.</returns>
        public List<string> GetAllTasks()
        {
            return tasks;
        }

    }
}

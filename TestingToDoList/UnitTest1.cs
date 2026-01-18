using TodoAppWPF;
using Xunit;

namespace TestingToDoList
{
    public class ToDoListTests
    {
        private TodoList _todoList;

        public ToDoListTests()
        {
            _todoList = new TodoList();
        }

        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            // Arrange
            var task = "test task";

            // Act
            _todoList.AddTask(task);

            // Assert
            var tasks = _todoList.GetAllTasks();
            Assert.Contains(task, tasks);
            Assert.Single(tasks);
        }

        [Fact]
        public void RemoveTask_ShouldRemoveTaskFromList()
        {
            // Arrange
            var task1 = "task 1";
            var task2 = "task 2";
            _todoList.AddTask(task1);
            _todoList.AddTask(task2);

            // Act
            _todoList.RemoveTask(0);

            // Assert
            var tasks = _todoList.GetAllTasks();
            Assert.DoesNotContain(task1, tasks);
            Assert.Contains(task2, tasks);
            Assert.Single(tasks);
        }

        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotFail()
        {
            // Arrange
            _todoList.AddTask("task 1");

            // Aact
            _todoList.RemoveTask(999);

            // Assert
            var tasks = _todoList.GetAllTasks();
            Assert.Single(tasks);
            Assert.Contains("task 1", tasks);
        }

        [Fact]
        public void GetAllTasks_ShouldReflectUpdatedTaskList()
        {
            // Arrange
            _todoList.AddTask("A");
            _todoList.AddTask("B");

            // Act
            _todoList.RemoveTask(0);

            // Assert
            var tasks = _todoList.GetAllTasks();
            Assert.Single(tasks);
            Assert.Contains("B", tasks);
            Assert.DoesNotContain("A", tasks);
        }
    }
}
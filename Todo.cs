namespace ERP_System;
using TECHCOOL.UI;
public class Todo
{
    public enum TodoState { Todo, Started, Done }
    public string Title {get;set;} = "";
    public int Priority {get;set;}
    public TodoState State {get;set;}
    public Todo(string title, int priority=1) 
    {
        Title = title;
        Priority = priority;
    }

    public Todo()
    {
        
    }

  
}
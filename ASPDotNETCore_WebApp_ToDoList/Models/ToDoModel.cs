using System.ComponentModel.DataAnnotations;

namespace ASPDotNETCore_WebApp_ToDoList.Models
{
    public class ToDoModel
    {
        [Display(Name="ToDo Element")]
        public string todoElement { get; set; }
    }
}
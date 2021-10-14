using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreUnderstanding
{
 [Table(name:"Employee")]
  public class Employee
  {
    public int Id { get; set; }
    public string Name { get; set; }
    [ForeignKey("FK_Department_Employee")]
    public int DepartmentId { get; set; }
    public int? ManagerId { get; set; }
  }
}

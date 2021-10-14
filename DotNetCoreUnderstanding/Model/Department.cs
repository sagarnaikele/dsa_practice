using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreUnderstanding
{
  [Table(name: "Department")]
  public class Department
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}

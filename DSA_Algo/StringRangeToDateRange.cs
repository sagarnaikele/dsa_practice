using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{


  public static class StringRangeToDateRange
  {

    public static List<string> GetDateRange(string range= "[2020-09-28 03:00 - 2020-10-05 03:00) _ [768, 1440)")
    { 
    var laborWeeks = new List<string>();
     var cDate= Convert.ToDateTime("2020-09-28 03:00");
    string dateWithout_ = (range.Substring(range.IndexOf("[")+1, range.IndexOf(")")-1)).Trim();
    var splittedRange=dateWithout_.Split(new char[]{' ','_',' ' });
    laborWeeks.AddRange(splittedRange);
      return laborWeeks;
    }


  }
}

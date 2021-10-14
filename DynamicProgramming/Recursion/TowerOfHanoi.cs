using System;

namespace LogicalPrograms.Recursion
{
  /// <summary>
  /// t1 =[1,2,3]
  /// t2 =[]
  /// t3 =[]
  /// Object of the game is to move all the disks over to Tower 3
  /// Only one disk can be moved among the towers at any given time.
  /// Only the "top" disk can be removed.
  /// No large disk can sit over a small disk.
  /// print step output in move disk {number} from {source} to {destination}
  /// </summary>
  public static class TowerOfHanoi
  {
    public static void MoveDisk(int disks, string tower1, string tower2, string tower3)
    {
      if (disks == 1) // we can only move 1 disk 
      {
        Console.WriteLine($"Move {disks} from {tower1} to {tower3} ");
        return;
      }
      MoveDisk(disks-1, tower1, tower3, tower2);
      Console.WriteLine($"Move {disks} from {tower1} to {tower3} ");
      MoveDisk(disks - 1, tower2, tower1, tower3);
    }
  }
}

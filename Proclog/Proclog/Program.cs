using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableParser;

namespace Proclog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get list of "old" procsif
            List<int> listOldProcesses = Process.GetProcesses().Select((x) => x.Id).ToList();
            Process[] arrayOldProcesses = Process.GetProcesses();
            List<Process> listCompareResults = new List<Process>();
                        
            //Perm loop
            Console.WriteLine("** Press ESC to QUIT **\n\n");
            do
            {
                while (!Console.KeyAvailable)
                {
                    Process[] arrayNewProcesses = Process.GetProcesses();

                    List<int> listCurrentProcesses = arrayNewProcesses.Select((x) => x.Id).ToList();
                    List<int> listDiffProcesses = listOldProcesses.Except(listCurrentProcesses).ToList();
                    Console.ForegroundColor = ConsoleColor.Red;

                    listCompareResults = arrayOldProcesses.Where((x) => listDiffProcesses.Contains(x.Id)).ToList();

                    if (listDiffProcesses.Count == 0)
                    {
                        listCompareResults = arrayNewProcesses.Where((x) => listDiffProcesses.Contains(x.Id)).ToList();
                        listDiffProcesses = listCurrentProcesses.Except(listOldProcesses).ToList();
                        Console.ForegroundColor = ConsoleColor.Green;
                        listCompareResults = arrayNewProcesses.Where((x) => listDiffProcesses.Contains(x.Id)).ToList();
                    }
                    ///
                    var table = listDiffProcesses.ToStringTable(
                            y => listCompareResults.Where((x) => x.Id == y).ToList()[0].Id,
                            y => listCompareResults.Where((x) => x.Id == y).ToList()[0].ProcessName
                            );
                    ///
                    foreach (int oldPID in listDiffProcesses)
                    {
                        try
                        {                            
                            Console.WriteLine(String.Format("{0,34} | {1,10}|", (listCompareResults.Where((x) => x.Id == oldPID).ToList()[0].ProcessName).PadLeft(4), oldPID.ToString().PadLeft(4)));                                                      
                            //Console.WriteLine(table);                                                        
                        }
                        catch
                        {
                        }
                    }
                    if (listDiffProcesses.Count > 0)
                    {
                        listOldProcesses = listCurrentProcesses;
                        arrayOldProcesses = arrayNewProcesses;
                    }
                    System.Threading.Thread.Sleep(100);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);           
        }        
    }//class
}

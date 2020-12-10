using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.IO;

namespace FindHandle
{
    class Program
    {
        // Default folder    
        static readonly string rootFolder = @"C:\Temp\";

        static void Main(string[] args)
        {
            // File to be deleted    
            string authorsFile = "Handles.txt";

            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(rootFolder, authorsFile)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(rootFolder, authorsFile));
                    Console.WriteLine("File Handles.txt removed...");
                }
                else Console.WriteLine("File Handles.txt not present creating new one on: "+rootFolder);
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
            Console.WriteLine("============================================================================");
            Console.WriteLine("============================================================================");
            Console.WriteLine("Searching Titles and Handles of all Windows, Please wait...");
            Console.WriteLine("============================================================================");
            ShowDesktopWindows();
            Console.WriteLine("Task completed.");            
            Console.WriteLine("============================================================================");
            Console.WriteLine("============================================================================");
            Console.WriteLine("============================================================================");            
            Console.WriteLine("Task completed. 5 seconds to close app.");
            Console.WriteLine("============================================================================");
            Console.WriteLine("============================================================================");            
            Console.WriteLine("============================================================================");
            Thread.Sleep(5000);
            Environment.Exit(0);
            ///Console.ReadLine();



            //    string _handle = SearchHandle("obs").ToString();
            //    string _handle2 = SearchHandle("OBS").ToString();
            //    string _handle3 = SearchHandle("obs64").ToString();

            //    Console.WriteLine("  Opcion obs: " + _handle + "  Opcion OBS: " + _handle2 + "  Opcion obs64: " + _handle3 + "\r\n");

            //    Thread.Sleep(5000);

            //    string _handle4 = SearchHandle("obs").ToString();
            //    string _handle5 = SearchHandle("OBS").ToString();
            //    string _handle6 = SearchHandle("obs64").ToString();

            //    Console.WriteLine("  Opcion obs: " + _handle4 + "  Opcion OBS: " + _handle5 + "  Opcion obs64: " + _handle6 + "\r\n");

            //    Thread.Sleep(5000);

            //    Console.WriteLine("Tareas Finalizadas.");

            //    Console.ReadLine();
            //}
             
        }
        // Display a list of the desktop windows' titles.
        private static void ShowDesktopWindows()
        {
            List<IntPtr> handles;
            List<string> titles;
            DesktopWindowsStuff.GetDesktopWindowHandlesAndTitles(out handles, out titles);
        }
        
    }
}

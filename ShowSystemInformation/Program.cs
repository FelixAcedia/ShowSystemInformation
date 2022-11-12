using System.Text;

namespace ShowSystemInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder systemInfo = new StringBuilder(string.Empty);

            systemInfo.AppendFormat("Operation System:  {0}\n", Environment.OSVersion);
            systemInfo.AppendFormat("Processor Architecture:  {0}\n", Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));
            systemInfo.AppendFormat("Processor Model:  {0}\n", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
            systemInfo.AppendFormat("Processor Level:  {0}\n", Environment.GetEnvironmentVariable("PROCESSOR_LEVEL"));
            systemInfo.AppendFormat("SystemDirectory:  {0}\n", Environment.SystemDirectory);
            systemInfo.AppendFormat("ProcessorCount:  {0}\n", Environment.ProcessorCount);
            systemInfo.AppendFormat("UserDomainName:  {0}\n", Environment.UserDomainName);
            systemInfo.AppendFormat("Home: {0}\n", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            systemInfo.AppendFormat("UserName: {0}\n", Environment.UserName);
            systemInfo.AppendFormat("Started since: {0} ticks\n",
                Environment.TickCount);
            systemInfo.AppendFormat("ThreadID: {0}\n", Environment.CurrentManagedThreadId);
            //Drives
            systemInfo.AppendFormat("LogicalDrives:\n");
            foreach (System.IO.DriveInfo DriveInfo1 in System.IO.DriveInfo.GetDrives())
            {
                try
                {
                    systemInfo.AppendFormat("\t Drive: {0} \n\t\t VolumeLabel: " +
                        "{1} \n\t\t DriveType: {2} \n\t\t DriveFormat: {3} \n\t\t " +
                        "TotalSize: {4}GB ({5}) \n\t\t AvailableFreeSpace: {6}GB ({7}) \n",
                        DriveInfo1.Name, DriveInfo1.VolumeLabel, DriveInfo1.DriveType,
                        DriveInfo1.DriveFormat, DriveInfo1.TotalSize/1000000000, DriveInfo1.TotalSize, 
                        DriveInfo1.AvailableFreeSpace/1000000000, DriveInfo1.AvailableFreeSpace);
                }
                catch
                {
                }
            }
            systemInfo.AppendFormat("Version:  {0}", Environment.Version);
            Console.WriteLine(systemInfo);
            Console.ReadKey();
        }
    }
}
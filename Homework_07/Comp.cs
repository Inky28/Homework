using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    class Comp
    {
        private int countDisk;
        private int countPrintDevice;
        private List<Disk> disks;
        private List<IPrintInformation> printDevice;

        public void AddDevice(IPrintInformation si)
        {
            printDevice.Add(si);
            countPrintDevice = printDevice.Count();
        }

        public void AddDisc(Disk d)
        {
            disks.Add(d);
            countDisk = disks.Count();
        }

        public bool CheckDisk(string device)
        {
            foreach (var item in disks)
            {
                if (item.GetName().Equals(device))
                    return true;
            }
            return false;
        }

        public Comp()
        {
            disks = new List<Disk>();
            printDevice = new List<IPrintInformation>();
        }

        public void InsertReject(string device, bool b)
        {
            foreach (var item in disks)
            {
                if (item.GetName().Equals(device) && item is IRemoveableDisk)
                {
                    if (b)
                        (item as IRemoveableDisk).Insert();
                    else
                        (item as IRemoveableDisk).Reject();
                }
            }
        }

        public bool PrintInfo(string text, string device)
        {
            foreach (var item in printDevice)
            {
                if (item.GetName().Equals(device))
                {
                    item.Print(text);
                    return true;
                }
            }
            return false;
        }

        public string ReadInfo(string device)
        {
            foreach (var item in disks)
            {
                if (item.GetName().Equals(device))
                    return item.Read();
            }
            return "";
        }

        public void ShowDisk()
        {
            foreach (var item in disks)
            {
                Console.WriteLine(item.GetName());
            }
        }

        public void ShowPrintDevice()
        {
            foreach (var item in printDevice)
            {
                Console.WriteLine(item.GetName());
            }
        }

        public bool WriteInfo(string text, string showDevice)
        {
            foreach (var item in printDevice)
            {
                if (item.GetName().Equals(showDevice))
                {
                    item.Print(text);
                    return true;
                }
            }
            return false;
        }
    }
}

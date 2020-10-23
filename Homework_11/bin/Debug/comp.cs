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
		// test
        public void AddDevice(IPrintInformation si)
        {
            printDevice.Add(si);
            countPrintDevice = printDevice.Count();
        }
		// commit_11
        public void AddDisc(Disk d)
        {
            disks.Add(d);
            countDisk = disks.Count();
        }
		// commit_22
        public bool CheckDisk(string device)
        {
            foreach (var item in disks)
            {
                if (item.GetName().Equals(device))  // commit -112212333
                    return true;
            }
            return false;
        }
		// commit_33
        public Comp()
        {
            disks = new List<Disk>();
            printDevice = new List<IPrintInformation>();
        }
		// commit_a234
        public void InsertReject(string device, bool b) // commit -11aa22
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
		// commit_3123123
        public bool PrintInfo(string text, string device)
        {
            foreach (var item in printDevice)
            {
                if (item.GetName().Equals(device)) // commit -1122
                {
                    item.Print(text);
                    return true;
                }
            }
            return false;
        }
		// commit_q1w2e3r4
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
